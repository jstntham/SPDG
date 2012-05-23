using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SPDG
{
    public class SPGDataHelper : IDisposable
    {
        SqlConnection sqlc;

        private bool ConnectSQL(string pConString)
        {
            try
            {
                sqlc = new SqlConnection(pConString);
                sqlc.Open();
                return true;
            }
            catch 
            {
                return false;
            }

        }
        public SqlDataReader GetStoredProcedureList(string pConString)
        {
            try
            {
                if (ConnectSQL(pConString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select name from sysobjects where type='P' order by name asc";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = sqlc;
                    try
                    {
                        return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    }
                    catch { return null; }
                }
                else { return null; }
            }
            catch (Exception e)
            { throw e; }
        }
        public SqlDataReader GetStoredProcedureParameters(string pConString, string pStoredProcedureName)
        {
            try
            {
                if (ConnectSQL(pConString))
                {
                    SqlCommand cmd = new SqlCommand();

                    StringBuilder sb = new StringBuilder();
                    sb.Append("select parameter_name, data_type, character_maximum_length, parameter_mode from information_schema.parameters where specific_name='" + pStoredProcedureName + "'");

                    cmd.CommandText = sb.ToString();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = sqlc;
                    try
                    {
                        return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    }
                    catch (SqlException sqle)
                    {
                        throw sqle;
                    }
                }
                else { return null; }
            }
            catch (Exception e)
            { throw e; }

        }
        public string GetStoredProcedureContent(string pConString, string pStoredProcedureName)
        {
            try
            {
                if (ConnectSQL(pConString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "exec sp_helptext '" + pStoredProcedureName + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = sqlc;
                    try
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        StringBuilder sb = new StringBuilder();
                        while (dr.Read())
                        {
                            sb.Append(dr["text"].ToString());
                        }
                        return sb.ToString();
                    }
                    catch (SqlException sqle)
                    {
                        throw sqle;
                    }
                }
                else { return null; }
            }
            catch (Exception e)
            { throw e; }

        }
        public void GetStoredProcedureMetadata(string pConString, string pStoredProcedureName, out bool pSkip, out bool pExecuteDataSet, out bool pExecuteDataReader, out bool pExecuteXML, out bool pExecuteNonQuery, out bool pExecuteScalar)
        {
            // check for stored procedure metadata for autopopulation of SP list
            pSkip = false;
            pExecuteDataSet = false;
            pExecuteDataReader = false;
            pExecuteNonQuery = false;
            pExecuteScalar = false;
            pExecuteXML = false;

            string spcontent = this.GetStoredProcedureContent(pConString, pStoredProcedureName);

            Regex re = new Regex(@"\/\*\[SPDG\].+\*\/");
            Match mc = re.Match(spcontent);
            if (mc.Success)
            {
                if (mc.Value != null)
                {
                    if (mc.Value.IndexOf("Skip") > 0) { pSkip = true; }
                    if (mc.Value.IndexOf("ExecuteDataSet") > 0) { pExecuteDataSet = true; }
                    if (mc.Value.IndexOf("ExecuteDataReader") > 0) { pExecuteDataReader = true; }
                    if (mc.Value.IndexOf("ExecuteXML") > 0) { pExecuteXML = true; }
                    if (mc.Value.IndexOf("ExecuteNonQuery") > 0) { pExecuteNonQuery = true; }
                    if (mc.Value.IndexOf("ExecuteScalar") > 0) { pExecuteScalar = true; }
                }
            }

            
        }
        public string GetDotNetDataTypeEquivalent(string pSQLDataType, string pLength)
        {
            switch (pSQLDataType)
            {
                case "bigint": return "Int64"; 
                case "binary": return "Byte[]"; 
                case "bit": return "Boolean"; 
                case "char": return "string"; 
                case "date": return "DateTime"; 
                case "datetime": return "DateTime"; 
                case "decimal": return "Decimal";
                case "varbinary": return "Byte[]"; 
                case "float": return "Double";
                case "image": return "Byte[]"; 
                case "int": return "Int32"; 
                case "money": return "Decimal"; 
                case "nchar": return "string"; 
                case "ntext": return "string"; 
                case "numeric": return "Decimal"; 
                case "nvarchar": return "string"; 
                case "real": return "Single";
                case "rowversion": return "Byte[]"; 
                case "smalldatetime": return "DateTime"; 
                case "smallint": return "Int16"; 
                case "smallmoney": return "Decimal"; 
                case "sql_variant": return "object"; 
                case "text": return "string"; 
                case "time": return "TimeSpan";
                case "timestamp": return "Byte[]"; 
                case "tinyint": return "Byte"; 
                case "uniqueidentifier": return "Guid"; 
                case "varchar": return "string"; 
                case "xml": return "System.Xml.XmlDocument"; 
                default: return "string";
            }



        }

        public static bool TestConString(string pConString)
        {
            try
            {
                SqlConnection sqlc = new SqlConnection(pConString);
                sqlc.Open();
                sqlc.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Dispose()
        {
            try
            {
                sqlc.Close();
                sqlc = null;
            }
            catch { }
        }
    }
}
