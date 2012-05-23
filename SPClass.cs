using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPDG
{
    public class SPClass
    {
        public SPClass(string ns, string procedurename)
        {
            this.Namespace = ns;
            this.ProcedureName = procedurename;
            Enums = new SPClassEnums();
            Properties = new SPClassProperties();
            ConstructorParams = new SPClassConstructorParams();
            ConstructorBody = new SPClassConstructorBody();
            FieldsIO = new SPClassFieldsIO();
        }

        public SPClassEnums Enums { get; set; }
        public SPClassProperties Properties { get; set; }
        public SPClassConstructorParams ConstructorParams { get; set; }
        public SPClassConstructorBody ConstructorBody { get; set; }
        public SPClassInterfaces Interfaces { get; set; }
        public SPClassInterfaceImplementations InterfaceImplementations { get; set; }
        public SPClassFieldsIO FieldsIO { get; set; }
        public string Namespace { get; set; }
        public string ProcedureName { get; set; }

        public override string ToString()
        {
            return string.Format(SPDG.Properties.Resources.strSPClass, this.Namespace, this.ProcedureName, this.Interfaces.ToString(), this.Enums.ToString(), this.Properties.ToString(), this.InterfaceImplementations.ToString(), this.ConstructorParams.ToString(), this.ConstructorBody.ToString(), this.FieldsIO.ToString()).Replace("<<", "{").Replace(">>", "}");
        }

    }
}
