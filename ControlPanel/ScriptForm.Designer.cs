namespace ControlPanel
{
    partial class ScriptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnCATIAv5 = new System.Windows.Forms.Button();
            this.lbxRevisionsV5 = new System.Windows.Forms.CheckedListBox();
            this.btnSophos = new System.Windows.Forms.Button();
            this.btnTight = new System.Windows.Forms.Button();
            this.btnMatlab = new System.Windows.Forms.Button();
            this.lbxMatlab = new System.Windows.Forms.CheckedListBox();
            this.pbxMatlabInfo = new System.Windows.Forms.PictureBox();
            this.rtbxMatlabInfo = new System.Windows.Forms.RichTextBox();
            this.pbxCATIAInfo = new System.Windows.Forms.PictureBox();
            this.rtbxCATIAv5Info = new System.Windows.Forms.RichTextBox();
            this.btnCATIAV6 = new System.Windows.Forms.Button();
            this.lbxRevisionsV6 = new System.Windows.Forms.CheckedListBox();
            this.pbxCATIAV6Info = new System.Windows.Forms.PictureBox();
            this.rtbxCATIAv6Info = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMatlabInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCATIAInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCATIAV6Info)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Plum;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(710, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(92, 22);
            this.toolStripLabel1.Text = "ScriptCenter";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // btnCATIAv5
            // 
            this.btnCATIAv5.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCATIAv5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCATIAv5.Location = new System.Drawing.Point(340, 42);
            this.btnCATIAv5.Name = "btnCATIAv5";
            this.btnCATIAv5.Size = new System.Drawing.Size(138, 79);
            this.btnCATIAv5.TabIndex = 4;
            this.btnCATIAv5.Text = "CATIAv5";
            this.btnCATIAv5.UseVisualStyleBackColor = false;
            this.btnCATIAv5.Click += new System.EventHandler(this.btnCATIA_Click);
            // 
            // lbxRevisionsV5
            // 
            this.lbxRevisionsV5.BackColor = System.Drawing.Color.DimGray;
            this.lbxRevisionsV5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxRevisionsV5.CheckOnClick = true;
            this.lbxRevisionsV5.FormattingEnabled = true;
            this.lbxRevisionsV5.Location = new System.Drawing.Point(484, 42);
            this.lbxRevisionsV5.Name = "lbxRevisionsV5";
            this.lbxRevisionsV5.Size = new System.Drawing.Size(129, 77);
            this.lbxRevisionsV5.TabIndex = 5;
            this.lbxRevisionsV5.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lbxRevisions_ItemCheck);
            // 
            // btnSophos
            // 
            this.btnSophos.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSophos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSophos.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSophos.Location = new System.Drawing.Point(42, 53);
            this.btnSophos.Name = "btnSophos";
            this.btnSophos.Size = new System.Drawing.Size(223, 26);
            this.btnSophos.TabIndex = 7;
            this.btnSophos.Text = "Sophos";
            this.btnSophos.UseVisualStyleBackColor = false;
            this.btnSophos.Click += new System.EventHandler(this.btnSophos_Click);
            // 
            // btnTight
            // 
            this.btnTight.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnTight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTight.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTight.Location = new System.Drawing.Point(42, 85);
            this.btnTight.Name = "btnTight";
            this.btnTight.Size = new System.Drawing.Size(223, 26);
            this.btnTight.TabIndex = 8;
            this.btnTight.Text = "TightVNC";
            this.btnTight.UseVisualStyleBackColor = false;
            this.btnTight.Click += new System.EventHandler(this.btnTight_Click);
            // 
            // btnMatlab
            // 
            this.btnMatlab.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnMatlab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatlab.Location = new System.Drawing.Point(340, 212);
            this.btnMatlab.Name = "btnMatlab";
            this.btnMatlab.Size = new System.Drawing.Size(138, 79);
            this.btnMatlab.TabIndex = 9;
            this.btnMatlab.Text = "Matlab";
            this.btnMatlab.UseVisualStyleBackColor = false;
            this.btnMatlab.Click += new System.EventHandler(this.btnMatlab_Click);
            // 
            // lbxMatlab
            // 
            this.lbxMatlab.BackColor = System.Drawing.Color.DimGray;
            this.lbxMatlab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxMatlab.CheckOnClick = true;
            this.lbxMatlab.FormattingEnabled = true;
            this.lbxMatlab.Location = new System.Drawing.Point(484, 212);
            this.lbxMatlab.Name = "lbxMatlab";
            this.lbxMatlab.Size = new System.Drawing.Size(129, 77);
            this.lbxMatlab.TabIndex = 10;
            this.lbxMatlab.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lbxMatlab_ItemCheck);
            // 
            // pbxMatlabInfo
            // 
            this.pbxMatlabInfo.BackColor = System.Drawing.Color.Transparent;
            this.pbxMatlabInfo.Image = global::ControlPanel.Properties.Resources.infosmall;
            this.pbxMatlabInfo.Location = new System.Drawing.Point(320, 223);
            this.pbxMatlabInfo.Name = "pbxMatlabInfo";
            this.pbxMatlabInfo.Size = new System.Drawing.Size(20, 20);
            this.pbxMatlabInfo.TabIndex = 11;
            this.pbxMatlabInfo.TabStop = false;
            this.pbxMatlabInfo.Click += new System.EventHandler(this.pbxMatlabInfo_Click);
            // 
            // rtbxMatlabInfo
            // 
            this.rtbxMatlabInfo.AcceptsTab = true;
            this.rtbxMatlabInfo.Location = new System.Drawing.Point(49, 241);
            this.rtbxMatlabInfo.Name = "rtbxMatlabInfo";
            this.rtbxMatlabInfo.Size = new System.Drawing.Size(280, 174);
            this.rtbxMatlabInfo.TabIndex = 12;
            this.rtbxMatlabInfo.Text = "";
            this.rtbxMatlabInfo.Visible = false;
            // 
            // pbxCATIAInfo
            // 
            this.pbxCATIAInfo.BackColor = System.Drawing.Color.Transparent;
            this.pbxCATIAInfo.Image = global::ControlPanel.Properties.Resources.infosmall;
            this.pbxCATIAInfo.Location = new System.Drawing.Point(320, 42);
            this.pbxCATIAInfo.Name = "pbxCATIAInfo";
            this.pbxCATIAInfo.Size = new System.Drawing.Size(20, 20);
            this.pbxCATIAInfo.TabIndex = 13;
            this.pbxCATIAInfo.TabStop = false;
            this.pbxCATIAInfo.Click += new System.EventHandler(this.infoClick);
            // 
            // rtbxCATIAv5Info
            // 
            this.rtbxCATIAv5Info.AcceptsTab = true;
            this.rtbxCATIAv5Info.Location = new System.Drawing.Point(49, 61);
            this.rtbxCATIAv5Info.Name = "rtbxCATIAv5Info";
            this.rtbxCATIAv5Info.Size = new System.Drawing.Size(280, 174);
            this.rtbxCATIAv5Info.TabIndex = 14;
            this.rtbxCATIAv5Info.Text = "";
            this.rtbxCATIAv5Info.Visible = false;
            // 
            // btnCATIAV6
            // 
            this.btnCATIAV6.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCATIAV6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCATIAV6.Location = new System.Drawing.Point(340, 127);
            this.btnCATIAV6.Name = "btnCATIAV6";
            this.btnCATIAV6.Size = new System.Drawing.Size(138, 79);
            this.btnCATIAV6.TabIndex = 15;
            this.btnCATIAV6.Text = "CATIAv6";
            this.btnCATIAV6.UseVisualStyleBackColor = false;
            this.btnCATIAV6.Click += new System.EventHandler(this.btnCATIAV6_Click);
            // 
            // lbxRevisionsV6
            // 
            this.lbxRevisionsV6.BackColor = System.Drawing.Color.DimGray;
            this.lbxRevisionsV6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxRevisionsV6.CheckOnClick = true;
            this.lbxRevisionsV6.FormattingEnabled = true;
            this.lbxRevisionsV6.Location = new System.Drawing.Point(484, 127);
            this.lbxRevisionsV6.Name = "lbxRevisionsV6";
            this.lbxRevisionsV6.Size = new System.Drawing.Size(129, 77);
            this.lbxRevisionsV6.TabIndex = 16;
            // 
            // pbxCATIAV6Info
            // 
            this.pbxCATIAV6Info.BackColor = System.Drawing.Color.Transparent;
            this.pbxCATIAV6Info.Image = global::ControlPanel.Properties.Resources.infosmall;
            this.pbxCATIAV6Info.Location = new System.Drawing.Point(320, 127);
            this.pbxCATIAV6Info.Name = "pbxCATIAV6Info";
            this.pbxCATIAV6Info.Size = new System.Drawing.Size(20, 20);
            this.pbxCATIAV6Info.TabIndex = 17;
            this.pbxCATIAV6Info.TabStop = false;
            this.pbxCATIAV6Info.Click += new System.EventHandler(this.pbxCATIAV6Info_Click);
            // 
            // rtbxCATIAv6Info
            // 
            this.rtbxCATIAv6Info.AcceptsTab = true;
            this.rtbxCATIAv6Info.Location = new System.Drawing.Point(49, 142);
            this.rtbxCATIAv6Info.Name = "rtbxCATIAv6Info";
            this.rtbxCATIAv6Info.Size = new System.Drawing.Size(280, 174);
            this.rtbxCATIAv6Info.TabIndex = 18;
            this.rtbxCATIAv6Info.Text = "";
            this.rtbxCATIAv6Info.Visible = false;
            // 
            // ScriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(710, 420);
            this.Controls.Add(this.rtbxCATIAv6Info);
            this.Controls.Add(this.pbxCATIAV6Info);
            this.Controls.Add(this.lbxRevisionsV6);
            this.Controls.Add(this.btnCATIAV6);
            this.Controls.Add(this.rtbxCATIAv5Info);
            this.Controls.Add(this.pbxCATIAInfo);
            this.Controls.Add(this.rtbxMatlabInfo);
            this.Controls.Add(this.pbxMatlabInfo);
            this.Controls.Add(this.lbxMatlab);
            this.Controls.Add(this.btnMatlab);
            this.Controls.Add(this.btnTight);
            this.Controls.Add(this.btnSophos);
            this.Controls.Add(this.lbxRevisionsV5);
            this.Controls.Add(this.btnCATIAv5);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScriptForm";
            this.Text = "ScriptForm";
            this.Load += new System.EventHandler(this.ScriptForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMatlabInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCATIAInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCATIAV6Info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button btnCATIAv5;
        private System.Windows.Forms.CheckedListBox lbxRevisionsV5;
        private System.Windows.Forms.Button btnSophos;
        private System.Windows.Forms.Button btnTight;
        private System.Windows.Forms.Button btnMatlab;
        private System.Windows.Forms.CheckedListBox lbxMatlab;
        private System.Windows.Forms.PictureBox pbxMatlabInfo;
        private System.Windows.Forms.RichTextBox rtbxMatlabInfo;
        private System.Windows.Forms.PictureBox pbxCATIAInfo;
        private System.Windows.Forms.RichTextBox rtbxCATIAv5Info;
        private System.Windows.Forms.Button btnCATIAV6;
        private System.Windows.Forms.CheckedListBox lbxRevisionsV6;
        private System.Windows.Forms.PictureBox pbxCATIAV6Info;
        private System.Windows.Forms.RichTextBox rtbxCATIAv6Info;
    }
}