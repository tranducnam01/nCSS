using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace KIEMTRA20_11_2024
{
    internal class ketnoi
    {
        private string contr = @"Data Source=NAM;Initial Catalog=MOBILE_SHOP;Persist Security Info=True;User ID=sa;Password=123456789;Encrypt=False";
        private SqlConnection conn;

        public ketnoi()
        {
            conn = new SqlConnection(contr);
        }

        public DataTable laydulieu(string truyvan)
        {
            SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
            DataTable dt = new DataTable();
            try
            {
                // Kiểm tra kết nối trước khi thực thi
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                da.Fill(dt); // Thực thi câu truy vấn và lấy dữ liệu vào DataTable
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Lỗi SQL: {sqlEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close(); // Đảm bảo luôn đóng kết nối
            }
            return dt;
        }

        public bool thucthi(string truyvan)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                // Ghi log câu lệnh trước khi thực thi
                Console.WriteLine("Executing query: " + truyvan);

                SqlCommand cmd = new SqlCommand(truyvan, conn);
                int r = cmd.ExecuteNonQuery();
                return r > 0; // Trả về true nếu có bản ghi bị ảnh hưởng
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Lỗi khi thực thi câu lệnh: {sqlEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close(); // Đảm bảo đóng kết nối
            }
        }

    }
}
