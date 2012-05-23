using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SPDG
{
    public class SPGHelper
    {

        public static SPClass GenerateClass(string pConString, string pNamespace, string pSPName, bool pSkip, bool pExecuteDataSet, bool pExecuteDataReader, bool pExecuteXML, bool pExecuteNonQuery, bool pExecuteScalar, DataGridView dgv)
        {
            SPGDataHelper spg = new SPGDataHelper();
            SPClass spc = new SPClass(pNamespace, pSPName);
            try
            {
                SqlDataReader dr = spg.GetStoredProcedureParameters(pConString, pSPName);
                SPClassInterfaceImplementationParams InterfaceImplementationParams = new SPClassInterfaceImplementationParams();
                while (dr.Read())
                {
                    if (dgv != null)
                    {
                        dgv.Rows.Add(dr["parameter_name"].ToString(), dr["data_type"].ToString(), dr["character_maximum_length"].ToString(), spg.GetDotNetDataTypeEquivalent(dr["data_type"].ToString(), dr["character_maximum_length"].ToString()), dr["parameter_mode"].ToString());
                    }
                    spc.Enums.Add(dr["parameter_name"].ToString().Remove(0, 1));
                    spc.Properties.Add(new SPClassProperty(dr["parameter_name"].ToString().Remove(0, 1), spg.GetDotNetDataTypeEquivalent(dr["data_type"].ToString(), dr["character_maximum_length"].ToString())));
                    spc.ConstructorParams.Add(new SPClassConstructorParam(dr["parameter_name"].ToString().Remove(0, 1), spg.GetDotNetDataTypeEquivalent(dr["data_type"].ToString(), dr["character_maximum_length"].ToString())));
                    spc.ConstructorBody.Add(new SPClassConstructorBodyEntry(dr["parameter_name"].ToString().Remove(0, 1)));
                    if (dr["parameter_mode"].ToString() == "IN")
                        spc.FieldsIO.Add(false);
                    else
                        spc.FieldsIO.Add(true);

                    InterfaceImplementationParams.Add(new SPClassInterfaceImplementationParam(dr["parameter_name"].ToString().Remove(0, 1)));

                }
                spc.Interfaces = new SPClassInterfaces(pExecuteDataSet, pExecuteDataReader, pExecuteXML, pExecuteNonQuery, pExecuteScalar);
                spc.InterfaceImplementations = new SPClassInterfaceImplementations(pExecuteDataSet, pExecuteDataReader, pExecuteXML, pExecuteNonQuery, pExecuteScalar, InterfaceImplementationParams);
                dr.Close();
                dr = null;
            }
            catch (SqlException sqle)
            {
                throw sqle;
            }
            return spc;
        }
        public static void WriteBaseClass(string pDir, string pNamespace, string pConString) 
        {
            if (!Directory.Exists(pDir))
                Directory.CreateDirectory(pDir);
            File.WriteAllText(pDir + "spbase.cs", string.Format(Properties.Resources.strSPBase, pNamespace, pConString).Replace("<<", "{").Replace(">>", "}"), Encoding.ASCII);
                        
        }
        public static void WriteSQLHelper(string pDir)
        {
            if (!Directory.Exists(pDir))
                Directory.CreateDirectory(pDir);
            File.WriteAllText(pDir + "SQLHelper.cs", Properties.Resources.strSQLHelper, Encoding.ASCII);
        }
        public static void WriteInterfaces(string pDir, string pNamespace) 
        {
            if (!Directory.Exists(pDir))
                Directory.CreateDirectory(pDir);

            File.WriteAllText(pDir + "IExecuteDataSet.cs", string.Format(Properties.Resources.strIExecuteDataSet, pNamespace).Replace("<<", "{").Replace(">>", "}"), Encoding.ASCII);
            File.WriteAllText(pDir + "IExecuteXML.cs", string.Format(Properties.Resources.strIExecuteXML, pNamespace).Replace("<<", "{").Replace(">>", "}"), Encoding.ASCII);
            File.WriteAllText(pDir + "IExecuteNonQuery.cs", string.Format(Properties.Resources.strIExecuteNonQuery,pNamespace).Replace("<<", "{").Replace(">>", "}"), Encoding.ASCII);
            File.WriteAllText(pDir + "IExecuteScalar.cs", string.Format(Properties.Resources.strIExecuteScalar, pNamespace).Replace("<<", "{").Replace(">>", "}"), Encoding.ASCII);
            File.WriteAllText(pDir + "IExecuteDataReader.cs", string.Format(Properties.Resources.strIExecuteDataReader, pNamespace).Replace("<<", "{").Replace(">>", "}"), Encoding.ASCII);
        }
        public static void WriteSPClasses(string pDir, string pSPClass, string pSPClassFilename) 
        {
            File.WriteAllText(pDir + pSPClassFilename + ".cs", pSPClass, Encoding.ASCII);
        }
        public static void WriteCSProject(string pDir, string pNamespace, string pCompileIncludes)
        {
            File.WriteAllText(pDir + "\\" + pNamespace + ".csproj", string.Format(Properties.Resources.strCSPROJ, pNamespace, pCompileIncludes), Encoding.ASCII);
        }
    }
}
