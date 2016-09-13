using System;

namespace com.theparagroup.parabooks.models
{
	public partial class AccountType
	{
		public int Id { get; set;}
		public int? ParentId { get; set;}
		public string Number { get; set;}
		public string Name { get; set;}
		public string Description { get; set;}
		public int? NormalId { get; set;}
		public int? BusinessFormId { get; set;}
		public int? MethodId { get; set;}
		public int? CanonicalId { get; set;}
		public bool? Nominal { get; set;}
		public bool? Contra { get; set;}
		public bool? MethodRequired { get; set;}
		public bool? BusinessFormRequired { get; set;}
	}
}
