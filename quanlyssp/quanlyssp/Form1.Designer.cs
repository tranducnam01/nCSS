namespace quanlyssp
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
            groupBox1 = new GroupBox();
            cbLoaiSP = new ComboBox();
            tbMoTaChiTiet = new TextBox();
            tbMoTaNgan = new TextBox();
            tbHinhAnh = new TextBox();
            tbGia = new TextBox();
            tbTenSP = new TextBox();
            tbMaSP = new TextBox();
            labelLoaiSP = new Label();
            labelMotadai = new Label();
            labelMotangan = new Label();
            labelAnh = new Label();
            labelGia = new Label();
            labelTenSP = new Label();
            labelMaSP = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            textBox8 = new TextBox();
            label8 = new Label();
            groupBox3 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            buttonThem = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbLoaiSP);
            groupBox1.Controls.Add(tbMoTaChiTiet);
            groupBox1.Controls.Add(tbMoTaNgan);
            groupBox1.Controls.Add(tbHinhAnh);
            groupBox1.Controls.Add(tbGia);
            groupBox1.Controls.Add(tbTenSP);
            groupBox1.Controls.Add(tbMaSP);
            groupBox1.Controls.Add(labelLoaiSP);
            groupBox1.Controls.Add(labelMotadai);
            groupBox1.Controls.Add(labelMotangan);
            groupBox1.Controls.Add(labelAnh);
            groupBox1.Controls.Add(labelGia);
            groupBox1.Controls.Add(labelTenSP);
            groupBox1.Controls.Add(labelMaSP);
            groupBox1.Location = new Point(12, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 541);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cbLoaiSP
            // 
            cbLoaiSP.FormattingEnabled = true;
            cbLoaiSP.Items.AddRange(new object[] { "ao ", "quan", "do an " });
            cbLoaiSP.Location = new Point(120, 460);
            cbLoaiSP.Name = "cbLoaiSP";
            cbLoaiSP.Size = new Size(277, 28);
            cbLoaiSP.TabIndex = 13;
            cbLoaiSP.SelectedIndexChanged += cbLoaiSP_SelectedIndexChanged;
            // 
            // tbMoTaChiTiet
            // 
            tbMoTaChiTiet.Location = new Point(118, 337);
            tbMoTaChiTiet.Multiline = true;
            tbMoTaChiTiet.Name = "tbMoTaChiTiet";
            tbMoTaChiTiet.Size = new Size(279, 101);
            tbMoTaChiTiet.TabIndex = 12;
            // 
            // tbMoTaNgan
            // 
            tbMoTaNgan.Location = new Point(118, 276);
            tbMoTaNgan.Name = "tbMoTaNgan";
            tbMoTaNgan.Size = new Size(279, 27);
            tbMoTaNgan.TabIndex = 11;
            // 
            // tbHinhAnh
            // 
            tbHinhAnh.Location = new Point(118, 222);
            tbHinhAnh.Name = "tbHinhAnh";
            tbHinhAnh.Size = new Size(279, 27);
            tbHinhAnh.TabIndex = 10;
            // 
            // tbGia
            // 
            tbGia.Location = new Point(120, 163);
            tbGia.Name = "tbGia";
            tbGia.Size = new Size(277, 27);
            tbGia.TabIndex = 9;
            // 
            // tbTenSP
            // 
            tbTenSP.Location = new Point(120, 104);
            tbTenSP.Name = "tbTenSP";
            tbTenSP.Size = new Size(277, 27);
            tbTenSP.TabIndex = 8;
            // 
            // tbMaSP
            // 
            tbMaSP.Location = new Point(118, 53);
            tbMaSP.Name = "tbMaSP";
            tbMaSP.Size = new Size(125, 27);
            tbMaSP.TabIndex = 7;
            // 
            // labelLoaiSP
            // 
            labelLoaiSP.AutoSize = true;
            labelLoaiSP.Location = new Point(18, 460);
            labelLoaiSP.Name = "labelLoaiSP";
            labelLoaiSP.Size = new Size(57, 20);
            labelLoaiSP.TabIndex = 6;
            labelLoaiSP.Text = "Loại SP";
            labelLoaiSP.Click += label7_Click;
            // 
            // labelMotadai
            // 
            labelMotadai.AutoSize = true;
            labelMotadai.Location = new Point(18, 337);
            labelMotadai.Name = "labelMotadai";
            labelMotadai.Size = new Size(100, 20);
            labelMotadai.TabIndex = 5;
            labelMotadai.Text = "Mô tả chi tiết:";
            // 
            // labelMotangan
            // 
            labelMotangan.AutoSize = true;
            labelMotangan.Location = new Point(18, 276);
            labelMotangan.Name = "labelMotangan";
            labelMotangan.Size = new Size(88, 20);
            labelMotangan.TabIndex = 4;
            labelMotangan.Text = "Mô tả ngắn:";
            // 
            // labelAnh
            // 
            labelAnh.AutoSize = true;
            labelAnh.Location = new Point(18, 222);
            labelAnh.Name = "labelAnh";
            labelAnh.Size = new Size(71, 20);
            labelAnh.TabIndex = 3;
            labelAnh.Text = "Hình ảnh:";
            // 
            // labelGia
            // 
            labelGia.AutoSize = true;
            labelGia.Location = new Point(18, 163);
            labelGia.Name = "labelGia";
            labelGia.Size = new Size(65, 20);
            labelGia.TabIndex = 2;
            labelGia.Text = "Đơn giá:";
            // 
            // labelTenSP
            // 
            labelTenSP.AutoSize = true;
            labelTenSP.Location = new Point(18, 104);
            labelTenSP.Name = "labelTenSP";
            labelTenSP.Size = new Size(55, 20);
            labelTenSP.TabIndex = 1;
            labelTenSP.Text = "Tên SP:";
            // 
            // labelMaSP
            // 
            labelMaSP.AutoSize = true;
            labelMaSP.Location = new Point(18, 53);
            labelMaSP.Name = "labelMaSP";
            labelMaSP.Size = new Size(57, 20);
            labelMaSP.TabIndex = 0;
            labelMaSP.Text = "Mã SP :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(457, -1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(753, 679);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dữ liệu";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(686, 513);
            dataGridView1.TabIndex = 3;
            // 
            // button5
            // 
            button5.Location = new Point(610, 51);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 2;
            button5.Text = "Tìm kiếm";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(127, 53);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(442, 27);
            textBox8.TabIndex = 1;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 55);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 0;
            label8.Text = "Tìm kiếm mã:";
            label8.Click += label8_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(buttonThem);
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(12, 553);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(439, 125);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // button4
            // 
            button4.Location = new Point(318, 59);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(218, 59);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(118, 59);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(94, 29);
            buttonThem.TabIndex = 1;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(18, 59);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Làm mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 690);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelMaSP;
        private GroupBox groupBox2;
        private Label labelAnh;
        private Label labelGia;
        private Label labelTenSP;
        private Label labelLoaiSP;
        private Label labelMotadai;
        private Label labelMotangan;
        private GroupBox groupBox3;
        private Button button4;
        private Button button3;
        private Button buttonThem;
        private Button button1;
        private TextBox tbMoTaChiTiet;
        private TextBox tbMoTaNgan;
        private TextBox tbHinhAnh;
        private TextBox tbGia;
        private TextBox tbTenSP;
        private TextBox tbMaSP;
        private DataGridView dataGridView1;
        private Button button5;
        private TextBox textBox8;
        private Label label8;
        private ComboBox cbLoaiSP;
    }
}
