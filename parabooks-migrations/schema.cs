using System;
using FluentMigrator;
using com.paralib.Migrations;
using com.paralib.DataAnnotations;

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
                Insert.IntoTable("transaction_types").Row(new { id = 0, name = "SPLIT" }); //splits have child transactions
                Insert.IntoTable("transaction_types").Row(new { id = 1, name = "LOANEXP" });
            }


            Create.Table("transactions")
                .WithColumn("id").AsParaType(ParaTypes.Key).PrimaryKey().Identity()
                .WithColumn("parent_id").AsParaType(ParaTypes.Key).ForeignKey("transactions", "id")
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
    }
}
