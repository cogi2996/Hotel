using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.Lib;

namespace POS
{
    public partial class Form1 : Form
    {
        Order order = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            childForm.MdiParent = this;
            //childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(GLOBAL.role != 2)
            {
               /* btnEditRoom.Enabled = false;
                btnEditService.Enabled = false;
                btnHistory.Enabled = false;*/
            }
        }

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Customer());
        }

        private void gunaGradientTileButton2_Click(object sender, EventArgs e)
        {
            order = new Order();
            OpenChildForm(order);
        }

        private void gunaGradientTileButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Service());
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientTileButton5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditService());
        }

        private void gunaGradientTileButton6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditRoom());
        }

        private void gunaGradientTileButton7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Price());
        }

        private void gunaGradientTileButton8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BillHistory());
        }

        private void gunaGradientTileButton9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookedRoom());
        }

        private void gunaGradientTileButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new checkout());
        }

        private void gunaGradientTileButton5_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new EditAccount());
        }
    }
}
