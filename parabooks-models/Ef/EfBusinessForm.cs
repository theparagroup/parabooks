using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using com.theparagroup.parabooks.models;

namespace com.theparagroup.parabooks.models.Ef
{
	public partial class EfBusinessForm:BusinessForm
	{
		[InverseProperty("BusinessForm")]
		public virtual List<EfAccountTypeBusinessForm> AccountTypeBusinessForms { get; set;}
	}
}
