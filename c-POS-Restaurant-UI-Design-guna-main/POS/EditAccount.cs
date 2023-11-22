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
    public partial class EditAccount : Form
    {
        SqlConnection con;
        DataSet ds;
        SqlDataAdapter da;

        SqlCommand cmd;


        DBConnection dbcon = new DBConnection();
        public EditAccount()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            dg_account.DataSource = dbcon.ListAccount();
            dg_account.Refresh();
            cb_role.DisplayMember = "role";
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {
            dbcon.Connect();
            LoadData();
        }

        private void dg_account_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = -1;
            DataTable dt = new DataTable();
            dt = (DataTable)dg_account.DataSource;
            index = dg_account.SelectedCells[0].RowIndex;
            DataRow row = dt.Rows[index];

            txt_username.Text = row["username"].ToString();
            txt_password.Text = row["password"].ToString();
            cb_role.Text = row["role"].ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                dbcon.AddAccount(txt_username.Text, txt_password.Text, cb_role.Text);
                MessageBox.Show("Thêm account mới thành công!",
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
                txt_username.ResetText();
                txt_password.ResetText();
                cb_role.ResetText();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                dbcon.RemoveAccount(txt_username.Text);
                MessageBox.Show("Xóa tài khoản thành công!",
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
                txt_username.ResetText();
                txt_password.ResetText();
                cb_role.ResetText();
            }
        }
    }
}
