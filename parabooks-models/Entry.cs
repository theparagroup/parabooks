using System;

namespace com.theparagroup.parabooks.models
{
	public partial class Entry
	{
		public int Id { get; set;}
		public int TransactionId { get; set;}
		public int? Reference { get; set;}
		public int AccountId { get; set;}
		public decimal Amount { get; set;}
		public string Description { get; set;}
	}
}
