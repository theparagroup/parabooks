using System;

namespace com.theparagroup.parabooks.models
{
	public partial class Entry
	{
		public long Id { get; set;}
		public long TransactionId { get; set;}
		public int? Reference { get; set;}
		public long AccountId { get; set;}
		public decimal Amount { get; set;}
		public string Description { get; set;}
	}
}
