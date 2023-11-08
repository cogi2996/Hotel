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
    public partial class Order : Form
    {
        DBConnection conn = new DBConnection();
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.quanLyKhachSanDataSet.Phong);

        }
        public void reset()
        {
            txtSoPhong.ResetText();
            txtLoaiPhong.ResetText();
            txtSucChua.ResetText();
             dg_dsPhong.DataSource= conn.CreateTable("select * from Phong");
        }
     

        private void dg_dsPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtSoPhong.Text = dg_dsPhong.CurrentRow.Cells["soPhong"].Value.ToString();
                txtSucChua.Text = dg_dsPhong.CurrentRow.Cells["sucChua"].Value.ToString();
                txtLoaiPhong.Text = dg_dsPhong.CurrentRow.Cells["loaiPhong"].Value.ToString();
            }


        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            string phone = txtSoDT.Text.ToString();
            int MaKH = conn.findOneByPhone(phone);
            int soPhong = int.Parse(txtSoPhong.Text);
            int count = conn.DatPhong(soPhong,MaKH);
            if (count > 0)
            {
                MessageBox.Show("Đặt phòng thành công ");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
            this.reset();
        }
    }
}
