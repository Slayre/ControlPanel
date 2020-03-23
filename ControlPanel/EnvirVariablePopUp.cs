using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace ControlPanel
{
    public partial class EnvirVariablePopUp : Form
    {
        private readonly MainScreen _parent;
        public EnvirVariablePopUp(MainScreen p)
        {
            this._parent = p;
            InitializeComponent();
        }

        private void pbxEnvironInfo_Click(object sender, EventArgs e)
        {
            string instructpath = Directory.GetCurrentDirectory() + @"\Instructions\EnvironVariableInfo.txt";
            string originalinstruct = File.ReadAllText(instructpath);

            //rtbx is not open, so read from file and set visibility = true
            if (rtbxEnvironInfo.Visible == false)
            {
                //set other infos visibility to false just in case

                rtbxEnvironInfo.Text = File.ReadAllText(instructpath);
                rtbxEnvironInfo.Visible = true;
            }
            //rtbx is open, so check for edits
            else
            {
                //if the current text in rtbxMatLabInfo != originalinstructions --> then we have a save dialog box
                if (!string.Equals(rtbxEnvironInfo.Text, originalinstruct))
                {
                    DialogResult saveBox = MessageBox.Show("Would you like to save your edits?", "Save Changes", MessageBoxButtons.YesNoCancel);
                    if (saveBox == DialogResult.Yes)
                    {
                        //saves from rtbxMatLabInfo.Text into instructpath and hides rtbx
                        File.WriteAllText(instructpath, rtbxEnvironInfo.Text);
                        rtbxEnvironInfo.Visible = false;
                    }
                    else if (saveBox == DialogResult.No)
                    {
                        //RichTextBox gets filled up with original content and is hidden
                        rtbxEnvironInfo.Text = File.ReadAllText(instructpath);
                        rtbxEnvironInfo.Visible = false;
                    }
                    else if (saveBox == DialogResult.Cancel)
                        //rtbx remains open
                        rtbxEnvironInfo.Visible = true;
                }
                //rtbx has been opened and was not edited so we just close the box.
                else
                    rtbxEnvironInfo.Visible = false;

            }
        }

        private void EnvirVariablePopUp_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\bats\SetVariable.bat";
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = path;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.Verb = "runas";
                proc.StartInfo.Arguments = tbxVariable.Text + " " + tbxValue.Text;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();

                //proc.WaitForExit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Successfully saved");
        }
    }

}

