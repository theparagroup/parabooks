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

		[Key]
		[Display(Name="Id")]
		[Required(ErrorMessage="Id is required")]
		public object Id;

		[Display(Name="Guid")]
		public object Guid;

		[ForeignKey("Parent")]
		[Display(Name="Parent Id")]
		public object ParentId;

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

		[ForeignKey("Normal")]
		[Display(Name="Normal Id")]
		[Required(ErrorMessage="Normal Id is required")]
		public object NormalId;

		[Display(Name="Nominal")]
		[Required(ErrorMessage="Nominal is required")]
		public object Nominal;

		[Display(Name="Contra")]
		[Required(ErrorMessage="Contra is required")]
		public object Contra;

		[ForeignKey("Method")]
		[Display(Name="Method Id")]
		public object MethodId;

		[ForeignKey("Module")]
		[Display(Name="Module Id")]
		[Required(ErrorMessage="Module Id is required")]
		public object ModuleId;
	}
}
