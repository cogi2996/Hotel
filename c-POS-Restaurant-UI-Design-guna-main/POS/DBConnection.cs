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
        SqlConnection conn = null;
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
        public void ThemDichVU()
        {

        }


        //tay
        public DataTable ListCustomer()
        {
            dt = new DataTable();

            cmd = new SqlCommand("proc_XemDanhSachKhachHang", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
               
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        public void AddNewCustomer(string TenKH, DateTime NgaySinh, string CCCD, string SDT, string LoaiKH)
        {
            cmd = new SqlCommand("proc_ThemKhachHang", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TenKH", TenKH);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            cmd.Parameters.AddWithValue("@CCCD", CCCD);
            cmd.Parameters.AddWithValue("@SDT", SDT);
            cmd.Parameters.AddWithValue("@LoaiKH", LoaiKH);

            cmd.ExecuteNonQuery();
        }

        public DataTable CustomerInfo(int MaKH)
        {
            dt = new DataTable();

            cmd = new SqlCommand("proc_ThongTinKhachHang", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaKH", MaKH);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public void EditCustomerInfo(int MaKH, string TenKH, DateTime NgaySinh, string CCCD, string SDT, string LoaiKH)
        {
            cmd = new SqlCommand("proc_SuaThongTinKhachHang", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            cmd.Parameters.AddWithValue("@TenKH", TenKH);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            cmd.Parameters.AddWithValue("@CCCD", CCCD);
            cmd.Parameters.AddWithValue("@SDT", SDT);
            cmd.Parameters.AddWithValue("@LoaiKH", LoaiKH);

            cmd.ExecuteNonQuery();
        }

    }


    // dat


    //tuan





}
