﻿using System;
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
    public partial class Price : Form
    {
        DBConnection cnn = new DBConnection();
        public Price()
        {
            InitializeComponent();
        }

        private void Price_Load(object sender, EventArgs e)
        {
            cnn.Connect();
            dgBangGia.DataSource = cnn.BangGiaPhong();
            dgBangGia.Refresh();
        }
    }
}
