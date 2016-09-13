using com.theparagroup.parabooks.models.Ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.theparagroup.parabooks.Transactors
{

    public class LOAN : Transactor
    {
        /*
            Loan to/from the company.



        */

        public LOAN(EfAccount assetAccount, EfAccount payableAccount, EfAccount recievableAccount, DateTime date, string description, decimal amount, int? reference) : base(date, description, reference)
        {
            Execute(transaction =>
            {

                InvalidAccountException.Verify(assetAccount, new int[] { 111 }); //current asset (cash, checking)
                InvalidAccountException.Verify(payableAccount, new int[] { 211, 221 }); //notes payable
                InvalidAccountException.Verify(recievableAccount, new int[] {1115, 1151 }); //notes recievable

             


            });


        }

    }

}
