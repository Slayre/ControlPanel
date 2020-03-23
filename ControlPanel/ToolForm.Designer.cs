namespace ControlPanel
{
    partial class ToolForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnRDP = new System.Windows.Forms.Button();
            this.btnCompMgmt = new System.Windows.Forms.Button();
            this.btnAD = new System.Windows.Forms.Button();
            this.btnCCInstall = new System.Windows.Forms.Button();
            this.btnRemoteSettings = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSCBackup = new System.Windows.Forms.Button();
            this.btnSCDisable = new System.Windows.Forms.Button();
            this.btnPowerOpt = new System.Windows.Forms.Button();
            this.btnDotNetInstall = new System.Windows.Forms.Button();
            this.btnEnvirVariables = new System.Windows.Forms.Button();
            this.btnReloadProf = new System.Windows.Forms.Button();
            this.tbxProfileName = new System.Windows.Forms.TextBox();
            this.btnDesc = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
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
            this.toolStrip1.TabIndex = 3;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel1.Text = "Tools";
            // 
            // btnRDP
            // 
            this.btnRDP.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnRDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRDP.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRDP.Location = new System.Drawing.Point(43, 218);
            this.btnRDP.Name = "btnRDP";
            this.btnRDP.Size = new System.Drawing.Size(223, 26);
            this.btnRDP.TabIndex = 13;
            this.btnRDP.Text = "Remote Desktop";
            this.btnRDP.UseVisualStyleBackColor = false;
            this.btnRDP.Click += new System.EventHandler(this.btnRDP_Click);
            // 
            // btnCompMgmt
            // 
            this.btnCompMgmt.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCompMgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompMgmt.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompMgmt.Location = new System.Drawing.Point(43, 250);
            this.btnCompMgmt.Name = "btnCompMgmt";
            this.btnCompMgmt.Size = new System.Drawing.Size(223, 26);
            this.btnCompMgmt.TabIndex = 14;
            this.btnCompMgmt.Text = "Computer Management";
            this.btnCompMgmt.UseVisualStyleBackColor = false;
            this.btnCompMgmt.Click += new System.EventHandler(this.btnCompMgmt_Click);
            // 
            // btnAD
            // 
            this.btnAD.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAD.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAD.Location = new System.Drawing.Point(43, 314);
            this.btnAD.Name = "btnAD";
            this.btnAD.Size = new System.Drawing.Size(223, 26);
            this.btnAD.TabIndex = 15;
            this.btnAD.Text = "Users and Computers (AD)";
            this.btnAD.UseVisualStyleBackColor = false;
            this.btnAD.Click += new System.EventHandler(this.btnAD_Click);
            // 
            // btnCCInstall
            // 
            this.btnCCInstall.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCCInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCCInstall.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCCInstall.Location = new System.Drawing.Point(43, 40);
            this.btnCCInstall.Name = "btnCCInstall";
            this.btnCCInstall.Size = new System.Drawing.Size(223, 26);
            this.btnCCInstall.TabIndex = 16;
            this.btnCCInstall.Text = "Master CC 2018 Installer";
            this.btnCCInstall.UseVisualStyleBackColor = false;
            this.btnCCInstall.Click += new System.EventHandler(this.btnCCInstall_Click);
            // 
            // btnRemoteSettings
            // 
            this.btnRemoteSettings.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnRemoteSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoteSettings.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoteSettings.Location = new System.Drawing.Point(437, 218);
            this.btnRemoteSettings.Name = "btnRemoteSettings";
            this.btnRemoteSettings.Size = new System.Drawing.Size(223, 26);
            this.btnRemoteSettings.TabIndex = 17;
            this.btnRemoteSettings.Text = "Remote Settings";
            this.btnRemoteSettings.UseVisualStyleBackColor = false;
            this.btnRemoteSettings.Click += new System.EventHandler(this.btnRemoteSettings_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(437, 250);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(223, 26);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Check for Updates";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSCBackup
            // 
            this.btnSCBackup.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSCBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSCBackup.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSCBackup.Location = new System.Drawing.Point(437, 40);
            this.btnSCBackup.Name = "btnSCBackup";
            this.btnSCBackup.Size = new System.Drawing.Size(223, 26);
            this.btnSCBackup.TabIndex = 19;
            this.btnSCBackup.Text = "Sync Center  ( backup )";
            this.btnSCBackup.UseVisualStyleBackColor = false;
            this.btnSCBackup.Click += new System.EventHandler(this.btnSCBackup_Click);
            // 
            // btnSCDisable
            // 
            this.btnSCDisable.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSCDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSCDisable.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSCDisable.Location = new System.Drawing.Point(437, 72);
            this.btnSCDisable.Name = "btnSCDisable";
            this.btnSCDisable.Size = new System.Drawing.Size(223, 26);
            this.btnSCDisable.TabIndex = 20;
            this.btnSCDisable.Text = "Sync Center  ( disable )";
            this.btnSCDisable.UseVisualStyleBackColor = false;
            this.btnSCDisable.Click += new System.EventHandler(this.btnSCDisable_Click);
            // 
            // btnPowerOpt
            // 
            this.btnPowerOpt.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnPowerOpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPowerOpt.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPowerOpt.Location = new System.Drawing.Point(437, 282);
            this.btnPowerOpt.Name = "btnPowerOpt";
            this.btnPowerOpt.Size = new System.Drawing.Size(223, 26);
            this.btnPowerOpt.TabIndex = 21;
            this.btnPowerOpt.Text = "Power Options";
            this.btnPowerOpt.UseVisualStyleBackColor = false;
            this.btnPowerOpt.Click += new System.EventHandler(this.btnPowerOpt_Click);
            // 
            // btnDotNetInstall
            // 
            this.btnDotNetInstall.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDotNetInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDotNetInstall.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDotNetInstall.Location = new System.Drawing.Point(437, 104);
            this.btnDotNetInstall.Name = "btnDotNetInstall";
            this.btnDotNetInstall.Size = new System.Drawing.Size(223, 26);
            this.btnDotNetInstall.TabIndex = 22;
            this.btnDotNetInstall.Text = "Install .NET 3.5(NOT FINISHED)";
            this.btnDotNetInstall.UseMnemonic = false;
            this.btnDotNetInstall.UseVisualStyleBackColor = false;
            this.btnDotNetInstall.Click += new System.EventHandler(this.btnDotNetInstall_Click);
            // 
            // btnEnvirVariables
            // 
            this.btnEnvirVariables.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnEnvirVariables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvirVariables.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvirVariables.Location = new System.Drawing.Point(43, 282);
            this.btnEnvirVariables.Name = "btnEnvirVariables";
            this.btnEnvirVariables.Size = new System.Drawing.Size(223, 26);
            this.btnEnvirVariables.TabIndex = 23;
            this.btnEnvirVariables.Text = "Set Environmental Variables";
            this.btnEnvirVariables.UseVisualStyleBackColor = false;
            this.btnEnvirVariables.Click += new System.EventHandler(this.btnEnvirVariables_Click);
            // 
            // btnReloadProf
            // 
            this.btnReloadProf.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnReloadProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReloadProf.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadProf.Location = new System.Drawing.Point(554, 136);
            this.btnReloadProf.Name = "btnReloadProf";
            this.btnReloadProf.Size = new System.Drawing.Size(106, 26);
            this.btnReloadProf.TabIndex = 24;
            this.btnReloadProf.Text = "Reload Profile";
            this.btnReloadProf.UseVisualStyleBackColor = false;
            this.btnReloadProf.Click += new System.EventHandler(this.btnReloadProf_Click);
            // 
            // tbxProfileName
            // 
            this.tbxProfileName.Location = new System.Drawing.Point(437, 139);
            this.tbxProfileName.Name = "tbxProfileName";
            this.tbxProfileName.Size = new System.Drawing.Size(111, 20);
            this.tbxProfileName.TabIndex = 25;
            // 
            // btnDesc
            // 
            this.btnDesc.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesc.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesc.Location = new System.Drawing.Point(43, 186);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(223, 26);
            this.btnDesc.TabIndex = 26;
            this.btnDesc.Text = "Update Active Dir";
            this.btnDesc.UseVisualStyleBackColor = false;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // ToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(710, 420);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.tbxProfileName);
            this.Controls.Add(this.btnReloadProf);
            this.Controls.Add(this.btnEnvirVariables);
            this.Controls.Add(this.btnDotNetInstall);
            this.Controls.Add(this.btnPowerOpt);
            this.Controls.Add(this.btnSCDisable);
            this.Controls.Add(this.btnSCBackup);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemoteSettings);
            this.Controls.Add(this.btnCCInstall);
            this.Controls.Add(this.btnAD);
            this.Controls.Add(this.btnCompMgmt);
            this.Controls.Add(this.btnRDP);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToolForm";
            this.Text = "ToolForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button btnRDP;
        private System.Windows.Forms.Button btnCompMgmt;
        private System.Windows.Forms.Button btnAD;
        private System.Windows.Forms.Button btnCCInstall;
        private System.Windows.Forms.Button btnRemoteSettings;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSCBackup;
        private System.Windows.Forms.Button btnSCDisable;
        private System.Windows.Forms.Button btnPowerOpt;
        private System.Windows.Forms.Button btnDotNetInstall;
        private System.Windows.Forms.Button btnEnvirVariables;
        private System.Windows.Forms.Button btnReloadProf;
        private System.Windows.Forms.TextBox tbxProfileName;
        private System.Windows.Forms.Button btnDesc;
    }
}