using System;
using System.Data.Entity;
using com.paralib.Dal.Ef;

namespace com.theparagroup.parabooks.models.Ef
{
	[DbConfigurationType(typeof(EfConfiguration))]
	public class DbContext:EfContext
	{

#if DEBUG
		public DbContext()
		{
			Database.Log = message => System.Diagnostics.Debug.WriteLine(message);
		}
#endif

		public DbSet<EfBusinessForm> BusinessForms { get; set; }
		public DbSet<EfNormal> Normals { get; set; }
		public DbSet<EfMethod> Methods { get; set; }
		public DbSet<EfAccountType> AccountTypes { get; set; }
		public DbSet<EfAccount> Accounts { get; set; }
		public DbSet<EfTransactionType> TransactionTypes { get; set; }
		public DbSet<EfTransaction> Transactions { get; set; }
		public DbSet<EfEntry> Entries { get; set; }
	}
}
