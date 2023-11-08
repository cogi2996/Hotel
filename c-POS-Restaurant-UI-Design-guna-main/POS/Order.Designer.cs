
namespace POS
{
    partial class Order
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_dsPhong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.sophong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhachSanDataSet = new POS.QuanLyKhachSanDataSet();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSoPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnDatPhong = new Guna.UI2.WinForms.Guna2Button();
            this.phongTableAdapter = new POS.QuanLyKhachSanDataSetTableAdapters.PhongTableAdapter();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.txtLoaiPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSucChua = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dsPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_dsPhong
            // 
            this.dg_dsPhong.AllowUserToResizeColumns = false;
            this.dg_dsPhong.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dg_dsPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dg_dsPhong.AutoGenerateColumns = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_dsPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dg_dsPhong.ColumnHeadersHeight = 25;
            this.dg_dsPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sophong,
            this.loaiPhong,
            this.sucChua,
            this.tinhTrang});
            this.dg_dsPhong.DataSource = this.phongBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_dsPhong.DefaultCellStyle = dataGridViewCellStyle11;
            this.dg_dsPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_dsPhong.Location = new System.Drawing.Point(13, 62);
            this.dg_dsPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dg_dsPhong.Name = "dg_dsPhong";
            this.dg_dsPhong.ReadOnly = true;
            this.dg_dsPhong.RowHeadersVisible = false;
            this.dg_dsPhong.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5);
            this.dg_dsPhong.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dg_dsPhong.RowTemplate.Height = 30;
            this.dg_dsPhong.Size = new System.Drawing.Size(673, 272);
            this.dg_dsPhong.TabIndex = 31;
            this.dg_dsPhong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_dsPhong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dg_dsPhong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dg_dsPhong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dg_dsPhong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dg_dsPhong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dg_dsPhong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_dsPhong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dg_dsPhong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_dsPhong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_dsPhong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dg_dsPhong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_dsPhong.ThemeStyle.HeaderStyle.Height = 25;
            this.dg_dsPhong.ThemeStyle.ReadOnly = true;
            this.dg_dsPhong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_dsPhong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_dsPhong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_dsPhong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dg_dsPhong.ThemeStyle.RowsStyle.Height = 30;
            this.dg_dsPhong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_dsPhong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dg_dsPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_dsPhong_CellClick);
            this.dg_dsPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_dsPhong_CellContentClick);
            // 
            // sophong
            // 
            this.sophong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sophong.DataPropertyName = "SoPhong";
            this.sophong.HeaderText = "SoPhong";
            this.sophong.MinimumWidth = 6;
            this.sophong.Name = "sophong";
            this.sophong.ReadOnly = true;
            // 
            // loaiPhong
            // 
            this.loaiPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loaiPhong.DataPropertyName = "LoaiPhong";
            this.loaiPhong.HeaderText = "LoaiPhong";
            this.loaiPhong.MinimumWidth = 6;
            this.loaiPhong.Name = "loaiPhong";
            this.loaiPhong.ReadOnly = true;
            // 
            // sucChua
            // 
            this.sucChua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sucChua.DataPropertyName = "SucChua";
            this.sucChua.HeaderText = "SucChua";
            this.sucChua.MinimumWidth = 6;
            this.sucChua.Name = "sucChua";
            this.sucChua.ReadOnly = true;
            // 
            // tinhTrang
            // 
            this.tinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tinhTrang.DataPropertyName = "TinhTrang";
            this.tinhTrang.HeaderText = "TinhTrang";
            this.tinhTrang.MinimumWidth = 6;
            this.tinhTrang.Name = "tinhTrang";
            this.tinhTrang.ReadOnly = true;
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataMember = "Phong";
            this.phongBindingSource.DataSource = this.quanLyKhachSanDataSet;
            // 
            // quanLyKhachSanDataSet
            // 
            this.quanLyKhachSanDataSet.DataSetName = "QuanLyKhachSanDataSet";
            this.quanLyKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(259, 376);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(68, 18);
            this.guna2HtmlLabel2.TabIndex = 33;
            this.guna2HtmlLabel2.Text = "Số Phòng :";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoPhong.DefaultText = "";
            this.txtSoPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoPhong.Location = new System.Drawing.Point(349, 376);
            this.txtSoPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.PasswordChar = '\0';
            this.txtSoPhong.PlaceholderText = "";
            this.txtSoPhong.SelectedText = "";
            this.txtSoPhong.Size = new System.Drawing.Size(105, 34);
            this.txtSoPhong.TabIndex = 32;
            this.txtSoPhong.TextChanged += new System.EventHandler(this.txtSoPhong_TextChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(492, 376);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(77, 18);
            this.guna2HtmlLabel3.TabIndex = 33;
            this.guna2HtmlLabel3.Text = "Loại Phòng :";
            this.guna2HtmlLabel3.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(54, 376);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(66, 18);
            this.guna2HtmlLabel4.TabIndex = 33;
            this.guna2HtmlLabel4.Text = "Sức Chứa :";
            this.guna2HtmlLabel4.Click += new System.EventHandler(this.guna2HtmlLabel4_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDatPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDatPhong.ForeColor = System.Drawing.Color.White;
            this.btnDatPhong.Location = new System.Drawing.Point(554, 441);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(136, 33);
            this.btnDatPhong.TabIndex = 35;
            this.btnDatPhong.Text = "Đặt Phòng";
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // phongTableAdapter
            // 
            this.phongTableAdapter.ClearBeforeFill = true;
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(13, 21);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(101, 33);
            this.guna2Button2.TabIndex = 36;
            this.guna2Button2.Text = "Tìm kiếm";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoaiPhong.DefaultText = "";
            this.txtLoaiPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoaiPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoaiPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoaiPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoaiPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoaiPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaiPhong.Location = new System.Drawing.Point(577, 376);
            this.txtLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.PasswordChar = '\0';
            this.txtLoaiPhong.PlaceholderText = "";
            this.txtLoaiPhong.SelectedText = "";
            this.txtLoaiPhong.Size = new System.Drawing.Size(109, 34);
            this.txtLoaiPhong.TabIndex = 32;
            this.txtLoaiPhong.TextChanged += new System.EventHandler(this.txtLoaiPhong_TextChanged);
            // 
            // txtSucChua
            // 
            this.txtSucChua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSucChua.DefaultText = "";
            this.txtSucChua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSucChua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSucChua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSucChua.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSucChua.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSucChua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSucChua.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSucChua.Location = new System.Drawing.Point(128, 376);
            this.txtSucChua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.PasswordChar = '\0';
            this.txtSucChua.PlaceholderText = "";
            this.txtSucChua.SelectedText = "";
            this.txtSucChua.Size = new System.Drawing.Size(105, 34);
            this.txtSucChua.TabIndex = 32;
            this.txtSucChua.TextChanged += new System.EventHandler(this.txtSucChua_TextChanged);
            // 
            // txtSoDT
            // 
            this.txtSoDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDT.DefaultText = "";
            this.txtSoDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDT.Location = new System.Drawing.Point(333, 441);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.PasswordChar = '\0';
            this.txtSoDT.PlaceholderText = "";
            this.txtSoDT.SelectedText = "";
            this.txtSoDT.Size = new System.Drawing.Size(199, 33);
            this.txtSoDT.TabIndex = 32;
            this.txtSoDT.TextChanged += new System.EventHandler(this.txtSoDT_TextChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(113, 441);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(193, 18);
            this.guna2HtmlLabel1.TabIndex = 33;
            this.guna2HtmlLabel1.Text = "Nhập số điện thoại khách hàng ;";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // Order
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(908, 591);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtSucChua);
            this.Controls.Add(this.txtLoaiPhong);
            this.Controls.Add(this.txtSoPhong);
            this.Controls.Add(this.dg_dsPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Order";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_dsPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dg_dsPhong;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtSoPhong;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Button btnDatPhong;
        private QuanLyKhachSanDataSet quanLyKhachSanDataSet;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private QuanLyKhachSanDataSetTableAdapters.PhongTableAdapter phongTableAdapter;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sophong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrang;
        private Guna.UI2.WinForms.Guna2TextBox txtLoaiPhong;
        private Guna.UI2.WinForms.Guna2TextBox txtSucChua;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDT;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}