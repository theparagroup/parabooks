using System;

namespace com.theparagroup.parabooks.models
{
	public partial class AccountType
	{
		public long Id { get; set;}
		public Guid? Guid { get; set;}
		public long? ParentId { get; set;}
		public string Number { get; set;}
		public string Name { get; set;}
		public string Description { get; set;}
		public long NormalId { get; set;}
		public bool Nominal { get; set;}
		public bool Contra { get; set;}
		public long? MethodId { get; set;}
		public long ModuleId { get; set;}
	}
}
