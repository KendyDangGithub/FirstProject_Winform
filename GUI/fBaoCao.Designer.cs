namespace GUI
{
    partial class fTaiKhoan
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
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelTotalPages = new System.Windows.Forms.Label();
            this.labelCurrentPage = new System.Windows.Forms.Label();
            this.buttonNext2 = new System.Windows.Forms.Button();
            this.buttonNext1 = new System.Windows.Forms.Button();
            this.buttonUndo1 = new System.Windows.Forms.Button();
            this.buttonUndo2 = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.groupBoxChuyenNganh = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.labelTenNganh = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelMaNganh = new System.Windows.Forms.Label();
            this.dataGridViewContent = new System.Windows.Forms.DataGridView();
            this.ButtonDel = new FontAwesome.Sharp.IconButton();
            this.ButtonUpdate = new FontAwesome.Sharp.IconButton();
            this.panelFooter.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.groupBoxChuyenNganh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContent)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelFooter.Controls.Add(this.labelTotalPages);
            this.panelFooter.Controls.Add(this.labelCurrentPage);
            this.panelFooter.Controls.Add(this.buttonNext2);
            this.panelFooter.Controls.Add(this.buttonNext1);
            this.panelFooter.Controls.Add(this.buttonUndo1);
            this.panelFooter.Controls.Add(this.buttonUndo2);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 731);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1386, 50);
            this.panelFooter.TabIndex = 6;
            // 
            // labelTotalPages
            // 
            this.labelTotalPages.AutoSize = true;
            this.labelTotalPages.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPages.Location = new System.Drawing.Point(949, 16);
            this.labelTotalPages.Name = "labelTotalPages";
            this.labelTotalPages.Size = new System.Drawing.Size(19, 21);
            this.labelTotalPages.TabIndex = 2;
            this.labelTotalPages.Text = "1";
            // 
            // labelCurrentPage
            // 
            this.labelCurrentPage.AutoSize = true;
            this.labelCurrentPage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPage.Location = new System.Drawing.Point(878, 16);
            this.labelCurrentPage.Name = "labelCurrentPage";
            this.labelCurrentPage.Size = new System.Drawing.Size(76, 21);
            this.labelCurrentPage.TabIndex = 1;
            this.labelCurrentPage.Text = "Trang: 1/";
            // 
            // buttonNext2
            // 
            this.buttonNext2.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext2.ForeColor = System.Drawing.Color.White;
            this.buttonNext2.Location = new System.Drawing.Point(1076, 7);
            this.buttonNext2.Name = "buttonNext2";
            this.buttonNext2.Size = new System.Drawing.Size(80, 40);
            this.buttonNext2.TabIndex = 0;
            this.buttonNext2.Text = ">>";
            this.buttonNext2.UseVisualStyleBackColor = false;
            // 
            // buttonNext1
            // 
            this.buttonNext1.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext1.ForeColor = System.Drawing.Color.White;
            this.buttonNext1.Location = new System.Drawing.Point(990, 7);
            this.buttonNext1.Name = "buttonNext1";
            this.buttonNext1.Size = new System.Drawing.Size(80, 40);
            this.buttonNext1.TabIndex = 0;
            this.buttonNext1.Text = ">";
            this.buttonNext1.UseVisualStyleBackColor = false;
            // 
            // buttonUndo1
            // 
            this.buttonUndo1.BackColor = System.Drawing.Color.Transparent;
            this.buttonUndo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUndo1.ForeColor = System.Drawing.Color.White;
            this.buttonUndo1.Location = new System.Drawing.Point(776, 7);
            this.buttonUndo1.Name = "buttonUndo1";
            this.buttonUndo1.Size = new System.Drawing.Size(80, 40);
            this.buttonUndo1.TabIndex = 0;
            this.buttonUndo1.Text = "<";
            this.buttonUndo1.UseVisualStyleBackColor = false;
            // 
            // buttonUndo2
            // 
            this.buttonUndo2.BackColor = System.Drawing.Color.Transparent;
            this.buttonUndo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUndo2.ForeColor = System.Drawing.Color.White;
            this.buttonUndo2.Location = new System.Drawing.Point(690, 7);
            this.buttonUndo2.Name = "buttonUndo2";
            this.buttonUndo2.Size = new System.Drawing.Size(80, 40);
            this.buttonUndo2.TabIndex = 0;
            this.buttonUndo2.Text = "<<";
            this.buttonUndo2.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHeader.Controls.Add(this.groupBoxChuyenNganh);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(428, 731);
            this.panelHeader.TabIndex = 7;
            // 
            // groupBoxChuyenNganh
            // 
            this.groupBoxChuyenNganh.Controls.Add(this.label1);
            this.groupBoxChuyenNganh.Controls.Add(this.textBoxSDT);
            this.groupBoxChuyenNganh.Controls.Add(this.ButtonDel);
            this.groupBoxChuyenNganh.Controls.Add(this.labelTenNganh);
            this.groupBoxChuyenNganh.Controls.Add(this.ButtonUpdate);
            this.groupBoxChuyenNganh.Controls.Add(this.textBoxPass);
            this.groupBoxChuyenNganh.Controls.Add(this.textBoxUsername);
            this.groupBoxChuyenNganh.Controls.Add(this.labelMaNganh);
            this.groupBoxChuyenNganh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChuyenNganh.Location = new System.Drawing.Point(40, 120);
            this.groupBoxChuyenNganh.Name = "groupBoxChuyenNganh";
            this.groupBoxChuyenNganh.Size = new System.Drawing.Size(325, 386);
            this.groupBoxChuyenNganh.TabIndex = 3;
            this.groupBoxChuyenNganh.TabStop = false;
            this.groupBoxChuyenNganh.Text = "Tài Khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số điện thoại:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Location = new System.Drawing.Point(152, 143);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(144, 26);
            this.textBoxSDT.TabIndex = 8;
            // 
            // labelTenNganh
            // 
            this.labelTenNganh.AutoSize = true;
            this.labelTenNganh.Location = new System.Drawing.Point(45, 102);
            this.labelTenNganh.Name = "labelTenNganh";
            this.labelTenNganh.Size = new System.Drawing.Size(103, 19);
            this.labelTenNganh.TabIndex = 2;
            this.labelTenNganh.Text = "Mât Khẩu Mới:";
            this.labelTenNganh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(152, 101);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(144, 26);
            this.textBoxPass.TabIndex = 3;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(152, 60);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(144, 26);
            this.textBoxUsername.TabIndex = 3;
            // 
            // labelMaNganh
            // 
            this.labelMaNganh.AutoSize = true;
            this.labelMaNganh.Location = new System.Drawing.Point(45, 63);
            this.labelMaNganh.Name = "labelMaNganh";
            this.labelMaNganh.Size = new System.Drawing.Size(73, 19);
            this.labelMaNganh.TabIndex = 2;
            this.labelMaNganh.Text = "Username:";
            this.labelMaNganh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewContent
            // 
            this.dataGridViewContent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewContent.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewContent.Location = new System.Drawing.Point(428, 0);
            this.dataGridViewContent.Name = "dataGridViewContent";
            this.dataGridViewContent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewContent.Size = new System.Drawing.Size(958, 731);
            this.dataGridViewContent.TabIndex = 8;
            this.dataGridViewContent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContent_CellClick);
            // 
            // ButtonDel
            // 
            this.ButtonDel.BackColor = System.Drawing.Color.White;
            this.ButtonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDel.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ButtonDel.IconColor = System.Drawing.Color.Black;
            this.ButtonDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonDel.IconSize = 45;
            this.ButtonDel.Location = new System.Drawing.Point(88, 265);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(160, 50);
            this.ButtonDel.TabIndex = 6;
            this.ButtonDel.Text = "Xóa Tài Khoản";
            this.ButtonDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDel.UseVisualStyleBackColor = false;
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.BackColor = System.Drawing.Color.White;
            this.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdate.IconChar = FontAwesome.Sharp.IconChar.Squarespace;
            this.ButtonUpdate.IconColor = System.Drawing.Color.Black;
            this.ButtonUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonUpdate.IconSize = 45;
            this.ButtonUpdate.Location = new System.Drawing.Point(88, 192);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(160, 50);
            this.ButtonUpdate.TabIndex = 5;
            this.ButtonUpdate.Text = "Cập Nhật";
            this.ButtonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // fTaiKhoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 781);
            this.Controls.Add(this.dataGridViewContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Name = "fTaiKhoan";
            this.Text = "fTaiKhoan";
            this.Load += new System.EventHandler(this.fBaoCao_Load);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.groupBoxChuyenNganh.ResumeLayout(false);
            this.groupBoxChuyenNganh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelTotalPages;
        private System.Windows.Forms.Label labelCurrentPage;
        private System.Windows.Forms.Button buttonNext2;
        private System.Windows.Forms.Button buttonNext1;
        private System.Windows.Forms.Button buttonUndo1;
        private System.Windows.Forms.Button buttonUndo2;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.GroupBox groupBoxChuyenNganh;
        private FontAwesome.Sharp.IconButton ButtonDel;
        private System.Windows.Forms.Label labelTenNganh;
        private FontAwesome.Sharp.IconButton ButtonUpdate;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelMaNganh;
        private System.Windows.Forms.DataGridView dataGridViewContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSDT;
    }
}