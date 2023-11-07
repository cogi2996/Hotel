
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
            this.txt_1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.button_2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // txt_1
            // 
            this.txt_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_1.DefaultText = "";
            this.txt_1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_1.Location = new System.Drawing.Point(243, 166);
            this.txt_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_1.Name = "txt_1";
            this.txt_1.PasswordChar = '\0';
            this.txt_1.PlaceholderText = "";
            this.txt_1.SelectedText = "";
            this.txt_1.Size = new System.Drawing.Size(229, 48);
            this.txt_1.TabIndex = 0;
            this.txt_1.TextChanged += new System.EventHandler(this.txt_1_TextChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(172, 105);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(108, 18);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "guna2HtmlLabel1";
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.Color.Transparent;
            this.button_2.Location = new System.Drawing.Point(449, 91);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(108, 18);
            this.button_2.TabIndex = 2;
            this.button_2.Text = "guna2HtmlLabel2";
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txt_1);
            this.Name = "Service";
            this.Text = "Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel button_2;
    }
}