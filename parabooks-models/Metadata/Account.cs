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

		[Key, Column(Order = 0)]
		[Display(Name="Account Type Id")]
		[Required(ErrorMessage="Account Type Id is required")]
		public object AccountTypeId;

		[Key, Column(Order = 1)]
		[Display(Name="Account Id")]
		[Required(ErrorMessage="Account Id is required")]
		public object AccountId;

		[Display(Name="Parent Account Type Id")]
		public object ParentAccountTypeId;

		[Display(Name="Parent Account Id")]
		public object ParentAccountId;

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
	}
}
