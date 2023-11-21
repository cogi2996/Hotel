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
                DataGridViewTextBoxCell cellSoLuong = new DataGridViewTextBoxCell();
                cellSoLuong.Value = 1;

                rowDichVuDaChon.Cells.Add(cellMaDichVu);
                rowDichVuDaChon.Cells.Add(cellTenDichVu);
                rowDichVuDaChon.Cells.Add(cellSoLuong);
                dg_dvDaChon.Rows.Add(rowDichVuDaChon);

            }
        }

        private void LoadData()
        {
            dg_dsdv.DataSource = dbcon.ListService();
            dg_dsdv.Refresh();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            LoadGridByKeyword();
        }

        public void LoadGridByKeyword()
        {

            dbcon.Connect();
            string sql = "select * from DichVu where TenDV like N'%" + txt_search.Text + "%'";
            DataTable dt = dbcon.CreateTable(sql);

            dg_dsdv.DataSource = dt;

            dbcon.Close();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dg_dvDaChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_dvDaChon.CurrentCell.OwningColumn.Name == "col_xoa")
            {                        
                DialogResult result = MessageBox.Show("Bạn có muốn xóa?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    // Lấy chỉ mục của hàng đang được chọn
                    int rowIndex = dg_dvDaChon.CurrentCell.RowIndex;

                    // Xóa hàng đó
                    dg_dvDaChon.Rows.RemoveAt(rowIndex);
                    //MessageBox.Show("Xoá dịch vụ thành công");
                }
                else
                {
                    MessageBox.Show("Thêm dịch vụ thành công");
                }
                
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            /*
            dbcon.Connect();
            int MaKh = dbcon.findOneByPhone(Convert.ToString(txt_SDT.Text));

            foreach (DataGridViewRow row in dg_dvDaChon.Rows)
            {
                int MaDV = Convert.ToInt32(row.Cells["col_madvdachon"].Value);
                int SL = Convert.ToInt32(row.Cells["col_sl"].Value);
                dbcon.ThemSuDungDV(MaKh, MaDV, SL);

            }
            //MessageBox.Show("Thêm các dịch vụ thành công cho mã khách hàng " + MaKh);
            dg_dvDaChon.Rows.Clear(); */
            dbcon.Connect();
            int MaKh = dbcon.findOneByPhone(Convert.ToString(txt_SDT.Text));


            foreach (DataGridViewRow row in dg_dvDaChon.Rows)
            {
                int MaDV = Convert.ToInt32(row.Cells["col_madvdachon"].Value);
                int SL = Convert.ToInt32(row.Cells["col_sl"].Value);
                try
                {
                    dbcon.ThemSuDungDV(MaKh, MaDV, SL);
                    MessageBox.Show("Thêm dịch vụ thành công");
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 50000) // Kiểm tra mức lỗi 16
                    {
                        MessageBox.Show(ex.Message, "Lỗi từ database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi không xác định", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

               
        
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa tất cả các dịch vụ vừa chọn không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                dg_dvDaChon.Rows.Clear();
            }
        }
    }
}
