using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using com.theparagroup.parabooks.models;

namespace com.theparagroup.parabooks.models.Ef
{
	public partial class EfAccount:Account
	{
		public virtual EfAccountType AccountType { get; set;}
		public virtual EfAccount Parent { get; set;}

		[InverseProperty("Parent")]
		public virtual List<EfAccount> Accounts { get; set;}

		[InverseProperty("Account")]
		public virtual List<EfEntry> Entries { get; set;}
	}
}
