using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using com.theparagroup.parabooks.models;

namespace com.theparagroup.parabooks.models.Ef
{
	public partial class EfTransactionType:TransactionType
	{
		public virtual EfModule Module { get; set;}

		[InverseProperty("TransactionType")]
		public virtual List<EfTransaction> Transactions { get; set;}
	}
}
