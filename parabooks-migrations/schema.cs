using System;
using FluentMigrator;
using com.paralib.Migrations;
using com.paralib.DataAnnotations;
using System.Collections.Generic;

namespace com.theparagroup.parabooks.migrations
{
    [Migration(000000000001)]
    public class InitialSchema : Migration
    {
        public override void Down()
        {

            Delete.Table("entries");
            Delete.Table("transactions");
            Delete.Table("transaction_types");
            Delete.Table("accounts");
            Delete.Table("account_types");
            Delete.Table("methods");
            Delete.Table("normals");
            Delete.Table("business_forms");

            //entry_expense
            //vendors
            //clients

            //entry_invoice
            //invoices
            //clients

            //entry_payroll
            //payroll
            //employees

            //entry_asset
            //vendors
            //assets

            //account_type_report_lines
            //reports
            //report_lines

            //account_type_tax_form_lines
            //tax_forms
            //tax_form_lines

            //account_type_industries
            //industries



        }

        public override void Up()
        {
            Create.Table("business_forms")
                .WithColumn("id").AsParaType(ParaTypes.Key).PrimaryKey()
                .WithColumn("name").AsParaType(ParaTypes.Name);
            {
                Insert.IntoTable("business_forms").Row(new { id = 0, name = "Sole Proprietorship/Parnership" });
                Insert.IntoTable("business_forms").Row(new { id = 1, name = "Corporation" });
            }

            Create.Table("normals")
                .WithColumn("id").AsParaType(ParaTypes.Key).PrimaryKey()
                .WithColumn("name").AsParaType(ParaTypes.Name);
            {
                Insert.IntoTable("normals").Row(new { id = 0, name = "Debit" });
                Insert.IntoTable("normals").Row(new { id = 1, name = "Credit" });
            }

            Create.Table("methods")
                .WithColumn("id").AsParaType(ParaTypes.Key).PrimaryKey()
                .WithColumn("name").AsParaType(ParaTypes.Name);
            {
                Insert.IntoTable("methods").Row(new { id = 0, name = "Cash" });
                Insert.IntoTable("methods").Row(new { id = 1, name = "Accrual" });
            }


            Create.Table("account_types")
                .WithColumn("id").AsParaType(ParaTypes.Key).PrimaryKey().Identity()
                .WithColumn("parent_id").AsParaType(ParaTypes.Key).Nullable().ForeignKey("account_types", "id")
                .WithColumn("number").AsParaType(ParaTypes.Name)
                .WithColumn("name").AsParaType(ParaTypes.Name)
                .WithColumn("description").AsParaType(ParaTypes.Description).Nullable()
                .WithColumn("normal_id").AsParaType(ParaTypes.Key).Nullable().ForeignKey("normals", "id")
                .WithColumn("business_form_id").AsParaType(ParaTypes.Key).Nullable().ForeignKey("business_forms", "id")
                .WithColumn("method_id").AsParaType(ParaTypes.Key).Nullable().ForeignKey("methods", "id")
                .WithColumn("canonical").AsParaType(ParaTypes.Bool).Nullable()
                .WithColumn("canonical_id").AsParaType(ParaTypes.Int32).Nullable()
                .WithColumn("nominal").AsParaType(ParaTypes.Bool).Nullable()
                .WithColumn("contra").AsParaType(ParaTypes.Bool).Nullable()
                .WithColumn("method_required").AsParaType(ParaTypes.Bool).Nullable()
                .WithColumn("business_form_required").AsParaType(ParaTypes.Bool).Nullable();

            Execute.EmbeddedScript("100000000 - Assets.sql");
            Execute.EmbeddedScript("200000000 - Liabilities.sql");
            Execute.EmbeddedScript("300000000 - Equity.sql");
            Execute.EmbeddedScript("400000000 - Operating Income.sql");
            Execute.EmbeddedScript("500000000 - Direct Costs.sql");
            Execute.EmbeddedScript("600000000 - Operating Expenses.sql");
            Execute.EmbeddedScript("700000000 - Non-Operating Income.sql");
            Execute.EmbeddedScript("800000000 - Non-Operating Expenses.sql");

            Execute.Sql("update account_types set canonical=1 where canonical_id is not null");

            Execute.WithConnection(DenormalizeAccountTypes);


            Create.Table("accounts")
                .WithColumn("id").AsParaType(ParaTypes.Key).PrimaryKey().Identity()
                .WithColumn("parent_id").AsParaType(ParaTypes.Key).Nullable().ForeignKey("accounts", "id")
                .WithColumn("account_type_id").AsParaType(ParaTypes.Key).ForeignKey("account_types", "id")
                .WithColumn("linking").AsParaType(ParaTypes.Bool)
                .WithColumn("number").AsParaType(ParaTypes.Name)
                .WithColumn("name").AsParaType(ParaTypes.Name)
                .WithColumn("description").AsParaType(ParaTypes.Description).Nullable();


            Create.Table("transaction_types")
                .WithColumn("id").AsParaType(ParaTypes.Key).PrimaryKey()
                .WithColumn("name").AsParaType(ParaTypes.Name);
            {
                Insert.IntoTable("transaction_types").Row(new { id = 1, name = "SPLIT" }); //splits have child transactions
                Insert.IntoTable("transaction_types").Row(new { id = 2, name = "LOANEXP" });
                Insert.IntoTable("transaction_types").Row(new { id = 3, name = "LOAN" });
                Insert.IntoTable("transaction_types").Row(new { id = 4, name = "EXP" });
                Insert.IntoTable("transaction_types").Row(new { id = 5, name = "ASS" });
                Insert.IntoTable("transaction_types").Row(new { id = 6, name = "INT" });
            }


            Create.Table("transactions")
                .WithColumn("id").AsParaType(ParaTypes.Key).PrimaryKey().Identity()
                .WithColumn("transaction_type_id").AsParaType(ParaTypes.Key).ForeignKey("transaction_types", "id")
                .WithColumn("reference").AsParaType(ParaTypes.Int32).Nullable()
                .WithColumn("date").AsParaType(ParaTypes.DateTime)
                .WithColumn("description").AsParaType(ParaTypes.Description).Nullable();

            Create.Table("entries")
                .WithColumn("id").AsParaType(ParaTypes.Key).PrimaryKey().Identity()
                .WithColumn("transaction_id").AsParaType(ParaTypes.Key).ForeignKey("transactions", "id")
                .WithColumn("account_id").AsParaType(ParaTypes.Key).ForeignKey("accounts", "id")
                .WithColumn("amount").AsParaType(ParaTypes.Decimal);


        }

