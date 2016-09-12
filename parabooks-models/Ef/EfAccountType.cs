using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using com.theparagroup.parabooks.models;

namespace com.theparagroup.parabooks.models.Ef
{
	public class EfAccountType:AccountType
	{
		[ForeignKey("ParentId")]
		public virtual EfAccountType Parent { get; set;}
		[ForeignKey("BusinessFormId")]
		public virtual EfBusinessForm BusinessForm { get; set;}
		[ForeignKey("MethodId")]
		public virtual EfMethod Method { get; set;}
		[ForeignKey("NormalId")]
		public virtual EfNormal Normal { get; set;}
		[InverseProperty("Parent")]
		public virtual List<EfAccountType> AccountTypes { get; set;}
		[InverseProperty("AccountType")]
		public virtual List<EfAccount> Accounts { get; set;}
	}
}
