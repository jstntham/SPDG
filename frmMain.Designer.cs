namespace SPDG
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tConString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tNamespace = new System.Windows.Forms.TextBox();
            this.lStoredProcedure = new System.Windows.Forms.TextBox();
            this.dgSP = new System.Windows.Forms.DataGridView();
            this.spname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skip = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ExecuteDataSet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ExecuteDataReader = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ExecuteXML = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ExecuteNonQuery = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ExecuteScalar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.syncToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.writeClassToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.quitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgSPParams = new System.Windows.Forms.DataGridView();
            this.ParameterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SQLDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DotNetDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParameterMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lClass = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bSynchronize = new System.Windows.Forms.Button();
            this.bWriteClasses = new System.Windows.Forms.Button();
            this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.tDefaultProjectDir = new System.Windows.Forms.TextBox();
            this.bWriteLoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSP)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSPParams)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tConString
            // 
            this.tConString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tConString.Location = new System.Drawing.Point(121, 30);
            this.tConString.Name = "tConString";
            this.tConString.Size = new System.Drawing.Size(1008, 23);
            this.tConString.TabIndex = 0;
            this.tConString.Text = "[Enter your connection string here]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection String";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Namespace";
            // 
            // tNamespace
            // 
            this.tNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tNamespace.Location = new System.Drawing.Point(121, 59);
            this.tNamespace.Name = "tNamespace";
            this.tNamespace.Size = new System.Drawing.Size(1008, 23);
            this.tNamespace.TabIndex = 11;
            this.tNamespace.Text = "[Enter your namespace here]";
            // 
            // lStoredProcedure
            // 
            this.lStoredProcedure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lStoredProcedure.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStoredProcedure.Location = new System.Drawing.Point(3, 3);
            this.lStoredProcedure.Multiline = true;
            this.lStoredProcedure.Name = "lStoredProcedure";
            this.lStoredProcedure.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lStoredProcedure.Size = new System.Drawing.Size(566, 525);
            this.lStoredProcedure.TabIndex = 13;
            // 
            // dgSP
            // 
            this.dgSP.AllowUserToAddRows = false;
            this.dgSP.AllowUserToDeleteRows = false;
            this.dgSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.spname,
            this.Skip,
            this.ExecuteDataSet,
            this.ExecuteDataReader,
            this.ExecuteXML,
            this.ExecuteNonQuery,
            this.ExecuteScalar});
            this.dgSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSP.Location = new System.Drawing.Point(0, 0);
            this.dgSP.Name = "dgSP";
            this.dgSP.Size = new System.Drawing.Size(685, 559);
            this.dgSP.TabIndex = 14;
            this.dgSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSP_CellClick);
            this.dgSP.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSP_CellEndEdit);
            this.dgSP.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSP_CellEnter);
            this.dgSP.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgSP_RowsAdded);
            // 
            // spname
            // 
            this.spname.HeaderText = "Stored Procedure Name";
            this.spname.Name = "spname";
            this.spname.Width = 200;
            // 
            // Skip
            // 
            this.Skip.HeaderText = "Skip";
            this.Skip.Name = "Skip";
            this.Skip.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Skip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Skip.Width = 70;
            // 
            // ExecuteDataSet
            // 
            this.ExecuteDataSet.HeaderText = "Execute DataSet";
            this.ExecuteDataSet.Name = "ExecuteDataSet";
            this.ExecuteDataSet.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ExecuteDataSet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ExecuteDataSet.Width = 70;
            // 
            // ExecuteDataReader
            // 
            this.ExecuteDataReader.HeaderText = "Execute DataReader";
            this.ExecuteDataReader.Name = "ExecuteDataReader";
            this.ExecuteDataReader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ExecuteDataReader.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ExecuteDataReader.Width = 70;
            // 
            // ExecuteXML
            // 
            this.ExecuteXML.HeaderText = "Execute XML";
            this.ExecuteXML.Name = "ExecuteXML";
            this.ExecuteXML.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ExecuteXML.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ExecuteXML.Width = 70;
            // 
            // ExecuteNonQuery
            // 
            this.ExecuteNonQuery.HeaderText = "Execute NonQuery";
            this.ExecuteNonQuery.Name = "ExecuteNonQuery";
            this.ExecuteNonQuery.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ExecuteNonQuery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ExecuteNonQuery.Width = 70;
            // 
            // ExecuteScalar
            // 
            this.ExecuteScalar.HeaderText = "Execute Scalar";
            this.ExecuteScalar.Name = "ExecuteScalar";
            this.ExecuteScalar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ExecuteScalar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ExecuteScalar.Width = 70;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.syncToolStripButton,
            this.writeClassToolStripButton,
            this.quitToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1270, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // syncToolStripButton
            // 
            this.syncToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.syncToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("syncToolStripButton.Image")));
            this.syncToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.syncToolStripButton.Name = "syncToolStripButton";
            this.syncToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.syncToolStripButton.Text = "Synchronize";
            this.syncToolStripButton.Click += new System.EventHandler(this.syncToolStripButton_Click);
            // 
            // writeClassToolStripButton
            // 
            this.writeClassToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.writeClassToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("writeClassToolStripButton.Image")));
            this.writeClassToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.writeClassToolStripButton.Name = "writeClassToolStripButton";
            this.writeClassToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.writeClassToolStripButton.Text = "Write Classes";
            this.writeClassToolStripButton.Click += new System.EventHandler(this.writeClassToolStripButton_Click);
            // 
            // quitToolStripButton
            // 
            this.quitToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.quitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.quitToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("quitToolStripButton.Image")));
            this.quitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.quitToolStripButton.Name = "quitToolStripButton";
            this.quitToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.quitToolStripButton.Text = "Quit";
            this.quitToolStripButton.Click += new System.EventHandler(this.quitToolStripButton_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.DefaultExt = "spg";
            this.dlgOpen.Filter = "SPG files (*.spg)|*.spg";
            // 
            // dlgSave
            // 
            this.dlgSave.DefaultExt = "spg";
            this.dlgSave.Filter = "SPG files (*.spg)|*.spg";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbStatus,
            this.sbProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 681);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1270, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sbStatus
            // 
            this.sbStatus.Name = "sbStatus";
            this.sbStatus.Size = new System.Drawing.Size(1153, 17);
            this.sbStatus.Spring = true;
            this.sbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sbProgress
            // 
            this.sbProgress.Name = "sbProgress";
            this.sbProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(580, 559);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgSPParams);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(572, 531);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Stored Procedure Parameters";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgSPParams
            // 
            this.dgSPParams.AllowUserToAddRows = false;
            this.dgSPParams.AllowUserToDeleteRows = false;
            this.dgSPParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSPParams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParameterName,
            this.SQLDataType,
            this.DataLength,
            this.DotNetDataType,
            this.ParameterMode});
            this.dgSPParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSPParams.Location = new System.Drawing.Point(3, 3);
            this.dgSPParams.Name = "dgSPParams";
            this.dgSPParams.ReadOnly = true;
            this.dgSPParams.Size = new System.Drawing.Size(566, 525);
            this.dgSPParams.TabIndex = 0;
            // 
            // ParameterName
            // 
            this.ParameterName.HeaderText = "Parameter Name";
            this.ParameterName.Name = "ParameterName";
            this.ParameterName.ReadOnly = true;
            // 
            // SQLDataType
            // 
            this.SQLDataType.HeaderText = "SQL DataType";
            this.SQLDataType.Name = "SQLDataType";
            this.SQLDataType.ReadOnly = true;
            // 
            // DataLength
            // 
            this.DataLength.HeaderText = "Data Length";
            this.DataLength.Name = "DataLength";
            this.DataLength.ReadOnly = true;
            this.DataLength.Width = 50;
            // 
            // DotNetDataType
            // 
            this.DotNetDataType.HeaderText = ".Net DataType";
            this.DotNetDataType.Name = "DotNetDataType";
            this.DotNetDataType.ReadOnly = true;
            // 
            // ParameterMode
            // 
            this.ParameterMode.HeaderText = "Param Mode";
            this.ParameterMode.Name = "ParameterMode";
            this.ParameterMode.ReadOnly = true;
            this.ParameterMode.Width = 50;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lStoredProcedure);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(572, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stored Procedure";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lClass);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(572, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "C# SP Class";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lClass
            // 
            this.lClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lClass.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClass.Location = new System.Drawing.Point(3, 3);
            this.lClass.Multiline = true;
            this.lClass.Name = "lClass";
            this.lClass.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lClass.Size = new System.Drawing.Size(566, 525);
            this.lClass.TabIndex = 14;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 122);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgSP);
            this.splitContainer1.Panel1MinSize = 685;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1269, 559);
            this.splitContainer1.SplitterDistance = 685;
            this.splitContainer1.TabIndex = 18;
            // 
            // bSynchronize
            // 
            this.bSynchronize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSynchronize.Image = ((System.Drawing.Image)(resources.GetObject("bSynchronize.Image")));
            this.bSynchronize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSynchronize.Location = new System.Drawing.Point(1135, 30);
            this.bSynchronize.Name = "bSynchronize";
            this.bSynchronize.Size = new System.Drawing.Size(127, 23);
            this.bSynchronize.TabIndex = 19;
            this.bSynchronize.Text = "Synchronize";
            this.bSynchronize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bSynchronize.UseVisualStyleBackColor = true;
            this.bSynchronize.Click += new System.EventHandler(this.bSynchronize_Click);
            // 
            // bWriteClasses
            // 
            this.bWriteClasses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bWriteClasses.Image = ((System.Drawing.Image)(resources.GetObject("bWriteClasses.Image")));
            this.bWriteClasses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bWriteClasses.Location = new System.Drawing.Point(1135, 59);
            this.bWriteClasses.Name = "bWriteClasses";
            this.bWriteClasses.Size = new System.Drawing.Size(127, 52);
            this.bWriteClasses.TabIndex = 20;
            this.bWriteClasses.Text = "Write Classes";
            this.bWriteClasses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bWriteClasses.UseVisualStyleBackColor = true;
            this.bWriteClasses.Click += new System.EventHandler(this.bWriteClasses_Click);
            // 
            // dlgFolder
            // 
            this.dlgFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Default Project Dir";
            // 
            // tDefaultProjectDir
            // 
            this.tDefaultProjectDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tDefaultProjectDir.Location = new System.Drawing.Point(121, 88);
            this.tDefaultProjectDir.Name = "tDefaultProjectDir";
            this.tDefaultProjectDir.Size = new System.Drawing.Size(976, 23);
            this.tDefaultProjectDir.TabIndex = 21;
            this.tDefaultProjectDir.Text = "[This is where the classes will be generated into]";
            // 
            // bWriteLoc
            // 
            this.bWriteLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bWriteLoc.Location = new System.Drawing.Point(1103, 88);
            this.bWriteLoc.Name = "bWriteLoc";
            this.bWriteLoc.Size = new System.Drawing.Size(26, 23);
            this.bWriteLoc.TabIndex = 23;
            this.bWriteLoc.Text = "...";
            this.bWriteLoc.UseVisualStyleBackColor = true;
            this.bWriteLoc.Click += new System.EventHandler(this.bWriteLoc_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 703);
            this.Controls.Add(this.bWriteLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tDefaultProjectDir);
            this.Controls.Add(this.bWriteClasses);
            this.Controls.Add(this.bSynchronize);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tNamespace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tConString);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Stored Procedure Data Gateway Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgSP)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSPParams)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tConString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tNamespace;
        private System.Windows.Forms.TextBox lStoredProcedure;
        private System.Windows.Forms.DataGridView dgSP;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sbStatus;
        private System.Windows.Forms.ToolStripProgressBar sbProgress;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox lClass;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button bSynchronize;
        private System.Windows.Forms.Button bWriteClasses;
        private System.Windows.Forms.ToolStripButton syncToolStripButton;
        private System.Windows.Forms.ToolStripButton writeClassToolStripButton;
        private System.Windows.Forms.DataGridView dgSPParams;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SQLDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn DotNetDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterMode;
        private System.Windows.Forms.ToolStripButton quitToolStripButton;
        private System.Windows.Forms.FolderBrowserDialog dlgFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn spname;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Skip;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExecuteDataSet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExecuteDataReader;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExecuteXML;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExecuteNonQuery;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExecuteScalar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tDefaultProjectDir;
        private System.Windows.Forms.Button bWriteLoc;
    }
}

