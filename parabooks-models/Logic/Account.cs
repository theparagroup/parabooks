using System;
using System.Collections.Generic;
using System.Linq;
using com.theparagroup.parabooks.models.Ef;

namespace com.theparagroup.parabooks.models
{
	public partial class Account
	{
        //note: the parent in the lambda is the 'walking' parent, and may not be the same as the account.Parent
        public static void Enumerate(EfAccountType accountType, Action<EfAccount, EfAccount, bool, bool, bool, Stack<EfAccount>> lambda)
        {
            using (var db = new DbContext())
            {
                var accounts = (from a in db.Accounts.Include("AccountType").Include("Parent.AccountType") where a.AccountTypeId == accountType.Id && (a.Parent==null || (a.Parent!=null && a.AccountType!=a.Parent.AccountType)) select a).ToList();

                foreach (var a in accounts)
                {
                    var accountStack = new Stack<EfAccount>();
                    Enumerate(db, accountStack, accountType, null, a, lambda);
                }
            }
        }


        private static void Enumerate(DbContext db, Stack<EfAccount> accountStack, EfAccountType accountType, EfAccount parent, EfAccount account, Action<EfAccount, EfAccount, bool, bool, bool, Stack<EfAccount>> lambda)
        {
            /*
                We always enumate accounts in the context of an account type (the 'walking account type').

                If an account is "virtual", it only is used for organization and should not have entries booked to it.

                If an account is "contra", then (regardless of account type), it is always booked against the parent.
                Contra accounts should have the same normality as the parent, but carry an oppositer or zero balance.
                Contra accounts can be xFiled, but never XBooked.

                When a non-contra account's actual type doesn't match the walking account, then it is xBooked 
                (parented here booked to another type). Top-level accounts (no parent) can never be xBooked.

                When a child account's type does match the walking type, but the parent type is different, then it is xFiled 
                (booked here but parented somewhere else).

            */



            accountStack.Push(account);

            bool xFiled = false;
            bool xBooked = false;

            //account's type DOES match the accountType we're walking
            if ((account.AccountTypeId == accountType.Id))
            {
                //but account's parent type DOES NOT match what we're walking
                if ((account.Parent != null) && (account.Parent.AccountTypeId != accountType.Id))
                {
                    //this can only happen for child accounts of course
                    xFiled = true;
                }

            }
            else
            {
                //account's type DOES NOT match the accountType we're walking
                //contra accounts are never 'xBooked'
                if (!account.AccountType.Contra)
                {
                    //this can only happen for child accounts because top-level accounts
                    //only appear when walking thier type
                    xBooked = true;
                }
            }

            lambda(parent, account, xFiled, xBooked, true, accountStack);

            var parentId = account?.Id;
            var accounts = (from a in db.Accounts where a.ParentId == parentId select a).ToList();

            foreach (var a in accounts)
            {
                Enumerate(db, accountStack, accountType, account, a, lambda);
            }

            lambda(parent, account, xFiled, xBooked, false, accountStack);

            accountStack.Pop();

        }
    }
}
