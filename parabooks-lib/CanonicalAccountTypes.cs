using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.theparagroup.parabooks
{
    public class CanonicalAccountTypes2
    {
        /*
           select 'public const int ' + ISNULL(REPLACE(a2.name, ' ', '') + '_','') + REPLACE(a1.name, ' ', '') + ' = ' +cast(a1.id as varchar) +  ';'  
           from 
           account_types a1
           left outer join 
           account_types a2 on a1.parent_id=a2.id
           where a1.canonical=1
        */

        public const int Assets = 100000;
        public const int Assets_TangibleAssets = 110000;
        public const int TangibleAssets_CurrentAssets = 111000;
        public const int CurrentAssets_Checking = 111100;
        public const int CurrentAssets_Saving = 111200;
        public const int CurrentAssets_AccountsReceivable = 111300;
        public const int CurrentAssets_EmployeeAdvances = 111400;
        public const int CurrentAssets_NotesReceivable = 111500;
        public const int CurrentAssets_Cash = 111600;
        public const int TangibleAssets_FixedAssets = 112000;
        public const int TangibleAssets_AccumulatedDepreciation = 113000;
        public const int TangibleAssets_AccumulatedAmortization = 114000;
        public const int TangibleAssets_OtherAssets = 115000;
        public const int OtherAssets_NotesReceivable = 115100;
        public const int Assets_IntangibleAssets = 120000;
        public const int Liabilities = 200000;
        public const int Liabilities_CurrentLiabilities = 210000;
        public const int CurrentLiabilities_NotesPayableCurrent = 211000;
        public const int Liabilities_LongTermLiabilities = 220000;
        public const int LongTermLiabilities_NotesPayableLongTerm = 221000;
        public const int Equity = 300000;
        public const int OperatingIncome = 400000;
        public const int OperatingIncome_Revenue = 410000;
        public const int DirectCosts = 500000;
        public const int OperatingExpenses = 600000;
        public const int OperatingExpenses_GeneralExpenses = 610000;
        public const int GeneralExpenses_Payroll = 610170;
        public const int Payroll_GrossWages = 610171;
        public const int Payroll_FringeBenefits = 610172;
        public const int Payroll_WorkersCompensation = 610173;
        public const int Payroll_SocialSecurityMatch = 610174;
        public const int Payroll_MedicareMatch = 610175;
        public const int Payroll_FUTA = 610176;
        public const int Payroll_SUTA = 610177;
        public const int OperatingExpenses_DepreciationExpense = 680000;
        public const int OperatingExpenses_AmortizationExpense = 690000;
        public const int NonOperatingIncome = 700000;
        public const int NonOperatingExpenses = 800000;
        public const int NonOperatingExpenses_StartUpCosts = 890000;
    }
}
