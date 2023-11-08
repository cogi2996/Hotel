
namespace POS
{
    partial class Service
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.btn_hienThiAll = new Guna.UI2.WinForms.Guna2Button();
            this.btn_tim = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.dg_dsdv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_madv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tendv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_them = new System.Windows.Forms.DataGridViewImageColumn();
            this.dg_dvDaChon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_madvdachon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tendvdachon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_xoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_huy = new Guna.UI2.WinForms.Guna2Button();
            this.btn_luu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txt_KhachHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dsdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dvDaChon)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // btn_hienThiAll
            // 
            this.btn_hienThiAll.AutoRoundedCorners = true;
            this.btn_hienThiAll.BorderRadius = 15;
            this.btn_hienThiAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_hienThiAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_hienThiAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_hienThiAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_hienThiAll.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_hienThiAll.ForeColor = System.Drawing.Color.White;
            this.btn_hienThiAll.Location = new System.Drawing.Point(495, 183);
            this.btn_hienThiAll.Name = "btn_hienThiAll";
            this.btn_hienThiAll.Size = new System.Drawing.Size(119, 32);
            this.btn_hienThiAll.TabIndex = 14;
            this.btn_hienThiAll.Text = "Hiển thị tất cả";
            this.btn_hienThiAll.Click += new System.EventHandler(this.btn_hienThiAll_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.AutoRoundedCorners = true;
            this.btn_tim.BorderRadius = 12;
            this.btn_tim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tim.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_tim.ForeColor = System.Drawing.Color.White;
            this.btn_tim.Location = new System.Drawing.Point(416, 183);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(73, 32);
            this.btn_tim.TabIndex = 15;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(273, 158);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(89, 18);
            this.guna2HtmlLabel1.TabIndex = 13;
            this.guna2HtmlLabel1.Text = "Search";
            // 
            // txt_search
            // 
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.IconLeftSize = new System.Drawing.Size(35, 30);
            this.txt_search.Location = new System.Drawing.Point(263, 183);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "Search here";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(147, 32);
            this.txt_search.TabIndex = 12;
            // 
            // dg_dsdv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dg_dsdv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_dsdv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_dsdv.ColumnHeadersHeight = 18;
            this.dg_dsdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dg_dsdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_madv,
            this.col_tendv,
            this.col_dongia,
            this.col_them});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_dsdv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_dsdv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_dsdv.Location = new System.Drawing.Point(167, 222);
            this.dg_dsdv.Name = "dg_dsdv";
            this.dg_dsdv.RowHeadersVisible = false;
            this.dg_dsdv.RowHeadersWidth = 60;
            this.dg_dsdv.RowTemplate.Height = 24;
            this.dg_dsdv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dg_dsdv.Size = new System.Drawing.Size(449, 323);
            this.dg_dsdv.TabIndex = 11;
            this.dg_dsdv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_dsdv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dg_dsdv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dg_dsdv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dg_dsdv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dg_dsdv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dg_dsdv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_dsdv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dg_dsdv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_dsdv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dg_dsdv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dg_dsdv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dg_dsdv.ThemeStyle.HeaderStyle.Height = 18;
            this.dg_dsdv.ThemeStyle.ReadOnly = false;
            this.dg_dsdv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_dsdv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_dsdv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dg_dsdv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dg_dsdv.ThemeStyle.RowsStyle.Height = 24;
            this.dg_dsdv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_dsdv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dg_dsdv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_dsdv_CellContentClick);
            // 
            // col_madv
            // 
            this.col_madv.DataPropertyName = "MaDV";
            this.col_madv.HeaderText = "Mã Dịch Vụ";
            this.col_madv.MinimumWidth = 6;
            this.col_madv.Name = "col_madv";
            // 
            // col_tendv
            // 
            this.col_tendv.DataPropertyName = "TenDV";
            this.col_tendv.HeaderText = "Tên Dịch Vụ";
            this.col_tendv.MinimumWidth = 6;
            this.col_tendv.Name = "col_tendv";
            this.col_tendv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_dongia
            // 
            this.col_dongia.DataPropertyName = "DonGia";
            this.col_dongia.HeaderText = "Đơn Giá";
            this.col_dongia.MinimumWidth = 6;
            this.col_dongia.Name = "col_dongia";
            // 
            // col_them
            // 
            this.col_them.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_them.FillWeight = 50F;
            this.col_them.HeaderText = "Thêm";
            this.col_them.Image = global::POS.Properties.Resources.icons8_add_48;
            this.col_them.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_them.MinimumWidth = 50;
            this.col_them.Name = "col_them";
            this.col_them.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_them.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_them.Width = 50;
            // 
            // dg_dvDaChon
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dg_dvDaChon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_dvDaChon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_dvDaChon.ColumnHeadersHeight = 18;
            this.dg_dvDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dg_dvDaChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_madvdachon,
            this.col_tendvdachon,
            this.col_sl,
            this.col_xoa});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_dvDaChon.DefaultCellStyle = dataGridViewCellStyle6;
            this.dg_dvDaChon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_dvDaChon.Location = new System.Drawing.Point(641, 222);
            this.dg_dvDaChon.Name = "dg_dvDaChon";
            this.dg_dvDaChon.RowHeadersVisible = false;
            this.dg_dvDaChon.RowHeadersWidth = 51;
            this.dg_dvDaChon.RowTemplate.Height = 24;
            this.dg_dvDaChon.Size = new System.Drawing.Size(450, 323);
            this.dg_dvDaChon.TabIndex = 16;
            this.dg_dvDaChon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_dvDaChon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dg_dvDaChon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dg_dvDaChon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dg_dvDaChon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dg_dvDaChon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dg_dvDaChon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_dvDaChon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dg_dvDaChon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_dvDaChon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dg_dvDaChon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dg_dvDaChon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dg_dvDaChon.ThemeStyle.HeaderStyle.Height = 18;
            this.dg_dvDaChon.ThemeStyle.ReadOnly = false;
            this.dg_dvDaChon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_dvDaChon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_dvDaChon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dg_dvDaChon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dg_dvDaChon.ThemeStyle.RowsStyle.Height = 24;
            this.dg_dvDaChon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_dvDaChon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dg_dvDaChon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_dvDaChon_CellContentClick);
            // 
            // col_madvdachon
            // 
            this.col_madvdachon.HeaderText = "Mã Dịch Vụ";
            this.col_madvdachon.MinimumWidth = 6;
            this.col_madvdachon.Name = "col_madvdachon";
            // 
            // col_tendvdachon
            // 
            this.col_tendvdachon.HeaderText = "Tên Dịch Vụ";
            this.col_tendvdachon.MinimumWidth = 6;
            this.col_tendvdachon.Name = "col_tendvdachon";
            // 
            // col_sl
            // 
            this.col_sl.HeaderText = "Số Lượng";
            this.col_sl.MinimumWidth = 6;
            this.col_sl.Name = "col_sl";
            // 
            // col_xoa
            // 
            this.col_xoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_xoa.DataPropertyName = "none";
            this.col_xoa.FillWeight = 70F;
            this.col_xoa.HeaderText = "Xóa";
            this.col_xoa.Image = global::POS.Properties.Resources.icons8_x_48;
            this.col_xoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_xoa.MinimumWidth = 70;
            this.col_xoa.Name = "col_xoa";
            this.col_xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_xoa.Width = 70;
            // 
            // btn_huy
            // 
            this.btn_huy.AutoRoundedCorners = true;
            this.btn_huy.BorderRadius = 14;
            this.btn_huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.Location = new System.Drawing.Point(762, 560);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(74, 31);
            this.btn_huy.TabIndex = 17;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.AutoRoundedCorners = true;
            this.btn_luu.BorderRadius = 14;
            this.btn_luu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_luu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_luu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_luu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Location = new System.Drawing.Point(890, 560);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(74, 31);
            this.btn_luu.TabIndex = 18;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(167, 158);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(90, 18);
            this.guna2HtmlLabel2.TabIndex = 19;
            this.guna2HtmlLabel2.Text = "Khách Hàng";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "Thêm";
            this.dataGridViewImageColumn1.Image = global::POS.Properties.Resources.icons8_add_48;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.DataPropertyName = "none";
            this.dataGridViewImageColumn2.FillWeight = 70F;
            this.dataGridViewImageColumn2.HeaderText = "Xóa";
            this.dataGridViewImageColumn2.Image = global::POS.Properties.Resources.icons8_x_48;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 70;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 70;
            // 
            // txt_KhachHang
            // 
            this.txt_KhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_KhachHang.DefaultText = "";
            this.txt_KhachHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_KhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_KhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_KhachHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_KhachHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_KhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_KhachHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_KhachHang.Location = new System.Drawing.Point(167, 183);
            this.txt_KhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_KhachHang.Name = "txt_KhachHang";
            this.txt_KhachHang.PasswordChar = '\0';
            this.txt_KhachHang.PlaceholderText = "";
            this.txt_KhachHang.SelectedText = "";
            this.txt_KhachHang.Size = new System.Drawing.Size(78, 32);
            this.txt_KhachHang.TabIndex = 31;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(622, 222);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 324);
            this.guna2VSeparator1.TabIndex = 32;
            // 
            // btn_huy
            // 
            this.btn_huy.AutoRoundedCorners = true;
            this.btn_huy.BorderRadius = 17;
            this.btn_huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.Location = new System.Drawing.Point(1060, 492);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(57, 37);
            this.btn_huy.TabIndex = 17;
            this.btn_huy.Text = "Hủy";
            // 
            // btn_luu
            // 
            this.btn_luu.AutoRoundedCorners = true;
            this.btn_luu.BorderRadius = 17;
            this.btn_luu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_luu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_luu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_luu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Location = new System.Drawing.Point(985, 492);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(57, 37);
            this.btn_luu.TabIndex = 18;
            this.btn_luu.Text = "Lưu";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(208, 180);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(63, 15);
            this.guna2HtmlLabel2.TabIndex = 19;
            this.guna2HtmlLabel2.Text = "Khách Hàng";
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 626);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.txt_KhachHang);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.dg_dvDaChon);
            this.Controls.Add(this.btn_hienThiAll);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dg_dsdv);
            this.Name = "Service";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            this.Controls.SetChildIndex(this.dg_dsdv, 0);
            this.Controls.SetChildIndex(this.txt_search, 0);
            this.Controls.SetChildIndex(this.guna2HtmlLabel1, 0);
            this.Controls.SetChildIndex(this.btn_tim, 0);
            this.Controls.SetChildIndex(this.btn_hienThiAll, 0);
            this.Controls.SetChildIndex(this.dg_dvDaChon, 0);
            this.Controls.SetChildIndex(this.btn_luu, 0);
            this.Controls.SetChildIndex(this.btn_huy, 0);
            this.Controls.SetChildIndex(this.guna2HtmlLabel2, 0);
            this.Controls.SetChildIndex(this.txt_KhachHang, 0);
            this.Controls.SetChildIndex(this.guna2VSeparator1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dg_dsdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dvDaChon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_1;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private Guna.UI2.WinForms.Guna2Button btn_hienThiAll;
        private Guna.UI2.WinForms.Guna2Button btn_tim;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2DataGridView dg_dsdv;
        private Guna.UI2.WinForms.Guna2DataGridView dg_dvDaChon;
        private Guna.UI2.WinForms.Guna2Button btn_huy;
        private Guna.UI2.WinForms.Guna2Button btn_luu;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_madv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tendv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dongia;
        private System.Windows.Forms.DataGridViewImageColumn col_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_madvdachon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tendvdachon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sl;
        private System.Windows.Forms.DataGridViewImageColumn col_xoa;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI2.WinForms.Guna2TextBox txt_KhachHang;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
    }
}