namespace POS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaResizeControl1 = new Guna.UI.WinForms.GunaResizeControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaGradientTileButton3 = new Guna.UI.WinForms.GunaGradientTileButton();
            this.gunaGradientTileButton4 = new Guna.UI.WinForms.GunaGradientTileButton();
            this.gunaGradientTileButton2 = new Guna.UI.WinForms.GunaGradientTileButton();
            this.gunaGradientTileButton1 = new Guna.UI.WinForms.GunaGradientTileButton();
            this.gunaGradientTileButton5 = new Guna.UI.WinForms.GunaGradientTileButton();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.gunaPictureBox2);
            this.gunaPanel1.Controls.Add(this.gunaGradientTileButton5);
            this.gunaPanel1.Controls.Add(this.gunaGradientTileButton3);
            this.gunaPanel1.Controls.Add(this.gunaGradientTileButton4);
            this.gunaPanel1.Controls.Add(this.gunaGradientTileButton2);
            this.gunaPanel1.Controls.Add(this.gunaGradientTileButton1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(135, 727);
            this.gunaPanel1.TabIndex = 2;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Gray;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1267, 0);
            this.gunaControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Tomato;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(60, 36);
            this.gunaControlBox1.TabIndex = 27;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Gray;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(1199, 0);
            this.gunaControlBox2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.Tomato;
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(60, 36);
            this.gunaControlBox2.TabIndex = 28;
            // 
            // gunaControlBox3
            // 
            this.gunaControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox3.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox3.AnimationSpeed = 0.03F;
            this.gunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox3.IconColor = System.Drawing.Color.Gray;
            this.gunaControlBox3.IconSize = 15F;
            this.gunaControlBox3.Location = new System.Drawing.Point(1131, 0);
            this.gunaControlBox3.Margin = new System.Windows.Forms.Padding(4);
            this.gunaControlBox3.Name = "gunaControlBox3";
            this.gunaControlBox3.OnHoverBackColor = System.Drawing.Color.Tomato;
            this.gunaControlBox3.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox3.Size = new System.Drawing.Size(60, 36);
            this.gunaControlBox3.TabIndex = 29;
            // 
            // gunaResizeControl1
            // 
            this.gunaResizeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaResizeControl1.ForeColor = System.Drawing.Color.Gray;
            this.gunaResizeControl1.ForeColorDepth = 255;
            this.gunaResizeControl1.Location = new System.Drawing.Point(1299, 701);
            this.gunaResizeControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaResizeControl1.Name = "gunaResizeControl1";
            this.gunaResizeControl1.Size = new System.Drawing.Size(27, 25);
            this.gunaResizeControl1.TabIndex = 30;
            this.gunaResizeControl1.TargetControl = this;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(-12, -25);
            this.gunaPictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(155, 165);
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
            this.gunaGradientTileButton3.Location = new System.Drawing.Point(24, 486);
            this.gunaGradientTileButton3.Margin = new System.Windows.Forms.Padding(4);
            this.gunaGradientTileButton3.Name = "gunaGradientTileButton3";
            this.gunaGradientTileButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaGradientTileButton3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaGradientTileButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientTileButton3.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientTileButton3.OnHoverImage")));
            this.gunaGradientTileButton3.OnPressedColor = System.Drawing.Color.White;
            this.gunaGradientTileButton3.Radius = 6;
            this.gunaGradientTileButton3.Size = new System.Drawing.Size(92, 76);
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
            this.gunaGradientTileButton4.Location = new System.Drawing.Point(24, 379);
            this.gunaGradientTileButton4.Margin = new System.Windows.Forms.Padding(4);
            this.gunaGradientTileButton4.Name = "gunaGradientTileButton4";
            this.gunaGradientTileButton4.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaGradientTileButton4.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaGradientTileButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientTileButton4.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientTileButton4.OnHoverImage")));
            this.gunaGradientTileButton4.OnPressedColor = System.Drawing.Color.White;
            this.gunaGradientTileButton4.Radius = 6;
            this.gunaGradientTileButton4.Size = new System.Drawing.Size(80, 74);
            this.gunaGradientTileButton4.TabIndex = 2;
            this.gunaGradientTileButton4.Text = "Service";
            this.gunaGradientTileButton4.Click += new System.EventHandler(this.gunaGradientTileButton4_Click);
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
            this.gunaGradientTileButton2.Location = new System.Drawing.Point(24, 271);
            this.gunaGradientTileButton2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaGradientTileButton2.Name = "gunaGradientTileButton2";
            this.gunaGradientTileButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaGradientTileButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaGradientTileButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientTileButton2.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientTileButton2.OnHoverImage")));
            this.gunaGradientTileButton2.OnPressedColor = System.Drawing.Color.White;
            this.gunaGradientTileButton2.Radius = 6;
            this.gunaGradientTileButton2.Size = new System.Drawing.Size(80, 74);
            this.gunaGradientTileButton2.TabIndex = 1;
            this.gunaGradientTileButton2.Text = "Order";
            this.gunaGradientTileButton2.Click += new System.EventHandler(this.gunaGradientTileButton2_Click);
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
            this.gunaGradientTileButton1.Location = new System.Drawing.Point(24, 164);
            this.gunaGradientTileButton1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaGradientTileButton1.Name = "gunaGradientTileButton1";
            this.gunaGradientTileButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaGradientTileButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaGradientTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientTileButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientTileButton1.OnHoverImage")));
            this.gunaGradientTileButton1.OnPressedColor = System.Drawing.Color.White;
            this.gunaGradientTileButton1.Radius = 6;
            this.gunaGradientTileButton1.Size = new System.Drawing.Size(80, 74);
            this.gunaGradientTileButton1.TabIndex = 0;
            this.gunaGradientTileButton1.Text = "customer";
            this.gunaGradientTileButton1.Click += new System.EventHandler(this.gunaGradientTileButton1_Click);
            // 
            // gunaGradientTileButton5
            // 
            this.gunaGradientTileButton5.Animated = true;
            this.gunaGradientTileButton5.AnimationHoverSpeed = 0.07F;
            this.gunaGradientTileButton5.AnimationSpeed = 0.03F;
            this.gunaGradientTileButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton5.BaseColor1 = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton5.BaseColor2 = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientTileButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientTileButton5.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.gunaGradientTileButton5.ForeColor = System.Drawing.Color.Gray;
            this.gunaGradientTileButton5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gunaGradientTileButton5.Image = global::POS.Properties.Resources.icons8_edit_26;
            this.gunaGradientTileButton5.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaGradientTileButton5.Location = new System.Drawing.Point(13, 615);
            this.gunaGradientTileButton5.Margin = new System.Windows.Forms.Padding(4);
            this.gunaGradientTileButton5.Name = "gunaGradientTileButton5";
            this.gunaGradientTileButton5.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaGradientTileButton5.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaGradientTileButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientTileButton5.OnHoverImage = global::POS.Properties.Resources.icons8_edit_26;
            this.gunaGradientTileButton5.OnPressedColor = System.Drawing.Color.White;
            this.gunaGradientTileButton5.Radius = 6;
            this.gunaGradientTileButton5.Size = new System.Drawing.Size(107, 76);
            this.gunaGradientTileButton5.TabIndex = 3;
            this.gunaGradientTileButton5.Text = "Edit service";
            this.gunaGradientTileButton5.Click += new System.EventHandler(this.gunaGradientTileButton5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1325, 727);
            this.ControlBox = false;
            this.Controls.Add(this.gunaResizeControl1);
            this.Controls.Add(this.gunaControlBox3);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaResizeControl gunaResizeControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public Guna.UI.WinForms.GunaGradientTileButton gunaGradientTileButton1;
        public Guna.UI.WinForms.GunaGradientTileButton gunaGradientTileButton3;
        public Guna.UI.WinForms.GunaGradientTileButton gunaGradientTileButton4;
        public Guna.UI.WinForms.GunaGradientTileButton gunaGradientTileButton2;
        public Guna.UI.WinForms.GunaGradientTileButton gunaGradientTileButton5;
    }
}

