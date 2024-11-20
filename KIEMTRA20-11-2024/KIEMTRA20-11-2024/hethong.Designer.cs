namespace KIEMTRA20_11_2024
{
    partial class hethong
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
            panel1 = new Panel();
            label1 = new Label();
            button_DonHang = new Button();
            button2 = new Button();
            button_SanPham = new Button();
            button_KhachHang = new Button();
            panel2 = new Panel();
            button_thoat = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button_thoat);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button_DonHang);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button_SanPham);
            panel1.Controls.Add(button_KhachHang);
            panel1.Location = new Point(12, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 372);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(51, 30);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 4;
            label1.Text = "Menu";
            // 
            // button_DonHang
            // 
            button_DonHang.Location = new Point(31, 254);
            button_DonHang.Name = "button_DonHang";
            button_DonHang.Size = new Size(110, 29);
            button_DonHang.TabIndex = 3;
            button_DonHang.Text = "Đơn Hàng";
            button_DonHang.UseVisualStyleBackColor = true;
            button_DonHang.Click += button_DonHang_Click;
            // 
            // button2
            // 
            button2.Location = new Point(65, 264);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button_SanPham
            // 
            button_SanPham.Location = new Point(31, 170);
            button_SanPham.Name = "button_SanPham";
            button_SanPham.Size = new Size(110, 29);
            button_SanPham.TabIndex = 1;
            button_SanPham.Text = "Sản Phẩm";
            button_SanPham.UseVisualStyleBackColor = true;
            // 
            // button_KhachHang
            // 
            button_KhachHang.Location = new Point(31, 90);
            button_KhachHang.Name = "button_KhachHang";
            button_KhachHang.Size = new Size(110, 29);
            button_KhachHang.TabIndex = 0;
            button_KhachHang.Text = "Khách hàng";
            button_KhachHang.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Location = new Point(195, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1070, 719);
            panel2.TabIndex = 1;
            // 
            // button_thoat
            // 
            button_thoat.Location = new Point(31, 328);
            button_thoat.Name = "button_thoat";
            button_thoat.Size = new Size(110, 29);
            button_thoat.TabIndex = 5;
            button_thoat.Text = "Thoát";
            button_thoat.UseVisualStyleBackColor = true;
            button_thoat.Click += button_thoat_Click;
            // 
            // hethong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 716);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "hethong";
            Text = "hethong";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_KhachHang;
        private Label label1;
        private Button button_DonHang;
        private Button button2;
        private Button button_SanPham;
        private Panel panel2;
        private Button button_thoat;
    }
}