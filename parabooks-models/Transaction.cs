using System;

namespace com.theparagroup.parabooks.models
{
	public partial class Transaction
	{
		public long Id { get; set;}
		public long TransactionTypeId { get; set;}
		public int? Reference { get; set;}
		public DateTime Date { get; set;}
		public string Description { get; set;}
	}
}
