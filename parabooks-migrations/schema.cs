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
            Delete.Table("account_type_business_forms");
            Delete.Table("account_types");
            Delete.Table("methods");
            Delete.Table("normals");
            Delete.Table("business_forms");
            Delete.Table("modules");

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
            Create.Table("modules")
                .WithColumn("id").AsParaType(ParaTypes.Key).PrimaryKey()
                .WithColumn("name").AsParaType(ParaTypes.Name);
            {
                Insert.IntoTable("modules").Row(new { id = 0, name = "Parabooks" });
                Insert.IntoTable("modules").Row(new { id = 1, name = "PX8 Books" });
            }

            Create.Table("business_forms")
                .WithColumn("id").AsParaType(ParaTypes.Key).PrimaryKey()
                .WithColumn("name").AsParaType(ParaTypes.Name);
            {
                Insert.IntoTable("business_forms").Row(new { id = 0, name = "Sole Proprietorship" });
                Insert.IntoTable("business_forms").Row(new { id = 1, name = "Partnership" });
                Insert.IntoTable("business_forms").Row(new { id = 2, name = "Corporation" });
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
                .WithColumn("guid").AsParaType(ParaTypes.Guid).Nullable()
                .WithColumn("parent_id").AsParaType(ParaTypes.Key).Nullable().ForeignKey("account_types", "id")
                .WithColumn("number").AsParaType(ParaTypes.Name).Nullable()
                .WithColumn("name").AsParaType(ParaTypes.Name)
                .WithColumn("description").AsParaType(ParaTypes.Description).Nullable()
                .WithColumn("normal_id").AsParaType(ParaTypes.Key).Nullable().ForeignKey("normals", "id")
                .WithColumn("nominal").AsParaType(ParaTypes.Bool).Nullable() //temporary accounts
                .WithColumn("contra").AsParaType(ParaTypes.Bool).WithDefaultValue(false) //contra to parent account type or parent account?
                .WithColumn("method_id").AsParaType(ParaTypes.Key).Nullable().ForeignKey("methods", "id") //null means 'all methods'
                .WithColumn("module_id").AsParaType(ParaTypes.Key).ForeignKey("modules", "id").WithDefaultValue(0);

            //non-core modules must use GUIDs to identify account types
            Execute.Sql("ALTER TABLE account_types ADD CHECK ( (module_id=0 AND guid is null) OR (module_id<>0 AND guid is not null) )");

            //TODO assign guids to core and enable unique constraint on guid

            //TODO make normal_id, nominal non-null (after load)

            //this table restricts account types to certain business forms
            Create.Table("account_type_business_forms")
                    .WithColumn("account_type_id").AsParaType(ParaTypes.Key).PrimaryKey().ForeignKey("account_types", "id")
                    .WithColumn("business_form_id").AsParaType(ParaTypes.Key).PrimaryKey().ForeignKey("business_forms", "id");


            Create.Table("accounts")
                    .WithColumn("id").AsParaType(ParaTypes.Key).PrimaryKey().Identity()
                    .WithColumn("account_type_id").AsParaType(ParaTypes.Key).ForeignKey("account_types", "id")
                    .WithColumn("parent_id").AsParaType(ParaTypes.Key).Nullable().ForeignKey("accounts", "id")
                    .WithColumn("virtual").AsParaType(ParaTypes.Bool) //a folder
                    .WithColumn("number").AsParaType(ParaTypes.Name).Nullable()
                    .WithColumn("name").AsParaType(ParaTypes.Name)
                    .WithColumn("description").AsParaType(ParaTypes.Description).Nullable();

            Create.Table("transaction_types")
                .WithColumn("id").AsParaType(ParaTypes.Key).PrimaryKey().Identity()
                .WithColumn("guid").AsParaType(ParaTypes.Guid).Nullable()
                .WithColumn("name").AsParaType(ParaTypes.Name)
                .WithColumn("module_id").AsParaType(ParaTypes.Key).ForeignKey("modules","id");

            //non-core modules must use GUIDs to identify transaction types
            Execute.Sql("ALTER TABLE transaction_types ADD CHECK ( (module_id=0 AND guid is null) OR (module_id<>0 AND guid is not null) )");


            Create.Table("transactions")
                    .WithColumn("id").AsParaType(ParaTypes.Key).PrimaryKey().Identity()
                    .WithColumn("transaction_type_id").AsParaType(ParaTypes.Key).ForeignKey("transaction_types", "id")
                    .WithColumn("reference").AsParaType(ParaTypes.Int32).Nullable()
                    .WithColumn("date").AsParaType(ParaTypes.DateTime)
                    .WithColumn("description").AsParaType(ParaTypes.Description).Nullable();

            Create.Table("entries")
                    .WithColumn("id").AsParaType(ParaTypes.Key).PrimaryKey().Identity()
                    .WithColumn("transaction_id").AsParaType(ParaTypes.Key).ForeignKey("transactions", "id")
                    .WithColumn("reference").AsParaType(ParaTypes.Int32).Nullable()
                    .WithColumn("account_id").AsParaType(ParaTypes.Key).ForeignKey("accounts","id")
                    .WithColumn("amount").AsParaType(ParaTypes.Decimal)
                    .WithColumn("description").AsParaType(ParaTypes.Description).Nullable();


            Execute.EmbeddedScript("100000000 - Assets.sql");
            Execute.EmbeddedScript("200000000 - Liabilities.sql");
            Execute.EmbeddedScript("300000000 - Equity.sql");
            Execute.EmbeddedScript("400000000 - Operating Income.sql");
            Execute.EmbeddedScript("500000000 - Direct Costs.sql");
            Execute.EmbeddedScript("600000000 - Operating Expenses.sql");
            Execute.EmbeddedScript("700000000 - Non-Operating Income.sql");
            Execute.EmbeddedScript("800000000 - Non-Operating Expenses.sql");

            Execute.WithConnection(DenormalizeAccountTypes);

            Alter.Table("account_types").AlterColumn("nominal").AsParaType(ParaTypes.Bool).NotNullable();
            Alter.Table("account_types").AlterColumn("normal_id").AsParaType(ParaTypes.Key).NotNullable();

            Execute.Sql("DBCC CHECKIDENT (account_types, RESEED, 90000)");


            return;

        }

        protected static void DenormalizeAccountTypes(System.Data.IDbConnection connection, System.Data.IDbTransaction transaction)
        {
            var cmd = connection.CreateCommand();
            cmd.Transaction = transaction;
            cmd.CommandText = "select * from account_types where parent_id is null";
            var reader = cmd.ExecuteReader();
            var ids = new List<long>(); 
            while (reader.Read()) { ids.Add((long)reader["id"]); }
            reader.Close();

            foreach (int id in ids)
            {
                DenormalizeAccountTypes(connection, transaction, id);
            }

        }

        private class AccountType
        {
            public long Id;
            public long NormalId;
            public bool Nominal;
        }

        protected static void DenormalizeAccountTypes(System.Data.IDbConnection connection, System.Data.IDbTransaction transaction, long parentId)
        {
            var cmd = connection.CreateCommand();
            cmd.Transaction = transaction;
            cmd.CommandText = $"select a.id id, a.normal_id nid, a.nominal n, a.parent_id pid, p.normal_id pnid, p.nominal pn from account_types a inner join account_types p on a.parent_id=p.id where a.parent_id={parentId}";

            var update = connection.CreateCommand();
            update.Transaction = transaction;

            var reader = cmd.ExecuteReader();
            var ats = new List<AccountType>();
            while (reader.Read())
            {
                var at = new AccountType();
                at.Id = (long)reader["id"];
                at.NormalId = (long)reader["pnid"];
                at.Nominal = (bool)reader["pn"];
                ats.Add(at);
            }
            reader.Close();

            foreach (var at in ats)
            {
                update.CommandText = $"update account_types set normal_id={at.NormalId} where id={at.Id} and normal_id is null";
                update.ExecuteNonQuery();

                update.CommandText = $"update account_types set nominal={(at.Nominal?1:0)} where id={at.Id} and nominal is null";
                update.ExecuteNonQuery();

                DenormalizeAccountTypes(connection, transaction, at.Id);
            }

        }


    }


   

}
