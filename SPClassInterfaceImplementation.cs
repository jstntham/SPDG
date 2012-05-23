using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPDG
{
    public class SPClassInterfaceImplementation
    {
        public string Interface;
        private string InterfaceParams;

        public SPClassInterfaceImplementation(string interfacetoimplement, SPClassInterfaceImplementationParams interfaceparams)
        {
            InterfaceParams = interfaceparams.ToString();
            if (interfacetoimplement == "IExecuteDataSet") { Interface = string.Format(Properties.Resources.strIExecuteDataSetImplementation, InterfaceParams); }
            if (interfacetoimplement == "IExecuteDataReader") { Interface = string.Format(Properties.Resources.strIExecuteDataReaderImplementation, InterfaceParams); }
            if (interfacetoimplement == "IExecuteXML") { Interface = string.Format(Properties.Resources.strIExecuteXMLImplementation, InterfaceParams); }
            if (interfacetoimplement == "IExecuteNonQuery") { Interface = string.Format(Properties.Resources.strIExecuteNonQueryImplementation, InterfaceParams); }
            if (interfacetoimplement == "IExecuteScalar") { Interface = string.Format(Properties.Resources.strIExecuteScalarImplementation, InterfaceParams); }
        }

        public override string ToString()
        {
            return Interface;
        }
    }
}
