using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Threading;
using System.Globalization;
using System.Windows.Forms;
using System.Security.Principal;
using System.Net.Sockets;
using System.Net;
using CefSharp;
using CefSharp.WinForms;
using System.Diagnostics;
using System.IO;

namespace ControlPanel
{
    public partial class MainScreen : Form
    {
        ChromiumWebBrowser browser = null;
        WindowsIdentity identity = WindowsIdentity.GetCurrent();
        Queue<Process> processQueue = new Queue<Process>();
        public string softwareshare = @"\\wsuniar\data\software";
        int openProcesses = 0;


        Form openForm;
        

        public MainScreen()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //checks if user is admin in order to notify them
            bool adminrights = IsUserAdministrator();
            if (adminrights == false)
            {
                pbxAdminError.Visible = true;
                lblAdminError1.Visible = true;
                lblAdminError2.Visible = true;

            }
            else
            {
                pbxAdminOK.Visible = true;
                lblAdminOK.Visible = true;

            }
            //splits username after domain (ie. user = wsuniar\\username)
            //var userName = identity.Name.Split('\\')[1];
            var userName = identity.Name.Split('\\')[1];
            lblName.Text = userName;
            //store local IP so we dont have to call this function twice for next line
            string localip = GetIPAddress();
            lblCurrently.Text = String.Format("Your IP is currently {0} on hostname {1}", localip, GetHostName(localip).Split('.')[0]);

            lvwQueue.ItemActivate += new EventHandler(lvwQueue_ItemActivate);


           //initiates browser
           browser = new ChromiumWebBrowser("https://niar.wichita.edu/ITWorkorders/Auth/Login.aspx?ReturnUrl=%2fITWorkorders%2fViewWorkorders");
            browser.FrameLoadStart += (o, ex) => browser.SetZoomLevel(-1.75);
            browser.Left = -10;


            //lvwSuccess.SmallImageList = imageList;

        }


        private string GetIPAddress()
        {
            string localIP;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                //pings Google's main DNS server (8.8.8.8) at port 65530 (TCP)
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
            return localIP;
        }

        //Workorder Button
        private void btnWorkorders_Click(object sender, EventArgs e)
        {
            OpenTab(3);
        }

