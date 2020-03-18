using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Toolkit.Forms.UI.Controls;

namespace WebViewBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void TextBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || string.IsNullOrEmpty(textBox1.Text))
                return;
            try
            {
                Uri url = new Uri(textBox1.Text.StartsWith("http") ? textBox1.Text : $"http://{textBox1.Text}");
                _webview.Source = url;
            }
            catch  { }         
        }

        private void _webview_NavigationCompleted(object sender, WebViewControlNavigationCompletedEventArgs e)
        {
            textBox1.Text = e.Uri.AbsoluteUri;
        }
    }
}
