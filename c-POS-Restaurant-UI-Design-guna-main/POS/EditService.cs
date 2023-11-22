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
    public partial class EditService : Form
    {
        SqlConnection con;
        DataSet ds;
        SqlDataAdapter da;

        SqlCommand cmd;


        DBConnection dbcon = new DBConnection();
        public EditService()
        {
            InitializeComponent();
        }

        private void EditService_Load(object sender, EventArgs e)
        {
            dbcon.Connect();
            LoadData();
        }

        private void dg_dsdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = -1;
            DataTable dt = new DataTable();
            dt = (DataTable)dg_dsdv.DataSource;
            index = dg_dsdv.SelectedCells[0].RowIndex;
            DataRow row = dt.Rows[index];

            txtMaDV.Text = row["MaDV"].ToString();
            txtTenDV.Text = row["TenDV"].ToString();
            txtDonGia.Text = row["DonGia"].ToString();
           
        }


        private void LoadData()
        {
            dg_dsdv.DataSource = dbcon.ListService();
            dg_dsdv.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                dbcon.AddService(txtTenDV.Text, int.Parse(txtDonGia.Text));
                MessageBox.Show("Thêm dịch vụ mới thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                LoadData();
            }
            catch (SqlException ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show(ex.Message,
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtMaDV.ResetText();
                txtTenDV.ResetText();
                txtDonGia.ResetText();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                dbcon.RemoveService(int.Parse(txtMaDV.Text));
                MessageBox.Show("Xóa dịch vụ thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                LoadData();
            }
            catch (SqlException ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show(ex.Message,
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtMaDV.ResetText();
                txtTenDV.ResetText();
                txtDonGia.ResetText();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                dbcon.EditService(int.Parse(txtMaDV.Text), txtTenDV.Text, int.Parse(txtDonGia.Text));
                MessageBox.Show("Sửa thông tin dịch vụ thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                LoadData();
            }
            catch (SqlException ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show(ex.Message,
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtMaDV.ResetText();
                txtTenDV.ResetText();
                txtDonGia.ResetText();
            }
        }
    }
}
