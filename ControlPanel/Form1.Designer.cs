using System.Threading.Tasks;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.pnlSide = new System.Windows.Forms.Panel();
            this.pbxUpDoot = new System.Windows.Forms.PictureBox();
            this.pbxDownDoot = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lvwQueue = new System.Windows.Forms.ListView();
            this.hdrProcName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblQueue = new System.Windows.Forms.Label();
            this.lblAdminOK = new System.Windows.Forms.Label();
            this.lblAdminError2 = new System.Windows.Forms.Label();
            this.lblAdminError1 = new System.Windows.Forms.Label();
            this.pbxAdminOK = new System.Windows.Forms.PictureBox();
            this.pbxAdminError = new System.Windows.Forms.PictureBox();
            this.btnTools = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnWorkorders = new System.Windows.Forms.Button();
            this.btnScripts = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbxNIAR = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblCurrently = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUpDoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDownDoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdminOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdminError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNIAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.AutoSize = true;
            this.pnlSide.Controls.Add(this.pbxUpDoot);
            this.pnlSide.Controls.Add(this.pbxDownDoot);
            this.pnlSide.Controls.Add(this.button1);
            this.pnlSide.Controls.Add(this.lvwQueue);
            this.pnlSide.Controls.Add(this.lblQueue);
            this.pnlSide.Controls.Add(this.lblAdminOK);
            this.pnlSide.Controls.Add(this.lblAdminError2);
            this.pnlSide.Controls.Add(this.lblAdminError1);
            this.pnlSide.Controls.Add(this.pbxAdminOK);
            this.pnlSide.Controls.Add(this.pbxAdminError);
            this.pnlSide.Controls.Add(this.btnTools);
            this.pnlSide.Controls.Add(this.lblName);
            this.pnlSide.Controls.Add(this.label1);
            this.pnlSide.Controls.Add(this.pictureBox2);
            this.pnlSide.Controls.Add(this.btnWorkorders);
            this.pnlSide.Controls.Add(this.btnScripts);
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(200, 500);
            this.pnlSide.TabIndex = 0;
            // 
            // pbxUpDoot
            // 
            this.pbxUpDoot.BackColor = System.Drawing.Color.Transparent;
            this.pbxUpDoot.Image = global::ControlPanel.Properties.Resources.updootgrey;
            this.pbxUpDoot.Location = new System.Drawing.Point(169, 319);
            this.pbxUpDoot.Name = "pbxUpDoot";
            this.pbxUpDoot.Size = new System.Drawing.Size(25, 25);
            this.pbxUpDoot.TabIndex = 15;
            this.pbxUpDoot.TabStop = false;
            // 
            // pbxDownDoot
            // 
            this.pbxDownDoot.BackColor = System.Drawing.Color.Transparent;
            this.pbxDownDoot.Image = global::ControlPanel.Properties.Resources.downdootgrey;
            this.pbxDownDoot.Location = new System.Drawing.Point(138, 319);
            this.pbxDownDoot.Name = "pbxDownDoot";
            this.pbxDownDoot.Size = new System.Drawing.Size(25, 25);
            this.pbxDownDoot.TabIndex = 0;
            this.pbxDownDoot.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(76, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lvwQueue
            // 
            this.lvwQueue.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwQueue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwQueue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrProcName,
            this.hdrTime});
            this.lvwQueue.FullRowSelect = true;
            this.lvwQueue.GridLines = true;
            this.lvwQueue.HideSelection = false;
            this.lvwQueue.Location = new System.Drawing.Point(3, 350);
            this.lvwQueue.MultiSelect = false;
            this.lvwQueue.Name = "lvwQueue";
            this.lvwQueue.Size = new System.Drawing.Size(191, 147);
            this.lvwQueue.TabIndex = 13;
            this.lvwQueue.UseCompatibleStateImageBehavior = false;
            this.lvwQueue.View = System.Windows.Forms.View.Details;
            this.lvwQueue.ItemActivate += new System.EventHandler(this.lvwQueue_ItemActivate);
            this.lvwQueue.SelectedIndexChanged += new System.EventHandler(this.lvwQueue_SelectedIndexChanged);
            // 
            // hdrProcName
            // 
            this.hdrProcName.Text = "Process";
            this.hdrProcName.Width = 120;
            // 
            // hdrTime
            // 
            this.hdrTime.Text = "Queued";
            this.hdrTime.Width = 71;
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueue.ForeColor = System.Drawing.Color.White;
            this.lblQueue.Location = new System.Drawing.Point(6, 331);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(53, 16);
            this.lblQueue.TabIndex = 12;
            this.lblQueue.Text = "Queue";
            // 
            // lblAdminOK
            // 
            this.lblAdminOK.AutoSize = true;
            this.lblAdminOK.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminOK.Font = new System.Drawing.Font("Segoe UI Semibold", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminOK.ForeColor = System.Drawing.Color.White;
            this.lblAdminOK.Location = new System.Drawing.Point(45, 105);
            this.lblAdminOK.Name = "lblAdminOK";
            this.lblAdminOK.Size = new System.Drawing.Size(71, 24);
            this.lblAdminOK.TabIndex = 9;
            this.lblAdminOK.Text = "Admin privileges\r\nare enabled";
            this.lblAdminOK.Visible = false;
            // 
            // lblAdminError2
            // 
            this.lblAdminError2.AutoSize = true;
            this.lblAdminError2.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminError2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminError2.ForeColor = System.Drawing.Color.White;
            this.lblAdminError2.Location = new System.Drawing.Point(49, 111);
            this.lblAdminError2.Name = "lblAdminError2";
            this.lblAdminError2.Size = new System.Drawing.Size(103, 20);
            this.lblAdminError2.TabIndex = 11;
            this.lblAdminError2.Text = "NOT enabled.";
            this.lblAdminError2.Visible = false;
            // 
            // lblAdminError1
            // 
            this.lblAdminError1.AutoSize = true;
            this.lblAdminError1.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminError1.Font = new System.Drawing.Font("Segoe UI Semibold", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminError1.ForeColor = System.Drawing.Color.White;
            this.lblAdminError1.Location = new System.Drawing.Point(55, 99);
            this.lblAdminError1.Name = "lblAdminError1";
            this.lblAdminError1.Size = new System.Drawing.Size(86, 12);
            this.lblAdminError1.TabIndex = 10;
            this.lblAdminError1.Text = "Admin privileges are";
            this.lblAdminError1.Visible = false;
            // 
            // pbxAdminOK
            // 
            this.pbxAdminOK.Image = global::ControlPanel.Properties.Resources.shield_ok_iconsmaller;
            this.pbxAdminOK.Location = new System.Drawing.Point(15, 103);
            this.pbxAdminOK.Name = "pbxAdminOK";
            this.pbxAdminOK.Size = new System.Drawing.Size(26, 30);
            this.pbxAdminOK.TabIndex = 8;
            this.pbxAdminOK.TabStop = false;
            this.pbxAdminOK.Visible = false;
            // 
            // pbxAdminError
            // 
            this.pbxAdminError.Image = global::ControlPanel.Properties.Resources.shield_error_iconsmaller;
            this.pbxAdminError.Location = new System.Drawing.Point(15, 102);
            this.pbxAdminError.Name = "pbxAdminError";
            this.pbxAdminError.Size = new System.Drawing.Size(26, 30);
            this.pbxAdminError.TabIndex = 7;
            this.pbxAdminError.TabStop = false;
            this.pbxAdminError.Visible = false;
            // 
            // btnTools
            // 
            this.btnTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTools.Font = new System.Drawing.Font("Gadugi", 13F, System.Drawing.FontStyle.Bold);
            this.btnTools.ForeColor = System.Drawing.Color.White;
            this.btnTools.Image = global::ControlPanel.Properties.Resources.briefcasesmall;
            this.btnTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.Location = new System.Drawing.Point(15, 196);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(170, 50);
            this.btnTools.TabIndex = 6;
            this.btnTools.Text = "Tools";
            this.btnTools.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTools.UseVisualStyleBackColor = false;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
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
            this.btnWorkorders.Location = new System.Drawing.Point(15, 252);
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
            this.pnlTop.Controls.Add(this.lblWelcome);
            this.pnlTop.Controls.Add(this.lblCurrently);
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
            this.pbxNIAR.Image = global::ControlPanel.Properties.Resources.NIAR1;
            this.pbxNIAR.Location = new System.Drawing.Point(558, 10);
            this.pbxNIAR.Name = "pbxNIAR";
            this.pbxNIAR.Size = new System.Drawing.Size(148, 65);
            this.pbxNIAR.TabIndex = 0;
            this.pbxNIAR.TabStop = false;
            this.pbxNIAR.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 10);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(181, 39);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome,";
            // 
            // lblCurrently
            // 
            this.lblCurrently.AutoSize = true;
            this.lblCurrently.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrently.ForeColor = System.Drawing.Color.White;
            this.lblCurrently.Location = new System.Drawing.Point(39, 53);
            this.lblCurrently.Name = "lblCurrently";
            this.lblCurrently.Size = new System.Drawing.Size(141, 20);
            this.lblCurrently.TabIndex = 1;
            this.lblCurrently.Text = "Your IP is currently";
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.Location = new System.Drawing.Point(200, 81);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(710, 420);
            this.pnlMain.TabIndex = 2;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.Text = "Control Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUpDoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDownDoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdminOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdminError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
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
        private System.Windows.Forms.Label lblCurrently;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.PictureBox pbxAdminError;
        private System.Windows.Forms.PictureBox pbxAdminOK;
        private System.Windows.Forms.Label lblAdminOK;
        private System.Windows.Forms.Label lblAdminError1;
        private System.Windows.Forms.Label lblAdminError2;
        public System.Windows.Forms.ListView lvwQueue;
        private System.Windows.Forms.ColumnHeader hdrProcName;
        private System.Windows.Forms.ColumnHeader hdrTime;
        private System.Windows.Forms.Label lblQueue;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbxDownDoot;
        private System.Windows.Forms.PictureBox pbxUpDoot;
    }
}

