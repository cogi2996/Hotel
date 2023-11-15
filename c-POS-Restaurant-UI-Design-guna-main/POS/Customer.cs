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
        private Boolean showAllButtonVisible = false;

        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            cnn.Connect();
            LoadData();
            btnShowAll.Visible = showAllButtonVisible;
        }

        private void LoadData()
        {
            dgCustomer.DataSource = cnn.ListCustomer();
            dgCustomer.Refresh();
            AddEditAndDeleteButtons();
        }

        private void AddEditAndDeleteButtons()
        {
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
            if (e.RowIndex >= 0 && e.RowIndex < dgCustomer.Rows.Count)
            {
                DataGridViewColumn editColumn = dgCustomer.Columns["Edit"];
                DataGridViewColumn deleteColumn = dgCustomer.Columns["Delete"];

                if (editColumn != null && e.ColumnIndex == editColumn.Index)
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
                else if (deleteColumn != null && e.ColumnIndex == deleteColumn.Index)
                {
                    try
                    {
                        // Lấy mã khách hàng cần xóa
                        int customerID = (int)dgCustomer.Rows[e.RowIndex].Cells["MaKH"].Value;

                        cnn.DeleteCustomer(customerID);

                        MessageBox.Show("Xóa khách hàng thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        dgCustomer.Columns.Clear();
                        LoadData();

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

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // Gọi form thêm thông tin khách hàng mới
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();

            // Tải lại dữ liệu sau khi chỉnh sửa
            dgCustomer.Columns.Clear();
            LoadData();
        }

        private void cbFilterCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbFilterCustomer.SelectedIndex;

            if (selectedIndex >= 0)
            {
                string selectedValue = cbFilterCustomer.Items[selectedIndex].ToString();

                if (selectedValue == "V")
                {
                    dgCustomer.DataSource = cnn.ListVIPCustomer();
                    dgCustomer.Refresh();

                    showAllButtonVisible = true;
                }
                else if (selectedValue == "T")
                {
                    dgCustomer.DataSource = cnn.ListNormalCustomer();
                    dgCustomer.Refresh();

                    showAllButtonVisible = true;
                }
            }
            else
            {
                showAllButtonVisible = false;
            }

            btnShowAll.Visible = showAllButtonVisible;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dgCustomer.DataSource = cnn.ListCustomer();
            dgCustomer.Refresh();

            cbFilterCustomer.SelectedIndex = -1;

            showAllButtonVisible = false;

            btnShowAll.Visible = showAllButtonVisible;

            // Tải lại dữ liệu sau khi chỉnh sửa
            dgCustomer.Columns.Clear();
            dgCustomer.DataSource = cnn.ListCustomer();
            dgCustomer.Refresh();
        }
    }
}
