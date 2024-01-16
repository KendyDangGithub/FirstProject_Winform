namespace GUI
{
    partial class fLopHoc
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.groupBoxChuyenNganh = new System.Windows.Forms.GroupBox();
            this.ButtonDel = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxbranch = new System.Windows.Forms.ComboBox();
            this.labelTenLop = new System.Windows.Forms.Label();
            this.ButtonAdd = new FontAwesome.Sharp.IconButton();
            this.ButtonUpdate = new FontAwesome.Sharp.IconButton();
            this.textBoxTenLop = new System.Windows.Forms.TextBox();
            this.textBoxMaLop = new System.Windows.Forms.TextBox();
            this.labelMaNganh = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.comboBoxValue = new System.Windows.Forms.ComboBox();
            this.comboBoxColumn = new System.Windows.Forms.ComboBox();
            this.ButtonSearch = new FontAwesome.Sharp.IconButton();
            this.dataGridViewContent = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.groupBoxChuyenNganh.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContent)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHeader.Controls.Add(this.groupBoxChuyenNganh);
            this.panelHeader.Controls.Add(this.groupBoxSearch);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(428, 742);
            this.panelHeader.TabIndex = 7;
            // 
            // groupBoxChuyenNganh
            // 
            this.groupBoxChuyenNganh.Controls.Add(this.ButtonDel);
            this.groupBoxChuyenNganh.Controls.Add(this.label2);
            this.groupBoxChuyenNganh.Controls.Add(this.comboBoxbranch);
            this.groupBoxChuyenNganh.Controls.Add(this.labelTenLop);
            this.groupBoxChuyenNganh.Controls.Add(this.ButtonAdd);
            this.groupBoxChuyenNganh.Controls.Add(this.ButtonUpdate);
            this.groupBoxChuyenNganh.Controls.Add(this.textBoxTenLop);
            this.groupBoxChuyenNganh.Controls.Add(this.textBoxMaLop);
            this.groupBoxChuyenNganh.Controls.Add(this.labelMaNganh);
            this.groupBoxChuyenNganh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChuyenNganh.Location = new System.Drawing.Point(45, 12);
            this.groupBoxChuyenNganh.Name = "groupBoxChuyenNganh";
            this.groupBoxChuyenNganh.Size = new System.Drawing.Size(325, 410);
            this.groupBoxChuyenNganh.TabIndex = 3;
            this.groupBoxChuyenNganh.TabStop = false;
            this.groupBoxChuyenNganh.Text = "Lớp Hoc";
            // 
            // ButtonDel
            // 
            this.ButtonDel.BackColor = System.Drawing.Color.White;
            this.ButtonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDel.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ButtonDel.IconColor = System.Drawing.Color.Black;
            this.ButtonDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonDel.IconSize = 45;
            this.ButtonDel.Location = new System.Drawing.Point(83, 329);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(160, 50);
            this.ButtonDel.TabIndex = 6;
            this.ButtonDel.Text = "Xóa Lớp";
            this.ButtonDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDel.UseVisualStyleBackColor = false;
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chuyên Ngành:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxbranch
            // 
            this.comboBoxbranch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxbranch.FormattingEnabled = true;
            this.comboBoxbranch.Location = new System.Drawing.Point(129, 122);
            this.comboBoxbranch.Name = "comboBoxbranch";
            this.comboBoxbranch.Size = new System.Drawing.Size(169, 29);
            this.comboBoxbranch.TabIndex = 6;
            this.comboBoxbranch.Text = "Công Nghệ Web";
            // 
            // labelTenLop
            // 
            this.labelTenLop.AutoSize = true;
            this.labelTenLop.Location = new System.Drawing.Point(23, 86);
            this.labelTenLop.Name = "labelTenLop";
            this.labelTenLop.Size = new System.Drawing.Size(64, 19);
            this.labelTenLop.TabIndex = 2;
            this.labelTenLop.Text = "Tên Lớp:";
            this.labelTenLop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.White;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.ButtonAdd.IconColor = System.Drawing.Color.Black;
            this.ButtonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAdd.IconSize = 45;
            this.ButtonAdd.Location = new System.Drawing.Point(85, 181);
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
            this.ButtonUpdate.Location = new System.Drawing.Point(83, 256);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(160, 50);
            this.ButtonUpdate.TabIndex = 5;
            this.ButtonUpdate.Text = "Cập Nhật";
            this.ButtonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // textBoxTenLop
            // 
            this.textBoxTenLop.Location = new System.Drawing.Point(129, 81);
            this.textBoxTenLop.Name = "textBoxTenLop";
            this.textBoxTenLop.Size = new System.Drawing.Size(169, 26);
            this.textBoxTenLop.TabIndex = 3;
            // 
            // textBoxMaLop
            // 
            this.textBoxMaLop.Location = new System.Drawing.Point(129, 40);
            this.textBoxMaLop.Name = "textBoxMaLop";
            this.textBoxMaLop.Size = new System.Drawing.Size(169, 26);
            this.textBoxMaLop.TabIndex = 3;
            // 
            // labelMaNganh
            // 
            this.labelMaNganh.AutoSize = true;
            this.labelMaNganh.Location = new System.Drawing.Point(23, 47);
            this.labelMaNganh.Name = "labelMaNganh";
            this.labelMaNganh.Size = new System.Drawing.Size(62, 19);
            this.labelMaNganh.TabIndex = 2;
            this.labelMaNganh.Text = "Mã Lớp:";
            this.labelMaNganh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.comboBoxValue);
            this.groupBoxSearch.Controls.Add(this.comboBoxColumn);
            this.groupBoxSearch.Controls.Add(this.ButtonSearch);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearch.Location = new System.Drawing.Point(45, 501);
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
            this.comboBoxValue.Text = "Công Nghệ Web";
            // 
            // comboBoxColumn
            // 
            this.comboBoxColumn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColumn.FormattingEnabled = true;
            this.comboBoxColumn.Items.AddRange(new object[] {
            "Mã Lớp",
            "Tên Lớp",
            "Chuyên Ngành"});
            this.comboBoxColumn.Location = new System.Drawing.Point(68, 36);
            this.comboBoxColumn.Name = "comboBoxColumn";
            this.comboBoxColumn.Size = new System.Drawing.Size(180, 29);
            this.comboBoxColumn.TabIndex = 6;
            this.comboBoxColumn.Text = "Chuyên Ngành";
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
            this.dataGridViewContent.Size = new System.Drawing.Size(942, 742);
            this.dataGridViewContent.TabIndex = 8;
            this.dataGridViewContent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContent_CellClick);
            // 
            // fLopHoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 742);
            this.Controls.Add(this.dataGridViewContent);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fLopHoc";
            this.Text = "fLopHoc";
            this.panelHeader.ResumeLayout(false);
            this.groupBoxChuyenNganh.ResumeLayout(false);
            this.groupBoxChuyenNganh.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.GroupBox groupBoxChuyenNganh;
        private FontAwesome.Sharp.IconButton ButtonDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxbranch;
        private System.Windows.Forms.Label labelTenLop;
        private FontAwesome.Sharp.IconButton ButtonAdd;
        private FontAwesome.Sharp.IconButton ButtonUpdate;
        private System.Windows.Forms.TextBox textBoxTenLop;
        private System.Windows.Forms.TextBox textBoxMaLop;
        private System.Windows.Forms.Label labelMaNganh;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxValue;
        private System.Windows.Forms.ComboBox comboBoxColumn;
        private FontAwesome.Sharp.IconButton ButtonSearch;
        private System.Windows.Forms.DataGridView dataGridViewContent;
    }
}