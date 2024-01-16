namespace GUI
{
    partial class fDiem
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
            this.ButtonDel = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.comboBoxDiem = new System.Windows.Forms.ComboBox();
            this.ButtonSort = new FontAwesome.Sharp.IconButton();
            this.ButtonUpdate = new FontAwesome.Sharp.IconButton();
            this.ButtonAdd = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownHocKy = new System.Windows.Forms.NumericUpDown();
            this.comboBoxMonHoc = new System.Windows.Forms.ComboBox();
            this.textBoxDiemThi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMonHoc = new System.Windows.Forms.Label();
            this.textBoxMaSV = new System.Windows.Forms.TextBox();
            this.labelMaSV = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.comboBoxValueSearch = new System.Windows.Forms.ComboBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.ButtonSearch = new FontAwesome.Sharp.IconButton();
            this.dataGridViewContent = new System.Windows.Forms.DataGridView();
            this.panelFooter.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHocKy)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
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
            this.panelFooter.TabIndex = 4;
            // 
            // labelTotalPages
            // 
            this.labelTotalPages.AutoSize = true;
            this.labelTotalPages.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPages.Location = new System.Drawing.Point(952, 16);
            this.labelTotalPages.Name = "labelTotalPages";
            this.labelTotalPages.Size = new System.Drawing.Size(19, 21);
            this.labelTotalPages.TabIndex = 2;
            this.labelTotalPages.Text = "1";
            // 
            // labelCurrentPage
            // 
            this.labelCurrentPage.AutoSize = true;
            this.labelCurrentPage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPage.Location = new System.Drawing.Point(881, 16);
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
            this.buttonNext2.Location = new System.Drawing.Point(1074, 7);
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
            this.buttonNext1.Location = new System.Drawing.Point(988, 7);
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
            this.buttonUndo1.Location = new System.Drawing.Point(779, 7);
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
            this.buttonUndo2.Location = new System.Drawing.Point(693, 7);
            this.buttonUndo2.Name = "buttonUndo2";
            this.buttonUndo2.Size = new System.Drawing.Size(80, 40);
            this.buttonUndo2.TabIndex = 0;
            this.buttonUndo2.Text = "<<";
            this.buttonUndo2.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHeader.Controls.Add(this.ButtonDel);
            this.panelHeader.Controls.Add(this.groupBox2);
            this.panelHeader.Controls.Add(this.ButtonUpdate);
            this.panelHeader.Controls.Add(this.ButtonAdd);
            this.panelHeader.Controls.Add(this.groupBox1);
            this.panelHeader.Controls.Add(this.groupBoxSearch);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(428, 731);
            this.panelHeader.TabIndex = 3;
            // 
            // ButtonDel
            // 
            this.ButtonDel.BackColor = System.Drawing.Color.White;
            this.ButtonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDel.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ButtonDel.IconColor = System.Drawing.Color.Black;
            this.ButtonDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonDel.IconSize = 35;
            this.ButtonDel.Location = new System.Drawing.Point(286, 233);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(120, 45);
            this.ButtonDel.TabIndex = 9;
            this.ButtonDel.Text = "Xóa Điểm";
            this.ButtonDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDel.UseVisualStyleBackColor = false;
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxSort);
            this.groupBox2.Controls.Add(this.comboBoxDiem);
            this.groupBox2.Controls.Add(this.ButtonSort);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 519);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 213);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sắp Xếp";
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Tăng Dần",
            "Giảm Dần"});
            this.comboBoxSort.Location = new System.Drawing.Point(68, 82);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(180, 29);
            this.comboBoxSort.TabIndex = 6;
            this.comboBoxSort.Text = "Tăng Dần";
            // 
            // comboBoxDiem
            // 
            this.comboBoxDiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDiem.FormattingEnabled = true;
            this.comboBoxDiem.Location = new System.Drawing.Point(68, 46);
            this.comboBoxDiem.Name = "comboBoxDiem";
            this.comboBoxDiem.Size = new System.Drawing.Size(180, 29);
            this.comboBoxDiem.TabIndex = 6;
            this.comboBoxDiem.Text = "Điểm";
            // 
            // ButtonSort
            // 
            this.ButtonSort.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.ButtonSort.IconColor = System.Drawing.Color.Black;
            this.ButtonSort.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonSort.IconSize = 45;
            this.ButtonSort.Location = new System.Drawing.Point(68, 122);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(180, 45);
            this.ButtonSort.TabIndex = 3;
            this.ButtonSort.Text = "Sắp Xếp";
            this.ButtonSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.BackColor = System.Drawing.Color.White;
            this.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdate.IconChar = FontAwesome.Sharp.IconChar.Squarespace;
            this.ButtonUpdate.IconColor = System.Drawing.Color.Black;
            this.ButtonUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonUpdate.IconSize = 35;
            this.ButtonUpdate.Location = new System.Drawing.Point(151, 233);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(120, 45);
            this.ButtonUpdate.TabIndex = 8;
            this.ButtonUpdate.Text = "Cập Nhật";
            this.ButtonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.White;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.ButtonAdd.IconColor = System.Drawing.Color.Black;
            this.ButtonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAdd.IconSize = 35;
            this.ButtonAdd.Location = new System.Drawing.Point(15, 233);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(120, 45);
            this.ButtonAdd.TabIndex = 7;
            this.ButtonAdd.Text = "Thêm Mới";
            this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownHocKy);
            this.groupBox1.Controls.Add(this.comboBoxMonHoc);
            this.groupBox1.Controls.Add(this.textBoxDiemThi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelMonHoc);
            this.groupBox1.Controls.Add(this.textBoxMaSV);
            this.groupBox1.Controls.Add(this.labelMaSV);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 196);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Điểm";
            // 
            // numericUpDownHocKy
            // 
            this.numericUpDownHocKy.Location = new System.Drawing.Point(130, 110);
            this.numericUpDownHocKy.Name = "numericUpDownHocKy";
            this.numericUpDownHocKy.Size = new System.Drawing.Size(144, 26);
            this.numericUpDownHocKy.TabIndex = 6;
            // 
            // comboBoxMonHoc
            // 
            this.comboBoxMonHoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMonHoc.FormattingEnabled = true;
            this.comboBoxMonHoc.ItemHeight = 21;
            this.comboBoxMonHoc.Location = new System.Drawing.Point(130, 71);
            this.comboBoxMonHoc.Name = "comboBoxMonHoc";
            this.comboBoxMonHoc.Size = new System.Drawing.Size(144, 29);
            this.comboBoxMonHoc.TabIndex = 6;
            this.comboBoxMonHoc.Text = "WindowsForm";
            // 
            // textBoxDiemThi
            // 
            this.textBoxDiemThi.Location = new System.Drawing.Point(130, 145);
            this.textBoxDiemThi.Name = "textBoxDiemThi";
            this.textBoxDiemThi.Size = new System.Drawing.Size(144, 26);
            this.textBoxDiemThi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Điểm Thi:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Học Kỳ: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMonHoc
            // 
            this.labelMonHoc.AutoSize = true;
            this.labelMonHoc.Location = new System.Drawing.Point(44, 75);
            this.labelMonHoc.Name = "labelMonHoc";
            this.labelMonHoc.Size = new System.Drawing.Size(72, 19);
            this.labelMonHoc.TabIndex = 2;
            this.labelMonHoc.Text = "Học Phần:";
            this.labelMonHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxMaSV
            // 
            this.textBoxMaSV.Location = new System.Drawing.Point(130, 36);
            this.textBoxMaSV.Name = "textBoxMaSV";
            this.textBoxMaSV.Size = new System.Drawing.Size(144, 26);
            this.textBoxMaSV.TabIndex = 3;
            // 
            // labelMaSV
            // 
            this.labelMaSV.AutoSize = true;
            this.labelMaSV.Location = new System.Drawing.Point(44, 39);
            this.labelMaSV.Name = "labelMaSV";
            this.labelMaSV.Size = new System.Drawing.Size(56, 19);
            this.labelMaSV.TabIndex = 2;
            this.labelMaSV.Text = "Mã SV:";
            this.labelMaSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.comboBoxValueSearch);
            this.groupBoxSearch.Controls.Add(this.comboBoxSearch);
            this.groupBoxSearch.Controls.Add(this.ButtonSearch);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearch.Location = new System.Drawing.Point(45, 304);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(325, 186);
            this.groupBoxSearch.TabIndex = 2;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Tìm Kiếm";
            // 
            // comboBoxValueSearch
            // 
            this.comboBoxValueSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxValueSearch.FormattingEnabled = true;
            this.comboBoxValueSearch.ItemHeight = 21;
            this.comboBoxValueSearch.Location = new System.Drawing.Point(68, 72);
            this.comboBoxValueSearch.Name = "comboBoxValueSearch";
            this.comboBoxValueSearch.Size = new System.Drawing.Size(180, 29);
            this.comboBoxValueSearch.TabIndex = 6;
            this.comboBoxValueSearch.Text = "WindowsForm";
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.ItemHeight = 21;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Môn Học",
            "Lớp",
            "Mã Sinh Viên"});
            this.comboBoxSearch.Location = new System.Drawing.Point(68, 36);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(180, 29);
            this.comboBoxSearch.TabIndex = 6;
            this.comboBoxSearch.Text = "Môn Học";
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.ButtonSearch.IconColor = System.Drawing.Color.Black;
            this.ButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonSearch.IconSize = 45;
            this.ButtonSearch.Location = new System.Drawing.Point(68, 112);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(180, 45);
            this.ButtonSearch.TabIndex = 3;
            this.ButtonSearch.Text = "Tìm Kiếm";
            this.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
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
            this.dataGridViewContent.TabIndex = 5;
            this.dataGridViewContent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContent_CellClick);
            // 
            // fDiem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 781);
            this.Controls.Add(this.dataGridViewContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Name = "fDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDiem";
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHocKy)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.ComboBox comboBoxDiem;
        private FontAwesome.Sharp.IconButton ButtonSort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxMonHoc;
        private System.Windows.Forms.TextBox textBoxDiemThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMonHoc;
        private System.Windows.Forms.TextBox textBoxMaSV;
        private System.Windows.Forms.Label labelMaSV;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxValueSearch;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private FontAwesome.Sharp.IconButton ButtonSearch;
        private System.Windows.Forms.DataGridView dataGridViewContent;
        private FontAwesome.Sharp.IconButton ButtonDel;
        private FontAwesome.Sharp.IconButton ButtonAdd;
        private FontAwesome.Sharp.IconButton ButtonUpdate;
        private System.Windows.Forms.NumericUpDown numericUpDownHocKy;
    }
}