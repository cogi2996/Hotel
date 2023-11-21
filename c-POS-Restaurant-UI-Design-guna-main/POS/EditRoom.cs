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
using System.Xml.Linq;

namespace POS
{
    public partial class EditRoom : Form
    {
        DBConnection cnn = new DBConnection();
        public EditRoom()
        {
            InitializeComponent();
        }

        private void EditRoom_Load(object sender, EventArgs e)
        {
            cnn.Connect();
            LoadData();
        }

        private void LoadData()
        {
            dgPhong.DataSource = cnn.ListRoom();
            dgPhong.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.AddRoom(int.Parse(txtSoPhong.Text), cbLoaiPhong.Text, int.Parse(txtSucChua.Text), cbTinhTrang.Text);
                MessageBox.Show("Thêm phòng mới thành công!",
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
                txtSoPhong.ResetText();
                cbLoaiPhong.ResetText();
                txtSucChua.ResetText();
                cbTinhTrang.ResetText();
            }
        }

        private void dgPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = -1;
            DataTable dt = new DataTable();
            dt = (DataTable)dgPhong.DataSource;
            index = dgPhong.SelectedCells[0].RowIndex;
            DataRow row = dt.Rows[index];

            txtSoPhong.Text = row["SoPhong"].ToString();
            txtSucChua.Text = row["SucChua"].ToString();
            cbTinhTrang.Text = row["TinhTrang"].ToString();
            cbLoaiPhong.Text = row["LoaiPhong"].ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.EditRoom(int.Parse(txtSoPhong.Text), cbLoaiPhong.Text, int.Parse(txtSucChua.Text), cbTinhTrang.Text);
                MessageBox.Show("Sửa thông tin phòng thành công!",
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
                txtSoPhong.ResetText();
                cbLoaiPhong.ResetText();
                txtSucChua.ResetText();
                cbTinhTrang.ResetText();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.RemoveRoom(int.Parse(txtSoPhong.Text));
                MessageBox.Show("Xóa phòng thành công!",
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
                txtSoPhong.ResetText();
                cbLoaiPhong.ResetText();
                txtSucChua.ResetText();
                cbTinhTrang.ResetText();
            }
        }
    }
}
