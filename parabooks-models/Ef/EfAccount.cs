using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using com.theparagroup.parabooks.models;

namespace com.theparagroup.parabooks.models.Ef
{
	public partial class EfAccount:Account
	{
		[ForeignKey("AccountTypeId")]
		public virtual EfAccountType AccountType { get; set;}
	}
}
