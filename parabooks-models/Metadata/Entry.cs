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

		[Key]
		[Display(Name="Id")]
		[Required(ErrorMessage="Id is required")]
		public object Id;

		[ForeignKey("Transaction")]
		[Display(Name="Transaction Id")]
		[Required(ErrorMessage="Transaction Id is required")]
		public object TransactionId;

		[Display(Name="Reference")]
		public object Reference;

		[ForeignKey("Account")]
		[Display(Name="Account Id")]
		[Required(ErrorMessage="Account Id is required")]
		public object AccountId;

		[Display(Name="Amount")]
		[Required(ErrorMessage="Amount is required")]
		public object Amount;

		[Display(Name="Description")]
		[StringLength(128)]
		public object Description;
	}
}
