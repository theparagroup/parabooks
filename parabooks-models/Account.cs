using System;

namespace com.theparagroup.parabooks.models
{
	public partial class Account
	{
		public int Id { get; set;}
		public int AccountTypeId { get; set;}
		public int? ParentId { get; set;}
		public bool Virtual { get; set;}
		public string Number { get; set;}
		public string Name { get; set;}
		public string Description { get; set;}
	}
}
