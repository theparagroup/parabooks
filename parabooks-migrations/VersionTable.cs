using FluentMigrator.VersionTableInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.theparagroup.parabooks.migrations
{
    [VersionTableMetaData]
    public class VersionTable : DefaultVersionTableMetaData
    {
        public override string TableName
        {
            get { return "parabooks_version_info"; }
        }
    }
}
