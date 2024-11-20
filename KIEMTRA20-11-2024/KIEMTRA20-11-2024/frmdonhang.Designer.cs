namespace KIEMTRA20_11_2024
{
    partial class frmdonhang
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaDH = new TextBox();
            txtMaKH = new TextBox();
            txtSoLuong = new TextBox();
            txtMaSP = new TextBox();
            dateNgayNhap = new DateTimePicker();
            tbDataDonHang = new DataGridView();
            txtTimKiem = new TextBox();
            button_timkiem = new Button();
            button_sua = new Button();
            button_lammoi = new Button();
            button_them = new Button();
            button_xoa = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)tbDataDonHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 29);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Hóa Đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 96);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã Khách Hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(520, 29);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Số Lượng";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(520, 92);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 3;
            label4.Text = "Mã Sản Phẩm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 174);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 4;
            label5.Text = "Ngày Nhập:";
            label5.Click += label5_Click;
            // 
            // txtMaDH
            // 
            txtMaDH.Location = new Point(173, 22);
            txtMaDH.Name = "txtMaDH";
            txtMaDH.Size = new Size(172, 27);
            txtMaDH.TabIndex = 5;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(173, 96);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(172, 27);
            txtMaKH.TabIndex = 6;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(649, 22);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(181, 27);
            txtSoLuong.TabIndex = 7;
            txtSoLuong.TextChanged += textBox3_TextChanged;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(649, 89);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(181, 27);
            txtMaSP.TabIndex = 8;
            // 
            // dateNgayNhap
            // 
            dateNgayNhap.Font = new Font("Microsoft Sans Serif", 7.8F);
            dateNgayNhap.Location = new Point(173, 174);
            dateNgayNhap.Name = "dateNgayNhap";
            dateNgayNhap.Size = new Size(250, 22);
            dateNgayNhap.TabIndex = 3;
            // 
            // tbDataDonHang
            // 
            tbDataDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbDataDonHang.Location = new Point(45, 271);
            tbDataDonHang.Name = "tbDataDonHang";
            tbDataDonHang.RowHeadersWidth = 51;
            tbDataDonHang.Size = new Size(569, 188);
            tbDataDonHang.TabIndex = 10;
            tbDataDonHang.CellContentClick += tbDataDonHang_CellContentClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(649, 160);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(181, 27);
            txtTimKiem.TabIndex = 12;
            // 
            // button_timkiem
            // 
            button_timkiem.Location = new Point(520, 165);
            button_timkiem.Name = "button_timkiem";
            button_timkiem.Size = new Size(94, 29);
            button_timkiem.TabIndex = 13;
            button_timkiem.Text = "Tìm Kiếm";
            button_timkiem.UseVisualStyleBackColor = true;
            button_timkiem.Click += button_timkiem_Click;
            // 
            // button_sua
            // 
            button_sua.Location = new Point(198, 484);
            button_sua.Name = "button_sua";
            button_sua.Size = new Size(94, 29);
            button_sua.TabIndex = 14;
            button_sua.Text = "Sửa";
            button_sua.UseVisualStyleBackColor = true;
            button_sua.Click += button_sua_Click;
            // 
            // button_lammoi
            // 
            button_lammoi.Location = new Point(520, 484);
            button_lammoi.Name = "button_lammoi";
            button_lammoi.Size = new Size(94, 29);
            button_lammoi.TabIndex = 15;
            button_lammoi.Text = "Làm Mới";
            button_lammoi.UseVisualStyleBackColor = true;
            button_lammoi.Click += button_lammoi_Click;
            // 
            // button_them
            // 
            button_them.Location = new Point(45, 484);
            button_them.Name = "button_them";
            button_them.Size = new Size(94, 29);
            button_them.TabIndex = 16;
            button_them.Text = "Thêm";
            button_them.UseVisualStyleBackColor = true;
            button_them.Click += button_them_Click;
            // 
            // button_xoa
            // 
            button_xoa.Location = new Point(362, 484);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(94, 29);
            button_xoa.TabIndex = 17;
            button_xoa.Text = "Xóa";
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += button_xoa_Click;
            // 
            // button1
            // 
            button1.Location = new Point(719, 473);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 18;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(45, 530);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 19;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmdonhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 571);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button_xoa);
            Controls.Add(button_them);
            Controls.Add(button_lammoi);
            Controls.Add(button_sua);
            Controls.Add(button_timkiem);
            Controls.Add(txtTimKiem);
            Controls.Add(tbDataDonHang);
            Controls.Add(dateNgayNhap);
            Controls.Add(txtMaSP);
            Controls.Add(txtSoLuong);
            Controls.Add(txtMaKH);
            Controls.Add(txtMaDH);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmdonhang";
            Text = "frmdonhang";
            Load += frmdonhang_Load;
            ((System.ComponentModel.ISupportInitialize)tbDataDonHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaDH;
        private TextBox txtMaKH;
        private TextBox txtSoLuong;
        private TextBox txtMaSP;
        private DateTimePicker dateNgayNhap;
        private DataGridView tbDataDonHang;
        private TextBox txtTimKiem;
        private Button button_timkiem;
        private Button button_sua;
        private Button button_lammoi;
        private Button button_them;
        private Button button_xoa;
        private Button button1;
        private Button button2;
    }
}