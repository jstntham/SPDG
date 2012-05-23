using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPDG
{
    public class SPClassProperties: List<SPClassProperty>
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (SPClassProperty prop in this)
            {
                sb.AppendLine(prop.ToString());
            }
            return sb.ToString();
        }
    }
}
