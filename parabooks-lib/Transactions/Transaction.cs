using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.theparagroup.parabooks.Transactions
{
    public abstract class Transaction
    {
        public void Execute()
        {

        }

        public virtual void Start()
        {

        }

        public abstract void WriteEntries();

        public virtual void End()
        {

        }
    }
}
