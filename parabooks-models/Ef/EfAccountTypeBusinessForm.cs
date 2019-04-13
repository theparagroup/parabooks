using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using com.theparagroup.parabooks.models;

namespace com.theparagroup.parabooks.models.Ef
{
	public partial class EfAccountTypeBusinessForm:AccountTypeBusinessForm
	{
		public virtual EfAccountType AccountType { get; set;}
		public virtual EfBusinessForm BusinessForm { get; set;}
	}
}
