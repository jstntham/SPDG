using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPDG
{
    public class SPClassInterfaceImplementationParam
    {
        public SPClassInterfaceImplementationParam(string propname)
        {
            this.propname = propname;
        }
        public string propname { get; set; }

        public override string ToString()
        {
            return string.Format("eFields.{0}", this.propname);
        }
    }
}
