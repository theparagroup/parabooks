using System;
using System.Collections.Generic;
using System.Linq;
using com.theparagroup.parabooks.models.Ef;

namespace com.theparagroup.parabooks.models
{
	public partial class Account
	{
        //note: the parent in the lambda is the 'walking' parent, and may not be the same as the account.Parent
        public static void Enumerate(EfAccountType accountType, Action<EfAccount, EfAccount, bool, bool, Stack<EfAccount>> lambda)
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

        private static void Enumerate(DbContext db, Stack<EfAccount> accountStack, EfAccountType accountType, EfAccount parent, EfAccount account, Action<EfAccount, EfAccount, bool, bool, Stack<EfAccount>> lambda)
        {
            accountStack.Push(account);

            bool xFiled = false;
            bool xBooked = false;

            //account's type matches what we're walking
            if ((account.AccountTypeId == accountType.Id))
            {
                //but account's parent type doesn't match what we're walking
                if ((account.Parent != null) && (account.Parent.AccountTypeId != accountType.Id))
                {
                    xFiled = true;
                }

            }
            else
            {
                //doesn't match what we're walking
                xBooked = true;
            }

            lambda(parent, account, xFiled, xBooked, accountStack);

            var parentId = account?.Id;
            var accounts = (from a in db.Accounts where a.ParentId == parentId select a).ToList();

            foreach (var a in accounts)
            {
                Enumerate(db, accountStack, accountType, account, a, lambda);
            }

            accountStack.Pop();

        }
    }
}
