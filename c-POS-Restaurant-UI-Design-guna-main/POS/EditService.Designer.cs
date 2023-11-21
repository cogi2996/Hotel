namespace POS
{
    partial class EditService
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_dsdv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_madv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tendv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_them = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dsdv)).BeginInit();
            this.SuspendLayout();
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
            this.dg_dsdv.Location = new System.Drawing.Point(21, 202);
            this.dg_dsdv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dg_dsdv.Name = "dg_dsdv";
            this.dg_dsdv.RowHeadersVisible = false;
            this.dg_dsdv.RowHeadersWidth = 51;
            this.dg_dsdv.RowTemplate.Height = 24;
            this.dg_dsdv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dg_dsdv.Size = new System.Drawing.Size(490, 282);
            this.dg_dsdv.TabIndex = 12;
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
            // EditService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 614);
            this.Controls.Add(this.dg_dsdv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditService";
            this.Text = "EditService";
            this.Load += new System.EventHandler(this.EditService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_dsdv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dg_dsdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_madv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tendv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dongia;
        private System.Windows.Forms.DataGridViewImageColumn col_them;
    }
}