        protected static void DenormalizeAccountTypes(System.Data.IDbConnection connection, System.Data.IDbTransaction transaction)
        {
            var cmd = connection.CreateCommand();
            cmd.Transaction = transaction;
            cmd.CommandText = "select * from account_types where parent_id is null";
            var reader = cmd.ExecuteReader();
            var ids = new List<int>();
            while (reader.Read()) { ids.Add((int)reader["id"]); }
            reader.Close();

            foreach (int id in ids)
            {
                DenormalizeAccountTypes(connection, transaction, id);
            }

        }

        private class AccountType
        {
            public int Id;
            public int Nid;
            public int Cid;
        }

        protected static void DenormalizeAccountTypes(System.Data.IDbConnection connection, System.Data.IDbTransaction transaction, int parentId)
        {
            var cmd = connection.CreateCommand();
            cmd.Transaction = transaction;
            cmd.CommandText = $"select a.id id, a.normal_id a_nid, a.canonical_id a_cid, a.parent_id a_pid, p.normal_id p_nid, p.canonical_id p_cid from account_types a inner join account_types p on a.parent_id=p.id where a.parent_id={parentId}";

            var update = connection.CreateCommand();
            update.Transaction = transaction;

            var reader = cmd.ExecuteReader();
            var ats = new List<AccountType>();
            while (reader.Read())
            {
                var at = new AccountType();
                at.Id = (int)reader["id"];
                at.Nid = (int)reader["p_nid"];
                at.Cid = (int)reader["p_cid"];
                ats.Add(at);
            }
            reader.Close();

            foreach (var at in ats)
            {
                update.CommandText = $"update account_types set normal_id={at.Nid} where id={at.Id} and normal_id is null";
                update.ExecuteNonQuery();

                update.CommandText = $"update account_types set canonical_id={at.Cid} where id={at.Id} and canonical_id is null";
                update.ExecuteNonQuery();

                DenormalizeAccountTypes(connection, transaction, at.Id);
            }

        }


    }
}
