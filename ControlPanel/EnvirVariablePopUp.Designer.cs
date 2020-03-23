namespace ControlPanel
{
    partial class EnvirVariablePopUp
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
            this.lblPort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxVariable = new System.Windows.Forms.TextBox();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.pbxEnvironInfo = new System.Windows.Forms.PictureBox();
            this.rtbxEnvironInfo = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnvironInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.ForeColor = System.Drawing.Color.White;
            this.lblPort.Location = new System.Drawing.Point(12, 27);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(71, 16);
            this.lblPort.TabIndex = 13;
            this.lblPort.Text = "Variable:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Value:";
            // 
            // tbxVariable
            // 
            this.tbxVariable.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbxVariable.Location = new System.Drawing.Point(89, 27);
            this.tbxVariable.Name = "tbxVariable";
            this.tbxVariable.Size = new System.Drawing.Size(180, 20);
            this.tbxVariable.TabIndex = 15;
            // 
            // tbxValue
            // 
            this.tbxValue.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbxValue.Location = new System.Drawing.Point(89, 56);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(180, 20);
            this.tbxValue.TabIndex = 16;
            // 
            // pbxEnvironInfo
            // 
            this.pbxEnvironInfo.Image = global::ControlPanel.Properties.Resources.infosmall;
            this.pbxEnvironInfo.Location = new System.Drawing.Point(0, 82);
            this.pbxEnvironInfo.Name = "pbxEnvironInfo";
            this.pbxEnvironInfo.Size = new System.Drawing.Size(20, 20);
            this.pbxEnvironInfo.TabIndex = 17;
            this.pbxEnvironInfo.TabStop = false;
            this.pbxEnvironInfo.Click += new System.EventHandler(this.pbxEnvironInfo_Click);
            // 
            // rtbxEnvironInfo
            // 
            this.rtbxEnvironInfo.AcceptsTab = true;
            this.rtbxEnvironInfo.BackColor = System.Drawing.Color.LavenderBlush;
            this.rtbxEnvironInfo.Location = new System.Drawing.Point(26, 82);
            this.rtbxEnvironInfo.Name = "rtbxEnvironInfo";
            this.rtbxEnvironInfo.Size = new System.Drawing.Size(369, 102);
            this.rtbxEnvironInfo.TabIndex = 18;
            this.rtbxEnvironInfo.Text = "";
            this.rtbxEnvironInfo.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(295, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 58);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EnvirVariablePopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(407, 196);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbxEnvironInfo);
            this.Controls.Add(this.pbxEnvironInfo);
            this.Controls.Add(this.tbxValue);
            this.Controls.Add(this.tbxVariable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EnvirVariablePopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Environmental Variable";
            this.Load += new System.EventHandler(this.EnvirVariablePopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnvironInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxVariable;
        private System.Windows.Forms.TextBox tbxValue;
        private System.Windows.Forms.PictureBox pbxEnvironInfo;
        private System.Windows.Forms.RichTextBox rtbxEnvironInfo;
        private System.Windows.Forms.Button btnSave;
    }
}