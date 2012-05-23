using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Resources;
using System.Data.SqlClient;
using System.Xml;

namespace SPDG
{
    public partial class frmMain : Form
    {
        bool isExistingProject = false;

        public frmMain()
        {
            InitializeComponent();
            string[] cmdLine = Environment.GetCommandLineArgs();
            if (cmdLine.Length == 2)
            {
                this.OpenSPGFile( cmdLine[1].ToString());
            }
        }

        private void bSynchronize_Click(object sender, EventArgs e)
        {
            this.SynchronizeSP();
        }
        private void bWriteClasses_Click(object sender, EventArgs e)
        {
            WriteClasses();
        }
        private void bWriteLoc_Click(object sender, EventArgs e)
        {
            dlgFolder.ShowDialog();
            if (dlgFolder.SelectedPath != "" && Directory.Exists(dlgFolder.SelectedPath))
            {
                tDefaultProjectDir.Text = dlgFolder.SelectedPath;
            }
        }


        private void dgSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    SPGDataHelper spg = new SPGDataHelper();
                    dgSPParams.Rows.Clear();

                    lStoredProcedure.Text = spg.GetStoredProcedureContent(tConString.Text, dgSP.Rows[e.RowIndex].Cells[0].Value.ToString());
                    lClass.Text = SPGHelper.GenerateClass(tConString.Text, tNamespace.Text,
                        dgSP.Rows[e.RowIndex].Cells["SPName"].Value.ToString(),
                        Convert.ToBoolean(dgSP.Rows[e.RowIndex].Cells["Skip"].Value.ToString()),
                        Convert.ToBoolean(dgSP.Rows[e.RowIndex].Cells["ExecuteDataSet"].Value.ToString()),
                        Convert.ToBoolean(dgSP.Rows[e.RowIndex].Cells["ExecuteDataReader"].Value.ToString()),
                        Convert.ToBoolean(dgSP.Rows[e.RowIndex].Cells["ExecuteXML"].Value.ToString()),
                        Convert.ToBoolean(dgSP.Rows[e.RowIndex].Cells["ExecuteNonQuery"].Value.ToString()),
                        Convert.ToBoolean(dgSP.Rows[e.RowIndex].Cells["ExecuteScalar"].Value.ToString()),
                        dgSPParams).ToString();
                }
                catch (Exception ex)
                {
                    sbStatus.Text = ex.Message;
                }
            }
        }
        private void dgSP_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgSP_CellClick(sender, e);
        }
        private void dgSP_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            SetRowColor(e.RowIndex);
        }
        private void dgSP_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                SetRowColor(e.RowIndex);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.SaveSPGFile();
        }
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            dlgOpen.ShowDialog();
            if (dlgOpen.FileName != "")
            {
                this.OpenSPGFile(dlgOpen.FileName);
            }
        }
        private void syncToolStripButton_Click(object sender, EventArgs e)
        {
            this.SynchronizeSP();
        }
        private void quitToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void writeClassToolStripButton_Click(object sender, EventArgs e)
        {
            WriteClasses();
        }

        private void SetRowColor(int rowindex)
        {
            try
            {
                DataGridViewCellStyle sSkip = new DataGridViewCellStyle();
                sSkip.BackColor = Color.LightGray;
                sSkip.ForeColor = Color.Gray;
                DataGridViewCellStyle sExecuteDataSet = new DataGridViewCellStyle();
                sExecuteDataSet.BackColor = Color.LightBlue;
                sExecuteDataSet.ForeColor = Color.Black;
                DataGridViewCellStyle sExecuteNonQuery = new DataGridViewCellStyle();
                sExecuteNonQuery.BackColor = Color.LightSalmon;
                sExecuteNonQuery.ForeColor = Color.Black;
                DataGridViewCellStyle sExecuteScalar = new DataGridViewCellStyle();
                sExecuteScalar.BackColor = Color.LightGreen;
                sExecuteScalar.ForeColor = Color.Black;
                DataGridViewCellStyle sClear = new DataGridViewCellStyle();
                sClear.BackColor = Color.White;
                sClear.ForeColor = Color.Black;


                if (Convert.ToBoolean(dgSP.Rows[rowindex].Cells["Skip"].Value) == true)
                {
                    dgSP.Rows[rowindex].DefaultCellStyle = sSkip;
                }
                else if (Convert.ToBoolean(dgSP.Rows[rowindex].Cells["ExecuteDataSet"].Value) == true || Convert.ToBoolean(dgSP.Rows[rowindex].Cells["ExecuteXML"].Value) == true)
                {
                    dgSP.Rows[rowindex].DefaultCellStyle = sExecuteDataSet;
                }
                else if (Convert.ToBoolean(dgSP.Rows[rowindex].Cells["ExecuteScalar"].Value) == true)
                {
                    dgSP.Rows[rowindex].DefaultCellStyle = sExecuteScalar;
                }
                else if (Convert.ToBoolean(dgSP.Rows[rowindex].Cells["ExecuteNonQuery"].Value) == true)
                {
                    dgSP.Rows[rowindex].DefaultCellStyle = sExecuteNonQuery;
                }
                else
                {
                    dgSP.Rows[rowindex].DefaultCellStyle = sClear;
                }
            }
            catch (Exception ex)
            {
                sbStatus.Text = ex.Message;
            }

        }
        private void SynchronizeSP()
        {
            if (!SPGDataHelper.TestConString(tConString.Text))
            {
                sbStatus.Text = "Connection String Error ...";
            }
            else
            {
                try
                {
                    bool bMerge = false;
                    bool bReplace = false;
                    SPGDataHelper spg = new SPGDataHelper();

                    if (isExistingProject)
                    {
                        DialogResult sr = MessageBox.Show("Synchronizing Stored Procedures will remove current listings. Click Yes to replace, No to merge or Cancel action", "", MessageBoxButtons.YesNoCancel);
                        if (sr == DialogResult.Yes)
                        {
                            bReplace = true;
                        }
                        else if (sr == DialogResult.No)
                        {
                            bMerge = true;
                        }
                    }
                    else
                    {
                        bReplace = true;
                    }

                    if (bReplace || bMerge)
                    {
                        try
                        {
                            if (bReplace)
                            {
                                dgSP.Rows.Clear();
                            }
                            SqlDataReader dr = spg.GetStoredProcedureList(tConString.Text);
                            while (dr.Read())
                            {
                                bool pSkip = false;
                                bool pExecuteDataSet = false;
                                bool pExecuteDataReader = false;
                                bool pExecuteNonQuery = false;
                                bool pExecuteScalar = false;
                                bool pExecuteXML = false;
                                spg.GetStoredProcedureMetadata(tConString.Text, dr["name"].ToString(), out pSkip, out pExecuteDataSet, out pExecuteDataReader, out pExecuteXML, out pExecuteNonQuery, out pExecuteScalar);
                                
                                if (bMerge)
                                {
                                    bool bExists = false;
                                    foreach (DataGridViewRow dvgr in dgSP.Rows)
                                    {
                                        if (dvgr.Cells[0].Value.ToString() == dr["name"].ToString())
                                        {
                                            bExists = true;
                                            if (bExists && (pSkip || pExecuteDataSet || pExecuteDataReader || pExecuteXML || pExecuteNonQuery || pExecuteScalar))
                                            {
                                                dvgr.Cells["Skip"].Value = pSkip;
                                                dvgr.Cells["ExecuteDataSet"].Value = pExecuteDataSet;
                                                dvgr.Cells["ExecuteDataReader"].Value = pExecuteDataReader;
                                                dvgr.Cells["ExecuteXML"].Value = pExecuteXML;
                                                dvgr.Cells["ExecuteNonQuery"].Value = pExecuteNonQuery;
                                                dvgr.Cells["ExecuteScalar"].Value = pExecuteScalar;
                                            }
                                            break;
                                        }
                                    }
                                    if (!bExists)
                                    {
                                        dgSP.Rows.Add(dr["name"].ToString(), pSkip, pExecuteDataSet, pExecuteDataReader, pExecuteXML, pExecuteNonQuery, pExecuteScalar);
                                        sbStatus.Text = "Stored Procedure [" + dr["name"].ToString() + "] added";
                                        bExists = false;
                                    }
                                }
                                else
                                {
                                    dgSP.Rows.Add(dr["name"].ToString(), pSkip, pExecuteDataSet, pExecuteDataReader, pExecuteXML, pExecuteNonQuery, pExecuteScalar);
                                    sbStatus.Text = "Stored Procedure [" + dr["name"].ToString() + "] added";
                                }
                            }
                            isExistingProject = true;
                        }
                        catch (SqlException sqle)
                        {
                            sbStatus.Text = sqle.Message;
                        }
                    }
                }
                catch (Exception ex)
                {
                    sbStatus.Text = ex.Message;
                }
            }
        }
        private void WriteClasses()
        {
            if (!SPGDataHelper.TestConString(tConString.Text))
            {
                sbStatus.Text = "Connection String Error ...";
            }
            else
            {

                try
                {
                    string dir = tDefaultProjectDir.Text;
                    if (Directory.Exists(dir))
                    {
                        DialogResult dresult = MessageBox.Show("Warning: all files within directory " + dir + " will be deleted.\nPress [OK] to continue, [Cancel] to abort.", "", MessageBoxButtons.OKCancel);
                        if (dresult == System.Windows.Forms.DialogResult.OK)
                        {

                            sbStatus.Text = "Creating helpers directory ...";
                            Directory.CreateDirectory(dir + @"\helpers\");
                            sbStatus.Text = "Creating interfaces directory ...";
                            Directory.CreateDirectory(dir + @"\interfaces\");
                            sbStatus.Text = "Creating sps directory ...";
                            Directory.CreateDirectory(dir + @"\sps\");

                            try
                            {
                                sbStatus.Text = "Creating interfaces ...";
                                SPGHelper.WriteInterfaces(dir + @"\interfaces\", tNamespace.Text);
                                sbStatus.Text = "Creating base class ...";
                                SPGHelper.WriteBaseClass(dir + @"\sps\", tNamespace.Text, tConString.Text);
                                sbStatus.Text = "Creating SQL Helper ...";
                                SPGHelper.WriteSQLHelper(dir + @"\helpers\");

                                SPCompileIncludes compileIncludes = new SPCompileIncludes();
                                for (int i = 0; i < dgSP.Rows.Count; i++)
                                {
                                    SPClass spc = SPGHelper.GenerateClass(tConString.Text, tNamespace.Text,
                                        dgSP.Rows[i].Cells["SPName"].Value.ToString(),
                                        Convert.ToBoolean(dgSP.Rows[i].Cells["Skip"].Value.ToString()),
                                        Convert.ToBoolean(dgSP.Rows[i].Cells["ExecuteDataSet"].Value.ToString()),
                                        Convert.ToBoolean(dgSP.Rows[i].Cells["ExecuteDataReader"].Value.ToString()),
                                        Convert.ToBoolean(dgSP.Rows[i].Cells["ExecuteXML"].Value.ToString()),
                                        Convert.ToBoolean(dgSP.Rows[i].Cells["ExecuteNonQuery"].Value.ToString()),
                                        Convert.ToBoolean(dgSP.Rows[i].Cells["ExecuteScalar"].Value.ToString()),
                                        null);
                                    if (!Convert.ToBoolean(dgSP.Rows[i].Cells["Skip"].Value.ToString()))
                                    {
                                        sbStatus.Text = "Creating class " + dgSP.Rows[i].Cells["SPName"].Value.ToString() + " ...";
                                        SPGHelper.WriteSPClasses(dir + @"\sps\", spc.ToString(), dgSP.Rows[i].Cells["SPName"].Value.ToString());
                                        compileIncludes.Add(new SPCompileInclude(dgSP.Rows[i].Cells["SPName"].Value.ToString() + ".cs"));
                                    }
                                }

                                sbStatus.Text = "Creating CS Project ...";
                                SPGHelper.WriteCSProject(dir, tNamespace.Text, compileIncludes.ToString());
                                sbStatus.Text = "SPGData Project Completed Successfully ...";

                            }
                            catch (Exception ex)
                            {
                                sbStatus.Text = ex.Message;
                            }
                        }
                    }
                    else
                    {
                        sbStatus.Text = "Invalid Default Project Directory. Please select a destination folder before continuing.";
                    }
                }
                catch (Exception ex)
                {
                    sbStatus.Text = ex.Message;
                }
            }
        }
        private void OpenSPGFile(string filename)
        {
            try
            {
                ClearAll();
                try
                {
                    FileStream fs = File.OpenRead(filename);
                    XmlTextReader xmltr = new XmlTextReader(fs);

                    while (xmltr.Read())
                    {
                        switch (xmltr.Name)
                        {
                            case "Settings":
                                tConString.Text = xmltr.GetAttribute("connectionString");
                                tNamespace.Text = xmltr.GetAttribute("namespace");
                                if (xmltr.GetAttribute("defaultprojectdir") != null)
                                    tDefaultProjectDir.Text = xmltr.GetAttribute("defaultprojectdir");
                                break;
                            case "StoredProcedure":
                                //for backward compatibility
                                if (xmltr.GetAttribute("ExecuteDataReader") != null)
                                {
                                    dgSP.Rows.Add(xmltr.GetAttribute("SPName").ToString(), xmltr.GetAttribute("skip").ToString(), xmltr.GetAttribute("ExecuteDataSet").ToString(), xmltr.GetAttribute("ExecuteDataReader").ToString(), xmltr.GetAttribute("ExecuteXML").ToString(), xmltr.GetAttribute("ExecuteNonQuery").ToString(), xmltr.GetAttribute("ExecuteScalar").ToString());
                                }
                                else
                                {
                                    dgSP.Rows.Add(xmltr.GetAttribute("SPName").ToString(), xmltr.GetAttribute("skip").ToString(), xmltr.GetAttribute("ExecuteDataSet").ToString(), "False", xmltr.GetAttribute("ExecuteXML").ToString(), xmltr.GetAttribute("ExecuteNonQuery").ToString(), xmltr.GetAttribute("ExecuteScalar").ToString());
                                }
                                break;
                        }
                    }
                    xmltr.Close();
                    fs.Close();
                    isExistingProject = true;
                    sbStatus.Text = dlgOpen.FileName + " has been opened successfully";

                }
                catch (Exception ex)
                {
                    sbStatus.Text = "Invalid SPG file : " + ex.Message;
                }
            }
            catch (Exception ex)
            {
                sbStatus.Text = ex.Message;
            }
        }
        private void SaveSPGFile()
        {
            if (!SPGDataHelper.TestConString(tConString.Text) || dgSP.Rows.Count <= 0)
            {
                sbStatus.Text = "Nothing to save ...";
            }
            else
            {
                try
                {
                    dlgSave.ShowDialog();

                    if (dlgSave.FileName != "")
                    {
                        XmlWriterSettings xsettings = new XmlWriterSettings();
                        xsettings.Indent = true;
                        FileStream fs = new FileStream(dlgSave.FileName, FileMode.Create);
                        XmlWriter xw = XmlWriter.Create(fs);
                        xw.WriteStartDocument();

                        xw.WriteStartElement("SPG");
                        xw.WriteStartElement("Settings");
                        xw.WriteStartAttribute("connectionString");
                        xw.WriteString(tConString.Text);
                        xw.WriteEndAttribute();
                        xw.WriteStartAttribute("namespace");
                        xw.WriteString(tNamespace.Text);
                        xw.WriteEndAttribute();
                        xw.WriteStartAttribute("defaultprojectdir");
                        xw.WriteString(tDefaultProjectDir.Text);
                        xw.WriteEndAttribute();
                        xw.WriteEndElement();

                        xw.WriteStartElement("Data");
                        foreach (DataGridViewRow dgr in dgSP.Rows)
                        {
                            xw.WriteStartElement("StoredProcedure");

                            xw.WriteStartAttribute("SPName");
                            xw.WriteString(dgr.Cells[0].Value.ToString());
                            xw.WriteEndAttribute();

                            xw.WriteStartAttribute("skip");
                            xw.WriteString(dgr.Cells[1].FormattedValue.ToString());
                            xw.WriteEndAttribute();

                            xw.WriteStartAttribute("ExecuteDataSet");
                            xw.WriteString(dgr.Cells["ExecuteDataSet"].FormattedValue.ToString());
                            xw.WriteEndAttribute();

                            xw.WriteStartAttribute("ExecuteDataReader");
                            xw.WriteString(dgr.Cells["ExecuteDataReader"].FormattedValue.ToString());
                            xw.WriteEndAttribute();

                            xw.WriteStartAttribute("ExecuteXML");
                            xw.WriteString(dgr.Cells["ExecuteXML"].FormattedValue.ToString());
                            xw.WriteEndAttribute();

                            xw.WriteStartAttribute("ExecuteNonQuery");
                            xw.WriteString(dgr.Cells["ExecuteNonQuery"].FormattedValue.ToString());
                            xw.WriteEndAttribute();

                            xw.WriteStartAttribute("ExecuteScalar");
                            xw.WriteString(dgr.Cells["ExecuteScalar"].FormattedValue.ToString());
                            xw.WriteEndAttribute();

                            xw.WriteEndElement();
                        }
                        xw.WriteEndElement();
                        xw.WriteEndElement();

                        xw.WriteEndDocument();
                        xw.Flush();

                        fs.Close();
                        sbStatus.Text = dlgSave.FileName + " has been saved successfully";
                        isExistingProject = true;
                    }
                }
                catch (Exception ex)
                {
                    sbStatus.Text = ex.Message;
                }
            }

        }

        private void ClearAll()
        {
            tConString.Text = "";
            tNamespace.Text = "";
            dgSP.Rows.Clear();
            dgSPParams.Rows.Clear();
            lStoredProcedure.Text = "";
            isExistingProject = false;
        }



    }
}
