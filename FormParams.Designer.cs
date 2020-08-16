namespace OutlookLocker
{
    partial class FormParams
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
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.tbNewPasswordConfirm = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOldPassword = new System.Windows.Forms.CheckBox();
            this.cbNewPassword = new System.Windows.Forms.CheckBox();
            this.cbConfirmNewPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.Location = new System.Drawing.Point(137, 12);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.Size = new System.Drawing.Size(173, 23);
            this.tbOldPassword.TabIndex = 0;
            this.tbOldPassword.UseSystemPasswordChar = true;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(137, 41);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(173, 23);
            this.tbNewPassword.TabIndex = 0;
            this.tbNewPassword.UseSystemPasswordChar = true;
            // 
            // tbNewPasswordConfirm
            // 
            this.tbNewPasswordConfirm.Location = new System.Drawing.Point(137, 70);
            this.tbNewPasswordConfirm.Name = "tbNewPasswordConfirm";
            this.tbNewPasswordConfirm.Size = new System.Drawing.Size(173, 23);
            this.tbNewPasswordConfirm.TabIndex = 0;
            this.tbNewPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(224, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Old password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "New password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm new password:";
            // 
            // cbOldPassword
            // 
            this.cbOldPassword.AutoSize = true;
            this.cbOldPassword.Location = new System.Drawing.Point(312, 17);
            this.cbOldPassword.Name = "cbOldPassword";
            this.cbOldPassword.Size = new System.Drawing.Size(15, 14);
            this.cbOldPassword.TabIndex = 3;
            this.cbOldPassword.UseVisualStyleBackColor = true;
            this.cbOldPassword.CheckedChanged += new System.EventHandler(this.cbOldPassword_CheckedChanged);
            // 
            // cbNewPassword
            // 
            this.cbNewPassword.AutoSize = true;
            this.cbNewPassword.Location = new System.Drawing.Point(312, 45);
            this.cbNewPassword.Name = "cbNewPassword";
            this.cbNewPassword.Size = new System.Drawing.Size(15, 14);
            this.cbNewPassword.TabIndex = 3;
            this.cbNewPassword.UseVisualStyleBackColor = true;
            this.cbNewPassword.CheckedChanged += new System.EventHandler(this.cbNewPassword_CheckedChanged);
            // 
            // cbConfirmNewPassword
            // 
            this.cbConfirmNewPassword.AutoSize = true;
            this.cbConfirmNewPassword.Location = new System.Drawing.Point(312, 74);
            this.cbConfirmNewPassword.Name = "cbConfirmNewPassword";
            this.cbConfirmNewPassword.Size = new System.Drawing.Size(15, 14);
            this.cbConfirmNewPassword.TabIndex = 3;
            this.cbConfirmNewPassword.UseVisualStyleBackColor = true;
            this.cbConfirmNewPassword.CheckedChanged += new System.EventHandler(this.cbConfirmNewPassword_CheckedChanged);
            // 
            // FormParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(331, 136);
            this.Controls.Add(this.cbConfirmNewPassword);
            this.Controls.Add(this.cbNewPassword);
            this.Controls.Add(this.cbOldPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbNewPasswordConfirm);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.tbOldPassword);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormParams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Params";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.TextBox tbNewPasswordConfirm;
        private System.Windows.Forms.CheckBox cbNewPassword;
        private System.Windows.Forms.CheckBox cbOldPassword;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.CheckBox cbConfirmNewPassword;
    }
}