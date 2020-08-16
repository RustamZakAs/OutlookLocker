using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace OutlookLocker
{
    public partial class FormLocker : Form
    {
        public bool IsPasswordShow { get; set; } = false;

        public FormLocker()
        {
            InitializeComponent();
        }

        private void pbPasswordShow_Click(object sender, EventArgs e)
        {
            if (IsPasswordShow)
            {
                IsPasswordShow = false;
                this.tbPassword.UseSystemPasswordChar = true;
                this.pbPasswordShow.BackgroundImage = OutlookLocker.Properties.Resources.EyeUnShow;
            }
            else
            {
                IsPasswordShow = true;
                this.tbPassword.UseSystemPasswordChar = false;
                this.pbPasswordShow.BackgroundImage = OutlookLocker.Properties.Resources.EyeShow;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<SQLiteValue> values = SQLite.LoadParams();
            if (values == null || values.Count == 0)
            {
                MessageBox.Show(this, "Values is empty!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string pass = this.tbPassword.Text;

            if (pass.Length == 0 || pass.Trim().Length == 0)
            {
                MessageBox.Show(this, "Password is empty!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string password = values.FirstOrDefault(x => x.name == "Password").value;
            if (password == pass)
            {
                try
                {
                    if (isOutlook())
                    {
                        OutlookLocker.WindowState.Hide("OutlookLocker");
                        //this.Hide();
                        //this.Close();
                    }
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.Message);
                    return;
                    throw;
                }
            }
            else
            {
                this.tbPassword.Text = string.Empty;
            }
        }

        private bool isOutlook()
        {
            Microsoft.Win32.RegistryKey key =
                Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\microsoft\\windows\\currentversion\\app paths\\OUTLOOK.EXE");
            string path = (string)key.GetValue("Path");
            if (path != null)
            {
                var process = System.Diagnostics.Process.Start(Path.Combine(path,"OUTLOOK.EXE"));
                Program.OutlookId = process.Id;
                return true;
            }
            else
            {
                MessageBox.Show("There is no Outlook in this computer!", "SystemError", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            this.lblClose.BackColor = Color.Red;
            this.lblClose.ForeColor = Color.White;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            this.lblClose.BackColor = Color.FromArgb(2, 112, 197);
            this.lblClose.ForeColor = Color.Red;
        }

        private void pbPasswordShow_MouseEnter(object sender, EventArgs e)
        {
            this.pbPasswordShow.BackColor = Color.Silver;
        }

        private void pbPasswordShow_MouseLeave(object sender, EventArgs e)
        {
            this.pbPasswordShow.BackColor = Color.FromArgb(2, 112, 197);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1401:P/Invokes should not be visible", Justification = "<Pending>")]
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1401:P/Invokes should not be visible", Justification = "<Pending>")]
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void pbLogo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pbParams_Click(object sender, EventArgs e)
        {
            FormParams formParams = new FormParams();
            formParams.Owner = this;
            formParams.ShowDialog();
        }
    }
}
