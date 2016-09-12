using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using com.theparagroup.parabooks.models;

namespace com.theparagroup.parabooks.models.Ef
{
	public class EfTransaction:Transaction
	{
		[ForeignKey("TransactionTypeId")]
		public virtual EfTransactionType TransactionType { get; set;}
		[ForeignKey("ParentId")]
		public virtual EfTransaction Parent { get; set;}
		[InverseProperty("Transaction")]
		public virtual List<EfEntry> Entries { get; set;}
		[InverseProperty("Parent")]
		public virtual List<EfTransaction> Transactions { get; set;}
	}
}
