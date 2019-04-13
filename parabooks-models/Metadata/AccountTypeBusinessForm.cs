using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using com.paralib.DataAnnotations;
using com.theparagroup.parabooks.models.Metadata;


namespace com.theparagroup.parabooks.models
{
	[MetadataType(typeof(AccountTypeBusinessFormMetadata))]
	public partial class AccountTypeBusinessForm
	{
	}
}

namespace com.theparagroup.parabooks.models.Metadata
{
	public class AccountTypeBusinessFormMetadata
	{

		[Key, Column(Order = 0)]
		[ForeignKey("AccountType")]
		[Display(Name="Account Type Id")]
		[Required(ErrorMessage="Account Type Id is required")]
		public object AccountTypeId;

		[Key, Column(Order = 1)]
		[ForeignKey("BusinessForm")]
		[Display(Name="Business Form Id")]
		[Required(ErrorMessage="Business Form Id is required")]
		public object BusinessFormId;
	}
}
