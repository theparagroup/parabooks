using System;

namespace com.theparagroup.parabooks.models
{
	public partial class TransactionType
	{
		public long Id { get; set;}
		public Guid? Guid { get; set;}
		public string Name { get; set;}
		public long ModuleId { get; set;}
	}
}
