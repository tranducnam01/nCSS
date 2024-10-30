namespace kiemtra30_10_2024
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
            labelAnhSanPham = new Label();
            dataGridView1 = new DataGridView();
            labelThongTinSP = new Label();
            jbThem = new Button();
            jbXoa = new Button();
            jbThanhToan = new Button();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            tbTong = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // labelAnhSanPham
            // 
            labelAnhSanPham.AutoSize = true;
            labelAnhSanPham.Location = new Point(654, 623);
            labelAnhSanPham.Name = "labelAnhSanPham";
            labelAnhSanPham.Size = new Size(104, 20);
            labelAnhSanPham.TabIndex = 0;
            labelAnhSanPham.Text = "Ảnh Sản Phẩm";
            labelAnhSanPham.Click += labelAnhSanPham_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(931, 270);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // labelThongTinSP
            // 
            labelThongTinSP.AutoSize = true;
            labelThongTinSP.Font = new Font("Microsoft Sans Serif", 13F);
            labelThongTinSP.Location = new Point(53, 27);
            labelThongTinSP.Name = "labelThongTinSP";
            labelThongTinSP.Size = new Size(216, 26);
            labelThongTinSP.TabIndex = 5;
            labelThongTinSP.Text = "Thông Tin Sản Phẩm";
            // 
            // jbThem
            // 
            jbThem.Font = new Font("Microsoft Sans Serif", 9F);
            jbThem.Location = new Point(108, 367);
            jbThem.Name = "jbThem";
            jbThem.Size = new Size(219, 29);
            jbThem.TabIndex = 6;
            jbThem.Text = "Thêm Vào Giỏ Hàng";
            jbThem.UseVisualStyleBackColor = true;
            jbThem.Click += jbThem_Click;
            // 
            // jbXoa
            // 
            jbXoa.Font = new Font("Microsoft Sans Serif", 9F);
            jbXoa.Location = new Point(612, 367);
            jbXoa.Name = "jbXoa";
            jbXoa.Size = new Size(226, 29);
            jbXoa.TabIndex = 7;
            jbXoa.Text = "Xóa Khỏi Giỏ Hàng";
            jbXoa.UseVisualStyleBackColor = true;
            jbXoa.Click += jbXoa_Click;
            // 
            // jbThanhToan
            // 
            jbThanhToan.Location = new Point(368, 695);
            jbThanhToan.Name = "jbThanhToan";
            jbThanhToan.Size = new Size(120, 29);
            jbThanhToan.TabIndex = 11;
            jbThanhToan.Text = "Thanh Toán";
            jbThanhToan.UseVisualStyleBackColor = true;
            jbThanhToan.Click += jbThanhToan_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(25, 473);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(463, 188);
            dataGridView2.TabIndex = 12;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 434);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 13;
            label1.Text = "Giỏ Hàng";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 695);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 14;
            label2.Text = "Tổng tiền";
            // 
            // tbTong
            // 
            tbTong.Location = new Point(139, 693);
            tbTong.Name = "tbTong";
            tbTong.Size = new Size(188, 27);
            tbTong.TabIndex = 15;
            tbTong.TextChanged += tbTong_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 793);
            Controls.Add(tbTong);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(jbThanhToan);
            Controls.Add(jbXoa);
            Controls.Add(jbThem);
            Controls.Add(labelThongTinSP);
            Controls.Add(dataGridView1);
            Controls.Add(labelAnhSanPham);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelAnhSanPham;
        private DataGridView dataGridView1;
        private Label labelThongTinSP;
        private Button jbThem;
        private Button jbXoa;
        private Button jbThanhToan;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
        private TextBox tbTong;
    }
}
