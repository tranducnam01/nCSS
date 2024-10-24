namespace quanlySinhVien
{
    partial class Form1
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
            groupBox_INput = new GroupBox();
            cbKhoa = new ComboBox();
            cbSex = new ComboBox();
            tbSDT = new TextBox();
            tbEmail = new TextBox();
            tbDiaChi = new TextBox();
            tbNgaySinh = new TextBox();
            tbTenSV = new TextBox();
            tbMaSv = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox_ChucNang = new GroupBox();
            btXoa = new Button();
            btSua = new Button();
            btThem = new Button();
            btLamMoi = new Button();
            groupBox_ThongtinSV = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox_INput.SuspendLayout();
            groupBox_ChucNang.SuspendLayout();
            groupBox_ThongtinSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox_INput
            // 
            groupBox_INput.Controls.Add(cbKhoa);
            groupBox_INput.Controls.Add(cbSex);
            groupBox_INput.Controls.Add(tbSDT);
            groupBox_INput.Controls.Add(tbEmail);
            groupBox_INput.Controls.Add(tbDiaChi);
            groupBox_INput.Controls.Add(tbNgaySinh);
            groupBox_INput.Controls.Add(tbTenSV);
            groupBox_INput.Controls.Add(tbMaSv);
            groupBox_INput.Controls.Add(label8);
            groupBox_INput.Controls.Add(label7);
            groupBox_INput.Controls.Add(label6);
            groupBox_INput.Controls.Add(label5);
            groupBox_INput.Controls.Add(label4);
            groupBox_INput.Controls.Add(label3);
            groupBox_INput.Controls.Add(label2);
            groupBox_INput.Controls.Add(label1);
            groupBox_INput.Location = new Point(0, 0);
            groupBox_INput.Name = "groupBox_INput";
            groupBox_INput.Size = new Size(756, 547);
            groupBox_INput.TabIndex = 0;
            groupBox_INput.TabStop = false;
            groupBox_INput.Text = "Nhập Dữ Liệu";
            groupBox_INput.Enter += groupBox1_Enter;
            // 
            // cbKhoa
            // 
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Items.AddRange(new object[] { "Công Nghệ Thông tin", "Quản Trị An Ninh Mạng", "Khác" });
            cbKhoa.Location = new Point(141, 481);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new Size(314, 28);
            cbKhoa.TabIndex = 15;
            // 
            // cbSex
            // 
            cbSex.FormattingEnabled = true;
            cbSex.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbSex.Location = new Point(141, 418);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(143, 28);
            cbSex.TabIndex = 14;
            // 
            // tbSDT
            // 
            tbSDT.Location = new Point(139, 344);
            tbSDT.Name = "tbSDT";
            tbSDT.Size = new Size(316, 27);
            tbSDT.TabIndex = 13;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(141, 281);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(314, 27);
            tbEmail.TabIndex = 12;
            // 
            // tbDiaChi
            // 
            tbDiaChi.Location = new Point(141, 226);
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.Size = new Size(314, 27);
            tbDiaChi.TabIndex = 11;
            tbDiaChi.TextChanged += textBox4_TextChanged;
            // 
            // tbNgaySinh
            // 
            tbNgaySinh.Location = new Point(141, 162);
            tbNgaySinh.Name = "tbNgaySinh";
            tbNgaySinh.Size = new Size(314, 27);
            tbNgaySinh.TabIndex = 10;
            // 
            // tbTenSV
            // 
            tbTenSV.Location = new Point(139, 101);
            tbTenSV.Name = "tbTenSV";
            tbTenSV.Size = new Size(316, 27);
            tbTenSV.TabIndex = 9;
            // 
            // tbMaSv
            // 
            tbMaSv.Location = new Point(139, 46);
            tbMaSv.Name = "tbMaSv";
            tbMaSv.Size = new Size(318, 27);
            tbMaSv.TabIndex = 8;
            tbMaSv.TextChanged += textBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 481);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 7;
            label8.Text = "Khoa";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 421);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 6;
            label7.Text = "Giới Tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 347);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 5;
            label6.Text = "Số Điện Thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 284);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 226);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Địa Chỉ";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 162);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày Sinh";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 101);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên sinh viên";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 46);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên";
            label1.Click += label1_Click;
            // 
            // groupBox_ChucNang
            // 
            groupBox_ChucNang.Controls.Add(btXoa);
            groupBox_ChucNang.Controls.Add(btSua);
            groupBox_ChucNang.Controls.Add(btThem);
            groupBox_ChucNang.Controls.Add(btLamMoi);
            groupBox_ChucNang.Location = new Point(3, 565);
            groupBox_ChucNang.Name = "groupBox_ChucNang";
            groupBox_ChucNang.Size = new Size(754, 166);
            groupBox_ChucNang.TabIndex = 1;
            groupBox_ChucNang.TabStop = false;
            groupBox_ChucNang.Text = "Chức Năng";
            // 
            // btXoa
            // 
            btXoa.Location = new Point(588, 71);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(122, 33);
            btXoa.TabIndex = 3;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += button4_Click;
            // 
            // btSua
            // 
            btSua.Location = new Point(398, 71);
            btSua.Name = "btSua";
            btSua.Size = new Size(127, 39);
            btSua.TabIndex = 2;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // btThem
            // 
            btThem.Location = new Point(202, 71);
            btThem.Name = "btThem";
            btThem.Size = new Size(124, 39);
            btThem.TabIndex = 1;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btLamMoi
            // 
            btLamMoi.Location = new Point(20, 72);
            btLamMoi.Name = "btLamMoi";
            btLamMoi.Size = new Size(123, 38);
            btLamMoi.TabIndex = 0;
            btLamMoi.Text = "Làm mới";
            btLamMoi.UseVisualStyleBackColor = true;
            btLamMoi.Click += btLamMoi_Click;
            // 
            // groupBox_ThongtinSV
            // 
            groupBox_ThongtinSV.Controls.Add(dataGridView1);
            groupBox_ThongtinSV.Location = new Point(772, 0);
            groupBox_ThongtinSV.Name = "groupBox_ThongtinSV";
            groupBox_ThongtinSV.Size = new Size(696, 730);
            groupBox_ThongtinSV.TabIndex = 2;
            groupBox_ThongtinSV.TabStop = false;
            groupBox_ThongtinSV.Text = "Thông tin Sinh Viên";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(684, 623);
            dataGridView1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 747);
            Controls.Add(groupBox_ThongtinSV);
            Controls.Add(groupBox_ChucNang);
            Controls.Add(groupBox_INput);
            Name = "Form1";
            Text = "Form1";
            groupBox_INput.ResumeLayout(false);
            groupBox_INput.PerformLayout();
            groupBox_ChucNang.ResumeLayout(false);
            groupBox_ThongtinSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_INput;
        private GroupBox groupBox_ChucNang;
        private GroupBox groupBox_ThongtinSV;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox tbMaSv;
        private TextBox tbDiaChi;
        private TextBox tbNgaySinh;
        private TextBox tbTenSV;
        private ComboBox cbKhoa;
        private ComboBox cbSex;
        private TextBox tbSDT;
        private TextBox tbEmail;
        private Button btThem;
        private Button btLamMoi;
        private Button btXoa;
        private Button btSua;
        private DataGridView dataGridView1;
    }
}
