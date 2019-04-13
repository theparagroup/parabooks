using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using com.theparagroup.parabooks.models;

namespace com.theparagroup.parabooks.models.Ef
{
	public partial class EfAccountType:AccountType
	{
		public virtual EfMethod Method { get; set;}
		public virtual EfModule Module { get; set;}
		public virtual EfNormal Normal { get; set;}
		public virtual EfAccountType Parent { get; set;}

		[InverseProperty("AccountType")]
		public virtual List<EfAccountTypeBusinessForm> AccountTypeBusinessForms { get; set;}

		[InverseProperty("Parent")]
		public virtual List<EfAccountType> AccountTypes { get; set;}

		[InverseProperty("AccountType")]
		public virtual List<EfAccount> Accounts { get; set;}
	}
}
