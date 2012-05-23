using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPDG
{
    public class SPClassInterfaceImplementations: List<SPClassInterfaceImplementation>
    {
        public SPClassInterfaceImplementations(bool IExecuteDataSet, bool IExecuteDataReader, bool IExecuteXML, bool IExecuteNonQuery, bool IExecuteScalar, SPClassInterfaceImplementationParams InterfaceImplementationParams)
        {
            if (IExecuteDataSet) { this.Add(new SPClassInterfaceImplementation("IExecuteDataSet", InterfaceImplementationParams)); }
            if (IExecuteDataReader) { this.Add(new SPClassInterfaceImplementation("IExecuteDataReader", InterfaceImplementationParams)); }
            if (IExecuteXML) { this.Add(new SPClassInterfaceImplementation("IExecuteXML", InterfaceImplementationParams)); }
            if (IExecuteNonQuery) { this.Add(new SPClassInterfaceImplementation("IExecuteNonQuery", InterfaceImplementationParams)); }
            if (IExecuteScalar) { this.Add(new SPClassInterfaceImplementation("IExecuteScalar", InterfaceImplementationParams)); }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (SPClassInterfaceImplementation imp in this)
            {
                sb.AppendLine(imp.ToString());
            }
            return sb.ToString();
        }
    }
}
