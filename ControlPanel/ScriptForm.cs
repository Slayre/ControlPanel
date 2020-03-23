using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security;
using System.Security.Principal;
using System.IO;

namespace ControlPanel
{
    public partial class ScriptForm : Form
    {
        //keeps count of the amount of open catia programs
        //CATIA had issues installing two revisions at once so max openCatias == 1
        private readonly MainScreen _parent;
        RichTextBox openInfoBox = new RichTextBox();

        public ScriptForm(MainScreen p)
        {
            this._parent = p;
            InitializeComponent();


            pbxCATIAInfo.Click += new EventHandler(infoClick);
            pbxCATIAV6Info.Click += new EventHandler(infoClick);
            pbxMatlabInfo.Click += new EventHandler(infoClick);

        }

        private void ScriptForm_Load(object sender, EventArgs e)
        {
            DirectoryInfo matlabpath = new DirectoryInfo(this._parent.softwareshare + @"\Matlab-Mathworks");
            foreach (DirectoryInfo dir in matlabpath.EnumerateDirectories())
            {
                if (dir.Name.Contains("20"))
                {
                    lbxMatlab.Items.Add(dir.Name);
                }
            }
            DirectoryInfo catiav5path = new DirectoryInfo(this._parent.softwareshare + @"\catiav5\");
            foreach (FileInfo file in catiav5path.GetFiles())
            {
                if (file.Extension == ".bat" && file.Name.Contains("CATIA_5"))
                {
                    string filename = file.Name.Substring(6).Split('.')[0];
                    lbxRevisionsV5.Items.Add(filename);
                }
            }
            DirectoryInfo catiav6path = new DirectoryInfo(this._parent.softwareshare + @"\catiav6\");
            foreach (DirectoryInfo dir in catiav6path.EnumerateDirectories())
            {
                if (dir.Name.Contains("client") || dir.Name.Contains("Client"))
                {

                    lbxRevisionsV6.Items.Add(dir.Name);
                }
            }


        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnCATIA_Click(object sender, EventArgs e)
        {
            //because the first 5 characters are excluded in the .bat filename 
            //when the items are added to the list, so we include it in our front path
            string fullpath = "";
            string frontpath = this._parent.softwareshare + @"\catiav5\CATIA_";

            Queue<Process> ourprocesses = new Queue<Process>();
            foreach (object itemChecked in lbxRevisionsV5.CheckedItems)
            {
                fullpath = frontpath + itemChecked.ToString() + ".bat";
                MessageBox.Show(fullpath);

                Process ourProcess = new Process();
                ourProcess.Exited += new EventHandler(this._parent.ourProcess_Exited);
                ourProcess.StartInfo.FileName = fullpath;
                ourProcess.EnableRaisingEvents = true;
                ourProcess.StartInfo.UseShellExecute = false;
                ourProcess.StartInfo.Verb = "runas";

                ourprocesses.Enqueue(ourProcess);

            }

            this._parent.queueProcess(ourprocesses);

        }


        private void lbxRevisions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            lbxRevisionsV5.BackColor = System.Drawing.Color.LavenderBlush;
        }

        private void btnSophos_Click(object sender, EventArgs e)
        {
            string path = @".\bats\SophosInstall.bat";
            this._parent.queueProcess(path);
        }


        private void btnTight_Click(object sender, EventArgs e)
        {
            string path = this._parent.softwareshare + @"\TightVNC\tightvncsetup.bat";
            this._parent.ExecuteAsAdmin(path);

        }

        private void btnMatlab_Click(object sender, EventArgs e)
        {
            //copies network.lic from Matlab directory and pastes on current user's desktop
            //for the install.
            string licsrcpath = this._parent.softwareshare + @"\Matlab-Mathworks\network.lic";
            string userdesktoppath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string licdestpath = userdesktoppath + "\\network.lic";
            //true param just overwrites file if it exists
            System.IO.File.Copy(licsrcpath, licdestpath, true);

            //executes
            string fullpath = "";
            string frontpath = this._parent.softwareshare + @"\Matlab-Mathworks\";
            string backpath = @"\setup.exe";
            string altpath = @"\bin\win64\setup.exe";

            Queue<Process> ourprocesses = new Queue<Process>();
            foreach (object itemChecked in lbxMatlab.CheckedItems)
            {
                //fullpath = "\\\\niar-fs1\\software\\Matlab-Mathworks\\20XXX\\setup.exe""
                fullpath = String.Concat(frontpath, itemChecked.ToString(), backpath);
                if (Directory.Exists(fullpath))
                {
                    Process ourProcess = new Process();
                    ourProcess.StartInfo.FileName = fullpath;
                    ourProcess.Exited += new EventHandler(this._parent.ourProcess_Exited);
                    ourProcess.EnableRaisingEvents = true;
                    ourProcess.StartInfo.UseShellExecute = false;
                    ourProcess.StartInfo.Verb = "runas";

                    ourprocesses.Enqueue(ourProcess);
                }
                else
                {
                    //fullpath = "\\\\niar-fs1\\software\\Matlab-Mathworks\\20XX\\\\bin\\win64\\setup.exe"
                    fullpath = String.Concat(frontpath, itemChecked.ToString(), altpath);
                    Process ourProcess = new Process();
                    ourProcess.StartInfo.FileName = fullpath;
                    ourProcess.Exited += new EventHandler(this._parent.ourProcess_Exited);
                    ourProcess.EnableRaisingEvents = true;
                    ourProcess.StartInfo.UseShellExecute = false;
                    ourProcess.StartInfo.Verb = "runas";

                    ourprocesses.Enqueue(ourProcess);
                }
            }

            this._parent.queueProcess(ourprocesses);
            if (!this._parent.backgroundWorker1.IsBusy)
            {
                this._parent.backgroundWorker1.RunWorkerAsync();
            }

        }

        private void pbxMatlabInfo_Click(object sender, EventArgs e)
        {
            //instruction path and the original contents of what MatLabInfo.txt contains on click.
            string instructpath = @".\Instructions\MatLabInfo.txt";
            Point location = new Point((pbxMatlabInfo.Location.X - rtbxMatlabInfo.Size.Width), pbxMatlabInfo.Location.Y);
            info_Click(rtbxMatlabInfo, instructpath, location);

        }

        private void pbxCATIAInfo_Click(object sender, EventArgs e)
        {
            //instruction path and the original contents of what MatLabInfo.txt contains on click.
            string instructpath = @".\Instructions\CATIAV5Info.txt";
            Point location = new Point((pbxCATIAInfo.Location.X - rtbxCATIAv5Info.Size.Width), pbxCATIAInfo.Location.Y);
            info_Click(rtbxCATIAv5Info, instructpath, location);

        }

        private void info_Click(RichTextBox rtbxInfo, string instructpath, Point p)
        {
            string originalinstruct = File.ReadAllText(instructpath);
            rtbxInfo.Location = p;
            //rtbx is not open, so read from file and set visibility = true
            if (openInfoBox.Visible == false || openInfoBox == null)
            {
                //set other infos visibility to false just in case
                openInfoBox = rtbxInfo;
                openInfoBox.Location = p;
                openInfoBox.Text = File.ReadAllText(instructpath);
                openInfoBox.Visible = true;
            }
            //rtbx is open, so check for edits
            else
            {
                //if the current text in rtbxMatLabInfo != originalinstructions --> then we have a save dialog box
                if (p != openInfoBox.Location && !string.Equals(openInfoBox.Text, originalinstruct))
                {
                    DialogResult saveBox = MessageBox.Show("Would you like to save your edits?", "Save Changes", MessageBoxButtons.YesNoCancel);
                    if (saveBox == DialogResult.Yes)
                    {
                        //saves from rtbxMatLabInfo.Text into instructpath and hides rtbx
                        openInfoBox.Visible = false;
                        File.WriteAllText(instructpath, openInfoBox.Text);
                        openInfoBox.Visible = false;
                    }
                    else if (saveBox == DialogResult.No)
                    {
                        //RichTextBox gets filled up with original content and is hidden
                        openInfoBox.Visible = false;
                        openInfoBox.Text = File.ReadAllText(instructpath);
                        openInfoBox.Visible = false;
                    }
                    else if (saveBox == DialogResult.Cancel)
                    {
                        //rtbx remains open
                        rtbxInfo.Visible = true;
                        openInfoBox.Visible = true;
                    }

                }
                //rtbx has been opened and was not edited so we just close the box.
                else if (p != openInfoBox.Location && string.Equals(openInfoBox.Text, originalinstruct))
                {
                    openInfoBox.Visible = false;
                    openInfoBox = rtbxInfo;
                    openInfoBox.Text = File.ReadAllText(instructpath);
                    openInfoBox.Location = p;
                    openInfoBox.Visible = true;
                }
                else if (p == openInfoBox.Location && !string.Equals(openInfoBox.Text, originalinstruct))
                {

                }
                else if (p == openInfoBox.Location && string.Equals(openInfoBox.Text, originalinstruct))
                {

                }
            }
        }

        private void infoClick(object sender, EventArgs e)
        {
            PictureBox btnClicked = sender as PictureBox;
            if (btnClicked.Name == "pbxCATIAInfo")
            {
                MessageBox.Show("HI");
            }
            else if (btnClicked.Name == "pbxCATIAV6Info")
            {

            }
            else if (btnClicked.Name == "pbxMatlabInfo")
            {

            }

        }


        private void lbxMatlab_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            lbxMatlab.BackColor = System.Drawing.Color.LavenderBlush;
        }

        private void pbxCATIAV6Info_Click(object sender, EventArgs e)
        {
            //instruction path and the original contents of what MatLabInfo.txt contains on click.
            string instructpath = @".\Instructions\CATIAV6Info.txt";
            Point location = new Point((pbxCATIAV6Info.Location.X - rtbxCATIAv6Info.Size.Width), pbxCATIAV6Info.Location.Y);
            info_Click(rtbxCATIAv5Info, instructpath, location);
        }

        private void btnCATIAV6_Click(object sender, EventArgs e)
        {
            string path = this._parent.softwareshare + @"\CATIAV6\";

            foreach( object itemChecked in lbxRevisionsV6.CheckedItems)
            {
                DirectoryInfo version = new DirectoryInfo(path + itemChecked.ToString());
                foreach (FileInfo file in version.GetFiles())
                {
                    if (file.Name.Contains("Setup") || file.Name.Contains("setup"))
                    {
                        string fullpath = version.FullName + @"\" + file.Name;
                        this._parent.queueProcess(fullpath);
                    }
                }
            }
            //this._parent.ExecuteAsAdmin(path);
        }
    }
}

