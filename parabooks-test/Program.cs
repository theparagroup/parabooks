using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.paralib;
using com.theparagroup.parabooks.models;

namespace parabooks_test
{

    class Program
    {
        static void Main(string[] args)
        {
            Paralib.Initialize();

            //com.theparagroup.parabooks.models.Example.Chart.Enumerate();
            //com.theparagroup.parabooks.models.Chart.Enumerate();

            AccountType.Enumerate((accountType, accountTypeStack) =>
            {
                string details = $"({(accountType.NormalId == 0 ? "dn" : "cn")}:{(accountType.Nominal ? "t" : "p")})";

                Console.WriteLine($"{new string('\t', accountTypeStack.Count)}{accountType.Id.ToString().PadRight(4,'0')} - {accountType.Name.ToUpper()} : {details} ");

                Account.Enumerate(accountType, (parent, account, accountStack) =>
                {
                    string linked = "";

                    if ((account.ParentAccountId.HasValue)&&(account.AccountTypeId!=account.ParentAccountTypeId))
                    {
                        if (account.AccountTypeId==accountType.Id)
                        {
                            linked = $"(displayed under {account.ParentAccountTypeId}-{account.ParentAccountId})";
                        }
                        else
                        {
                            linked = $"(booked to {account.AccountTypeId})";
                        }
                    }


                    Console.WriteLine($"{new string('\t', accountTypeStack.Count + accountStack.Count())}{(account.Virtual?"*":"")}{account.AccountTypeId}-{account.AccountId} : {account.Name} {linked}");
                });

            });

        }
    }
}
