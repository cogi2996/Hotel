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
    public partial class Service : Form1
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

        
        }

    }
}
