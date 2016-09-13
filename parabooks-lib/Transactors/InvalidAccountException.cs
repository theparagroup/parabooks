using com.theparagroup.parabooks.models.Ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.theparagroup.parabooks.Transactors
{
    public class InvalidAccountException:Exception
    {
        public InvalidAccountException(string message) : base(message)
        {
        }

        public static void Verify(EfAccount account, int[] cids)
        {
            if (account.AccountType.CanonicalId.HasValue)
            {
                if (!cids.Contains<int>(account.AccountType.CanonicalId.Value))
                {
                    throw new InvalidAccountException($"account [{account.Number} - {account.Name}] is a {account.AccountType.CanonicalId} but must be a [{string.Join(",", cids)}]");
                }
            }
            else
            {
                throw new InvalidAccountException($"account [{account.Number} - {account.Name}] has a null canonical id");
            }
        }

    }
}
