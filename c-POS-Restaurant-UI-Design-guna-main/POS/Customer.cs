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
    public partial class Customer : Form
    {
        DBConnection cnn = new DBConnection();

        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            cnn.Connect();
            LoadData();
        }

        private void LoadData()
        {
            dgCustomer.DataSource = cnn.ListCustomer();
            dgCustomer.Refresh();

            // Thêm cột nút sửa
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "";
            editButton.Name = "Edit";
            editButton.Text = "Sửa";
            editButton.UseColumnTextForButtonValue = true;
            dgCustomer.Columns.Add(editButton);

            // Thêm cột nút xóa
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "";
            deleteButton.Name = "Delete";
            deleteButton.Text = "Xóa";
            deleteButton.UseColumnTextForButtonValue = true;
            dgCustomer.Columns.Add(deleteButton);

            dgCustomer.CellClick += new DataGridViewCellEventHandler(dgCustomer_CellClick);
        }

        private void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn columnSua = dgCustomer.Columns["Edit"];
                DataGridViewColumn columnXoa = dgCustomer.Columns["Delete"];

                if (columnSua != null && e.ColumnIndex == columnSua.Index)
                {
                    // Lấy mã khách hàng cần sửa
                    int customerID = (int)dgCustomer.Rows[e.RowIndex].Cells["MaKH"].Value;

                    // Gọi form sửa thông tin với MaKH đã biết
                    EditCustomer formEdit = new EditCustomer(customerID);
                    formEdit.ShowDialog();

                    // Tải lại dữ liệu sau khi chỉnh sửa
                    dgCustomer.Columns.Clear();
                    LoadData();
                }
               /* else if (columnXoa != null && e.ColumnIndex == columnXoa.Index)
                {
                    try
                    {
                        // Lấy mã khách hàng cần xóa
                        int maKH = (int)dgKhachHang.Rows[e.RowIndex].Cells["MaKH"].Value;

                        // Xóa thông tin khách hàng có MaKH đã biết
                        cmd = new SqlCommand("proc_XoaKhachHang", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MaKH", SqlDbType.Int).Value = maKH;

                        // Thực thi SqlCommand
                        cmd.ExecuteNonQuery();

                        // Tải lại dữ liệu sau khi xóa
                        dgKhachHang.Columns.Clear();
                        LoadData();

                    }
                    catch
                    {
                        MessageBox.Show("Khách hàng đang có đơn đặt phòng, không thể xóa",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }*/
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // Gọi form thêm thông tin khách hàng mới
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();

            // Tải lại dữ liệu sau khi chỉnh sửa
            dgCustomer.Columns.Clear();
            LoadData();
        }
    }
}
