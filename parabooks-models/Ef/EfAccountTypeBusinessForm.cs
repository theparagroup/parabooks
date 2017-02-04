using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using com.theparagroup.parabooks.models;

namespace com.theparagroup.parabooks.models.Ef
{
	public partial class EfAccountTypeBusinessForm:AccountTypeBusinessForm
	{
		[ForeignKey("AccountTypeId")]
		public virtual EfAccountType AccountType { get; set;}
		[ForeignKey("BusinessFormId")]
		public virtual EfBusinessForm BusinessForm { get; set;}
	}
}
