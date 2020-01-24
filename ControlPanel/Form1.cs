using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;

namespace ControlPanel
{
    public partial class MainScreen : Form
    {

        WindowsIdentity identity = WindowsIdentity.GetCurrent();
        Form openForm;
        public MainScreen()
        {
            InitializeComponent();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var userName = identity.Name.Split('\\')[1];
            lblName.Text = userName;
        }

        //Workorder Button
        private void btnWorkorders_Click(object sender, EventArgs e)
        {
            OpenTab(2);
        }

        //Script button
        private void btnScripts_Click(object sender, EventArgs e)
        {
            OpenTab(1);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                    openForm = new ScriptForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    openForm.FormBorderStyle = FormBorderStyle.None;
                    this.pnlMain.Controls.Add(openForm);
                    openForm.Show();
                }
                //opens WOForm
                else if (id == 2)
                {
                    openForm = new WOForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    openForm.FormBorderStyle = FormBorderStyle.None;
                    this.pnlMain.Controls.Add(openForm);
                    openForm.Show();

                }
            }
            //openForm is already open
            else
            {
                //ScriptForm
                if (id == 1 && !(openForm is ScriptForm))
                {
                    //Close previous openForm and set to NULL for new instance
                    openForm.Close();
                    openForm = null;
                    //Open form
                    openForm = new ScriptForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    openForm.FormBorderStyle = FormBorderStyle.None;
                    this.pnlMain.Controls.Add(openForm);
                    openForm.Show();
                }
                //WOForm
                else if (id == 2 && !(openForm is WOForm))
                {
                    //Close previous openForm and set to NULL for new instance
                    openForm.Close();
                    openForm = null;
                    //Open form
                    openForm = new WOForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    openForm.FormBorderStyle = FormBorderStyle.None;
                    this.pnlMain.Controls.Add(openForm);
                    openForm.Show();

                }
            }
        }

        private void pnlSide_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
