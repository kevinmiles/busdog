﻿namespace busdog
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDevices = new System.Windows.Forms.TabPage();
            this.cbAutoTrace = new System.Windows.Forms.CheckBox();
            this.tvDevices = new System.Windows.Forms.TreeView();
            this.tabTrace = new System.Windows.Forms.TabPage();
            this.tsTrace = new System.Windows.Forms.ToolStrip();
            this.btnStartTraces = new System.Windows.Forms.ToolStripButton();
            this.btnClearTraces = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lbMaxTraces = new System.Windows.Forms.ToolStripLabel();
            this.cbMaxTraces = new System.Windows.Forms.ToolStripComboBox();
            this.btnCopyToClipboard = new System.Windows.Forms.ToolStripButton();
            this.btnCopySelectedToClipboard = new System.Windows.Forms.ToolStripButton();
            this.btnSaveToFile = new System.Windows.Forms.ToolStripButton();
            this.tabSetup = new System.Windows.Forms.TabPage();
            this.gbTraceList = new System.Windows.Forms.GroupBox();
            this.cbAscii = new System.Windows.Forms.CheckBox();
            this.cbHex = new System.Windows.Forms.CheckBox();
            this.cbLength = new System.Windows.Forms.CheckBox();
            this.cbTime = new System.Windows.Forms.CheckBox();
            this.cbType = new System.Windows.Forms.CheckBox();
            this.cbId = new System.Windows.Forms.CheckBox();
            this.gbFilterDriver = new System.Windows.Forms.GroupBox();
            this.btnReinstall = new System.Windows.Forms.Button();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.tmrDeviceChange = new System.Windows.Forms.Timer(this.components);
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lvTraces = new busdog.BufferedListView();
            this.chId = new System.Windows.Forms.ColumnHeader();
            this.chType = new System.Windows.Forms.ColumnHeader();
            this.chTime = new System.Windows.Forms.ColumnHeader();
            this.chLength = new System.Windows.Forms.ColumnHeader();
            this.chHex = new System.Windows.Forms.ColumnHeader();
            this.chAscii = new System.Windows.Forms.ColumnHeader();
            this.filterControl = new busdog.FilterControl();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl.SuspendLayout();
            this.tabDevices.SuspendLayout();
            this.tabTrace.SuspendLayout();
            this.tsTrace.SuspendLayout();
            this.tabSetup.SuspendLayout();
            this.gbTraceList.SuspendLayout();
            this.gbFilterDriver.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDevices);
            this.tabControl.Controls.Add(this.tabTrace);
            this.tabControl.Controls.Add(this.tabSetup);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImageList = this.imageList1;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(385, 386);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabDevices
            // 
            this.tabDevices.Controls.Add(this.cbAutoTrace);
            this.tabDevices.Controls.Add(this.tvDevices);
            this.tabDevices.ImageIndex = 0;
            this.tabDevices.Location = new System.Drawing.Point(4, 23);
            this.tabDevices.Name = "tabDevices";
            this.tabDevices.Padding = new System.Windows.Forms.Padding(3);
            this.tabDevices.Size = new System.Drawing.Size(377, 359);
            this.tabDevices.TabIndex = 0;
            this.tabDevices.Text = "Devices";
            this.tabDevices.UseVisualStyleBackColor = true;
            // 
            // cbAutoTrace
            // 
            this.cbAutoTrace.AutoSize = true;
            this.cbAutoTrace.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbAutoTrace.Location = new System.Drawing.Point(3, 339);
            this.cbAutoTrace.Name = "cbAutoTrace";
            this.cbAutoTrace.Size = new System.Drawing.Size(371, 17);
            this.cbAutoTrace.TabIndex = 2;
            this.cbAutoTrace.Text = "Automatically trace new devices";
            this.cbAutoTrace.UseVisualStyleBackColor = true;
            this.cbAutoTrace.CheckedChanged += new System.EventHandler(this.cbAutoTrace_CheckedChanged);
            // 
            // tvDevices
            // 
            this.tvDevices.CheckBoxes = true;
            this.tvDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDevices.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvDevices.Location = new System.Drawing.Point(3, 3);
            this.tvDevices.Name = "tvDevices";
            this.tvDevices.ShowNodeToolTips = true;
            this.tvDevices.Size = new System.Drawing.Size(371, 353);
            this.tvDevices.TabIndex = 1;
            this.tvDevices.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvDevices_AfterCheck);
            // 
            // tabTrace
            // 
            this.tabTrace.Controls.Add(this.lvTraces);
            this.tabTrace.Controls.Add(this.tsTrace);
            this.tabTrace.ImageIndex = 1;
            this.tabTrace.Location = new System.Drawing.Point(4, 23);
            this.tabTrace.Name = "tabTrace";
            this.tabTrace.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrace.Size = new System.Drawing.Size(377, 359);
            this.tabTrace.TabIndex = 1;
            this.tabTrace.Text = "Trace";
            this.tabTrace.UseVisualStyleBackColor = true;
            // 
            // tsTrace
            // 
            this.tsTrace.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsTrace.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStartTraces,
            this.btnClearTraces,
            this.toolStripSeparator1,
            this.lbMaxTraces,
            this.cbMaxTraces,
            this.toolStripSeparator2,
            this.btnCopyToClipboard,
            this.btnCopySelectedToClipboard,
            this.btnSaveToFile});
            this.tsTrace.Location = new System.Drawing.Point(3, 3);
            this.tsTrace.Name = "tsTrace";
            this.tsTrace.Size = new System.Drawing.Size(371, 25);
            this.tsTrace.TabIndex = 4;
            this.tsTrace.Text = "tsTrace";
            // 
            // btnStartTraces
            // 
            this.btnStartTraces.CheckOnClick = true;
            this.btnStartTraces.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStartTraces.Image = ((System.Drawing.Image)(resources.GetObject("btnStartTraces.Image")));
            this.btnStartTraces.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStartTraces.Name = "btnStartTraces";
            this.btnStartTraces.Size = new System.Drawing.Size(23, 22);
            this.btnStartTraces.Text = "Start";
            this.btnStartTraces.Click += new System.EventHandler(this.btnStartTraces_Click);
            // 
            // btnClearTraces
            // 
            this.btnClearTraces.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClearTraces.Image = ((System.Drawing.Image)(resources.GetObject("btnClearTraces.Image")));
            this.btnClearTraces.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearTraces.Name = "btnClearTraces";
            this.btnClearTraces.Size = new System.Drawing.Size(23, 22);
            this.btnClearTraces.Text = "Clear";
            this.btnClearTraces.Click += new System.EventHandler(this.btnClearTraces_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lbMaxTraces
            // 
            this.lbMaxTraces.AutoToolTip = true;
            this.lbMaxTraces.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lbMaxTraces.Image = ((System.Drawing.Image)(resources.GetObject("lbMaxTraces.Image")));
            this.lbMaxTraces.Name = "lbMaxTraces";
            this.lbMaxTraces.Size = new System.Drawing.Size(16, 22);
            this.lbMaxTraces.Text = "Max Traces";
            // 
            // cbMaxTraces
            // 
            this.cbMaxTraces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaxTraces.Items.AddRange(new object[] {
            "Unlimited",
            "100",
            "1000",
            "10000"});
            this.cbMaxTraces.Name = "cbMaxTraces";
            this.cbMaxTraces.Size = new System.Drawing.Size(119, 25);
            this.cbMaxTraces.SelectedIndexChanged += new System.EventHandler(this.cbMaxTraces_SelectedIndexChanged);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCopyToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyToClipboard.Image")));
            this.btnCopyToClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(23, 22);
            this.btnCopyToClipboard.Text = "Copy Traces";
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnCopySelectedToClipboard
            // 
            this.btnCopySelectedToClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCopySelectedToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("btnCopySelectedToClipboard.Image")));
            this.btnCopySelectedToClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopySelectedToClipboard.Name = "btnCopySelectedToClipboard";
            this.btnCopySelectedToClipboard.Size = new System.Drawing.Size(23, 22);
            this.btnCopySelectedToClipboard.Text = "Copy Selected Traces";
            this.btnCopySelectedToClipboard.Click += new System.EventHandler(this.btnCopySelectedToClipboard_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveToFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveToFile.Image")));
            this.btnSaveToFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(23, 22);
            this.btnSaveToFile.Text = "Save Traces to File";
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // tabSetup
            // 
            this.tabSetup.Controls.Add(this.filterControl);
            this.tabSetup.Controls.Add(this.gbTraceList);
            this.tabSetup.Controls.Add(this.gbFilterDriver);
            this.tabSetup.ImageIndex = 2;
            this.tabSetup.Location = new System.Drawing.Point(4, 23);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.Size = new System.Drawing.Size(377, 359);
            this.tabSetup.TabIndex = 2;
            this.tabSetup.Text = "Setup";
            this.tabSetup.UseVisualStyleBackColor = true;
            // 
            // gbTraceList
            // 
            this.gbTraceList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTraceList.Controls.Add(this.cbAscii);
            this.gbTraceList.Controls.Add(this.cbHex);
            this.gbTraceList.Controls.Add(this.cbLength);
            this.gbTraceList.Controls.Add(this.cbTime);
            this.gbTraceList.Controls.Add(this.cbType);
            this.gbTraceList.Controls.Add(this.cbId);
            this.gbTraceList.Location = new System.Drawing.Point(8, 60);
            this.gbTraceList.Name = "gbTraceList";
            this.gbTraceList.Size = new System.Drawing.Size(361, 90);
            this.gbTraceList.TabIndex = 3;
            this.gbTraceList.TabStop = false;
            this.gbTraceList.Text = "Trace List Columns";
            // 
            // cbAscii
            // 
            this.cbAscii.AutoSize = true;
            this.cbAscii.Checked = true;
            this.cbAscii.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAscii.Location = new System.Drawing.Point(114, 65);
            this.cbAscii.Name = "cbAscii";
            this.cbAscii.Size = new System.Drawing.Size(48, 17);
            this.cbAscii.TabIndex = 5;
            this.cbAscii.Text = "Ascii";
            this.cbAscii.UseVisualStyleBackColor = true;
            this.cbAscii.CheckedChanged += new System.EventHandler(this.cbTraceListColumn_CheckedChanged);
            // 
            // cbHex
            // 
            this.cbHex.AutoSize = true;
            this.cbHex.Checked = true;
            this.cbHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHex.Location = new System.Drawing.Point(114, 42);
            this.cbHex.Name = "cbHex";
            this.cbHex.Size = new System.Drawing.Size(45, 17);
            this.cbHex.TabIndex = 4;
            this.cbHex.Text = "Hex";
            this.cbHex.UseVisualStyleBackColor = true;
            this.cbHex.CheckedChanged += new System.EventHandler(this.cbTraceListColumn_CheckedChanged);
            // 
            // cbLength
            // 
            this.cbLength.AutoSize = true;
            this.cbLength.Checked = true;
            this.cbLength.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLength.Location = new System.Drawing.Point(114, 19);
            this.cbLength.Name = "cbLength";
            this.cbLength.Size = new System.Drawing.Size(59, 17);
            this.cbLength.TabIndex = 3;
            this.cbLength.Text = "Length";
            this.cbLength.UseVisualStyleBackColor = true;
            this.cbLength.CheckedChanged += new System.EventHandler(this.cbTraceListColumn_CheckedChanged);
            // 
            // cbTime
            // 
            this.cbTime.AutoSize = true;
            this.cbTime.Checked = true;
            this.cbTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTime.Location = new System.Drawing.Point(6, 65);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(49, 17);
            this.cbTime.TabIndex = 2;
            this.cbTime.Text = "Time";
            this.cbTime.UseVisualStyleBackColor = true;
            this.cbTime.CheckedChanged += new System.EventHandler(this.cbTraceListColumn_CheckedChanged);
            // 
            // cbType
            // 
            this.cbType.AutoSize = true;
            this.cbType.Checked = true;
            this.cbType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbType.Location = new System.Drawing.Point(6, 42);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(50, 17);
            this.cbType.TabIndex = 1;
            this.cbType.Text = "Type";
            this.cbType.UseVisualStyleBackColor = true;
            this.cbType.CheckedChanged += new System.EventHandler(this.cbTraceListColumn_CheckedChanged);
            // 
            // cbId
            // 
            this.cbId.AutoSize = true;
            this.cbId.Checked = true;
            this.cbId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbId.Location = new System.Drawing.Point(6, 19);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(35, 17);
            this.cbId.TabIndex = 0;
            this.cbId.Text = "Id";
            this.cbId.UseVisualStyleBackColor = true;
            this.cbId.CheckedChanged += new System.EventHandler(this.cbTraceListColumn_CheckedChanged);
            // 
            // gbFilterDriver
            // 
            this.gbFilterDriver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFilterDriver.Controls.Add(this.btnReinstall);
            this.gbFilterDriver.Controls.Add(this.btnUninstall);
            this.gbFilterDriver.Location = new System.Drawing.Point(8, 3);
            this.gbFilterDriver.Name = "gbFilterDriver";
            this.gbFilterDriver.Size = new System.Drawing.Size(361, 51);
            this.gbFilterDriver.TabIndex = 2;
            this.gbFilterDriver.TabStop = false;
            this.gbFilterDriver.Text = "Filter Driver";
            // 
            // btnReinstall
            // 
            this.btnReinstall.Location = new System.Drawing.Point(6, 19);
            this.btnReinstall.Name = "btnReinstall";
            this.btnReinstall.Size = new System.Drawing.Size(102, 23);
            this.btnReinstall.TabIndex = 0;
            this.btnReinstall.Text = "Reinstall";
            this.btnReinstall.UseVisualStyleBackColor = true;
            this.btnReinstall.Click += new System.EventHandler(this.btnReinstall_Click);
            // 
            // btnUninstall
            // 
            this.btnUninstall.Location = new System.Drawing.Point(114, 19);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(102, 23);
            this.btnUninstall.TabIndex = 1;
            this.btnUninstall.Text = "Uninstall";
            this.btnUninstall.UseVisualStyleBackColor = true;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // tmrDeviceChange
            // 
            this.tmrDeviceChange.Interval = 1000;
            this.tmrDeviceChange.Tick += new System.EventHandler(this.tmrDeviceChange_Tick);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(371, 354);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "computer.png");
            this.imageList1.Images.SetKeyName(1, "text_align_left.png");
            this.imageList1.Images.SetKeyName(2, "cog.png");
            // 
            // lvTraces
            // 
            this.lvTraces.AllowColumnReorder = true;
            this.lvTraces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chType,
            this.chTime,
            this.chLength,
            this.chHex,
            this.chAscii});
            this.lvTraces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTraces.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTraces.FullRowSelect = true;
            this.lvTraces.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTraces.Location = new System.Drawing.Point(3, 28);
            this.lvTraces.Name = "lvTraces";
            this.lvTraces.Size = new System.Drawing.Size(371, 328);
            this.lvTraces.TabIndex = 3;
            this.lvTraces.UseCompatibleStateImageBehavior = false;
            this.lvTraces.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "Id";
            this.chId.Width = 30;
            // 
            // chType
            // 
            this.chType.Text = "Type";
            this.chType.Width = 46;
            // 
            // chTime
            // 
            this.chTime.Text = "Time";
            this.chTime.Width = 79;
            // 
            // chLength
            // 
            this.chLength.Text = "Length";
            this.chLength.Width = 59;
            // 
            // chHex
            // 
            this.chHex.Text = "Hex";
            // 
            // chAscii
            // 
            this.chAscii.Text = "Ascii";
            // 
            // filterControl
            // 
            this.filterControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.filterControl.Filter = "";
            this.filterControl.Include = busdog.FilterInclude.Include;
            this.filterControl.LengthMatch_ = busdog.LengthMatch.GreaterThen;
            this.filterControl.Location = new System.Drawing.Point(8, 156);
            this.filterControl.Name = "filterControl";
            this.filterControl.Size = new System.Drawing.Size(361, 195);
            this.filterControl.TabIndex = 4;
            this.filterControl.Type = busdog.FilterType.Length;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 386);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "BusDog";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tabControl.ResumeLayout(false);
            this.tabDevices.ResumeLayout(false);
            this.tabDevices.PerformLayout();
            this.tabTrace.ResumeLayout(false);
            this.tabTrace.PerformLayout();
            this.tsTrace.ResumeLayout(false);
            this.tsTrace.PerformLayout();
            this.tabSetup.ResumeLayout(false);
            this.gbTraceList.ResumeLayout(false);
            this.gbTraceList.PerformLayout();
            this.gbFilterDriver.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDevices;
        private System.Windows.Forms.TabPage tabTrace;
        private System.Windows.Forms.Timer tmrDeviceChange;
        private System.Windows.Forms.TreeView tvDevices;
        private System.Windows.Forms.TabPage tabSetup;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.Button btnReinstall;
        private System.Windows.Forms.GroupBox gbTraceList;
        private System.Windows.Forms.CheckBox cbTime;
        private System.Windows.Forms.CheckBox cbType;
        private System.Windows.Forms.CheckBox cbId;
        private System.Windows.Forms.GroupBox gbFilterDriver;
        private System.Windows.Forms.CheckBox cbAscii;
        private System.Windows.Forms.CheckBox cbHex;
        private System.Windows.Forms.CheckBox cbLength;
        private FilterControl filterControl;
        private System.Windows.Forms.CheckBox cbAutoTrace;
        private BufferedListView lvTraces;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chLength;
        private System.Windows.Forms.ColumnHeader chHex;
        private System.Windows.Forms.ColumnHeader chAscii;
        private System.Windows.Forms.ToolStrip tsTrace;
        private System.Windows.Forms.ToolStripButton btnStartTraces;
        private System.Windows.Forms.ToolStripButton btnClearTraces;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lbMaxTraces;
        private System.Windows.Forms.ToolStripComboBox cbMaxTraces;
        private System.Windows.Forms.ToolStripButton btnCopyToClipboard;
        private System.Windows.Forms.ToolStripButton btnCopySelectedToClipboard;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripButton btnSaveToFile;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

