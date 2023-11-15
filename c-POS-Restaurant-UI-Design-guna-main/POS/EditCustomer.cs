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
    public partial class EditCustomer : Form
    {
        DBConnection cnn = new DBConnection();
        private int customerID;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;

        public EditCustomer(int customerID)
        {
            InitializeComponent();
            cnn.Connect();
            this.customerID = customerID;
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            // Thực thi thủ tục và đổ dữ liệu vào DataTable
            dt = cnn.CustomerInfo(this.customerID);

            // Điền thông tin vào các textbox
            txtName.Text = dt.Rows[0]["TenKH"].ToString();
            dtDateOfBirth.Value = Convert.ToDateTime(dt.Rows[0]["NgaySinh"]);
            txtCCCD.Text = dt.Rows[0]["CCCD"].ToString();
            txtPhoneNumber.Text = dt.Rows[0]["SDT"].ToString();
            cbCustomerType.Text = dt.Rows[0]["LoaiKH"].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.EditCustomerInfo(this.customerID, txtName.Text, dtDateOfBirth.Value, txtCCCD.Text, txtPhoneNumber.Text, cbCustomerType.Text);
                MessageBox.Show("Chỉnh sửa thông tin khách hàng thành công!",
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
            }
        }
    }
}
