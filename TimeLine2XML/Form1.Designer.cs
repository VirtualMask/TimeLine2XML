namespace TimeLine2XML
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFLD = new System.Windows.Forms.OpenFileDialog();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btResize = new System.Windows.Forms.Button();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.AutoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentOut = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TimeSec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DurationSec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SyncText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.WindowSec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItemOpenTimeLine = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveTimeLine = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveAsTimeLine = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExportXML = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFLD = new System.Windows.Forms.SaveFileDialog();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.LeftToolStripPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            this.LeftToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_LeftToolStripPanel_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ContentPanel.Size = new System.Drawing.Size(909, 202);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTop.Controls.Add(this.btResize);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(917, 25);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LogForm_MouseUp);
            // 
            // btResize
            // 
            this.btResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btResize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btResize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btResize.Image = ((System.Drawing.Image)(resources.GetObject("btResize.Image")));
            this.btResize.Location = new System.Drawing.Point(889, 0);
            this.btResize.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btResize.Name = "btResize";
            this.btResize.Padding = new System.Windows.Forms.Padding(2, 2, 10, 2);
            this.btResize.Size = new System.Drawing.Size(28, 25);
            this.btResize.TabIndex = 1;
            this.btResize.UseVisualStyleBackColor = true;
            this.btResize.Click += new System.EventHandler(this.btResize_Click);
            // 
            // dataGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            this.dataGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AutoId,
            this.CommentOut,
            this.TimeSec,
            this.Column3,
            this.Column4,
            this.DurationSec,
            this.Column6,
            this.SyncText,
            this.Column7,
            this.WindowSec});
            this.dataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV.GridColor = System.Drawing.Color.SlateGray;
            this.dataGV.Location = new System.Drawing.Point(0, 25);
            this.dataGV.Name = "dataGV";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dataGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGV.RowTemplate.Height = 21;
            this.dataGV.Size = new System.Drawing.Size(917, 177);
            this.dataGV.TabIndex = 1;
             this.dataGV.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGV_EditingControlShowing);
            // 
            // AutoId
            // 
            this.AutoId.FillWeight = 50F;
            this.AutoId.Frozen = true;
            this.AutoId.HeaderText = "ID";
            this.AutoId.MaxInputLength = 256;
            this.AutoId.Name = "AutoId";
            this.AutoId.ReadOnly = true;
            this.AutoId.Width = 50;
            // 
            // CommentOut
            // 
            this.CommentOut.FillWeight = 50F;
            this.CommentOut.Frozen = true;
            this.CommentOut.HeaderText = "#";
            this.CommentOut.Items.AddRange(new object[] {
            "",
            "#"});
            this.CommentOut.Name = "CommentOut";
            this.CommentOut.Width = 50;
            // 
            // TimeSec
            // 
            this.TimeSec.FillWeight = 60F;
            this.TimeSec.Frozen = true;
            this.TimeSec.HeaderText = "Sec";
            this.TimeSec.MaxInputLength = 128;
            this.TimeSec.Name = "TimeSec";
            this.TimeSec.Width = 60;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 180F;
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Title";
            this.Column3.MaxInputLength = 1024;
            this.Column3.Name = "Column3";
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 70F;
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Duration";
            this.Column4.Items.AddRange(new object[] {
            "",
            "duration"});
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 70;
            // 
            // DurationSec
            // 
            this.DurationSec.FillWeight = 60F;
            this.DurationSec.Frozen = true;
            this.DurationSec.HeaderText = "D-Sec ";
            this.DurationSec.MaxInputLength = 128;
            this.DurationSec.Name = "DurationSec";
            this.DurationSec.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DurationSec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DurationSec.Width = 60;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 70F;
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "同期";
            this.Column6.Items.AddRange(new object[] {
            "",
            "sync"});
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 70;
            // 
            // SyncText
            // 
            this.SyncText.FillWeight = 200F;
            this.SyncText.Frozen = true;
            this.SyncText.HeaderText = "同期テキスト";
            this.SyncText.Name = "SyncText";
            this.SyncText.Width = 200;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 70F;
            this.Column7.HeaderText = "Window";
            this.Column7.Items.AddRange(new object[] {
            "",
            "window"});
            this.Column7.Name = "Column7";
            this.Column7.Width = 70;
            // 
            // WindowSec
            // 
            this.WindowSec.FillWeight = 60F;
            this.WindowSec.HeaderText = "W-Sec";
            this.WindowSec.Name = "WindowSec";
            this.WindowSec.Width = 60;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGV);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panelTop);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(917, 202);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.LeftToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_LeftToolStripPanel_Click);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(946, 202);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(29, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOpenTimeLine,
            this.ToolStripMenuItemSaveTimeLine,
            this.toolStripMenuItemSaveAsTimeLine,
            this.ToolStripMenuItemExportXML,
            this.toolStripMenuItem_Exit});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(28, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // ToolStripMenuItemOpenTimeLine
            // 
            this.ToolStripMenuItemOpenTimeLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToolStripMenuItemOpenTimeLine.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItemOpenTimeLine.Name = "ToolStripMenuItemOpenTimeLine";
            this.ToolStripMenuItemOpenTimeLine.Size = new System.Drawing.Size(161, 22);
            this.ToolStripMenuItemOpenTimeLine.Text = "タイムラインを開く";
            this.ToolStripMenuItemOpenTimeLine.Click += new System.EventHandler(this.ToolStripMenuItemOpenTimeLine_Click);
            // 
            // ToolStripMenuItemSaveTimeLine
            // 
            this.ToolStripMenuItemSaveTimeLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToolStripMenuItemSaveTimeLine.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItemSaveTimeLine.Name = "ToolStripMenuItemSaveTimeLine";
            this.ToolStripMenuItemSaveTimeLine.Size = new System.Drawing.Size(161, 22);
            this.ToolStripMenuItemSaveTimeLine.Text = "タイムライン保存";
            this.ToolStripMenuItemSaveTimeLine.Click += new System.EventHandler(this.ToolStripMenuItemSaveTimeLine_Click);
            // 
            // toolStripMenuItemSaveAsTimeLine
            // 
            this.toolStripMenuItemSaveAsTimeLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripMenuItemSaveAsTimeLine.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemSaveAsTimeLine.Name = "toolStripMenuItemSaveAsTimeLine";
            this.toolStripMenuItemSaveAsTimeLine.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItemSaveAsTimeLine.Text = "名前を付けて保存";
            this.toolStripMenuItemSaveAsTimeLine.Click += new System.EventHandler(this.toolStripMenuItemSaveAsTimeLine_Click);
            // 
            // ToolStripMenuItemExportXML
            // 
            this.ToolStripMenuItemExportXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToolStripMenuItemExportXML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ToolStripMenuItemExportXML.Name = "ToolStripMenuItemExportXML";
            this.ToolStripMenuItemExportXML.Size = new System.Drawing.Size(161, 22);
            this.ToolStripMenuItemExportXML.Text = "XMLエクスポート";
            // 
            // toolStripMenuItem_Exit
            // 
            this.toolStripMenuItem_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripMenuItem_Exit.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem_Exit.Name = "toolStripMenuItem_Exit";
            this.toolStripMenuItem_Exit.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem_Exit.Text = "Exit";
            this.toolStripMenuItem_Exit.Click += new System.EventHandler(this.toolStripMenuItem_Exit_Click);
            // 
            // saveFLD
            // 
            this.saveFLD.Filter = "*.*|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(946, 202);
            this.ControlBox = false;
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFLD;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btResize;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutoId;
        private System.Windows.Forms.DataGridViewComboBoxColumn CommentOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationSec;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn SyncText;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn WindowSec;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpenTimeLine;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveTimeLine;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExportXML;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveAsTimeLine;
        private System.Windows.Forms.SaveFileDialog saveFLD;
    }
}

