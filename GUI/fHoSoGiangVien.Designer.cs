namespace GUI
{
    partial class fHoSoGiangVien
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
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.groupBoxThongTinGV = new System.Windows.Forms.GroupBox();
            this.comboBoxKhoa = new System.Windows.Forms.ComboBox();
            this.TimePickerNgaySinh = new GUI.UserControls.KDDateTimePicker();
            this.comboBoxGioiTInh = new System.Windows.Forms.ComboBox();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.labelKhoa = new System.Windows.Forms.Label();
            this.textBoxSoCCCD = new System.Windows.Forms.TextBox();
            this.labelSoCCCD = new System.Windows.Forms.Label();
            this.labelGioiTinh = new System.Windows.Forms.Label();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.textBoxHoten = new System.Windows.Forms.TextBox();
            this.labelSDT = new System.Windows.Forms.Label();
            this.labelHoten = new System.Windows.Forms.Label();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.textBoxMaGV = new System.Windows.Forms.TextBox();
            this.labelMaGV = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTotalPages = new System.Windows.Forms.Label();
            this.labelCurrentPage = new System.Windows.Forms.Label();
            this.buttonNext2 = new System.Windows.Forms.Button();
            this.buttonNext1 = new System.Windows.Forms.Button();
            this.buttonUndo1 = new System.Windows.Forms.Button();
            this.buttonUndo2 = new System.Windows.Forms.Button();
            this.groupBoxFunctions = new System.Windows.Forms.GroupBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.ButtonSearch = new FontAwesome.Sharp.IconButton();
            this.TextBoxSearch = new GUI.UserControls.KDTextBox();
            this.ButtonDel = new FontAwesome.Sharp.IconButton();
            this.ButtonUpdate = new FontAwesome.Sharp.IconButton();
            this.ButtonAdd = new FontAwesome.Sharp.IconButton();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.panelThongTin.SuspendLayout();
            this.groupBoxThongTinGV.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.groupBoxFunctions.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelThongTin
            // 
            this.panelThongTin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelThongTin.Controls.Add(this.groupBoxThongTinGV);
            this.panelThongTin.Controls.Add(this.groupBoxFunctions);
            this.panelThongTin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelThongTin.Location = new System.Drawing.Point(0, 0);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(347, 781);
            this.panelThongTin.TabIndex = 1;
            // 
            // groupBoxThongTinGV
            // 
            this.groupBoxThongTinGV.Controls.Add(this.comboBoxKhoa);
            this.groupBoxThongTinGV.Controls.Add(this.TimePickerNgaySinh);
            this.groupBoxThongTinGV.Controls.Add(this.comboBoxGioiTInh);
            this.groupBoxThongTinGV.Controls.Add(this.labelNgaySinh);
            this.groupBoxThongTinGV.Controls.Add(this.labelKhoa);
            this.groupBoxThongTinGV.Controls.Add(this.textBoxSoCCCD);
            this.groupBoxThongTinGV.Controls.Add(this.labelSoCCCD);
            this.groupBoxThongTinGV.Controls.Add(this.labelGioiTinh);
            this.groupBoxThongTinGV.Controls.Add(this.textBoxSDT);
            this.groupBoxThongTinGV.Controls.Add(this.textBoxHoten);
            this.groupBoxThongTinGV.Controls.Add(this.labelSDT);
            this.groupBoxThongTinGV.Controls.Add(this.labelHoten);
            this.groupBoxThongTinGV.Controls.Add(this.textBoxDiaChi);
            this.groupBoxThongTinGV.Controls.Add(this.labelDiaChi);
            this.groupBoxThongTinGV.Controls.Add(this.textBoxMaGV);
            this.groupBoxThongTinGV.Controls.Add(this.labelMaGV);
            this.groupBoxThongTinGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxThongTinGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxThongTinGV.Location = new System.Drawing.Point(12, 21);
            this.groupBoxThongTinGV.Name = "groupBoxThongTinGV";
            this.groupBoxThongTinGV.Size = new System.Drawing.Size(314, 328);
            this.groupBoxThongTinGV.TabIndex = 0;
            this.groupBoxThongTinGV.TabStop = false;
            this.groupBoxThongTinGV.Text = "Thông Tin Giảng Viên";
            // 
            // comboBoxKhoa
            // 
            this.comboBoxKhoa.Enabled = false;
            this.comboBoxKhoa.FormattingEnabled = true;
            this.comboBoxKhoa.Items.AddRange(new object[] {
            "CNTT"});
            this.comboBoxKhoa.Location = new System.Drawing.Point(135, 173);
            this.comboBoxKhoa.Name = "comboBoxKhoa";
            this.comboBoxKhoa.Size = new System.Drawing.Size(144, 27);
            this.comboBoxKhoa.TabIndex = 6;
            this.comboBoxKhoa.Text = "CNTT";
            // 
            // TimePickerNgaySinh
            // 
            this.TimePickerNgaySinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.TimePickerNgaySinh.BorderSize = 0;
            this.TimePickerNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimePickerNgaySinh.Location = new System.Drawing.Point(135, 132);
            this.TimePickerNgaySinh.MaxDate = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            this.TimePickerNgaySinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.TimePickerNgaySinh.MinimumSize = new System.Drawing.Size(0, 35);
            this.TimePickerNgaySinh.Name = "TimePickerNgaySinh";
            this.TimePickerNgaySinh.Size = new System.Drawing.Size(144, 35);
            this.TimePickerNgaySinh.SkinColor = System.Drawing.Color.White;
            this.TimePickerNgaySinh.TabIndex = 5;
            this.TimePickerNgaySinh.TextColor = System.Drawing.Color.Black;
            this.TimePickerNgaySinh.Value = new System.DateTime(2004, 8, 19, 0, 0, 0, 0);
            // 
            // comboBoxGioiTInh
            // 
            this.comboBoxGioiTInh.FormattingEnabled = true;
            this.comboBoxGioiTInh.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.comboBoxGioiTInh.Location = new System.Drawing.Point(135, 97);
            this.comboBoxGioiTInh.Name = "comboBoxGioiTInh";
            this.comboBoxGioiTInh.Size = new System.Drawing.Size(144, 27);
            this.comboBoxGioiTInh.TabIndex = 2;
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Location = new System.Drawing.Point(47, 141);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(75, 19);
            this.labelNgaySinh.TabIndex = 0;
            this.labelNgaySinh.Text = "Ngày Sinh:";
            this.labelNgaySinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelKhoa
            // 
            this.labelKhoa.AutoSize = true;
            this.labelKhoa.Location = new System.Drawing.Point(49, 176);
            this.labelKhoa.Name = "labelKhoa";
            this.labelKhoa.Size = new System.Drawing.Size(46, 19);
            this.labelKhoa.TabIndex = 0;
            this.labelKhoa.Text = "Khoa:";
            this.labelKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSoCCCD
            // 
            this.textBoxSoCCCD.Location = new System.Drawing.Point(135, 269);
            this.textBoxSoCCCD.Name = "textBoxSoCCCD";
            this.textBoxSoCCCD.Size = new System.Drawing.Size(144, 26);
            this.textBoxSoCCCD.TabIndex = 1;
            // 
            // labelSoCCCD
            // 
            this.labelSoCCCD.AutoSize = true;
            this.labelSoCCCD.Location = new System.Drawing.Point(49, 272);
            this.labelSoCCCD.Name = "labelSoCCCD";
            this.labelSoCCCD.Size = new System.Drawing.Size(77, 19);
            this.labelSoCCCD.TabIndex = 0;
            this.labelSoCCCD.Text = "Số CCCD:";
            this.labelSoCCCD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGioiTinh
            // 
            this.labelGioiTinh.AutoSize = true;
            this.labelGioiTinh.Location = new System.Drawing.Point(49, 104);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new System.Drawing.Size(67, 19);
            this.labelGioiTinh.TabIndex = 0;
            this.labelGioiTinh.Text = "Giới Tính:";
            this.labelGioiTinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Location = new System.Drawing.Point(135, 237);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(144, 26);
            this.textBoxSDT.TabIndex = 1;
            // 
            // textBoxHoten
            // 
            this.textBoxHoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHoten.Location = new System.Drawing.Point(135, 67);
            this.textBoxHoten.Name = "textBoxHoten";
            this.textBoxHoten.Size = new System.Drawing.Size(144, 26);
            this.textBoxHoten.TabIndex = 1;
            // 
            // labelSDT
            // 
            this.labelSDT.AutoSize = true;
            this.labelSDT.Location = new System.Drawing.Point(47, 240);
            this.labelSDT.Name = "labelSDT";
            this.labelSDT.Size = new System.Drawing.Size(40, 19);
            this.labelSDT.TabIndex = 0;
            this.labelSDT.Text = "SĐT:";
            this.labelSDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHoten
            // 
            this.labelHoten.AutoSize = true;
            this.labelHoten.Location = new System.Drawing.Point(49, 70);
            this.labelHoten.Name = "labelHoten";
            this.labelHoten.Size = new System.Drawing.Size(58, 19);
            this.labelHoten.TabIndex = 0;
            this.labelHoten.Text = "Họ Tên:";
            this.labelHoten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Location = new System.Drawing.Point(135, 205);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(144, 26);
            this.textBoxDiaChi.TabIndex = 1;
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Location = new System.Drawing.Point(49, 208);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(58, 19);
            this.labelDiaChi.TabIndex = 0;
            this.labelDiaChi.Text = "Đia Chỉ:";
            this.labelDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxMaGV
            // 
            this.textBoxMaGV.Location = new System.Drawing.Point(135, 35);
            this.textBoxMaGV.Name = "textBoxMaGV";
            this.textBoxMaGV.Size = new System.Drawing.Size(144, 26);
            this.textBoxMaGV.TabIndex = 1;
            // 
            // labelMaGV
            // 
            this.labelMaGV.AutoSize = true;
            this.labelMaGV.Location = new System.Drawing.Point(49, 38);
            this.labelMaGV.Name = "labelMaGV";
            this.labelMaGV.Size = new System.Drawing.Size(58, 19);
            this.labelMaGV.TabIndex = 0;
            this.labelMaGV.Text = "Mã GV:";
            this.labelMaGV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelFooter.Controls.Add(this.groupBoxSearch);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFooter.Location = new System.Drawing.Point(347, 0);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1039, 144);
            this.panelFooter.TabIndex = 2;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHeader.Controls.Add(this.labelTotalPages);
            this.panelHeader.Controls.Add(this.labelCurrentPage);
            this.panelHeader.Controls.Add(this.buttonNext2);
            this.panelHeader.Controls.Add(this.buttonNext1);
            this.panelHeader.Controls.Add(this.buttonUndo1);
            this.panelHeader.Controls.Add(this.buttonUndo2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHeader.Location = new System.Drawing.Point(347, 731);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1039, 50);
            this.panelHeader.TabIndex = 3;
            // 
            // labelTotalPages
            // 
            this.labelTotalPages.AutoSize = true;
            this.labelTotalPages.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPages.Location = new System.Drawing.Point(600, 14);
            this.labelTotalPages.Name = "labelTotalPages";
            this.labelTotalPages.Size = new System.Drawing.Size(19, 21);
            this.labelTotalPages.TabIndex = 2;
            this.labelTotalPages.Text = "1";
            // 
            // labelCurrentPage
            // 
            this.labelCurrentPage.AutoSize = true;
            this.labelCurrentPage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPage.Location = new System.Drawing.Point(529, 14);
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
            this.buttonNext2.Location = new System.Drawing.Point(713, 5);
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
            this.buttonNext1.Location = new System.Drawing.Point(627, 5);
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
            this.buttonUndo1.Location = new System.Drawing.Point(427, 5);
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
            this.buttonUndo2.Location = new System.Drawing.Point(341, 5);
            this.buttonUndo2.Name = "buttonUndo2";
            this.buttonUndo2.Size = new System.Drawing.Size(80, 40);
            this.buttonUndo2.TabIndex = 0;
            this.buttonUndo2.Text = "<<";
            this.buttonUndo2.UseVisualStyleBackColor = false;
            // 
            // groupBoxFunctions
            // 
            this.groupBoxFunctions.Controls.Add(this.ButtonDel);
            this.groupBoxFunctions.Controls.Add(this.ButtonUpdate);
            this.groupBoxFunctions.Controls.Add(this.ButtonAdd);
            this.groupBoxFunctions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFunctions.Location = new System.Drawing.Point(12, 392);
            this.groupBoxFunctions.Name = "groupBoxFunctions";
            this.groupBoxFunctions.Size = new System.Drawing.Size(314, 353);
            this.groupBoxFunctions.TabIndex = 4;
            this.groupBoxFunctions.TabStop = false;
            this.groupBoxFunctions.Text = "Chức Năng";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.comboBoxFilter);
            this.groupBoxSearch.Controls.Add(this.ButtonSearch);
            this.groupBoxSearch.Controls.Add(this.TextBoxSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(158, 21);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(690, 111);
            this.groupBoxSearch.TabIndex = 2;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Tìm Kiếm";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.ButtonSearch.IconColor = System.Drawing.Color.Black;
            this.ButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonSearch.IconSize = 45;
            this.ButtonSearch.Location = new System.Drawing.Point(446, 38);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(180, 45);
            this.ButtonSearch.TabIndex = 3;
            this.ButtonSearch.Text = "Tìm Kiếm";
            this.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BorderColor = System.Drawing.Color.Black;
            this.TextBoxSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxSearch.BorderRadius = 0;
            this.TextBoxSearch.BorderSize = 2;
            this.TextBoxSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(235, 38);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(6);
            this.TextBoxSearch.Multiline = false;
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.TextBoxSearch.PasswordChar = false;
            this.TextBoxSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxSearch.PlaceholderText = "Mã GV";
            this.TextBoxSearch.Size = new System.Drawing.Size(175, 45);
            this.TextBoxSearch.TabIndex = 0;
            this.TextBoxSearch.Texts = "";
            this.TextBoxSearch.UnderlinedStyle = false;
            // 
            // ButtonDel
            // 
            this.ButtonDel.BackColor = System.Drawing.Color.White;
            this.ButtonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDel.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ButtonDel.IconColor = System.Drawing.Color.Black;
            this.ButtonDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonDel.IconSize = 45;
            this.ButtonDel.Location = new System.Drawing.Point(51, 225);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(193, 59);
            this.ButtonDel.TabIndex = 1;
            this.ButtonDel.Text = "Xóa Sinh Viên";
            this.ButtonDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDel.UseVisualStyleBackColor = false;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.BackColor = System.Drawing.Color.White;
            this.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdate.IconChar = FontAwesome.Sharp.IconChar.Squarespace;
            this.ButtonUpdate.IconColor = System.Drawing.Color.Black;
            this.ButtonUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonUpdate.IconSize = 45;
            this.ButtonUpdate.Location = new System.Drawing.Point(53, 134);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(193, 59);
            this.ButtonUpdate.TabIndex = 1;
            this.ButtonUpdate.Text = "Cập Nhật";
            this.ButtonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.White;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.ButtonAdd.IconColor = System.Drawing.Color.Black;
            this.ButtonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAdd.IconSize = 45;
            this.ButtonAdd.Location = new System.Drawing.Point(53, 45);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(193, 59);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "Thêm Mới";
            this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAdd.UseVisualStyleBackColor = false;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.Enabled = false;
            this.comboBoxFilter.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(57, 47);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(144, 29);
            this.comboBoxFilter.TabIndex = 6;
            this.comboBoxFilter.Text = "Mã GV";
            // 
            // fHoSoGiangVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1386, 781);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelThongTin);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "fHoSoGiangVien";
            this.Text = "fHoSoGiangVien";
            this.panelThongTin.ResumeLayout(false);
            this.groupBoxThongTinGV.ResumeLayout(false);
            this.groupBoxThongTinGV.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.groupBoxFunctions.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThongTin;
        private System.Windows.Forms.GroupBox groupBoxThongTinGV;
        private UserControls.KDDateTimePicker TimePickerNgaySinh;
        private System.Windows.Forms.ComboBox comboBoxGioiTInh;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.TextBox textBoxSoCCCD;
        private System.Windows.Forms.Label labelSoCCCD;
        private System.Windows.Forms.Label labelGioiTinh;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.TextBox textBoxHoten;
        private System.Windows.Forms.Label labelSDT;
        private System.Windows.Forms.Label labelHoten;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.TextBox textBoxMaGV;
        private System.Windows.Forms.Label labelMaGV;
        private System.Windows.Forms.ComboBox comboBoxKhoa;
        private System.Windows.Forms.Label labelKhoa;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTotalPages;
        private System.Windows.Forms.Label labelCurrentPage;
        private System.Windows.Forms.Button buttonNext2;
        private System.Windows.Forms.Button buttonNext1;
        private System.Windows.Forms.Button buttonUndo1;
        private System.Windows.Forms.Button buttonUndo2;
        private System.Windows.Forms.GroupBox groupBoxFunctions;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private FontAwesome.Sharp.IconButton ButtonSearch;
        private UserControls.KDTextBox TextBoxSearch;
        private FontAwesome.Sharp.IconButton ButtonDel;
        private FontAwesome.Sharp.IconButton ButtonUpdate;
        private FontAwesome.Sharp.IconButton ButtonAdd;
        private System.Windows.Forms.ComboBox comboBoxFilter;
    }
}