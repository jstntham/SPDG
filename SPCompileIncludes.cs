using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPDG
{
    public class SPCompileIncludes: List<SPCompileInclude>
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (SPCompileInclude ci in this)
            {
                sb.Append(ci.ToString());
            }
            return sb.ToString();
        }
    }
}
