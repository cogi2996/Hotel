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
    public partial class checkout : Form
    {
        tinhtienDataContext dbs = new tinhtienDataContext();
        public checkout()
        {
            InitializeComponent();
        }
        DBConnection db = new DBConnection();

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable p = new DataTable();
            DataTable dv = new DataTable();
            DataTable tong = new DataTable();
            dt = db.DS_KhachHangThanhToan(db.findOneByPhone(txt_sdt.Text));
            txt_ten.Text = dt.Rows[0]["TenKH"].ToString();
            dt_ns.Text = dt.Rows[0]["NgaySinh"].ToString();
            p = db.ChiTietPhong(db.findOneByPhone(txt_sdt.Text));
            txt_phong.Text = p.Rows[0]["SoPhong"].ToString();
            ds_den.Text = p.Rows[0]["CheckIn"].ToString();
            ds_di.Text = DateTime.Now.ToString();
            txt_sodem.Text = dbs.f_TinhSoDem(ds_den.Value, ds_di.Value).ToString();
            dv = db.ChiTietDichVu(db.findOneByPhone(txt_sdt.Text));
            guna2DataGridView1.DataSource = dv;
            txt_tienphong.Text = dbs.f_TongTienHoaDon(db.findOneByPhone(txt_sdt.Text)).ToString();
            tong = db.TongTien(db.findOneByPhone(txt_sdt.Text));
            string tien = tong.Rows[0]["tongtiendv"].ToString();
            txt_tiendv.Text = tien;
            txt_tongtien.Text= (Convert.ToInt32(tien) + dbs.f_TongTienHoaDon(db.findOneByPhone(txt_sdt.Text))).ToString();
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DataTable dt = db.TaoHoaDon(db.findOneByPhone(txt_sdt.Text).ToString(), txt_ten.Text, txt_phong.Text, txt_sodem.Text, dt_ns.Text, ds_den.Text, ds_di.Text, txt_tienphong.Text, TenDV.ToString(), txt_tiendv.Text, txt_tongtien.Text);
            db.CapNhatHoaDon(db.findOneByPhone(txt_sdt.Text), txt_tongtien.Text);
            crys_bill bill = new crys_bill();
            bill.SetDataSource(dt);
            f_bill form = new f_bill();
            form.crystalReportViewer1.ReportSource = bill;
            form.ShowDialog();
        }
    }
}
