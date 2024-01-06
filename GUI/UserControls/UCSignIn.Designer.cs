namespace GUI.UserControls
{
    partial class UCSignIn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSignIn));
            this.linkLabelRegister = new System.Windows.Forms.LinkLabel();
            this.labelDontAccount = new System.Windows.Forms.Label();
            this.buttonLOGIN = new System.Windows.Forms.Button();
            this.linkLabelForgotPassword = new System.Windows.Forms.LinkLabel();
            this.checkBoxRemember = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.panelLinePassword = new System.Windows.Forms.Panel();
            this.panelLineUserName = new System.Windows.Forms.Panel();
            this.labelLoginTitle = new System.Windows.Forms.Label();
            this.pictureBoxLOGO = new System.Windows.Forms.PictureBox();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLOGO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelRegister
            // 
            this.linkLabelRegister.AutoSize = true;
            this.linkLabelRegister.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRegister.Location = new System.Drawing.Point(373, 480);
            this.linkLabelRegister.Name = "linkLabelRegister";
            this.linkLabelRegister.Size = new System.Drawing.Size(68, 18);
            this.linkLabelRegister.TabIndex = 41;
            this.linkLabelRegister.TabStop = true;
            this.linkLabelRegister.Text = "Register";
            this.linkLabelRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegister_LinkClicked);
            // 
            // labelDontAccount
            // 
            this.labelDontAccount.AutoSize = true;
            this.labelDontAccount.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDontAccount.Location = new System.Drawing.Point(190, 480);
            this.labelDontAccount.Name = "labelDontAccount";
            this.labelDontAccount.Size = new System.Drawing.Size(188, 18);
            this.labelDontAccount.TabIndex = 40;
            this.labelDontAccount.Text = "Don\'t Have An Account?";
            // 
            // buttonLOGIN
            // 
            this.buttonLOGIN.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLOGIN.FlatAppearance.BorderSize = 0;
            this.buttonLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLOGIN.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLOGIN.ForeColor = System.Drawing.Color.White;
            this.buttonLOGIN.Location = new System.Drawing.Point(254, 400);
            this.buttonLOGIN.Name = "buttonLOGIN";
            this.buttonLOGIN.Size = new System.Drawing.Size(125, 50);
            this.buttonLOGIN.TabIndex = 39;
            this.buttonLOGIN.Text = "LOGIN";
            this.buttonLOGIN.UseVisualStyleBackColor = false;
            this.buttonLOGIN.Click += new System.EventHandler(this.buttonLOGIN_Click);
            // 
            // linkLabelForgotPassword
            // 
            this.linkLabelForgotPassword.AutoSize = true;
            this.linkLabelForgotPassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelForgotPassword.Location = new System.Drawing.Point(398, 345);
            this.linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            this.linkLabelForgotPassword.Size = new System.Drawing.Size(124, 16);
            this.linkLabelForgotPassword.TabIndex = 38;
            this.linkLabelForgotPassword.TabStop = true;
            this.linkLabelForgotPassword.Text = "Forgot Password?";
            // 
            // checkBoxRemember
            // 
            this.checkBoxRemember.AutoSize = true;
            this.checkBoxRemember.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRemember.Location = new System.Drawing.Point(118, 344);
            this.checkBoxRemember.Name = "checkBoxRemember";
            this.checkBoxRemember.Size = new System.Drawing.Size(114, 21);
            this.checkBoxRemember.TabIndex = 37;
            this.checkBoxRemember.Text = "Remember me";
            this.checkBoxRemember.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxPassword.Location = new System.Drawing.Point(192, 290);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(259, 23);
            this.textBoxPassword.TabIndex = 36;
            this.textBoxPassword.Text = "Password";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserName.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxUserName.Location = new System.Drawing.Point(192, 230);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(259, 23);
            this.textBoxUserName.TabIndex = 35;
            this.textBoxUserName.Text = "UserName";
            // 
            // panelLinePassword
            // 
            this.panelLinePassword.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelLinePassword.Location = new System.Drawing.Point(152, 319);
            this.panelLinePassword.Name = "panelLinePassword";
            this.panelLinePassword.Size = new System.Drawing.Size(299, 4);
            this.panelLinePassword.TabIndex = 34;
            // 
            // panelLineUserName
            // 
            this.panelLineUserName.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelLineUserName.Location = new System.Drawing.Point(152, 259);
            this.panelLineUserName.Name = "panelLineUserName";
            this.panelLineUserName.Size = new System.Drawing.Size(299, 4);
            this.panelLineUserName.TabIndex = 32;
            // 
            // labelLoginTitle
            // 
            this.labelLoginTitle.AutoSize = true;
            this.labelLoginTitle.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginTitle.Location = new System.Drawing.Point(251, 153);
            this.labelLoginTitle.Name = "labelLoginTitle";
            this.labelLoginTitle.Size = new System.Drawing.Size(135, 41);
            this.labelLoginTitle.TabIndex = 30;
            this.labelLoginTitle.Text = "LOGIN";
            // 
            // pictureBoxLOGO
            // 
            this.pictureBoxLOGO.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLOGO.Image")));
            this.pictureBoxLOGO.Location = new System.Drawing.Point(238, 1);
            this.pictureBoxLOGO.Name = "pictureBoxLOGO";
            this.pictureBoxLOGO.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLOGO.TabIndex = 42;
            this.pictureBoxLOGO.TabStop = false;
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPassword.Image")));
            this.pictureBoxPassword.Location = new System.Drawing.Point(152, 283);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPassword.TabIndex = 33;
            this.pictureBoxPassword.TabStop = false;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.Location = new System.Drawing.Point(152, 223);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 31;
            this.pictureBoxUser.TabStop = false;
            // 
            // UCSignIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBoxLOGO);
            this.Controls.Add(this.linkLabelRegister);
            this.Controls.Add(this.labelDontAccount);
            this.Controls.Add(this.buttonLOGIN);
            this.Controls.Add(this.linkLabelForgotPassword);
            this.Controls.Add(this.checkBoxRemember);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.panelLinePassword);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.panelLineUserName);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.labelLoginTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCSignIn";
            this.Size = new System.Drawing.Size(628, 630);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLOGO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLOGO;
        private System.Windows.Forms.LinkLabel linkLabelRegister;
        private System.Windows.Forms.Label labelDontAccount;
        private System.Windows.Forms.Button buttonLOGIN;
        private System.Windows.Forms.LinkLabel linkLabelForgotPassword;
        private System.Windows.Forms.CheckBox checkBoxRemember;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Panel panelLinePassword;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.Panel panelLineUserName;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label labelLoginTitle;
    }
}
