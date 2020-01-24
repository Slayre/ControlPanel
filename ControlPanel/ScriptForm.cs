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

namespace ControlPanel
{
    public partial class ScriptForm : Form
    {
        string ouruser;
        Process process;
        Process catiaProcess;

        public ScriptForm()
        {
            InitializeComponent();
        }

        private void ScriptForm_Load(object sender, EventArgs e)
        {
            //Check if ScriptForm was loaded with admin privileges
            bool adminrights = IsUserAdministrator();
            if (adminrights == false)
                MessageBox.Show("Admin privileges are not on");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
        }

        private void btnSCBackup_Click_1(object sender, EventArgs e)
        {
            string path = "\\\\niar-fs1\\software\\sync center\\backupsynccenter.bat";
            ExecuteAsAdmin(path);
        }

        private void btnSCDisable_Click(object sender, EventArgs e)
        {
            string path = "\\\\niar-fs1\\software\\sync center\\disablesynccenter.bat";
            ExecuteAsAdmin(path);
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        //DOES work on student admin
        public void ExecuteAsAdmin(string fileName, string args = "")
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = fileName;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.Verb = "runas";
                proc.StartInfo.Arguments = args;
                proc.Start();
                //proc.WaitForExit();

            }
            catch(Exception e)
            {
                if (e is System.ComponentModel.Win32Exception)
                {
                    MessageBox.Show(e.Message);
                }
            }

        }

        public bool IsUserAdministrator()
        {
            bool isAdmin;
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException ex)
            {
                isAdmin = false;
            }
            catch (Exception ex)
            {
                isAdmin = false;
            }
            return isAdmin;
        }

        private void btnCATIA_Click(object sender, EventArgs e)
        {

            //uses lbxRevisions list of items to match the .bat file in the CATIA directory on network
            //concatenates frontpath + (our revision selected in lbxRevisions) + backpath = to get our full path
            string fullpath = "";
            string frontpath = "\\\\niar-fs1\\software\\catiav5\\CATIA_";
            string backpath = "_Install.bat";


            foreach(object itemChecked in lbxRevisions.CheckedItems)
            {
                fullpath = String.Concat(frontpath, itemChecked.ToString(), backpath);
                ExecuteAsAdmin(fullpath);
            }
        }

        private void lbxRevisions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            lbxRevisions.BackColor = System.Drawing.Color.LavenderBlush;
        }

        private void btnCCInstall_Click(object sender, EventArgs e)
        {
            string path = "\\\\niar-fs1\\software\\Adobe\\Adobe Creative Cloud 2018\\Master CC 2018 Installer.exe";
            ExecuteAsAdmin(path);
        }

        private void btnSophos_Click(object sender, EventArgs e)
        {
            string path = "\\\\niar-fs1\\software\\Sophos\\Client on the cloud\\SophosSetup.exe";
            ExecuteAsAdmin(path);
        }

        private void btnCompMgmt_Click(object sender, EventArgs e)
        {
            string path = "C:\\Windows\\System32\\mmc.exe";
            ExecuteAsAdmin(path, "compmgmt.msc");
        }

        private void btnAD_Click(object sender, EventArgs e)
        {
            
            string path = @"C:\WINDOWS\system32\mmc.exe";
            ExecuteAsAdmin(path,"dsa.msc");
        }

        private void btnAdminCenter_Click(object sender, EventArgs e)
        {
            string path = @"C:\Windows\System32\dsac.exe";
            ExecuteAsAdmin(path, "");
        }

        private void btnRDP_Click(object sender, EventArgs e)
        {
            string path = @"C:\Windows\System32\mstsc.exe";
            ExecuteAsAdmin(path);
        }
    }

}