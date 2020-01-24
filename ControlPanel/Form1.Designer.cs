namespace ControlPanel
{
    partial class MainScreen
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
            this.pnlSide = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnWorkorders = new System.Windows.Forms.Button();
            this.btnScripts = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbxNIAR = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNIAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.AutoSize = true;
            this.pnlSide.Controls.Add(this.lblName);
            this.pnlSide.Controls.Add(this.label1);
            this.pnlSide.Controls.Add(this.pictureBox2);
            this.pnlSide.Controls.Add(this.btnWorkorders);
            this.pnlSide.Controls.Add(this.btnScripts);
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(200, 500);
            this.pnlSide.TabIndex = 0;
            this.pnlSide.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSide_Paint);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(102, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ControlPanel.Properties.Resources.smalluser;
            this.pictureBox2.Location = new System.Drawing.Point(11, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 65);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnWorkorders
            // 
            this.btnWorkorders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnWorkorders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWorkorders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWorkorders.Font = new System.Drawing.Font("Gadugi", 13F, System.Drawing.FontStyle.Bold);
            this.btnWorkorders.ForeColor = System.Drawing.Color.White;
            this.btnWorkorders.Image = global::ControlPanel.Properties.Resources.calendarsmall;
            this.btnWorkorders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkorders.Location = new System.Drawing.Point(15, 195);
            this.btnWorkorders.Name = "btnWorkorders";
            this.btnWorkorders.Size = new System.Drawing.Size(170, 50);
            this.btnWorkorders.TabIndex = 2;
            this.btnWorkorders.Text = "Workorders";
            this.btnWorkorders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWorkorders.UseVisualStyleBackColor = false;
            this.btnWorkorders.Click += new System.EventHandler(this.btnWorkorders_Click);
            // 
            // btnScripts
            // 
            this.btnScripts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnScripts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnScripts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScripts.Font = new System.Drawing.Font("Gadugi", 13F, System.Drawing.FontStyle.Bold);
            this.btnScripts.ForeColor = System.Drawing.Color.White;
            this.btnScripts.Image = global::ControlPanel.Properties.Resources.workordersmall;
            this.btnScripts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScripts.Location = new System.Drawing.Point(15, 140);
            this.btnScripts.Name = "btnScripts";
            this.btnScripts.Size = new System.Drawing.Size(170, 50);
            this.btnScripts.TabIndex = 1;
            this.btnScripts.Text = "Scripts";
            this.btnScripts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScripts.UseVisualStyleBackColor = false;
            this.btnScripts.Click += new System.EventHandler(this.btnScripts_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.AutoSize = true;
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.pnlTop.Controls.Add(this.panel3);
            this.pnlTop.Controls.Add(this.pbxNIAR);
            this.pnlTop.Location = new System.Drawing.Point(200, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(738, 503);
            this.pnlTop.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 424);
            this.panel3.TabIndex = 2;
            // 
            // pbxNIAR
            // 
            this.pbxNIAR.Image = global::ControlPanel.Properties.Resources.NIAR;
            this.pbxNIAR.Location = new System.Drawing.Point(564, 7);
            this.pbxNIAR.Name = "pbxNIAR";
            this.pbxNIAR.Size = new System.Drawing.Size(144, 65);
            this.pbxNIAR.TabIndex = 0;
            this.pbxNIAR.TabStop = false;
            this.pbxNIAR.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.Location = new System.Drawing.Point(200, 78);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(710, 420);
            this.pnlMain.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(585, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 65);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(910, 501);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSide);
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxNIAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pbxNIAR;
        private System.Windows.Forms.Button btnWorkorders;
        private System.Windows.Forms.Button btnScripts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
    }
}

