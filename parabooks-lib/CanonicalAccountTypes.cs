using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.theparagroup.parabooks
{
    public class CanonicalAccountTypes
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
        public const int TangibleAssets_FixedAssets = 112000;
        public const int TangibleAssets_AccumulatedDepreciation = 113000;
        public const int TangibleAssets_AccumulatedAmortization = 114300;
        public const int Assets_IntangibleAssets = 120000;
        public const int Liabilities = 200000;
        public const int Equity = 300000;
        public const int OperatingIncome = 400000;
        public const int DirectCosts = 500000;
        public const int OperatingExpenses = 600000;
        public const int OperatingExpenses_GeneralExpenses = 610000;
        public const int OperatingExpenses_DepreciationExpense = 680000;
        public const int OperatingExpenses_AmortizationExpense = 690000;
        public const int NonOperatingIncome = 700000;
        public const int NonOperatingExpenses = 800000;
        public const int NonOperatingExpenses_StartUpCosts = 890000;
    }
}
