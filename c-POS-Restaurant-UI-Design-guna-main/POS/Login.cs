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
using CrystalDecisions.CrystalReports.Engine;

namespace POS
{
    public partial class Login : Form
    {
        private DBConnection cnnAdmin = new DBConnection();
        public Login()
        {
            InitializeComponent();
        }

     

        private void Login_Load(object sender, EventArgs e)
        {
            lbSuccess.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            cnnAdmin.ConnectAdmin();
            GLOBAL.username = txtName.Text;
            GLOBAL.password = txtPass.Text;

            SqlCommand cmd = new SqlCommand("Select dbo.checkLogin(@username,@password)",cnnAdmin.GetConnectionAdmin());
            cmd.Parameters.AddWithValue("@username", GLOBAL.username);
            cmd.Parameters.AddWithValue("@password", GLOBAL.password);
            int count = (int)cmd.ExecuteScalar();
            cnnAdmin.CloseAdmin();
            // khi đăng nhập sai
            if (count == 0)
            {
                txtName.ResetText();
                txtPass.ResetText();
                lbSuccess.Show();
                return;
            }

            // Khi đăng nhập đúng
            // gán role
            GLOBAL.role = count;
            this.Hide();
            // hiển thị form 1
            Form1 form1 = new Form1();

            form1.ShowDialog();
            this.Close();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
