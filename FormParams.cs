using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OutlookLocker
{
    public partial class FormParams : Form
    {
        public FormParams()
        {
            InitializeComponent();
        }

        private void cbOldPassword_CheckedChanged(object sender, EventArgs e)
        {
            this.tbOldPassword.UseSystemPasswordChar = !this.tbOldPassword.UseSystemPasswordChar;
        }

        private void cbNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            this.tbNewPassword.UseSystemPasswordChar = !this.tbNewPassword.UseSystemPasswordChar;
        }

        private void cbConfirmNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            this.tbNewPasswordConfirm.UseSystemPasswordChar = !this.tbNewPasswordConfirm.UseSystemPasswordChar;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<SQLiteValue> values = SQLite.LoadParams();
            if (values == null && values.Count == 0)
            {
                MessageBox.Show(this, "Values is not load!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (values.FirstOrDefault(x => x.name == "Password").value == "")
            {
                MessageBox.Show(this, "Password is empty!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TIСryptographer.Cryptographer.Decrypt(values.FirstOrDefault(x => x.name == "Password").value) != this.tbOldPassword.Text)
            {
                MessageBox.Show(this, "Password is not correct!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            if (this.tbNewPassword.Text != this.tbNewPasswordConfirm.Text)
            {
                MessageBox.Show(this, "New password is not confirm!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            bool result = SQLite.SaveParams(this.tbOldPassword.Text);
            if (result)
            {
                MessageBox.Show(this, "Password is changed!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "Password is no changed!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
