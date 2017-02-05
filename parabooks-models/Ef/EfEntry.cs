using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using com.theparagroup.parabooks.models;

namespace com.theparagroup.parabooks.models.Ef
{
	public partial class EfEntry:Entry
	{
		[ForeignKey("AccountId")]
		public virtual EfAccount Account { get; set;}
		[ForeignKey("TransactionId")]
		public virtual EfTransaction Transaction { get; set;}
	}
}
