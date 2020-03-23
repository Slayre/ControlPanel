using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace ControlPanel
{
    public partial class WOForm : Form
    {
        //public ChromiumWebBrowser browser;
        public WOForm()
        {
            InitializeComponent();
            //browser = brow;
        }

        private void WOForm_Load(object sender, EventArgs e)
        {
            //GetHtmlAsync();
            //if (browser == null) { MessageBox.Show("new"); browser = new ChromiumWebBrowser("https://niar.wichita.edu/ITWorkorders/Auth/Login.aspx?ReturnUrl=%2fITWorkorders%2fViewWorkorders"); }
            
        }

        private static async void GetHtmlAsync()
        {
            //var url = "https://niar.wichita.edu/ITWorkorders/Auth/Login.aspx?ReturnUrl=%2fITWorkorders%2fViewWorkorders";

            //var httpClient = new HttpClient();
            //var html = await httpClient.GetStringAsync();


        }
    }
}
