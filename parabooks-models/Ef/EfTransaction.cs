using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using com.theparagroup.parabooks.models;

namespace com.theparagroup.parabooks.models.Ef
{
	public partial class EfTransaction:Transaction
	{
		[ForeignKey("TransactionTypeId")]
		public virtual EfTransactionType TransactionType { get; set;}
		[InverseProperty("Transaction")]
		public virtual List<EfEntry> Entries { get; set;}
	}
}
