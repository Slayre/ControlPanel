using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;


//TODO:
/*
    NEW COMPUTER BUTTON
        CHECK PROGRAM FILES FOR ALL DEFAULT PROGRAMS
            -INSTALL IF NOT PRESENT-
                Check if windows is pro -> switch to enterprise and activate
                Drivers?? - how to detect?
                MS Office 16 - and activate (simple cmd prompt)
                Adobe(Reader and Pro) - activate and see if licfix will be an issue
                Sophos
                Windows Updates
                See if BitLocker can be turned on
                Run remote settings script
                Run sync center disable script
                Run .Net 3.5 Fix

    .NET 3.5 BUTTON
        SHOULD BE SIMPLE BAT FILE THAT CHANGES WUSERVER AND THEN DOWNLOADS IT



  COMPLETED:
    SAVE AND EDIT FEATURES FOR NEW INSTRUCTIONS
    POWER OPTIONS BUTTON 



  BUTTONS THAT QUEUE RATHER THAN EXECUTE AS ADMIN:
    SYNC CENTER (BACKUP)
    SYNC CENTER (DISABLE)
    INSTALL .NET 3.5








*/

namespace ControlPanel
{
    public partial class ToolForm : Form
    {
        private readonly MainScreen _parent;
        public ToolForm(MainScreen p)
        {
            this._parent = p;
            InitializeComponent();
        }

        private void btnAD_Click(object sender, EventArgs e)
        {
            string path = @"C:\WINDOWS\system32\mmc.exe";
            this._parent.ExecuteAsAdmin(path, "dsa.msc");
        }

        private void btnCompMgmt_Click(object sender, EventArgs e)
        {
            string path = @"C:\Windows\System32\mmc.exe";
            this._parent.queueProcess(path, "compmgmt.msc");
            if (!this._parent.backgroundWorker1.IsBusy)
            {
                this._parent.backgroundWorker1.RunWorkerAsync();
            }
        }
        private void btnRDP_Click(object sender, EventArgs e)
        {
            string path = @"C:\Windows\System32\mstsc.exe";
            this._parent.queueProcess(path);
            if (!this._parent.backgroundWorker1.IsBusy)
            {
                this._parent.backgroundWorker1.RunWorkerAsync();
            }
        }

        private void btnCCInstall_Click(object sender, EventArgs e)
        {
            string path = this._parent.softwareshare + @"\Adobe\Adobe Creative Cloud 2018\Master CC 2018 Installer.exe";
            this._parent.queueProcess(path);
            if (!this._parent.backgroundWorker1.IsBusy)
            {
                this._parent.backgroundWorker1.RunWorkerAsync();
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string path = @".\bats\WUServerAndUpdate.bat";
            this._parent.queueProcess(path);
            if (!this._parent.backgroundWorker1.IsBusy)
            {
                this._parent.backgroundWorker1.RunWorkerAsync();
            }
        }
        private void btnRemoteSettings_Click(object sender, EventArgs e)
        {
            string path = @".\bats\RemoteSettings.bat";
            this._parent.ExecuteAsAdmin(path);
        }

        private void btnSCBackup_Click(object sender, EventArgs e)
        {
            string path = @".\bats\backupsynccenter.bat";
            this._parent.ExecuteAsAdmin(path);
        }

        private void btnSCDisable_Click(object sender, EventArgs e)
        {
            string path = @".\bats\disablesynccenter.bat";
            this._parent.ExecuteAsAdmin(path);
        }

        private void btnDotNetInstall_Click(object sender, EventArgs e)
        {

        }

        private void btnPowerOpt_Click(object sender, EventArgs e)
        {
            string path = @".\bats\PowerOptions.bat";
            this._parent.ExecuteAsAdmin(path);
        }

        private void btnEnvirVariables_Click(object sender, EventArgs e)
        {
            Form EnvirVariablePopUp = new EnvirVariablePopUp(this._parent);
            EnvirVariablePopUp.ShowDialog();
        }

        private void btnReloadProf_Click(object sender, EventArgs e)
        {
            string profile = tbxProfileName.Text;
            string profilepath = @"C:\Users\" + profile;

            //ON 1ST BUTTON PRESS: If there is no profile.old folder already then it will rename the current profile to .old
            //ON 2ND BUTTON PRESS: It will copy over the old profile to the new one
            // ^^^^ this is due to how the bat file is written
            string exepath = @".\bats\copyprofile.bat";
            this._parent.ExecuteAsAdmin(exepath, profile);

            //!!SHOULD ONLY TRIGGER ON THE FIRST BUTTON PRESS!!
            //this is unless the user already has .old profile that we have reloaded before.
            if (!Directory.Exists(profilepath + ".old") && Directory.Exists(profilepath))
            {
                RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\ProfileList");
                foreach (var v in rk.GetSubKeyNames())
                {
                    RegistryKey userKey = rk.OpenSubKey(v);
                    if (userKey != null)
                    {
                        string keyValue = Convert.ToString(userKey.GetValue("ProfileImagePath"));
                        if (keyValue.Equals(@"C:\Users\" + profile, StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show(userKey.Name, "Hopefully user");
                            try
                            {
                                rk.DeleteSubKeyTree(userKey.Name, true);
                            }
                            catch(Exception exec)
                            {
                                MessageBox.Show(exec.Message);
                            }
                        }
                    }
                }
            }


        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            string path = @".\bats\updateDesc.vbs";
            this._parent.ExecuteAsAdmin("cscript", path);
        }
    }
}
