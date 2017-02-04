using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.theparagroup.parabooks.models.Ef
{

    public partial class EfAccount
    {

        [InverseProperty("Parent")]
        public virtual List<EfAccount> Accounts { get; set; }

        [ForeignKey("ParentAccountTypeId,ParentAccountId")]
        public virtual EfAccount Parent { get; set; }

        [InverseProperty("Account")]
        public virtual List<EfEntry> Entries { get; set; }


    }




}
