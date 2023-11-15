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

        public void ThemSuDungDV(int MaKH, int MaDV, int SoLuong)
        {

            try
            {
                Connect();

                using (SqlCommand cmd = new SqlCommand("proc_ThemDichVuSuDung", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Định rõ các tham số của stored procedure
                    cmd.Parameters.AddWithValue("@MaKH", MaKH);
                    cmd.Parameters.AddWithValue("@MaDV", MaDV);
                    cmd.Parameters.AddWithValue("@SoLuong", SoLuong);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi khi stored procedure báo lỗi
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                Close();
            }
        }

        //tay
        public DataTable ListCustomer()
        {
            dt = new DataTable();

            cmd = new SqlCommand("SELECT * FROM f_XemDanhSachKhachHang()", cnn);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        public DataTable ListVIPCustomer()
        {
            dt = new DataTable();

            cmd = new SqlCommand("SELECT * FROM f_XemDanhSachKhachHangVIP()", cnn);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        public DataTable ListNormalCustomer()
        {
            dt = new DataTable();

            cmd = new SqlCommand("SELECT * FROM f_XemDanhSachKhachHangThuong()", cnn);
            cmd.CommandType = CommandType.Text;

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

        public void DeleteCustomer(int MaKH)
        {
            cmd = new SqlCommand("proc_XoaKhachHang", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaKH", MaKH);

            cmd.ExecuteNonQuery();
        }

        public DataTable ListRoom()
        {
            dt = new DataTable();

            cmd = new SqlCommand("SELECT * FROM v_Phong", cnn);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        public void AddRoom(int soPhong, string loai, int sucChua, string tinhTrang)
        {
            cmd = new SqlCommand("proc_ThemPhong", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Thêm tham số cho stored procedure
            cmd.Parameters.AddWithValue("@SoPhong", soPhong);
            cmd.Parameters.AddWithValue("@Loai", loai);
            cmd.Parameters.AddWithValue("@SucChua", sucChua);
            cmd.Parameters.AddWithValue("@TinhTrang", tinhTrang);

            cmd.ExecuteNonQuery();
        }

        public void EditRoom(int soPhong, string loai, int sucChua, string tinhTrang)
        {
            cmd = new SqlCommand("proc_SuaPhong", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Thêm tham số cho stored procedure
            cmd.Parameters.AddWithValue("@SoPhong", soPhong);
            cmd.Parameters.AddWithValue("@Loai", loai);
            cmd.Parameters.AddWithValue("@SucChua", sucChua);
            cmd.Parameters.AddWithValue("@TinhTrang", tinhTrang);

            cmd.ExecuteNonQuery();
        }

        public void RemoveRoom(int soPhong)
        {
            cmd = new SqlCommand("proc_XoaPhong", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Thêm tham số cho stored procedure
            cmd.Parameters.AddWithValue("@SoPhong", soPhong);

            cmd.ExecuteNonQuery();
        }
        //tuan
        public int DatPhong(int SoPhong, int MaKH)
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
