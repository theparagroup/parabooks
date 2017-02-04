using System;

namespace com.theparagroup.parabooks.models
{
	public partial class Account
	{
		public int AccountTypeId { get; set;}
		public int AccountId { get; set;}
		public int? ParentAccountTypeId { get; set;}
		public int? ParentAccountId { get; set;}
		public bool Virtual { get; set;}
		public string Number { get; set;}
		public string Name { get; set;}
		public string Description { get; set;}
	}
}
