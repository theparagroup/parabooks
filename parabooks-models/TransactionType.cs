using System;

namespace com.theparagroup.parabooks.models
{
	public partial class TransactionType
	{
		public int Id { get; set;}
		public Guid? Guid { get; set;}
		public string Name { get; set;}
		public int ModuleId { get; set;}
	}
}
