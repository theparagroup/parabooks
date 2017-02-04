using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using com.theparagroup.parabooks.models;

namespace com.theparagroup.parabooks.models.Ef
{
	public partial class EfMethod:Method
	{
		[InverseProperty("Method")]
		public virtual List<EfAccountType> AccountTypes { get; set;}
	}
}
