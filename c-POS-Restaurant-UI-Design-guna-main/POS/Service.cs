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
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }

        private void Service_Load(object sender, EventArgs e)
        {

        }

        private void txt_1_TextChanged(object sender, EventArgs e)
        {
            txt_1.Text = "hello";
        }

    }
}
