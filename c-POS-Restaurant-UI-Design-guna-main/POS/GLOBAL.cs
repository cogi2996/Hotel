﻿using System;
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
    public static class GLOBAL
    {
        public static string username;
        public static string password;
        public static int role; // 2 - admin , 1 staff
        public static SqlConnection conn;
      
    }
}
