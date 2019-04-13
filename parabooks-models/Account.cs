using System;

namespace com.theparagroup.parabooks.models
{
	public partial class Account
	{
		public long Id { get; set;}
		public long AccountTypeId { get; set;}
		public long? ParentId { get; set;}
		public bool Virtual { get; set;}
		public string Number { get; set;}
		public string Name { get; set;}
		public string Description { get; set;}
	}
}
