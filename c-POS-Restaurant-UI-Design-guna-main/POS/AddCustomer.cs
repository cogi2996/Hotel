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
    public partial class AddCustomer : Form
    {
        DBConnection cnn = new DBConnection();
        public AddCustomer()
        {
            InitializeComponent();
            cnn.Connect();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.AddNewCustomer(txtName.Text, dtDateOfBirth.Value, txtCCCD.Text, txtPhoneNumber.Text, cbCustomerType.Text);
                MessageBox.Show("Thêm thông tin khách hàng mới thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                // Đóng kết nối và đóng form
                cnn.Close();
                this.Close();
            }
            catch (SqlException ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show(ex.Message,
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtName.ResetText();
                dtDateOfBirth.ResetText();
                txtCCCD.ResetText();
                txtPhoneNumber.ResetText();
            }
        }
    }
}
