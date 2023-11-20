using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class BookedRoom : Form
    {
        DBConnection cnn = new DBConnection();
        public BookedRoom()
        {
            InitializeComponent();
        }

        private void BookedRoom_Load(object sender, EventArgs e)
        {
            cnn.Connect();
            dgDatPhong.DataSource = cnn.DanhSachDatPhong();
            dgDatPhong.Refresh();

            // Thêm cột nút xóa
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "";
            deleteButton.Name = "Delete";
            deleteButton.Text = "Hủy";
            deleteButton.UseColumnTextForButtonValue = true;
            dgDatPhong.Columns.Add(deleteButton);

            dgDatPhong.CellClick += new DataGridViewCellEventHandler(dgDatPhong_CellClick);
        }

        private void dgDatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgDatPhong.Rows.Count)
            {
                DataGridViewColumn deleteColumn = dgDatPhong.Columns["Delete"];

                if (deleteColumn != null && e.ColumnIndex == deleteColumn.Index)
                {
                    try
                    {
                        int soPhong = (int)dgDatPhong.Rows[e.RowIndex].Cells["SoPhong"].Value;

                        cnn.XoaDatPhong(soPhong);

                        MessageBox.Show("Hủy đặt phòng thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        dgDatPhong.DataSource = cnn.DanhSachDatPhong();
                        dgDatPhong.Refresh();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,
                                        "Lỗi",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
