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

            AccountType.Enumerate((accountType, beforeAT, accountTypeStack) =>
            {
                if (beforeAT)
                {
                    int pad = 5;

                    string details = $"({(accountType.NormalId == 0 ? "dn" : "cn")}:{(accountType.Nominal ? "t" : "p")})";

                    Console.WriteLine($"{new string('\t', accountTypeStack.Count)}{accountType.Id.ToString().PadRight(pad, '0')} - {accountType.Name.ToUpper()} : {details} ");

                    Account.Enumerate(accountType, (parent, account, xFiled, xBooked, beforeA, accountStack) =>
                    {
                        if (beforeA)
                        {
                            string booked = "";
                            if (xBooked) booked = $"(BOOKED to {account.AccountTypeId.ToString().PadRight(pad, '0')})";

                            string displayed = "";
                            if (xFiled) displayed = $"(FILED under {account.Parent.AccountTypeId.ToString().PadRight(pad, '0')}-{account.Parent.Id})";

                            Console.WriteLine($"{new string('\t', accountTypeStack.Count + accountStack.Count())}{(account.Virtual ? "*" : "")}{account.AccountTypeId.ToString().PadRight(pad, '0')}-{account.Id} : {account.Name} {booked} {displayed}");
                        }
                    });
                }

            });

        }
    }
}
