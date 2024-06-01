using System;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using EasyTabs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace RewindBrowser
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser browser;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            browser = new ChromiumWebBrowser("https://google.com.tr");
            browser.Load("https://google.com.tr");
            browser.Dock = DockStyle.Fill;
            panel1.Controls.Add(browser);
        }
    }
}
