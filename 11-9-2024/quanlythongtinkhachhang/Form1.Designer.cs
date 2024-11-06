namespace quanlythongtinkhachhang
{
    partial class FormQLKH
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMa = new TextBox();
            txtTen = new TextBox();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 65);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Khách Hàng : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 125);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Khách hàng :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 195);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 2;
            label3.Text = "Số Điện Thoại :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 259);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 3;
            label4.Text = "Địa Chỉ :";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(221, 58);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(210, 27);
            txtMa.TabIndex = 4;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(221, 118);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(210, 27);
            txtTen.TabIndex = 5;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(221, 188);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(210, 27);
            txtSDT.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(221, 252);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(210, 27);
            txtDiaChi.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(49, 342);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Thêm Khách Hàng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(191, 342);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(337, 342);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(607, 331);
            button4.Name = "button4";
            button4.Size = new Size(127, 29);
            button4.TabIndex = 11;
            button4.Text = "Tạo Đơn Hàng";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(506, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(410, 221);
            dataGridView1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(506, 29);
            label5.Name = "label5";
            label5.Size = new Size(159, 20);
            label5.TabIndex = 13;
            label5.Text = "Thông Tin Khách Hàng";
            // 
            // FormQLKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 411);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDiaChi);
            Controls.Add(txtSDT);
            Controls.Add(txtTen);
            Controls.Add(txtMa);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormQLKH";
            Text = "Quản Lý Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMa;
        private TextBox txtTen;
        private TextBox txtSDT;
        private TextBox txtDiaChi;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label5;
    }
}
