using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using com.theparagroup.parabooks.models;

namespace com.theparagroup.parabooks.models.Ef
{
	public partial class EfEntry
	{
        [ForeignKey("AccountTypeId,AccountId")]
        public virtual EfAccount Account { get; set; }
    }
}
