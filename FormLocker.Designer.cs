namespace OutlookLocker
{
    partial class FormLocker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLocker));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblBy = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pbPasswordShow = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.pbParams = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParams)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(457, 230);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbLogo_MouseDown);
            // 
            // lblBy
            // 
            this.lblBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBy.AutoSize = true;
            this.lblBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(112)))), ((int)(((byte)(197)))));
            this.lblBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblBy.ForeColor = System.Drawing.Color.White;
            this.lblBy.Location = new System.Drawing.Point(352, 3);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(102, 15);
            this.lblBy.TabIndex = 1;
            this.lblBy.Text = "by Rustam Zak As";
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(112)))), ((int)(((byte)(197)))));
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbPassword.Location = new System.Drawing.Point(189, 195);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(192, 27);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbPassword_PreviewKeyDown);
            // 
            // pbPasswordShow
            // 
            this.pbPasswordShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPasswordShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPasswordShow.BackgroundImage")));
            this.pbPasswordShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPasswordShow.Location = new System.Drawing.Point(344, 197);
            this.pbPasswordShow.Name = "pbPasswordShow";
            this.pbPasswordShow.Size = new System.Drawing.Size(35, 23);
            this.pbPasswordShow.TabIndex = 3;
            this.pbPasswordShow.TabStop = false;
            this.pbPasswordShow.Click += new System.EventHandler(this.pbPasswordShow_Click);
            this.pbPasswordShow.MouseEnter += new System.EventHandler(this.pbPasswordShow_MouseEnter);
            this.pbPasswordShow.MouseLeave += new System.EventHandler(this.pbPasswordShow_MouseLeave);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.Silver;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOk.Location = new System.Drawing.Point(384, 195);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(66, 27);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(259, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Locker";
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.Red;
            this.lblClose.Location = new System.Drawing.Point(-5, -2);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(31, 28);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = " X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // pbParams
            // 
            this.pbParams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbParams.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbParams.BackgroundImage")));
            this.pbParams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbParams.Location = new System.Drawing.Point(162, 195);
            this.pbParams.Name = "pbParams";
            this.pbParams.Size = new System.Drawing.Size(27, 27);
            this.pbParams.TabIndex = 3;
            this.pbParams.TabStop = false;
            this.pbParams.Click += new System.EventHandler(this.pbParams_Click);
            // 
            // FormLocker
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(112)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(457, 230);
            this.Controls.Add(this.pbParams);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pbPasswordShow);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblBy);
            this.Controls.Add(this.pbLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLocker";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outlook Locker";
            this.Shown += new System.EventHandler(this.FormLocker_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox pbPasswordShow;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.PictureBox pbParams;
    }
}

