namespace GUI
{
    partial class fHocPhan
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
            this.groupBoxHocPhan = new System.Windows.Forms.GroupBox();
            this.numericUpDownSoTC = new System.Windows.Forms.NumericUpDown();
            this.ButtonDel = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTenNganh = new System.Windows.Forms.Label();
            this.ButtonAdd = new FontAwesome.Sharp.IconButton();
            this.ButtonUpdate = new FontAwesome.Sharp.IconButton();
            this.textBoxTenHp = new System.Windows.Forms.TextBox();
            this.textBoxMaHp = new System.Windows.Forms.TextBox();
            this.labelMaNganh = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.comboBoxValue = new System.Windows.Forms.ComboBox();
            this.comboBoxColumn = new System.Windows.Forms.ComboBox();
            this.ButtonSearch = new FontAwesome.Sharp.IconButton();
            this.dataGridViewContent = new System.Windows.Forms.DataGridView();
            this.panelFooter.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.groupBoxHocPhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoTC)).BeginInit();
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
            this.labelTotalPages.Location = new System.Drawing.Point(883, 16);
            this.labelTotalPages.Name = "labelTotalPages";
            this.labelTotalPages.Size = new System.Drawing.Size(19, 21);
            this.labelTotalPages.TabIndex = 2;
            this.labelTotalPages.Text = "1";
            // 
            // labelCurrentPage
            // 
            this.labelCurrentPage.AutoSize = true;
            this.labelCurrentPage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPage.Location = new System.Drawing.Point(812, 16);
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
            this.buttonNext2.Location = new System.Drawing.Point(1008, 7);
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
            this.buttonNext1.Location = new System.Drawing.Point(922, 7);
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
            this.buttonUndo1.Location = new System.Drawing.Point(710, 7);
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
            this.buttonUndo2.Location = new System.Drawing.Point(624, 7);
            this.buttonUndo2.Name = "buttonUndo2";
            this.buttonUndo2.Size = new System.Drawing.Size(80, 40);
            this.buttonUndo2.TabIndex = 0;
            this.buttonUndo2.Text = "<<";
            this.buttonUndo2.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHeader.Controls.Add(this.groupBoxHocPhan);
            this.panelHeader.Controls.Add(this.groupBoxSearch);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(428, 731);
            this.panelHeader.TabIndex = 7;
            // 
            // groupBoxHocPhan
            // 
            this.groupBoxHocPhan.Controls.Add(this.numericUpDownSoTC);
            this.groupBoxHocPhan.Controls.Add(this.ButtonDel);
            this.groupBoxHocPhan.Controls.Add(this.label2);
            this.groupBoxHocPhan.Controls.Add(this.comboBoxKhoa);
            this.groupBoxHocPhan.Controls.Add(this.label1);
            this.groupBoxHocPhan.Controls.Add(this.labelTenNganh);
            this.groupBoxHocPhan.Controls.Add(this.ButtonAdd);
            this.groupBoxHocPhan.Controls.Add(this.ButtonUpdate);
            this.groupBoxHocPhan.Controls.Add(this.textBoxTenHp);
            this.groupBoxHocPhan.Controls.Add(this.textBoxMaHp);
            this.groupBoxHocPhan.Controls.Add(this.labelMaNganh);
            this.groupBoxHocPhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHocPhan.Location = new System.Drawing.Point(45, 12);
            this.groupBoxHocPhan.Name = "groupBoxHocPhan";
            this.groupBoxHocPhan.Size = new System.Drawing.Size(325, 453);
            this.groupBoxHocPhan.TabIndex = 3;
            this.groupBoxHocPhan.TabStop = false;
            this.groupBoxHocPhan.Text = "Học Phần";
            // 
            // numericUpDownSoTC
            // 
            this.numericUpDownSoTC.Location = new System.Drawing.Point(130, 123);
            this.numericUpDownSoTC.Name = "numericUpDownSoTC";
            this.numericUpDownSoTC.Size = new System.Drawing.Size(144, 26);
            this.numericUpDownSoTC.TabIndex = 7;
            // 
            // ButtonDel
            // 
            this.ButtonDel.BackColor = System.Drawing.Color.White;
            this.ButtonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDel.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ButtonDel.IconColor = System.Drawing.Color.Black;
            this.ButtonDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonDel.IconSize = 45;
            this.ButtonDel.Location = new System.Drawing.Point(86, 369);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(160, 50);
            this.ButtonDel.TabIndex = 6;
            this.ButtonDel.Text = "Xóa Học Phần";
            this.ButtonDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDel.UseVisualStyleBackColor = false;
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khoa:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxKhoa
            // 
            this.comboBoxKhoa.Enabled = false;
            this.comboBoxKhoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKhoa.FormattingEnabled = true;
            this.comboBoxKhoa.Location = new System.Drawing.Point(130, 160);
            this.comboBoxKhoa.Name = "comboBoxKhoa";
            this.comboBoxKhoa.Size = new System.Drawing.Size(144, 29);
            this.comboBoxKhoa.TabIndex = 6;
            this.comboBoxKhoa.Text = "CNTT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số TC:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTenNganh
            // 
            this.labelTenNganh.AutoSize = true;
            this.labelTenNganh.Location = new System.Drawing.Point(44, 86);
            this.labelTenNganh.Name = "labelTenNganh";
            this.labelTenNganh.Size = new System.Drawing.Size(59, 19);
            this.labelTenNganh.TabIndex = 2;
            this.labelTenNganh.Text = "Tên HP:";
            this.labelTenNganh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.White;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.ButtonAdd.IconColor = System.Drawing.Color.Black;
            this.ButtonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAdd.IconSize = 45;
            this.ButtonAdd.Location = new System.Drawing.Point(88, 221);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(160, 50);
            this.ButtonAdd.TabIndex = 4;
            this.ButtonAdd.Text = "Thêm Mới";
            this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.BackColor = System.Drawing.Color.White;
            this.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdate.IconChar = FontAwesome.Sharp.IconChar.Squarespace;
            this.ButtonUpdate.IconColor = System.Drawing.Color.Black;
            this.ButtonUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonUpdate.IconSize = 45;
            this.ButtonUpdate.Location = new System.Drawing.Point(86, 296);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(160, 50);
            this.ButtonUpdate.TabIndex = 5;
            this.ButtonUpdate.Text = "Cập Nhật";
            this.ButtonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // textBoxTenHp
            // 
            this.textBoxTenHp.Location = new System.Drawing.Point(130, 85);
            this.textBoxTenHp.Name = "textBoxTenHp";
            this.textBoxTenHp.Size = new System.Drawing.Size(144, 26);
            this.textBoxTenHp.TabIndex = 3;
            // 
            // textBoxMaHp
            // 
            this.textBoxMaHp.Location = new System.Drawing.Point(130, 44);
            this.textBoxMaHp.Name = "textBoxMaHp";
            this.textBoxMaHp.Size = new System.Drawing.Size(144, 26);
            this.textBoxMaHp.TabIndex = 3;
            // 
            // labelMaNganh
            // 
            this.labelMaNganh.AutoSize = true;
            this.labelMaNganh.Location = new System.Drawing.Point(44, 47);
            this.labelMaNganh.Name = "labelMaNganh";
            this.labelMaNganh.Size = new System.Drawing.Size(57, 19);
            this.labelMaNganh.TabIndex = 2;
            this.labelMaNganh.Text = "Mã HP:";
            this.labelMaNganh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.comboBoxValue);
            this.groupBoxSearch.Controls.Add(this.comboBoxColumn);
            this.groupBoxSearch.Controls.Add(this.ButtonSearch);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearch.Location = new System.Drawing.Point(45, 508);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(325, 186);
            this.groupBoxSearch.TabIndex = 2;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Tìm Kiếm";
            // 
            // comboBoxValue
            // 
            this.comboBoxValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxValue.FormattingEnabled = true;
            this.comboBoxValue.Location = new System.Drawing.Point(68, 74);
            this.comboBoxValue.Name = "comboBoxValue";
            this.comboBoxValue.Size = new System.Drawing.Size(180, 29);
            this.comboBoxValue.TabIndex = 6;
            this.comboBoxValue.Text = "LT Windows Form";
            // 
            // comboBoxColumn
            // 
            this.comboBoxColumn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColumn.FormattingEnabled = true;
            this.comboBoxColumn.Items.AddRange(new object[] {
            "Học Phần",
            "Số Tín Chỉ",
            "Khoa"});
            this.comboBoxColumn.Location = new System.Drawing.Point(68, 36);
            this.comboBoxColumn.Name = "comboBoxColumn";
            this.comboBoxColumn.Size = new System.Drawing.Size(180, 29);
            this.comboBoxColumn.TabIndex = 6;
            this.comboBoxColumn.Text = "Học Phần";
            this.comboBoxColumn.SelectedIndexChanged += new System.EventHandler(this.comboBoxColumn_SelectedIndexChanged);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.ButtonSearch.IconColor = System.Drawing.Color.Black;
            this.ButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonSearch.IconSize = 45;
            this.ButtonSearch.Location = new System.Drawing.Point(68, 115);
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
            this.dataGridViewContent.TabIndex = 8;
            this.dataGridViewContent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContent_CellClick);
            // 
            // fHocPhan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 781);
            this.Controls.Add(this.dataGridViewContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fHocPhan";
            this.Text = "fHocPhan";
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.groupBoxHocPhan.ResumeLayout(false);
            this.groupBoxHocPhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoTC)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxHocPhan;
        private FontAwesome.Sharp.IconButton ButtonDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTenNganh;
        private FontAwesome.Sharp.IconButton ButtonAdd;
        private FontAwesome.Sharp.IconButton ButtonUpdate;
        private System.Windows.Forms.TextBox textBoxTenHp;
        private System.Windows.Forms.TextBox textBoxMaHp;
        private System.Windows.Forms.Label labelMaNganh;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxValue;
        private System.Windows.Forms.ComboBox comboBoxColumn;
        private FontAwesome.Sharp.IconButton ButtonSearch;
        private System.Windows.Forms.DataGridView dataGridViewContent;
        private System.Windows.Forms.NumericUpDown numericUpDownSoTC;
    }
}