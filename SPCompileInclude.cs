using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPDG
{
    public class SPCompileInclude
    {
        public SPCompileInclude(string pStoredProcedureName)
        {
            this.StoredProcedureName = pStoredProcedureName;
        }
        public string StoredProcedureName { get; set; }
        public override string ToString()
        {
            return string.Format(Properties.Resources.strCompileInclude, StoredProcedureName);
        }
    }
}