        //Script button
        private void btnScripts_Click(object sender, EventArgs e)
        {
            OpenTab(1);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OpenTab(int id)
        {
            

            //Checks if this is the first time a form has been opened
            if (openForm == null)
            {
                //opens ScriptForm
                if (id == 1)
                {
                    openForm = new ScriptForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    openForm.FormBorderStyle = FormBorderStyle.None;
                    this.pnlMain.Controls.Add(openForm);
                    openForm.Show();
                }
                //opens ToolForm
                else if (id == 2)
                {
                    openForm = new ToolForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    openForm.FormBorderStyle = FormBorderStyle.None;
                    this.pnlMain.Controls.Add(openForm);
                    openForm.Show();
                }
                //opens WOForm
                else if (id == 3)
                {
                    openForm = new WOForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    openForm.FormBorderStyle = FormBorderStyle.None;
                    this.pnlMain.Controls.Add(openForm);
                    openForm.Controls.Add(browser);
                    browser.Dock = DockStyle.Fill;
                    openForm.Show();

                }
            }

            //openForm has already been opened
            else
            {
                //ScriptForm
                if (id == 1 && !(openForm is ScriptForm))
                {
                    
                    //because the WOForm is the only form with a browser --> the browser might not be open
                    //thus the try {} block trying the call and the catch {} to catch the exception incase there is no browser
                    try { openForm.Controls.Remove(browser); } catch (Exception ex) { }   //add to any closing that could be the workorder form
                    //Close previous openForm and set to NULL for new instance
                    openForm.Close();
                    openForm = null;
                    //Open form
                    openForm = new ScriptForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    openForm.FormBorderStyle = FormBorderStyle.None;
                    this.pnlMain.Controls.Add(openForm);
                    openForm.Show();
                }

                //ToolForm
                else if (id == 2 && !(openForm is ToolForm))
                {
                    //because the WOForm is the only form with a browser --> the browser might not be open
                    //thus the try {} block trying the call and the catch {} to catch the exception incase there is no browser
                    try { openForm.Controls.Remove(browser); } catch (Exception ex) { }   //add to any closing that could be the workorder form
                    //Close previous openForm and set to NULL for new instance
                    openForm.Close();
                    openForm = null;
                    //Open form
                    openForm = new ToolForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    openForm.FormBorderStyle = FormBorderStyle.None;
                    this.pnlMain.Controls.Add(openForm);
                    openForm.Show();
                }

                //WOForm
                else if (id == 3 && !(openForm is WOForm))
                {
                    //Close previous openForm and set to NULL for new instance
                    openForm.Close();
                    openForm = null;
                    //Open form
                    openForm = new WOForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    openForm.FormBorderStyle = FormBorderStyle.None;
                    this.pnlMain.Controls.Add(openForm);
                    openForm.Controls.Add(browser);
                    browser.Dock = DockStyle.Fill;
                    openForm.Show();

                }

            }
        }
        private void btnTools_Click(object sender, EventArgs e)
        {
            OpenTab(2);
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
        public void ExecuteAsAdmin(string fileName, string args = "")
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = fileName;
                proc.Exited += new EventHandler(ourProcess_Exited);
                //proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.Verb = "runas";
                proc.StartInfo.Arguments = args;
                proc.Start();
                string[] row = { fileName, DateTime.Now.ToString("h:mm tt")};
                ListViewItem lvi = new ListViewItem(row);

                //proc.WaitForExit();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public void queueProcess(Queue<Process> queue)
        {

                foreach (Process process in queue)
                 {
                    processQueue.Enqueue(process);
                    string name = Path.GetFileNameWithoutExtension(process.StartInfo.FileName);
                    string[] row = { name, DateTime.Now.ToString("h:mm tt")};
                    ListViewItem lvi = new ListViewItem(row);
                    lvwQueue.Items.Add(lvi);
                }
            if (!backgroundWorker1.IsBusy && processQueue.Count != 0)
            {
                backgroundWorker1.RunWorkerAsync();
            }

        }

        public void queueProcess(string fileName, string args = "")
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = fileName;
                proc.Exited += new EventHandler(ourProcess_Exited);
                proc.StartInfo.Verb = "runas";
                proc.StartInfo.Arguments = args;
                processQueue.Enqueue(proc);
                string name = Path.GetFileNameWithoutExtension(proc.StartInfo.FileName);
                string[] row = { name, DateTime.Now.ToString("h:mm tt")};
                ListViewItem lvi = new ListViewItem(row);
                lvwQueue.Items.Add(lvi);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            if(!backgroundWorker1.IsBusy && openProcesses == 0)
            {
                backgroundWorker1.RunWorkerAsync();
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            openProcesses++;
            try { 
            Process temp = processQueue.Dequeue();
            temp.Start();
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("You cannot queue up 0 items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            openProcesses--;
            if(openProcesses == 0 && processQueue.Count != 0)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void procCompleted()
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ourProcess_Exited(object sender, System.EventArgs e)
        {
        }


        public DialogResult InputBox(string title, string promptText, ref string value1, ref string value2)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox1 = new TextBox();
            TextBox textBox2 = new TextBox();
            Button buttonOk = new Button();


            form.Text = title;
            label.Text = promptText;
            textBox1.Text = value1;
            textBox2.Text = value2;

            buttonOk.Text = "OK";
            buttonOk.DialogResult = DialogResult.OK;


            label.SetBounds(9, 20, 372, 13);
            textBox1.SetBounds(25, 36, 250, 20);
            textBox2.SetBounds(25, 60, 250, 20);
            buttonOk.SetBounds(75, 90, 75, 23);


            label.AutoSize = true;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox1, textBox2, buttonOk });
            form.ClientSize = new Size(300, 125);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;

            DialogResult dialogResult = form.ShowDialog();
            value1 = textBox1.Text;
            value2 = textBox2.Text;
            return dialogResult;
        }
        

        public string GetHostName(string ipAddress)
        {
            try
            {
                var entry = Dns.GetHostEntry(ipAddress);
                if (entry != null)
                {
                    return entry.HostName;
                }
            }
            catch (SocketException ex)
            {
                //unknown host or
                //not every IP has a name
                //log exception (manage it)
            }

            return null;
        }

        private void lvwQueue_ItemActivate(object sender, EventArgs e)
        {
            pbxDownDoot.Image = Properties.Resources.downdoot;
            pbxUpDoot.Image = Properties.Resources.updoot;
            pbxDownDoot.Update();
            pbxUpDoot.Update();
        }

        private void lvwQueue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
