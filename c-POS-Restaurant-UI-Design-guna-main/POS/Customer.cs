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
