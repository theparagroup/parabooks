using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using com.paralib.DataAnnotations;
using com.theparagroup.parabooks.models.Metadata;


namespace com.theparagroup.parabooks.models
{
	[MetadataType(typeof(TransactionTypeMetadata))]
	public partial class TransactionType
	{
	}
}

namespace com.theparagroup.parabooks.models.Metadata
{
	public class TransactionTypeMetadata
	{

		[Key, Column(Order = 0)]
		[Display(Name="Id")]
		[Required(ErrorMessage="Id is required")]
		public object Id;

		[Display(Name="Guid")]
		public object Guid;

		[Display(Name="Name")]
		[Required(ErrorMessage="Name is required")]
		[StringLength(64)]
		public object Name;

		[Display(Name="Module Id")]
		[Required(ErrorMessage="Module Id is required")]
		public object ModuleId;
	}
}
