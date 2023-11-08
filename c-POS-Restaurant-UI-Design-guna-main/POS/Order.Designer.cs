
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaGradientTileButton3 = new Guna.UI.WinForms.GunaGradientTileButton();
            this.gunaGradientTileButton4 = new Guna.UI.WinForms.GunaGradientTileButton();
            this.gunaGradientTileButton2 = new Guna.UI.WinForms.GunaGradientTileButton();
            this.gunaGradientTileButton1 = new Guna.UI.WinForms.GunaGradientTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dsPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_dsPhong
            // 
            this.dg_dsPhong.AllowUserToResizeColumns = false;
            this.dg_dsPhong.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dg_dsPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_dsPhong.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_dsPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dg_dsPhong.ColumnHeadersHeight = 25;
            this.dg_dsPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sophong,
            this.loaiPhong,
            this.sucChua,
            this.tinhTrang});
            this.dg_dsPhong.DataSource = this.phongBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_dsPhong.DefaultCellStyle = dataGridViewCellStyle7;
            this.dg_dsPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_dsPhong.Location = new System.Drawing.Point(131, 59);
            this.dg_dsPhong.Name = "dg_dsPhong";
            this.dg_dsPhong.ReadOnly = true;
            this.dg_dsPhong.RowHeadersVisible = false;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            this.dg_dsPhong.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dg_dsPhong.RowTemplate.Height = 30;
            this.dg_dsPhong.Size = new System.Drawing.Size(505, 221);
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
            // 
            // sophong
            // 
            this.sophong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sophong.DataPropertyName = "SoPhong";
            this.sophong.HeaderText = "SoPhong";
            this.sophong.Name = "sophong";
            this.sophong.ReadOnly = true;
            // 
            // loaiPhong
            // 
            this.loaiPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loaiPhong.DataPropertyName = "LoaiPhong";
            this.loaiPhong.HeaderText = "LoaiPhong";
            this.loaiPhong.Name = "loaiPhong";
            this.loaiPhong.ReadOnly = true;
            // 
            // sucChua
            // 
            this.sucChua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sucChua.DataPropertyName = "SucChua";
            this.sucChua.HeaderText = "SucChua";
            this.sucChua.Name = "sucChua";
            this.sucChua.ReadOnly = true;
            // 
            // tinhTrang
            // 
            this.tinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tinhTrang.DataPropertyName = "TinhTrang";
            this.tinhTrang.HeaderText = "TinhTrang";
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
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(306, 332);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(56, 15);
            this.guna2HtmlLabel2.TabIndex = 33;
            this.guna2HtmlLabel2.Text = "Số Phòng :";
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
            this.txtSoPhong.Location = new System.Drawing.Point(368, 332);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.PasswordChar = '\0';
            this.txtSoPhong.PlaceholderText = "";
            this.txtSoPhong.SelectedText = "";
            this.txtSoPhong.Size = new System.Drawing.Size(79, 28);
            this.txtSoPhong.TabIndex = 32;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(474, 332);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(63, 15);
            this.guna2HtmlLabel3.TabIndex = 33;
            this.guna2HtmlLabel3.Text = "Loại Phòng :";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(137, 332);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(56, 15);
            this.guna2HtmlLabel4.TabIndex = 33;
            this.guna2HtmlLabel4.Text = "Sức Chứa :";
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDatPhong.ForeColor = System.Drawing.Color.White;
            this.btnDatPhong.Location = new System.Drawing.Point(534, 414);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(102, 27);
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
            this.guna2Button2.Location = new System.Drawing.Point(131, 26);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(76, 27);
            this.guna2Button2.TabIndex = 36;
            this.guna2Button2.Text = "Tìm kiếm";
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
            this.txtLoaiPhong.Location = new System.Drawing.Point(554, 332);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.PasswordChar = '\0';
            this.txtLoaiPhong.PlaceholderText = "";
            this.txtLoaiPhong.SelectedText = "";
            this.txtLoaiPhong.Size = new System.Drawing.Size(82, 28);
            this.txtLoaiPhong.TabIndex = 32;
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
            this.txtSucChua.Location = new System.Drawing.Point(199, 332);
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.PasswordChar = '\0';
            this.txtSucChua.PlaceholderText = "";
            this.txtSucChua.SelectedText = "";
            this.txtSucChua.Size = new System.Drawing.Size(79, 28);
            this.txtSucChua.TabIndex = 32;
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
            this.txtSoDT.Location = new System.Drawing.Point(368, 414);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.PasswordChar = '\0';
            this.txtSoDT.PlaceholderText = "";
            this.txtSoDT.SelectedText = "";
            this.txtSoDT.Size = new System.Drawing.Size(149, 27);
            this.txtSoDT.TabIndex = 32;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(203, 414);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(159, 15);
            this.guna2HtmlLabel1.TabIndex = 33;
            this.guna2HtmlLabel1.Text = "Nhập số điện thoại khách hàng ;";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.gunaPictureBox2);
            this.gunaPanel1.Controls.Add(this.gunaGradientTileButton3);
            this.gunaPanel1.Controls.Add(this.gunaGradientTileButton4);
            this.gunaPanel1.Controls.Add(this.gunaGradientTileButton2);
            this.gunaPanel1.Controls.Add(this.gunaGradientTileButton1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(101, 482);
            this.gunaPanel1.TabIndex = 37;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(-9, -20);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(116, 134);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 5;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaGradientTileButton3
            // 
            this.gunaGradientTileButton3.Animated = true;
            this.gunaGradientTileButton3.AnimationHoverSpeed = 0.07F;
            this.gunaGradientTileButton3.AnimationSpeed = 0.03F;
            this.gunaGradientTileButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton3.BaseColor1 = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton3.BaseColor2 = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientTileButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientTileButton3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.gunaGradientTileButton3.ForeColor = System.Drawing.Color.Gray;
            this.gunaGradientTileButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gunaGradientTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientTileButton3.Image")));
            this.gunaGradientTileButton3.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaGradientTileButton3.Location = new System.Drawing.Point(18, 395);
            this.gunaGradientTileButton3.Name = "gunaGradientTileButton3";
            this.gunaGradientTileButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaGradientTileButton3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaGradientTileButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientTileButton3.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientTileButton3.OnHoverImage")));
            this.gunaGradientTileButton3.OnPressedColor = System.Drawing.Color.White;
            this.gunaGradientTileButton3.Radius = 6;
            this.gunaGradientTileButton3.Size = new System.Drawing.Size(69, 62);
            this.gunaGradientTileButton3.TabIndex = 3;
            this.gunaGradientTileButton3.Text = "Check out";
            // 
            // gunaGradientTileButton4
            // 
            this.gunaGradientTileButton4.Animated = true;
            this.gunaGradientTileButton4.AnimationHoverSpeed = 0.07F;
            this.gunaGradientTileButton4.AnimationSpeed = 0.03F;
            this.gunaGradientTileButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton4.BaseColor1 = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton4.BaseColor2 = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientTileButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientTileButton4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.gunaGradientTileButton4.ForeColor = System.Drawing.Color.Gray;
            this.gunaGradientTileButton4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gunaGradientTileButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientTileButton4.Image")));
            this.gunaGradientTileButton4.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaGradientTileButton4.Location = new System.Drawing.Point(18, 308);
            this.gunaGradientTileButton4.Name = "gunaGradientTileButton4";
            this.gunaGradientTileButton4.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaGradientTileButton4.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaGradientTileButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientTileButton4.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientTileButton4.OnHoverImage")));
            this.gunaGradientTileButton4.OnPressedColor = System.Drawing.Color.White;
            this.gunaGradientTileButton4.Radius = 6;
            this.gunaGradientTileButton4.Size = new System.Drawing.Size(60, 60);
            this.gunaGradientTileButton4.TabIndex = 2;
            this.gunaGradientTileButton4.Text = "Service";
            // 
            // gunaGradientTileButton2
            // 
            this.gunaGradientTileButton2.Animated = true;
            this.gunaGradientTileButton2.AnimationHoverSpeed = 0.07F;
            this.gunaGradientTileButton2.AnimationSpeed = 0.03F;
            this.gunaGradientTileButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton2.BaseColor1 = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton2.BaseColor2 = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientTileButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientTileButton2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.gunaGradientTileButton2.ForeColor = System.Drawing.Color.Gray;
            this.gunaGradientTileButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gunaGradientTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientTileButton2.Image")));
            this.gunaGradientTileButton2.ImageSize = new System.Drawing.Size(26, 26);
            this.gunaGradientTileButton2.Location = new System.Drawing.Point(18, 220);
            this.gunaGradientTileButton2.Name = "gunaGradientTileButton2";
            this.gunaGradientTileButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaGradientTileButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaGradientTileButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientTileButton2.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientTileButton2.OnHoverImage")));
            this.gunaGradientTileButton2.OnPressedColor = System.Drawing.Color.White;
            this.gunaGradientTileButton2.Radius = 6;
            this.gunaGradientTileButton2.Size = new System.Drawing.Size(60, 60);
            this.gunaGradientTileButton2.TabIndex = 1;
            this.gunaGradientTileButton2.Text = "Order";
            // 
            // gunaGradientTileButton1
            // 
            this.gunaGradientTileButton1.Animated = true;
            this.gunaGradientTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientTileButton1.AnimationSpeed = 0.03F;
            this.gunaGradientTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton1.BaseColor1 = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton1.BaseColor2 = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientTileButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientTileButton1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.gunaGradientTileButton1.ForeColor = System.Drawing.Color.Gray;
            this.gunaGradientTileButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gunaGradientTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientTileButton1.Image")));
            this.gunaGradientTileButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaGradientTileButton1.Location = new System.Drawing.Point(18, 133);
            this.gunaGradientTileButton1.Name = "gunaGradientTileButton1";
            this.gunaGradientTileButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaGradientTileButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaGradientTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientTileButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientTileButton1.OnHoverImage")));
            this.gunaGradientTileButton1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaGradientTileButton1.Radius = 6;
            this.gunaGradientTileButton1.Size = new System.Drawing.Size(60, 60);
            this.gunaGradientTileButton1.TabIndex = 0;
            this.gunaGradientTileButton1.Text = "customer";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 482);
            this.Controls.Add(this.gunaPanel1);
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
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_dsPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
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
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        public Guna.UI.WinForms.GunaGradientTileButton gunaGradientTileButton3;
        public Guna.UI.WinForms.GunaGradientTileButton gunaGradientTileButton4;
        public Guna.UI.WinForms.GunaGradientTileButton gunaGradientTileButton2;
        public Guna.UI.WinForms.GunaGradientTileButton gunaGradientTileButton1;
    }
}