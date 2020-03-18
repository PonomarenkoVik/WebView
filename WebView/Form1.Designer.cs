using Microsoft.Toolkit.Forms.UI.Controls;

namespace WebViewBrowser
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
#pragma warning disable CS0618 // Type or member is obsolete
            this._webview = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
#pragma warning restore CS0618 // Type or member is obsolete
            ((System.ComponentModel.ISupportInitialize)(this._webview)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1170, 20);
            this.textBox1.TabIndex = 0;
            textBox1.KeyDown += TextBox1_KeyDown;
            // 
            // _webview
            // 
            this._webview.Dock = System.Windows.Forms.DockStyle.Fill;
            this._webview.Location = new System.Drawing.Point(0, 20);
            this._webview.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this._webview.Name = "_webview";
            this._webview.Size = new System.Drawing.Size(1170, 556);
            this._webview.TabIndex = 0;
            _webview.NavigationCompleted += _webview_NavigationCompleted;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 576);
            this.Controls.Add(this._webview);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._webview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion

        private System.Windows.Forms.TextBox textBox1;
#pragma warning disable CS0618 // Type or member is obsolete
        private WebView _webview;
#pragma warning restore CS0618 // Type or member is obsolete
    }
}

