using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPDG
{
    public class SPClassFieldsIO: List<bool>
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                sb.Append(this[i].ToString().ToLower());
                if (i < this.Count - 1) { sb.Append(","); }
            }
            return sb.ToString();            
        }
    }
}
