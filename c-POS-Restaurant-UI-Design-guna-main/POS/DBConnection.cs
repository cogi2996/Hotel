using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace POS
{
    class DBConnection
    {
        SqlCommand cmd = null;
        SqlDataAdapter da = null;
        DataTable dt = null;

        public SqlConnection cnn = new SqlConnection("Data Source=.;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
        public void Connect()
        {
            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void Close()
        {
            cnn.Close();
        }
        public DataTable CreateTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(sql, cnn);
            ds.Fill(dt);
            return dt;
        }
        public static void main()
        {
            DBConnection conn = new DBConnection();
            conn.Connect();
            System.Diagnostics.Debug.WriteLine("Hello world");
        }

        //tin
    


        //tay


        // dat


        //tuan
        public int DatPhong(int SoPhong,int MaKH)
        {
            cnn.Open();
            cmd = new SqlCommand("proc_DatPhongKH", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SoPhong", SoPhong);
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            int count = cmd.ExecuteNonQuery();
            cnn.Close();
            return count;
        }

        // findOne
        public int findOneByPhone(string phone)
        {
            int MaKH = -1;
            string sql = $"select MaKH from KhachHang where SDT = '{phone}' ";
            da = new SqlDataAdapter(sql, cnn);
            dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                  MaKH = int.Parse(row["MaKH"].ToString());
            }

            return MaKH;

        }




    }
}
