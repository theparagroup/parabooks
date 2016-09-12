using System;
using System.Linq;
using com.theparagroup.parabooks.models.Ef;

namespace com.theparagroup.parabooks.models
{
	public partial class Account
	{
        public static void Enumerate(EfAccountType accountType, Action<EfAccount, int> lambda)
        {
            using (var db = new DbContext())
            {
                var accounts = (from a in db.Accounts where a.AccountTypeId == accountType.Id select a).ToList();

                foreach (var a in accounts)
                {
                    Enumerate(db, a, lambda, 0);
                }
            }
        }

        private static void Enumerate(DbContext db, EfAccount account, Action<EfAccount, int> lambda, int level)
        {
            ++level;

            lambda(account, level);

            var parentId = account?.Id;
            var accounts = (from a in db.Accounts where a.ParentId == parentId select a).ToList();

            foreach (var a in accounts)
            {
                Enumerate(db, a, lambda, level);
            }

            --level;

        }
    }
}
