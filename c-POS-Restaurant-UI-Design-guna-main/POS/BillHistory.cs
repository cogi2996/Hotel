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
    public partial class BillHistory : Form
    {
        DBConnection cnn = new DBConnection();

        public BillHistory()
        {
            InitializeComponent();
        }

        private void BillHistory_Load(object sender, EventArgs e)
        {
            cnn.Connect();
            dgLichSuHoaDon.DataSource = cnn.LichSuHoaDon();
            dgLichSuHoaDon.Refresh();
        }
    }
}
