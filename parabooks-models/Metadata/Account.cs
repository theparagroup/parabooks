using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using com.paralib.DataAnnotations;
using com.theparagroup.parabooks.models.Metadata;


namespace com.theparagroup.parabooks.models
{
	[MetadataType(typeof(AccountMetadata))]
	public partial class Account
	{
	}
}

namespace com.theparagroup.parabooks.models.Metadata
{
	public class AccountMetadata
	{

		[Key]
		[Display(Name="Id")]
		[Required(ErrorMessage="Id is required")]
		public object Id;

		[ForeignKey("AccountType")]
		[Display(Name="Account Type Id")]
		[Required(ErrorMessage="Account Type Id is required")]
		public object AccountTypeId;

		[ForeignKey("Parent")]
		[Display(Name="Parent Id")]
		public object ParentId;

		[Display(Name="Virtual")]
		[Required(ErrorMessage="Virtual is required")]
		public object Virtual;

		[Display(Name="Number")]
		[StringLength(64)]
		public object Number;

		[Display(Name="Name")]
		[Required(ErrorMessage="Name is required")]
		[StringLength(64)]
		public object Name;

		[Display(Name="Description")]
		[StringLength(128)]
		public object Description;

		[Display(Name="Notes")]
		[StringLength(512)]
		public object Notes;
	}
}
