using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using com.paralib.DataAnnotations;
using com.theparagroup.parabooks.models.Metadata;


namespace com.theparagroup.parabooks.models
{
	[MetadataType(typeof(EntryMetadata))]
	public partial class Entry
	{
	}
}

namespace com.theparagroup.parabooks.models.Metadata
{
	public class EntryMetadata
	{

		[Key, Column(Order = 0)]
		[Display(Name="Id")]
		[Required(ErrorMessage="Id is required")]
		public object Id;

		[Display(Name="Transaction Id")]
		[Required(ErrorMessage="Transaction Id is required")]
		public object TransactionId;

		[Display(Name="Account Id")]
		[Required(ErrorMessage="Account Id is required")]
		public object AccountId;

		[Display(Name="Amount")]
		[Required(ErrorMessage="Amount is required")]
		public object Amount;
	}
}
