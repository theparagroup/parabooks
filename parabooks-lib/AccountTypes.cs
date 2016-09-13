using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.theparagroup.parabooks
{
    public class AccountTypes
    {

        /*
        select 'public const int ' + ISNULL(REPLACE(a2.name, ' ', '') + '_','') + REPLACE(a1.name, ' ', '') + ' = ' +cast(a1.id as varchar) +  ';'  
        from 
        account_types a1
        left outer join 
        account_types a2 on a1.parent_id=a2.id
        where a1.canonical is null or a1.canonical=0
        */


        public const int InformationTechnology_Hardware = 101;
        public const int InformationTechnology_Software = 102;
        public const int InformationTechnology_Domains = 601;
        public const int InformationTechnology_Servers = 602;
        public const int InformationTechnology_Email = 603;
        public const int InformationTechnology_OnlineServices = 604;
        public const int Financial_BankFees = 605;
        public const int Financial_WireTransferFees = 606;
        public const int Financial_CreditCareProcessingFees = 607;
        public const int CurrentAssets_Checking = 111100;
        public const int Checking_General = 111110;
        public const int Checking_Payroll = 111120;
        public const int CurrentAssets_Saving = 111200;
        public const int CurrentAssets_AccountsReceivable = 111300;
        public const int CurrentAssets_EmployeeAdvances = 111400;
        public const int CurrentAssets_NotesReceivable = 111500;
        public const int NotesReceivable_LoanstoEquityHolders = 111510;
        public const int FixedAssets_Equipment = 112100;
        public const int Equipment_InformationTechnology = 112110;
        public const int OtherAssets_NotesPayable = 115100;
        public const int CurrentLiabilities_NotesPayable = 211000;
        public const int CurrentLiabilities_NotesPayable_LoansfromEquityHolders = 211100;
        public const int CurrentLiabilities_Taxes = 212000;
        public const int Taxes_SalesTaxes = 212100;
        public const int Taxes_PayrollTaxes = 212200;
        public const int PayrollTaxes_FICA = 212210;
        public const int PayrollTaxes_SUTA = 212220;
        public const int PayrollTaxes_FUTA = 212230;
        public const int PayrollTaxes_IncomeTaxesWithheld = 212240;
        public const int LongTermLiabilities_NotesPayable = 221000;
        public const int LongTermLiabilities_NotesPayable_LoansfromEquityHolders = 221100;
        public const int GeneralExpenses_Services = 610110;
        public const int Services_InformationTechnology = 610111;
        public const int Services_PayrollFees = 610112;
        public const int Services_Financial = 610113;
        public const int GeneralExpenses_Rent = 610120;
        public const int Rent_MailBoxes = 610121;
        public const int GeneralExpenses_Telephone = 610130;
        public const int Telephone_CellPhones = 610131;
        public const int Telephone_PBXService = 610132;
        public const int GeneralExpenses_Advertising = 610140;
        public const int Advertising_BusinessCards = 610141;
        public const int GeneralExpenses_OfficeSupplies = 610150;
        public const int GeneralExpenses_PermitsLicenses = 610160;
        public const int PermitsLicenses_Federal = 610161;
        public const int PermitsLicenses_State = 610162;
        public const int PermitsLicenses_County = 610163;
        public const int PermitsLicenses_City = 610164;
        public const int GeneralExpenses_Payroll = 610170;
        public const int Payroll_Wages = 610171;
        public const int Payroll_FringeBenefits = 610172;
        public const int Payroll_WorkersCompensation = 610173;
        public const int Payroll_FICAMatch = 610174;
        public const int Payroll_SUTAMatch = 610175;
        public const int Payroll_FUTAMatch = 610176;
    }
}
