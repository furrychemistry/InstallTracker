
namespace InstallTracker
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
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.chklstFiles = new System.Windows.Forms.CheckedListBox();
			this.btnPopulateRunList = new System.Windows.Forms.Button();
			this.txtSelectDirectory = new System.Windows.Forms.TextBox();
			this.ctxSelectDirectory = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ctxSelectDirectory_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.ctxSelectDirectory_Cut = new System.Windows.Forms.ToolStripMenuItem();
			this.ctxSelectDirectory_Copy = new System.Windows.Forms.ToolStripMenuItem();
			this.ctxSelectDirectory_Paste = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.ctxSelectDirectory_Clear = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.btnPickDirectory = new System.Windows.Forms.Button();
			this.btnRunAll = new System.Windows.Forms.Button();
			this.txtLastValidDirectory = new System.Windows.Forms.TextBox();
			this.ctxLastValidDirectory = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ctxLastValidDirectory_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.ctxLastValidDirectory_Copy = new System.Windows.Forms.ToolStripMenuItem();
			this.label2 = new System.Windows.Forms.Label();
			this.btnStopRun = new System.Windows.Forms.Button();
			this.dialogPickDirectory = new System.Windows.Forms.FolderBrowserDialog();
			this.ctxSelectDirectory.SuspendLayout();
			this.ctxLastValidDirectory.SuspendLayout();
			this.SuspendLayout();
			// 
			// chklstFiles
			// 
			this.chklstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chklstFiles.Location = new System.Drawing.Point(12, 69);
			this.chklstFiles.Name = "chklstFiles";
			this.chklstFiles.Size = new System.Drawing.Size(275, 364);
			this.chklstFiles.TabIndex = 6;
			// 
			// btnPopulateRunList
			// 
			this.btnPopulateRunList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPopulateRunList.Location = new System.Drawing.Point(293, 41);
			this.btnPopulateRunList.Name = "btnPopulateRunList";
			this.btnPopulateRunList.Size = new System.Drawing.Size(89, 23);
			this.btnPopulateRunList.TabIndex = 5;
			this.btnPopulateRunList.Text = "Populate";
			this.btnPopulateRunList.UseVisualStyleBackColor = true;
			this.btnPopulateRunList.Click += new System.EventHandler(this.btnPopulateRunList_Click);
			// 
			// txtSelectDirectory
			// 
			this.txtSelectDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSelectDirectory.ContextMenuStrip = this.ctxSelectDirectory;
			this.txtSelectDirectory.Location = new System.Drawing.Point(74, 14);
			this.txtSelectDirectory.Name = "txtSelectDirectory";
			this.txtSelectDirectory.Size = new System.Drawing.Size(255, 20);
			this.txtSelectDirectory.TabIndex = 1;
			this.txtSelectDirectory.TextChanged += new System.EventHandler(this.txtSelectDirectory_TextChanged);
			// 
			// ctxSelectDirectory
			// 
			this.ctxSelectDirectory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxSelectDirectory_SelectAll,
            this.toolStripMenuItem2,
            this.ctxSelectDirectory_Cut,
            this.ctxSelectDirectory_Copy,
            this.ctxSelectDirectory_Paste,
            this.toolStripMenuItem3,
            this.ctxSelectDirectory_Clear});
			this.ctxSelectDirectory.Name = "contextMenuStrip1";
			this.ctxSelectDirectory.Size = new System.Drawing.Size(181, 148);
			this.ctxSelectDirectory.Text = "Select Directory Context Menu";
			// 
			// ctxSelectDirectory_SelectAll
			// 
			this.ctxSelectDirectory_SelectAll.Name = "ctxSelectDirectory_SelectAll";
			this.ctxSelectDirectory_SelectAll.Size = new System.Drawing.Size(122, 22);
			this.ctxSelectDirectory_SelectAll.Text = "Select All";
			this.ctxSelectDirectory_SelectAll.Click += new System.EventHandler(this.ctxSelectDirectory_SelectAll_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(119, 6);
			// 
			// ctxSelectDirectory_Cut
			// 
			this.ctxSelectDirectory_Cut.Name = "ctxSelectDirectory_Cut";
			this.ctxSelectDirectory_Cut.Size = new System.Drawing.Size(180, 22);
			this.ctxSelectDirectory_Cut.Text = "Cut";
			this.ctxSelectDirectory_Cut.Click += new System.EventHandler(this.ctxSelectDirectory_Cut_Click);
			// 
			// ctxSelectDirectory_Copy
			// 
			this.ctxSelectDirectory_Copy.Name = "ctxSelectDirectory_Copy";
			this.ctxSelectDirectory_Copy.Size = new System.Drawing.Size(180, 22);
			this.ctxSelectDirectory_Copy.Text = "Copy";
			this.ctxSelectDirectory_Copy.Click += new System.EventHandler(this.ctxSelectDirectory_Copy_Click);
			// 
			// ctxSelectDirectory_Paste
			// 
			this.ctxSelectDirectory_Paste.Name = "ctxSelectDirectory_Paste";
			this.ctxSelectDirectory_Paste.Size = new System.Drawing.Size(180, 22);
			this.ctxSelectDirectory_Paste.Text = "Paste";
			this.ctxSelectDirectory_Paste.Click += new System.EventHandler(this.ctxSelectDirectory_Paste_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(119, 6);
			// 
			// ctxSelectDirectory_Clear
			// 
			this.ctxSelectDirectory_Clear.Name = "ctxSelectDirectory_Clear";
			this.ctxSelectDirectory_Clear.Size = new System.Drawing.Size(180, 22);
			this.ctxSelectDirectory_Clear.Text = "Clear";
			this.ctxSelectDirectory_Clear.Click += new System.EventHandler(this.ctxSelectDirectory_Clear_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Directory:";
			// 
			// btnPickDirectory
			// 
			this.btnPickDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPickDirectory.Location = new System.Drawing.Point(335, 12);
			this.btnPickDirectory.Name = "btnPickDirectory";
			this.btnPickDirectory.Size = new System.Drawing.Size(47, 23);
			this.btnPickDirectory.TabIndex = 2;
			this.btnPickDirectory.Text = "Pick...";
			this.btnPickDirectory.UseVisualStyleBackColor = true;
			this.btnPickDirectory.Click += new System.EventHandler(this.btnPickDirectory_Click);
			// 
			// btnRunAll
			// 
			this.btnRunAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRunAll.Location = new System.Drawing.Point(293, 69);
			this.btnRunAll.Name = "btnRunAll";
			this.btnRunAll.Size = new System.Drawing.Size(89, 23);
			this.btnRunAll.TabIndex = 7;
			this.btnRunAll.Text = "Run Selected";
			this.btnRunAll.UseVisualStyleBackColor = true;
			this.btnRunAll.Click += new System.EventHandler(this.btnRunSelected_Click);
			// 
			// txtLastValidDirectory
			// 
			this.txtLastValidDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtLastValidDirectory.ContextMenuStrip = this.ctxLastValidDirectory;
			this.txtLastValidDirectory.Location = new System.Drawing.Point(74, 43);
			this.txtLastValidDirectory.Name = "txtLastValidDirectory";
			this.txtLastValidDirectory.ReadOnly = true;
			this.txtLastValidDirectory.Size = new System.Drawing.Size(213, 20);
			this.txtLastValidDirectory.TabIndex = 4;
			this.txtLastValidDirectory.TabStop = false;
			// 
			// ctxLastValidDirectory
			// 
			this.ctxLastValidDirectory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxLastValidDirectory_SelectAll,
            this.toolStripMenuItem1,
            this.ctxLastValidDirectory_Copy});
			this.ctxLastValidDirectory.Name = "ctxLastValidDir";
			this.ctxLastValidDirectory.Size = new System.Drawing.Size(123, 54);
			this.ctxLastValidDirectory.Text = "Last Valid Directory Context Menu";
			// 
			// ctxLastValidDirectory_SelectAll
			// 
			this.ctxLastValidDirectory_SelectAll.Name = "ctxLastValidDirectory_SelectAll";
			this.ctxLastValidDirectory_SelectAll.Size = new System.Drawing.Size(180, 22);
			this.ctxLastValidDirectory_SelectAll.Text = "Select All";
			this.ctxLastValidDirectory_SelectAll.Click += new System.EventHandler(this.ctxLastValidDirectory_SelectAll_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
			// 
			// ctxLastValidDirectory_Copy
			// 
			this.ctxLastValidDirectory_Copy.Name = "ctxLastValidDirectory_Copy";
			this.ctxLastValidDirectory_Copy.Size = new System.Drawing.Size(180, 22);
			this.ctxLastValidDirectory_Copy.Text = "Copy";
			this.ctxLastValidDirectory_Copy.Click += new System.EventHandler(this.ctxLastValidDirectory_Copy_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Last Valid:";
			// 
			// btnStopRun
			// 
			this.btnStopRun.Location = new System.Drawing.Point(293, 98);
			this.btnStopRun.Name = "btnStopRun";
			this.btnStopRun.Size = new System.Drawing.Size(89, 23);
			this.btnStopRun.TabIndex = 8;
			this.btnStopRun.Text = "Stop Run";
			this.btnStopRun.UseVisualStyleBackColor = true;
			this.btnStopRun.Visible = false;
			this.btnStopRun.Click += new System.EventHandler(this.btnStopRun_Click);
			// 
			// dialogPickDirectory
			// 
			this.dialogPickDirectory.ShowNewFolderButton = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(394, 451);
			this.Controls.Add(this.btnStopRun);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtLastValidDirectory);
			this.Controls.Add(this.btnRunAll);
			this.Controls.Add(this.btnPickDirectory);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSelectDirectory);
			this.Controls.Add(this.btnPopulateRunList);
			this.Controls.Add(this.chklstFiles);
			this.Name = "MainForm";
			this.Text = "Run List Manager";
			this.Load += new System.EventHandler(this.Form_Load);
			this.ctxSelectDirectory.ResumeLayout(false);
			this.ctxLastValidDirectory.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox chklstFiles;
		private System.Windows.Forms.Button btnPopulateRunList;
		private System.Windows.Forms.TextBox txtSelectDirectory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnPickDirectory;
		private System.Windows.Forms.Button btnRunAll;
		private System.Windows.Forms.TextBox txtLastValidDirectory;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ContextMenuStrip ctxLastValidDirectory;
		private System.Windows.Forms.ToolStripMenuItem ctxLastValidDirectory_SelectAll;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ctxLastValidDirectory_Copy;
		private System.Windows.Forms.ContextMenuStrip ctxSelectDirectory;
		private System.Windows.Forms.ToolStripMenuItem ctxSelectDirectory_SelectAll;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem ctxSelectDirectory_Cut;
		private System.Windows.Forms.ToolStripMenuItem ctxSelectDirectory_Copy;
		private System.Windows.Forms.ToolStripMenuItem ctxSelectDirectory_Paste;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem ctxSelectDirectory_Clear;
		private System.Windows.Forms.Button btnStopRun;
		private System.Windows.Forms.FolderBrowserDialog dialogPickDirectory;
	}
}

