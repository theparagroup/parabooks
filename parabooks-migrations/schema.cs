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

            //Delete.Table("entries");
            //Delete.Table("transactions");
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
                .WithColumn("id").AsParaType(ParaTypes.Key).PrimaryKey()
                .WithColumn("parent_id").AsParaType(ParaTypes.Key).Nullable().ForeignKey("account_types", "id")
                .WithColumn("number").AsParaType(ParaTypes.Int32).Nullable()
                .WithColumn("name").AsParaType(ParaTypes.Name)
                .WithColumn("description").AsParaType(ParaTypes.Description).Nullable()
                .WithColumn("normal_id").AsParaType(ParaTypes.Key).Nullable().ForeignKey("normals", "id")
                .WithColumn("business_form_id").AsParaType(ParaTypes.Key).Nullable().ForeignKey("business_forms", "id")
                .WithColumn("method_id").AsParaType(ParaTypes.Key).Nullable().ForeignKey("methods", "id")
                .WithColumn("nominal").AsParaType(ParaTypes.Bool).Nullable()
                .WithColumn("contra").AsParaType(ParaTypes.Bool).Nullable()
                .WithColumn("method_required").AsParaType(ParaTypes.Bool).Nullable()
                .WithColumn("business_form_required").AsParaType(ParaTypes.Bool).Nullable();
            {
                Insert.IntoTable("account_types").Row(new { id = 100000000, name = "Assets", normal_id = 0 });
                {
                    Insert.IntoTable("account_types").Row(new { id = 110000000, parent_id = 100000000, name = "Tangible Assets" });
                    {
                        Insert.IntoTable("account_types").Row(new { id = 111000000, parent_id = 110000000, name = "Current Assets" });
                        {
                            Insert.IntoTable("account_types").Row(new { id = 111100000, parent_id = 111000000, name = "Checking" });
                            {
                                Insert.IntoTable("account_types").Row(new { id = 111101000, parent_id = 111100000, name = "General" });
                                Insert.IntoTable("account_types").Row(new { id = 111102000, parent_id = 111100000, name = "Payroll" });
                            }
                            Insert.IntoTable("account_types").Row(new { id = 111200000, parent_id = 111000000, name = "Saving" });
                            Insert.IntoTable("account_types").Row(new { id = 111300000, parent_id = 111000000, name = "Accounts Receivable" });
                            Insert.IntoTable("account_types").Row(new { id = 111400000, parent_id = 111000000, name = "Employee Advances" });
                        }

                        Insert.IntoTable("account_types").Row(new { id = 112000000, parent_id = 110000000, name = "Fixed Assets" });
                        {
                            Insert.IntoTable("account_types").Row(new { id = 112100000, parent_id = 112000000, name = "Equipment" });
                            {
                                Insert.IntoTable("account_types").Row(new { id = 112101000, parent_id = 112100000, name = "Information Technology" });
                                {
                                    Insert.IntoTable("account_types").Row(new { id = 112101100, parent_id = 112101000, name = "Hardware" });
                                    Insert.IntoTable("account_types").Row(new { id = 112101500, parent_id = 112101000, name = "Software" });
                                }
                            }
                        }

                        Insert.IntoTable("account_types").Row(new { id = 113000000, parent_id = 110000000, name = "Accumulated Depreciation", normal_id = 1, contra = true });
                        {
                            Insert.IntoTable("account_types").Row(new { id = 113100000, parent_id = 113000000, name = "Straight-Line" });
                            Insert.IntoTable("account_types").Row(new { id = 11320000, parent_id = 113000000, name = "Section 179" });
                        }

                        Insert.IntoTable("account_types").Row(new { id = 114000000, parent_id = 110000000, name = "Accumulated Amortization", normal_id=1, contra=true });
                        {
                            Insert.IntoTable("account_types").Row(new { id = 114100000, parent_id = 114000000, name = "Start-Up Costs" }); //over 180 months
                        }
                    }

                    Insert.IntoTable("account_types").Row(new { id = 120000000, parent_id = 100000000, name = "Intangible Assets" });

                }




                Insert.IntoTable("account_types").Row(new { id = 200000000, name = "Liabilities", normal_id = 1 });

                Insert.IntoTable("account_types").Row(new { id = 300000000, name = "Equity", normal_id = 1 });

                Insert.IntoTable("account_types").Row(new { id = 400000000, name = "Operating Income", normal_id = 1, nominal = true });

                Insert.IntoTable("account_types").Row(new { id = 500000000, name = "Direct Costs/Expenses", normal_id = 0, nominal = true });

                Insert.IntoTable("account_types").Row(new { id = 600000000, name = "Operating Expenses", normal_id = 0, nominal = true });
                {
                    Insert.IntoTable("account_types").Row(new { id = 680000000, parent_id= 600000000, name = "Depreciation Expense" });
                    Insert.IntoTable("account_types").Row(new { id = 690000000, parent_id = 600000000, name = "Amortization Expenses" });

                }

                Insert.IntoTable("account_types").Row(new { id = 700000000, name = "Non-Operating Income", normal_id = 1, nominal = true });

                Insert.IntoTable("account_types").Row(new { id = 800000000, name = "Non-Operating Expenses", normal_id = 0, nominal = true });
                {
                    Insert.IntoTable("account_types").Row(new { id = 89000000, parent_id = 800000000, name = "Start-Up Expenses", normal_id = 0, nominal = true }); //start-up costs up to 5,000 if under 50000

                }
                

            }

            Execute.Sql("update account_types set number=id");


            Create.Table("accounts")
                .WithColumn("id").AsParaType(ParaTypes.Key).PrimaryKey().Identity()
                .WithColumn("parent_id").AsParaType(ParaTypes.Key).Nullable().ForeignKey("accounts", "id")
                .WithColumn("account_type_id").AsParaType(ParaTypes.Key).ForeignKey("account_types", "id")
                .WithColumn("number").AsParaType(ParaTypes.Int32).Nullable()
                .WithColumn("name").AsParaType(ParaTypes.Name)
                .WithColumn("description").AsParaType(ParaTypes.Description).Nullable();


        }
    }
}
