using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using com.paralib.DataAnnotations;
using com.theparagroup.parabooks.models.Metadata;


namespace com.theparagroup.parabooks.models
{
	[MetadataType(typeof(AccountTypeMetadata))]
	public partial class AccountType
	{
	}
}

namespace com.theparagroup.parabooks.models.Metadata
{
	public class AccountTypeMetadata
	{

		[Key, Column(Order = 0)]
		[Display(Name="Id")]
		[Required(ErrorMessage="Id is required")]
		public object Id;

		[Display(Name="Parent Id")]
		public object ParentId;

		[Display(Name="Number")]
		[Required(ErrorMessage="Number is required")]
		[StringLength(64)]
		public object Number;

		[Display(Name="Name")]
		[Required(ErrorMessage="Name is required")]
		[StringLength(64)]
		public object Name;

		[Display(Name="Description")]
		[StringLength(128)]
		public object Description;

		[Display(Name="Normal Id")]
		public object NormalId;

		[Display(Name="Business Form Id")]
		public object BusinessFormId;

		[Display(Name="Method Id")]
		public object MethodId;

		[Display(Name="Canonical Id")]
		public object CanonicalId;

		[Display(Name="Nominal")]
		public object Nominal;

		[Display(Name="Contra")]
		public object Contra;

		[Display(Name="Method Required")]
		public object MethodRequired;

		[Display(Name="Business Form Required")]
		public object BusinessFormRequired;
	}
}
