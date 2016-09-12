using System;
using System.Linq;
using com.theparagroup.parabooks.models.Ef;

namespace com.theparagroup.parabooks.models
{
	public partial class AccountType
	{
        public static void Enumerate(Action<EfAccountType, int> lambda)
        {
            using (var db = new DbContext())
            {
                Enumerate(db, null, lambda, 0);
            }
        }

        private static void Enumerate(DbContext db, EfAccountType accountType, Action<EfAccountType, int> lambda, int level)
        {
            ++level;
            var parentId = accountType?.Id;
            var accountTypes = (from at in db.AccountTypes where at.ParentId == parentId select at).ToList();

            foreach (var at in accountTypes)
            {
                lambda(at, level);
                Enumerate(db, at, lambda, level);
            }

            --level;

        }
    }
}
