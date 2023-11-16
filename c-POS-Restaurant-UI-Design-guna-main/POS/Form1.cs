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
        Service service = null;
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

        
    }
}
