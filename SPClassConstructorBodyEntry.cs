using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPDG
{
    public class SPClassConstructorBodyEntry
    {
        public SPClassConstructorBodyEntry(string propname)
        {
            this.propname = propname;
        }
        public string propname { get; set; }

        public override string ToString()
        {
            return string.Format(Properties.Resources.strSPConstructorBodyEntry, this.propname);
        }

    }
}
