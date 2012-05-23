using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPDG
{
    public class SPClassProperty
    {
        public SPClassProperty(string propname, string proptype)
        {
            this.propname = propname;
            this.proptype = proptype;
        }
        public string propname { get; set; }
        public string proptype { get; set; }

        public override string ToString()
        {
            return string.Format(Properties.Resources.strProperty, this.proptype, this.propname);
        }
    }
}
