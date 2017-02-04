using System;
using System.Collections.Generic;
using System.Linq;
using com.theparagroup.parabooks.models.Ef;

namespace com.theparagroup.parabooks.models
{
	public partial class Account
	{
        public static void Enumerate(EfAccountType accountType, Action<EfAccount, EfAccount, Stack<EfAccount>> lambda)
        {
            using (var db = new DbContext())
            {
                var accounts = (from a in db.Accounts.Include("AccountType").Include("Parent.AccountType") where a.AccountTypeId == accountType.Id && ((a.ParentAccountTypeId==null && a.ParentAccountId==null) || (a.AccountTypeId!=a.ParentAccountTypeId)) select a).ToList();

                foreach (var a in accounts)
                {
                    var accountStack = new Stack<EfAccount>();
                    Enumerate(db, accountStack, null, a, lambda);
                }
            }
        }

        private static void Enumerate(DbContext db, Stack<EfAccount> accountStack, EfAccount parent, EfAccount account, Action<EfAccount, EfAccount, Stack<EfAccount>> lambda)
        {
            accountStack.Push(account);

            lambda(parent, account, accountStack);

            var parentAccountTypeId = account?.AccountTypeId;
            var parentAccountId = account?.AccountId;
            var accounts = (from a in db.Accounts where a.ParentAccountTypeId == parentAccountTypeId && a.ParentAccountId == parentAccountId select a).ToList();

            foreach (var a in accounts)
            {
                Enumerate(db, accountStack, account, a, lambda);
            }

            accountStack.Pop();

        }
    }
}
