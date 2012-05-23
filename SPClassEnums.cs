using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPDG
{
    public class SPClassEnums: List<string>
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("public enum eFields { ");

            for (int i = 0; i < this.Count; i++ )
            {
                sb.Append(this[i]);
                if (i < this.Count - 1) { sb.Append(","); }
            }
            
            sb.AppendLine(" }");
            return sb.ToString();
        }

    }
}
