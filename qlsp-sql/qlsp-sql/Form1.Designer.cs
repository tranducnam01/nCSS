namespace qlsp_sql
{
    partial class formSanPham
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
            label1 = new Label();
            txtMaSP = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTenSP = new TextBox();
            txtMoTa = new TextBox();
            txtGia = new TextBox();
            txtSoluong = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            txtTimKiem = new TextBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 49);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Sản Phẩm";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(166, 42);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(210, 27);
            txtMaSP.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 110);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên Sản Phẩm\r\n";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(591, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(500, 321);
            dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 163);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 6;
            label3.Text = "Mô Tả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 217);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 7;
            label4.Text = "Giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 266);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 8;
            label5.Text = "Số Lượng";
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(166, 110);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(210, 27);
            txtTenSP.TabIndex = 9;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(166, 163);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(210, 27);
            txtMoTa.TabIndex = 10;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(166, 217);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(210, 27);
            txtGia.TabIndex = 11;
            // 
            // txtSoluong
            // 
            txtSoluong.Location = new Point(166, 266);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(210, 27);
            txtSoluong.TabIndex = 12;
            txtSoluong.TextChanged += textBox5_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(46, 364);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Thêm\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(197, 364);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 14;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(336, 364);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 15;
            button3.Text = "Xóa\r\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(591, 12);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 16;
            button4.Text = "Tìm Kiếm\r\n";
            button4.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(591, 49);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(500, 27);
            txtTimKiem.TabIndex = 17;
            // 
            // button5
            // 
            button5.Location = new Point(427, 72);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 18;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // formSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 467);
            Controls.Add(button5);
            Controls.Add(txtTimKiem);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtSoluong);
            Controls.Add(txtGia);
            Controls.Add(txtMoTa);
            Controls.Add(txtTenSP);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(txtMaSP);
            Controls.Add(label1);
            Name = "formSanPham";
            Text = "Sản Phẩm";
            Load += formSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaSP;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTenSP;
        private TextBox txtMoTa;
        private TextBox txtGia;
        private TextBox txtSoluong;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox txtTimKiem;
        private Button button5;
    }
}
