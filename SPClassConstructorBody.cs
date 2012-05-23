using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPDG
{
    public class SPClassConstructorBody : List<SPClassConstructorBodyEntry>
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (SPClassConstructorBodyEntry entry in this)
            {
                sb.AppendLine(entry.ToString());
            }
            return sb.ToString();
        }
    }
}
