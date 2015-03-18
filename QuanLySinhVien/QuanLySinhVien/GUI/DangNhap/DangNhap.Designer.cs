namespace QuanLySinhVien.GUI
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this._lblHuy = new System.Windows.Forms.Label();
            this._lblDangNhap = new System.Windows.Forms.Label();
            this._txtMatKhau = new System.Windows.Forms.TextBox();
            this._txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._panelDangNhap = new System.Windows.Forms.Panel();
            this._lblClose = new System.Windows.Forms.Label();
            this._panelDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lblHuy
            // 
            this._lblHuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lblHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this._lblHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblHuy.Location = new System.Drawing.Point(331, 181);
            this._lblHuy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._lblHuy.Name = "_lblHuy";
            this._lblHuy.Size = new System.Drawing.Size(125, 39);
            this._lblHuy.TabIndex = 12;
            this._lblHuy.Text = "Hủy";
            this._lblHuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lblHuy.Click += new System.EventHandler(this.OnHuyClick);
            // 
            // _lblDangNhap
            // 
            this._lblDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lblDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this._lblDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblDangNhap.Location = new System.Drawing.Point(138, 181);
            this._lblDangNhap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._lblDangNhap.Name = "_lblDangNhap";
            this._lblDangNhap.Size = new System.Drawing.Size(125, 39);
            this._lblDangNhap.TabIndex = 8;
            this._lblDangNhap.Text = "Đăng nhập";
            this._lblDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lblDangNhap.Click += new System.EventHandler(this.OnDangNhapClick);
            // 
            // _txtMatKhau
            // 
            this._txtMatKhau.Location = new System.Drawing.Point(236, 123);
            this._txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this._txtMatKhau.Name = "_txtMatKhau";
            this._txtMatKhau.Size = new System.Drawing.Size(273, 22);
            this._txtMatKhau.TabIndex = 11;
            // 
            // _txtTenDangNhap
            // 
            this._txtTenDangNhap.Location = new System.Drawing.Point(236, 79);
            this._txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this._txtTenDangNhap.Name = "_txtTenDangNhap";
            this._txtTenDangNhap.Size = new System.Drawing.Size(273, 22);
            this._txtTenDangNhap.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // _panelDangNhap
            // 
            this._panelDangNhap.BackgroundImage = global::QuanLySinhVien.Properties.Resources.login;
            this._panelDangNhap.Controls.Add(this._lblClose);
            this._panelDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelDangNhap.Location = new System.Drawing.Point(0, 0);
            this._panelDangNhap.Margin = new System.Windows.Forms.Padding(5);
            this._panelDangNhap.Name = "_panelDangNhap";
            this._panelDangNhap.Size = new System.Drawing.Size(561, 36);
            this._panelDangNhap.TabIndex = 6;
            // 
            // _lblClose
            // 
            this._lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this._lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblClose.Location = new System.Drawing.Point(506, 4);
            this._lblClose.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._lblClose.Name = "_lblClose";
            this._lblClose.Size = new System.Drawing.Size(52, 28);
            this._lblClose.TabIndex = 1;
            this._lblClose.Text = "X";
            this._lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lblClose.Click += new System.EventHandler(this.OnCloseClick);
            this._lblClose.MouseLeave += new System.EventHandler(this.OnCloseMouseLeave);
            this._lblClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnCloseMouseMove);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 291);
            this.Controls.Add(this._panelDangNhap);
            this.Controls.Add(this._lblHuy);
            this.Controls.Add(this._lblDangNhap);
            this.Controls.Add(this._txtMatKhau);
            this.Controls.Add(this._txtTenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this._panelDangNhap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _panelDangNhap;
        private System.Windows.Forms.Label _lblClose;
        private System.Windows.Forms.Label _lblHuy;
        private System.Windows.Forms.Label _lblDangNhap;
        private System.Windows.Forms.TextBox _txtMatKhau;
        private System.Windows.Forms.TextBox _txtTenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}