namespace GUI.UserControls
{
    partial class UCForgotPassword
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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.linkLabelLoginHere = new System.Windows.Forms.LinkLabel();
            this.labelHaveAccount = new System.Windows.Forms.Label();
            this.TextBoxPhoneNumber = new GUI.UserControls.KDTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxUsername = new GUI.UserControls.KDTextBox();
            this.textBoxNewPass = new GUI.UserControls.KDTextBox();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSubmit.FlatAppearance.BorderSize = 0;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(259, 306);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(125, 50);
            this.buttonSubmit.TabIndex = 70;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            // 
            // linkLabelLoginHere
            // 
            this.linkLabelLoginHere.AutoSize = true;
            this.linkLabelLoginHere.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLoginHere.Location = new System.Drawing.Point(379, 495);
            this.linkLabelLoginHere.Name = "linkLabelLoginHere";
            this.linkLabelLoginHere.Size = new System.Drawing.Size(87, 18);
            this.linkLabelLoginHere.TabIndex = 69;
            this.linkLabelLoginHere.TabStop = true;
            this.linkLabelLoginHere.Text = "Login Here";
            // 
            // labelHaveAccount
            // 
            this.labelHaveAccount.AutoSize = true;
            this.labelHaveAccount.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHaveAccount.Location = new System.Drawing.Point(181, 495);
            this.labelHaveAccount.Name = "labelHaveAccount";
            this.labelHaveAccount.Size = new System.Drawing.Size(203, 18);
            this.labelHaveAccount.TabIndex = 68;
            this.labelHaveAccount.Text = "Already Have An Account?";
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.TextBoxPhoneNumber.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TextBoxPhoneNumber.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TextBoxPhoneNumber.BorderFocusColor = System.Drawing.Color.MediumBlue;
            this.TextBoxPhoneNumber.BorderRadius = 20;
            this.TextBoxPhoneNumber.BorderSize = 2;
            this.TextBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(137, 229);
            this.TextBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxPhoneNumber.Multiline = false;
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.TextBoxPhoneNumber.PasswordChar = false;
            this.TextBoxPhoneNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxPhoneNumber.PlaceholderText = "";
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(354, 43);
            this.TextBoxPhoneNumber.TabIndex = 65;
            this.TextBoxPhoneNumber.Texts = "";
            this.TextBoxPhoneNumber.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 61;
            this.label1.Text = "User Name";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.TextBoxUsername.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TextBoxUsername.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TextBoxUsername.BorderFocusColor = System.Drawing.Color.MediumBlue;
            this.TextBoxUsername.BorderRadius = 20;
            this.TextBoxUsername.BorderSize = 2;
            this.TextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsername.Location = new System.Drawing.Point(137, 139);
            this.TextBoxUsername.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxUsername.Multiline = false;
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.TextBoxUsername.PasswordChar = false;
            this.TextBoxUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxUsername.PlaceholderText = "";
            this.TextBoxUsername.Size = new System.Drawing.Size(354, 43);
            this.TextBoxUsername.TabIndex = 60;
            this.TextBoxUsername.Texts = "";
            this.TextBoxUsername.UnderlinedStyle = false;
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.textBoxNewPass.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxNewPass.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxNewPass.BorderFocusColor = System.Drawing.Color.MediumBlue;
            this.textBoxNewPass.BorderRadius = 20;
            this.textBoxNewPass.BorderSize = 2;
            this.textBoxNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPass.Location = new System.Drawing.Point(137, 407);
            this.textBoxNewPass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxNewPass.Multiline = false;
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.textBoxNewPass.PasswordChar = false;
            this.textBoxNewPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxNewPass.PlaceholderText = "";
            this.textBoxNewPass.Size = new System.Drawing.Size(354, 43);
            this.textBoxNewPass.TabIndex = 71;
            this.textBoxNewPass.Texts = "";
            this.textBoxNewPass.UnderlinedStyle = false;
            // 
            // UCForgotPassword
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBoxNewPass);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.linkLabelLoginHere);
            this.Controls.Add(this.labelHaveAccount);
            this.Controls.Add(this.TextBoxPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxUsername);
            this.Name = "UCForgotPassword";
            this.Size = new System.Drawing.Size(628, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.LinkLabel linkLabelLoginHere;
        private System.Windows.Forms.Label labelHaveAccount;
        private KDTextBox TextBoxPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private KDTextBox TextBoxUsername;
        private KDTextBox textBoxNewPass;
    }
}
