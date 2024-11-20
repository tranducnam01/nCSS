using System.Data;
using System.Data.SqlClient;

namespace KIEMTRA20_11_2024
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        private void button2_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //viết truy vấn theem
           // string query = string.Format("select * from TAIKHOAN where TENDANGNHAP ='{1}' and MATKHAU = '{2}' ",txtTenTK.Text,txtMatKhau.Text);
            string query = string.Format("select * from TAIKHOAN where TENDANGNHAP = '{0}' and MATKHAU = '{1}'", txtTenTK.Text.Trim(), txtMatKhau.Text.Trim());
       
            DataTable tb =kn.laydulieu(query);
            if (tb.Rows.Count == 1) { 
                DataRow row = tb.Rows[0];
                string usename = row["TENDANGNHAP"].ToString();
                string password = row["MATKHAU"].ToString();

                if(usename =="ADMIN" && password == "123")
                {
                    MessageBox.Show("Ddang thành công");
                    hethong frm = new hethong();
                    frm.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("khach hang");
                    hethong frm = new hethong();
                    frm.Show();
                    this.Hide();
                }
            }
            else if(tb.Rows.Count > 1)
            {
                MessageBox.Show("cos loi vois adin");
            }
            else
            {
                MessageBox.Show("tài khoản mật khẩu không đúng","Lỗi" );
            }
        }
    }
}
