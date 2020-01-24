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
            this.btnSCBackup = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnSCDisable = new System.Windows.Forms.Button();
            this.btnCATIA = new System.Windows.Forms.Button();
            this.lbxRevisions = new System.Windows.Forms.CheckedListBox();
            this.btnCCInstall = new System.Windows.Forms.Button();
            this.btnSophos = new System.Windows.Forms.Button();
            this.btnTight = new System.Windows.Forms.Button();
            this.btnCompMgmt = new System.Windows.Forms.Button();
            this.btnAD = new System.Windows.Forms.Button();
            this.btnAdminCenter = new System.Windows.Forms.Button();
            this.btnRDP = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSCBackup
            // 
            this.btnSCBackup.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSCBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSCBackup.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSCBackup.Location = new System.Drawing.Point(42, 42);
            this.btnSCBackup.Name = "btnSCBackup";
            this.btnSCBackup.Size = new System.Drawing.Size(223, 26);
            this.btnSCBackup.TabIndex = 0;
            this.btnSCBackup.Text = "Sync Center  ( backup )";
            this.btnSCBackup.UseVisualStyleBackColor = false;
            this.btnSCBackup.Click += new System.EventHandler(this.btnSCBackup_Click_1);
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
            // btnSCDisable
            // 
            this.btnSCDisable.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSCDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSCDisable.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSCDisable.Location = new System.Drawing.Point(42, 74);
            this.btnSCDisable.Name = "btnSCDisable";
            this.btnSCDisable.Size = new System.Drawing.Size(223, 26);
            this.btnSCDisable.TabIndex = 3;
            this.btnSCDisable.Text = "Sync Center  ( disable )";
            this.btnSCDisable.UseVisualStyleBackColor = false;
            this.btnSCDisable.Click += new System.EventHandler(this.btnSCDisable_Click);
            // 
            // btnCATIA
            // 
            this.btnCATIA.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCATIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCATIA.Location = new System.Drawing.Point(340, 42);
            this.btnCATIA.Name = "btnCATIA";
            this.btnCATIA.Size = new System.Drawing.Size(138, 79);
            this.btnCATIA.TabIndex = 4;
            this.btnCATIA.Text = "CATIAv5";
            this.btnCATIA.UseVisualStyleBackColor = false;
            this.btnCATIA.Click += new System.EventHandler(this.btnCATIA_Click);
            // 
            // lbxRevisions
            // 
            this.lbxRevisions.BackColor = System.Drawing.Color.DimGray;
            this.lbxRevisions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxRevisions.CheckOnClick = true;
            this.lbxRevisions.FormattingEnabled = true;
            this.lbxRevisions.Items.AddRange(new object[] {
            "520",
            "521",
            "522",
            "523",
            "524",
            "525",
            "526",
            "527",
            "528",
            "529"});
            this.lbxRevisions.Location = new System.Drawing.Point(484, 42);
            this.lbxRevisions.Name = "lbxRevisions";
            this.lbxRevisions.Size = new System.Drawing.Size(96, 77);
            this.lbxRevisions.TabIndex = 5;
            this.lbxRevisions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lbxRevisions_ItemCheck);
            // 
            // btnCCInstall
            // 
            this.btnCCInstall.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCCInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCCInstall.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCCInstall.Location = new System.Drawing.Point(42, 222);
            this.btnCCInstall.Name = "btnCCInstall";
            this.btnCCInstall.Size = new System.Drawing.Size(223, 26);
            this.btnCCInstall.TabIndex = 6;
            this.btnCCInstall.Text = "Master CC 2018 Installer";
            this.btnCCInstall.UseVisualStyleBackColor = false;
            this.btnCCInstall.Click += new System.EventHandler(this.btnCCInstall_Click);
            // 
            // btnSophos
            // 
            this.btnSophos.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSophos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSophos.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSophos.Location = new System.Drawing.Point(42, 132);
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
            this.btnTight.Location = new System.Drawing.Point(42, 164);
            this.btnTight.Name = "btnTight";
            this.btnTight.Size = new System.Drawing.Size(223, 26);
            this.btnTight.TabIndex = 8;
            this.btnTight.Text = "TightVNC";
            this.btnTight.UseVisualStyleBackColor = false;
            // 
            // btnCompMgmt
            // 
            this.btnCompMgmt.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCompMgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompMgmt.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompMgmt.Location = new System.Drawing.Point(42, 318);
            this.btnCompMgmt.Name = "btnCompMgmt";
            this.btnCompMgmt.Size = new System.Drawing.Size(223, 26);
            this.btnCompMgmt.TabIndex = 9;
            this.btnCompMgmt.Text = "Computer Management";
            this.btnCompMgmt.UseVisualStyleBackColor = false;
            this.btnCompMgmt.Click += new System.EventHandler(this.btnCompMgmt_Click);
            // 
            // btnAD
            // 
            this.btnAD.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAD.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAD.Location = new System.Drawing.Point(42, 350);
            this.btnAD.Name = "btnAD";
            this.btnAD.Size = new System.Drawing.Size(223, 26);
            this.btnAD.TabIndex = 10;
            this.btnAD.Text = "Users and Computers (AD)";
            this.btnAD.UseVisualStyleBackColor = false;
            this.btnAD.Click += new System.EventHandler(this.btnAD_Click);
            // 
            // btnAdminCenter
            // 
            this.btnAdminCenter.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAdminCenter.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdminCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminCenter.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminCenter.Location = new System.Drawing.Point(42, 382);
            this.btnAdminCenter.Name = "btnAdminCenter";
            this.btnAdminCenter.Size = new System.Drawing.Size(223, 26);
            this.btnAdminCenter.TabIndex = 11;
            this.btnAdminCenter.Text = "Administrative Center";
            this.btnAdminCenter.UseVisualStyleBackColor = false;
            this.btnAdminCenter.Click += new System.EventHandler(this.btnAdminCenter_Click);
            // 
            // btnRDP
            // 
            this.btnRDP.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnRDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRDP.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRDP.Location = new System.Drawing.Point(42, 286);
            this.btnRDP.Name = "btnRDP";
            this.btnRDP.Size = new System.Drawing.Size(223, 26);
            this.btnRDP.TabIndex = 12;
            this.btnRDP.Text = "Remote Desktop";
            this.btnRDP.UseVisualStyleBackColor = false;
            this.btnRDP.Click += new System.EventHandler(this.btnRDP_Click);
            // 
            // ScriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(710, 420);
            this.Controls.Add(this.btnRDP);
            this.Controls.Add(this.btnAdminCenter);
            this.Controls.Add(this.btnAD);
            this.Controls.Add(this.btnCompMgmt);
            this.Controls.Add(this.btnTight);
            this.Controls.Add(this.btnSophos);
            this.Controls.Add(this.btnCCInstall);
            this.Controls.Add(this.lbxRevisions);
            this.Controls.Add(this.btnCATIA);
            this.Controls.Add(this.btnSCDisable);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnSCBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScriptForm";
            this.Text = "ScriptForm";
            this.Load += new System.EventHandler(this.ScriptForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSCBackup;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button btnSCDisable;
        private System.Windows.Forms.Button btnCATIA;
        private System.Windows.Forms.CheckedListBox lbxRevisions;
        private System.Windows.Forms.Button btnCCInstall;
        private System.Windows.Forms.Button btnSophos;
        private System.Windows.Forms.Button btnTight;
        private System.Windows.Forms.Button btnCompMgmt;
        private System.Windows.Forms.Button btnAD;
        private System.Windows.Forms.Button btnAdminCenter;
        private System.Windows.Forms.Button btnRDP;
    }
}