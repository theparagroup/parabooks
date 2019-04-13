using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using com.theparagroup.parabooks.models;

namespace com.theparagroup.parabooks.models.Ef
{
	public partial class EfModule:Module
	{
		[InverseProperty("Module")]
		public virtual List<EfAccountType> AccountTypes { get; set;}

		[InverseProperty("Module")]
		public virtual List<EfTransactionType> TransactionTypes { get; set;}
	}
}
