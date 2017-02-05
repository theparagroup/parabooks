using System;
using System.Collections.Generic;
using System.Linq;
using com.theparagroup.parabooks.models.Ef;

namespace com.theparagroup.parabooks.models
{
	public partial class AccountType
	{
        public static void Enumerate(Action<EfAccountType, bool, Stack<EfAccountType>> lambda)
        {
            using (var db = new DbContext())
            {
                var stack = new Stack<EfAccountType>();
                Enumerate(db, stack, null, lambda);
            }
        }

        private static void Enumerate(DbContext db, Stack<EfAccountType> accountTypesStack, EfAccountType accountType, Action<EfAccountType, bool, Stack<EfAccountType>> lambda)
        {

            var parentId = accountType?.Id;
            var accountTypes = (from at in db.AccountTypes where at.Parent.Id == parentId select at).ToList();

            foreach (var at in accountTypes)
            {
                accountTypesStack.Push(at);
                lambda(at, true, accountTypesStack);
                Enumerate(db, accountTypesStack, at, lambda);
                lambda(at, false, accountTypesStack);
                accountTypesStack.Pop();
            }


        }
    }
}
