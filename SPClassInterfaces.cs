using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPDG
{
    public class SPClassInterfaces: List<string>
    {
        public SPClassInterfaces(bool IExecuteDataSet, bool IExecuteDataReader, bool IExecuteXML, bool IExecuteNonQuery, bool IExecuteScalar)
        {
            if (IExecuteDataSet) { this.Add("IExecuteDataSet"); }
            if (IExecuteDataReader) { this.Add("IExecuteDataReader"); }
            if (IExecuteXML) { this.Add("IExecuteXML"); }
            if (IExecuteNonQuery) { this.Add("IExecuteNonQuery"); }
            if (IExecuteScalar) { this.Add("IExecuteScalar"); }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                sb.Append(", " + this[i]);
            }
            return sb.ToString();
        }
    }
}
