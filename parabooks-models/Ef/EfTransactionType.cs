using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using com.theparagroup.parabooks.models;

namespace com.theparagroup.parabooks.models.Ef
{
	public class EfTransactionType:TransactionType
	{
		[InverseProperty("TransactionType")]
		public virtual List<EfTransaction> Transactions { get; set;}
	}
}
