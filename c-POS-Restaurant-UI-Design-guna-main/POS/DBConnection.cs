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
using CrystalDecisions.CrystalReports.Engine;


namespace POS
{
    class DBConnection
    {
        SqlCommand cmd = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        public SqlConnection cnnAdmin;
        public SqlConnection cnnAccount;
        public ParameterDirection Direction { get; private set; }

        public SqlConnection GetConnectionAdmin()
        {
            return this.cnnAdmin;
        }

        public void ConnectAdmin()
        {
            try
            {
                cnnAdmin = new SqlConnection("Data Source=.;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
                cnnAdmin.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void CloseAdmin()
        {
            cnnAdmin.Close();
        }
        public void Connect()
        {
            try
            {
                cnnAccount = new SqlConnection($"Data Source=.;Initial Catalog=QuanLyKhachSan;User ID={GLOBAL.username};Password={GLOBAL.password}");
                cnnAccount.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void Close()
        {
            cnnAccount.Close();
        }



        public DataTable CreateTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(sql, cnnAccount);
            ds.Fill(dt);
            return dt;
        }



        public static void main()
        {
            DBConnection conn = new DBConnection();
            conn.ConnectAdmin();
            System.Diagnostics.Debug.WriteLine("Hello world");
        }

        //tin

        public void ThemSuDungDV(int MaKH, int MaDV, int SoLuong)
        {

            try
            {
                ConnectAdmin();

                using (SqlCommand cmd = new SqlCommand("proc_ThemDichVuSuDung", cnnAccount))
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
                CloseAdmin();
            }
        }

        public DataTable ListService()
        {
            dt = new DataTable();

            cmd = new SqlCommand("SELECT * FROM f_XemDanhSachDichVu()", cnnAccount);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        public void AddService(string TenDV, int DonGia)
        {
            cmd = new SqlCommand("proc_ThemDichVu", cnnAccount);
            cmd.CommandType = CommandType.StoredProcedure;

            // Thêm tham số cho stored procedure
            cmd.Parameters.AddWithValue("@TenDV", TenDV);
            cmd.Parameters.AddWithValue("@DonGia", DonGia);
            
            cmd.ExecuteNonQuery();
        }

        public void EditService(int MaDV, string TenDV, int DonGia)
        {
            cmd = new SqlCommand("proc_SuaDichVu", cnnAccount);
            cmd.CommandType = CommandType.StoredProcedure;

            // Thêm tham số cho stored procedure
            cmd.Parameters.AddWithValue("@MaDV", MaDV);
            cmd.Parameters.AddWithValue("@TenDV", TenDV);
            cmd.Parameters.AddWithValue("@DonGia", DonGia);

            cmd.ExecuteNonQuery();
        }

        public void RemoveService(int MaDV)
        {
            cmd = new SqlCommand("proc_XoaDichVu", cnnAccount);
            cmd.CommandType = CommandType.StoredProcedure;

            // Thêm tham số cho stored procedure
            cmd.Parameters.AddWithValue("@MaDV", MaDV);


            cmd.ExecuteNonQuery();
        }

        public DataTable ListAccount()
        {
            dt = new DataTable();

            cmd = new SqlCommand("SELECT * FROM Dangnhap", cnnAccount);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        public void RemoveAccount(String username)
        {
            cmd = new SqlCommand("proc_XoaTaiKhoan", cnnAccount);
            cmd.CommandType = CommandType.StoredProcedure;

            // Thêm tham số cho stored procedure
            cmd.Parameters.AddWithValue("@username", username);


            cmd.ExecuteNonQuery();
        }

        public void AddAccount(String username, String password, String role)
        {
            cmd = new SqlCommand("proc_ThemTaiKhoan", cnnAccount);
            cmd.CommandType = CommandType.StoredProcedure;

            // Thêm tham số cho stored procedure
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@role", role);

            cmd.ExecuteNonQuery();
        }

        //tay
        public DataTable ListCustomer()
        {
            dt = new DataTable();

            cmd = new SqlCommand("SELECT * FROM f_XemDanhSachKhachHang()", cnnAccount);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        public DataTable ListVIPCustomer()
        {
            dt = new DataTable();

            cmd = new SqlCommand("SELECT * FROM f_XemDanhSachKhachHangVIP()", cnnAccount);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        public DataTable ListNormalCustomer()
        {
            dt = new DataTable();

            cmd = new SqlCommand("SELECT * FROM f_XemDanhSachKhachHangThuong()", cnnAccount);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }


        public void AddNewCustomer(string TenKH, DateTime NgaySinh, string CCCD, string SDT, string LoaiKH)
        {
            cmd = new SqlCommand("proc_ThemKhachHang", cnnAccount);
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

            cmd = new SqlCommand("proc_ThongTinKhachHang", cnnAccount);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaKH", MaKH);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public void EditCustomerInfo(int MaKH, string TenKH, DateTime NgaySinh, string CCCD, string SDT, string LoaiKH)
        {
            cmd = new SqlCommand("proc_SuaThongTinKhachHang", cnnAccount);
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
            cmd = new SqlCommand("proc_XoaKhachHang", cnnAccount);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaKH", MaKH);

            cmd.ExecuteNonQuery();
        }

        public DataTable ListRoom()
        {
            dt = new DataTable();

            cmd = new SqlCommand("SELECT * FROM v_Phong", cnnAccount);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        public void AddRoom(int soPhong, string loai, int sucChua, string tinhTrang)
        {
            cmd = new SqlCommand("proc_ThemPhong", cnnAccount);
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
            cmd = new SqlCommand("proc_SuaPhong", cnnAccount);
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
            cmd = new SqlCommand("proc_XoaPhong", cnnAccount);
            cmd.CommandType = CommandType.StoredProcedure;

            // Thêm tham số cho stored procedure
            cmd.Parameters.AddWithValue("@SoPhong", soPhong);

            cmd.ExecuteNonQuery();
        }

        public DataTable BangGiaPhong()
        {
            dt = new DataTable();

            cmd = new SqlCommand("SELECT * FROM v_BangGia", cnnAccount);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        public DataTable LichSuHoaDon()
        {
            dt = new DataTable();

            cmd = new SqlCommand("proc_DanhSachHoaDon", cnnAccount);
            cmd.CommandType = CommandType.StoredProcedure;

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public DataTable DanhSachDatPhong()
        {
            dt = new DataTable();

            cmd = new SqlCommand("proc_XemDatPhong", cnnAccount);
            cmd.CommandType = CommandType.StoredProcedure;

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public void XoaDatPhong(int soPhong)
        {
            cmd = new SqlCommand("proc_XoaDatPhong", cnnAccount);
            cmd.CommandType = CommandType.StoredProcedure;

            // Thêm tham số cho stored procedure
            cmd.Parameters.AddWithValue("@SoPhong", soPhong);

            cmd.ExecuteNonQuery();
        }
        //tuan
        public int DatPhong(int SoPhong, int MaKH)
        {
            cnnAccount.Open();
            cmd = new SqlCommand("proc_DatPhongKH", cnnAccount);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SoPhong", SoPhong);
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            cmd.Parameters.AddWithValue("@checkin", DateTime.Now);
            int count = cmd.ExecuteNonQuery();
            cnnAccount.Close();
            return count;
        }

        // findOne
        public int findOneByPhone(string phone)
        {
            int MaKH = -1;
            string sql = $"select MaKH from KhachHang where SDT = '{phone}' ";
            da = new SqlDataAdapter(sql, cnnAccount);
            dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                MaKH = int.Parse(row["MaKH"].ToString());
            }

            return MaKH;


        }
        public DataTable DS_KhachHang(string sql)
        {
            dt = new DataTable();

            cmd = new SqlCommand(sql, cnnAccount);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }
        public int SoDem(string checkin,string checkout)
        {
            cnnAccount.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "f_TinhSoDem";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@checkin_str", checkin));
            cmd.Parameters.Add(new SqlParameter("@checkout_str", checkout));

            var retValParam = new SqlParameter("sodem", SqlDbType.NVarChar, 50);
            {
                Direction = ParameterDirection.ReturnValue;
            }
            cmd.Parameters.Add(retValParam);
            int tenloai;
            cmd.ExecuteScalar();
            tenloai = (int)retValParam.Value;
            return tenloai;
        }
        public void TaoHoaDon(string ma,string ten,string phong,string dem,string ngays,string ngayden,string ngaydi,string tp,string tdv,string tiendv,string tt)
        {
            cnnAccount.Open();
            cmd = new SqlCommand("proc_taoHoaDon", cnnAccount);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", ma);
            cmd.Parameters.AddWithValue("@TenKH", ten);
            cmd.Parameters.AddWithValue("@SoPhong", phong);
            cmd.Parameters.AddWithValue("@SoDem", dem);
            cmd.Parameters.AddWithValue("@NgaySinh", ngays);
            cmd.Parameters.AddWithValue("@CheckIn", ngayden);
            cmd.Parameters.AddWithValue("@Ngaydi", ngaydi);
            cmd.Parameters.AddWithValue("@TienPhong", tp);
            cmd.Parameters.AddWithValue("@TenDV", tdv);
            cmd.Parameters.AddWithValue("@TienDV", tiendv);
            cmd.Parameters.AddWithValue("@TongTien", tt);
            cmd.ExecuteNonQuery();
            cnnAccount.Close();
        }





    }




}
