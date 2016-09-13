using com.theparagroup.parabooks.models.Ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.theparagroup.parabooks.Transactors
{
    public class LOANEXP : Transactor
    {
        /*
            Loan to the company to be used to pay an expense.

        */

        public LOANEXP(EfAccount liabilityAccount, EfAccount expenseAccount, DateTime date, string description, decimal amount, int? reference) : base(date, description, reference)
        {
            Execute(transaction =>
            {

                InvalidAccountException.Verify(liabilityAccount, new int[] { 211, 221 }); //note payable
                InvalidAccountException.Verify(expenseAccount, new int[] { 610, 890 }); //general expense or start-up cost

                //credit cn
                Entry(liabilityAccount, amount);

                //debit dn
                Entry(expenseAccount, amount);


            });


        }
    }
}
