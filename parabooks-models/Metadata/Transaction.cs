using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using com.paralib.DataAnnotations;
using com.theparagroup.parabooks.models.Metadata;


namespace com.theparagroup.parabooks.models
{
	[MetadataType(typeof(TransactionMetadata))]
	public partial class Transaction
	{
	}
}

namespace com.theparagroup.parabooks.models.Metadata
{
	public class TransactionMetadata
	{

		[Key, Column(Order = 0)]
		[Display(Name="Id")]
		[Required(ErrorMessage="Id is required")]
		public object Id;

		[Display(Name="Parent Id")]
		[Required(ErrorMessage="Parent Id is required")]
		public object ParentId;

		[Display(Name="Transaction Type Id")]
		[Required(ErrorMessage="Transaction Type Id is required")]
		public object TransactionTypeId;

		[Display(Name="Reference")]
		public object Reference;

		[Display(Name="Date")]
		[Required(ErrorMessage="Date is required")]
		public object Date;

		[Display(Name="Description")]
		[StringLength(128)]
		public object Description;
	}
}
