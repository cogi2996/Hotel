
namespace POS
{
    partial class Order_Find
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTienHanhDatPhong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSoDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // btnTienHanhDatPhong
            // 
            this.btnTienHanhDatPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTienHanhDatPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTienHanhDatPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTienHanhDatPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTienHanhDatPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTienHanhDatPhong.ForeColor = System.Drawing.Color.White;
            this.btnTienHanhDatPhong.Location = new System.Drawing.Point(405, 56);
            this.btnTienHanhDatPhong.Name = "btnTienHanhDatPhong";
            this.btnTienHanhDatPhong.Size = new System.Drawing.Size(141, 29);
            this.btnTienHanhDatPhong.TabIndex = 42;
            this.btnTienHanhDatPhong.Text = "Tiến hành đặt phòng";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 58);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(159, 15);
            this.guna2HtmlLabel1.TabIndex = 41;
            this.guna2HtmlLabel1.Text = "Nhập số điện thoại khách hàng :";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDienThoai.DefaultText = "";
            this.txtSoDienThoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDienThoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDienThoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoDienThoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoai.Location = new System.Drawing.Point(195, 58);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.PasswordChar = '\0';
            this.txtSoDienThoai.PlaceholderText = "";
            this.txtSoDienThoai.SelectedText = "";
            this.txtSoDienThoai.Size = new System.Drawing.Size(200, 27);
            this.txtSoDienThoai.TabIndex = 40;
            // 
            // Order_Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 122);
            this.Controls.Add(this.btnTienHanhDatPhong);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtSoDienThoai);
            this.Name = "Order_Find";
            this.Text = "Order_Find";
            this.Load += new System.EventHandler(this.Order_Find_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnTienHanhDatPhong;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDienThoai;
    }
}