using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Service : Form
    {
        SqlConnection con;
        DataSet ds;
        SqlDataAdapter da;

        SqlCommand cmd;


        DBConnection dbcon = new DBConnection();
        public Service()
        {
            InitializeComponent();
        }

        private void Service_Load(object sender, EventArgs e)
        {
            dbcon.Connect();
            LoadData();
        }

        private void dg_dsdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_dsdv.CurrentCell.OwningColumn.Name == "col_them")
            {

                // Lấy dữ liệu từ dòng đang được chọn
                DataGridViewRow row = dg_dsdv.SelectedRows[0];
                string maDichVu = row.Cells["col_madv"].Value.ToString();
                string tenDichVu = row.Cells["col_tendv"].Value.ToString();

                DataGridViewRow rowDichVuDaChon = new DataGridViewRow();
                // dữ liệu của 1 ô mới
                DataGridViewTextBoxCell cellMaDichVu = new DataGridViewTextBoxCell();
                cellMaDichVu.Value = maDichVu;
                DataGridViewTextBoxCell cellTenDichVu = new DataGridViewTextBoxCell();
                cellTenDichVu.Value = tenDichVu;
                DataGridViewTextBoxCell cellMaKh = new DataGridViewTextBoxCell();
                cellMaKh.Value = "";
                rowDichVuDaChon.Cells.Add(cellMaKh);
                rowDichVuDaChon.Cells.Add(cellMaDichVu);
                rowDichVuDaChon.Cells.Add(cellTenDichVu);
                dg_dvDaChon.Rows.Add(rowDichVuDaChon);

                //this.Hide();
                //frmChonDV frmChonDV = new frmChonDV();
                //frmChonDV.ShowDialog();
                //frmChonDV.Invalidate();
                //this.Show();
            }
        }

        private void LoadData()
        {
            dbcon.Connect();
            string sql = "select * from DichVu";
            dg_dsdv.DataSource = dbcon.CreateTable(sql);
            string sql1 = "select * from KhachHang";
            cb_khachang.DataSource = dbcon.CreateTable(sql1);
            cb_khachang.DisplayMember = "MaKH";


        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            LoadGridByKeyword();
        }

        public void LoadGridByKeyword()
        {

            dbcon.Connect();
            // dt để lưu trữ csdl
            ds = new DataSet();
            string sql = "select * from DichVu where TenDV like '%" + txt_search.Text + "%'";
            dg_dsdv.DataSource = dbcon.CreateTable(sql);
            // làm mới
            
            //dg_dsdv.Refresh();


            /*
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.KhachSan))
            {
                // đt kn csdl
                con = new SqlConnection();
                // gắn chuỗi kn
                con.ConnectionString = Properties.Settings.Default.KhachSan;
                con.Open();
                // dt để lưu trữ csdl
                ds = new DataSet();
                string sql = "select * from DichVu where TenDV like '%" + txt_search.Text + "%'";
                // thực hiện truy vấn 
                da = new SqlDataAdapter(sql, con);
                // điền dl vào ds
                da.Fill(ds);
                // đổ dl lên gridview

                dg_dsdv.DataSource = ds.Tables[0];
                // làm mới
                dg_dsdv.Refresh();
            }*/
        }

        private void cb_khachang_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            string sql = "Select * from DMMH where MaMH = '" + cb_khachang.Text + "'";
            DataTable d = dbcon.CreateTable(sql);
            foreach (DataRow hang in d.Rows)
            {
                txt_TenMH.Text = hang["TenMH"].ToString();
                txt_SoTiet.Text = hang["SoTiet"].ToString();
            }
            string s2 = "Select sv.MaSV, HoSV, TenSV, NgaySinh, Diem from DMSV sv, KetQua kq where (sv.MaSV = kq.MaSV) and kq.MaMH = '" + cb_MaMH.Text + "'";
            dataGridViewDiem.DataSource = cn.taobang(s2);*/
        }
    }
}
