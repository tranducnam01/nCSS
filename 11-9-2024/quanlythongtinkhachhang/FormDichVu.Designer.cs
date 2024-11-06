namespace quanlythongtinkhachhang
{
    partial class FormDichVu
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            cbxLoaiDV = new ComboBox();
            label4 = new Label();
            txtTenDV = new TextBox();
            label5 = new Label();
            txtGia = new TextBox();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(526, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 0;
            label1.Text = "Danh Sách Dịch Vụ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(526, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(418, 185);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 9);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 2;
            label2.Text = "Dịch Vụ khách Sử Dụng";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 129);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 3;
            label3.Text = "Loại Dịch Vụ:";
            label3.Click += label3_Click;
            // 
            // cbxLoaiDV
            // 
            cbxLoaiDV.FormattingEnabled = true;
            cbxLoaiDV.Items.AddRange(new object[] { "Gà đi bộ", "Mèn mén", "Đào đồ sơn ", "Hàu quất lâm" });
            cbxLoaiDV.Location = new Point(164, 126);
            cbxLoaiDV.Name = "cbxLoaiDV";
            cbxLoaiDV.Size = new Size(223, 28);
            cbxLoaiDV.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 51);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 5;
            label4.Text = "Tên Dịch vụ";
            // 
            // txtTenDV
            // 
            txtTenDV.Location = new Point(164, 51);
            txtTenDV.Name = "txtTenDV";
            txtTenDV.Size = new Size(223, 27);
            txtTenDV.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 209);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 7;
            label5.Text = "Giá Dịch Vụ:";
            label5.Click += label5_Click;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(164, 202);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(223, 27);
            txtGia.TabIndex = 8;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(22, 329);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(418, 157);
            dataGridView2.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(31, 269);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(164, 269);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(293, 269);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 13;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(526, 364);
            button4.Name = "button4";
            button4.Size = new Size(204, 38);
            button4.TabIndex = 14;
            button4.Text = "Thanh Toán\r\n\r\n";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(752, 364);
            button5.Name = "button5";
            button5.Size = new Size(192, 38);
            button5.TabIndex = 15;
            button5.Text = "hoàn thành";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // FormDichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 570);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(txtGia);
            Controls.Add(label5);
            Controls.Add(txtTenDV);
            Controls.Add(label4);
            Controls.Add(cbxLoaiDV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "FormDichVu";
            Text = "FormDichVu";
            Load += FormDichVu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private ComboBox cbxLoaiDV;
        private Label label4;
        private TextBox txtTenDV;
        private Label label5;
        private TextBox txtGia;
        private DataGridView dataGridView2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}