using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlsp_sql
{
    class ConnectionSQL
    {
        string conStr = "Data Source=NAM;Initial Catalog=QLBH;Persist Security Info=True;User ID=sa;Password=123456789;Encrypt=True;Encrypt=True";
        SqlConnection con;
        public ConnectionSQL()
        {
            con = new SqlConnection(conStr);
        }
        public DataSet laydulieu(string truyvan)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(truyvan, con);
                da.Fill(ds);
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public bool thucthi(string truyvan) {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(truyvan, con);
                int r = cmd.ExecuteNonQuery();
                con.Close();
                return r > 0;
            }
            catch
            {
                return false;
            }
        }

    }
}
