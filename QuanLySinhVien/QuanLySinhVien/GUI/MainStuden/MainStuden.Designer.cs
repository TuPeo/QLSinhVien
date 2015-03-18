namespace QuanLySinhVien
{
    partial class MainStuden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainStuden));
            this._panelTop = new System.Windows.Forms.Panel();
            this._lblMiniMize = new System.Windows.Forms.Label();
            this._lblClose = new System.Windows.Forms.Label();
            this._panelBottom = new System.Windows.Forms.Panel();
            this._lbTime = new System.Windows.Forms.Label();
            this._btnTroVe = new System.Windows.Forms.Button();
            this._panelTopRight = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this._lblBaoCao = new System.Windows.Forms.Label();
            this._lblTroGiup = new System.Windows.Forms.Label();
            this._lblDeTaiTT = new System.Windows.Forms.Label();
            this._lblDangKyDeTai = new System.Windows.Forms.Label();
            this._lblHuyDeTai = new System.Windows.Forms.Label();
            this._lblDiem = new System.Windows.Forms.Label();
            this._lblSinhVienTT = new System.Windows.Forms.Label();
            this._lblGiaoVienHD = new System.Windows.Forms.Label();
            this._menuTaiKhoan = new System.Windows.Forms.MenuStrip();
            this._taiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this._menuThayDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this._menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this._panelMain = new System.Windows.Forms.Panel();
            this._panelTop.SuspendLayout();
            this._panelBottom.SuspendLayout();
            this._panelTopRight.SuspendLayout();
            this._menuTaiKhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelTop
            // 
            this._panelTop.BackgroundImage = global::QuanLySinhVien.Properties.Resources.header;
            this._panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._panelTop.Controls.Add(this._lblMiniMize);
            this._panelTop.Controls.Add(this._lblClose);
            this._panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelTop.Location = new System.Drawing.Point(0, 0);
            this._panelTop.Name = "_panelTop";
            this._panelTop.Size = new System.Drawing.Size(1024, 40);
            this._panelTop.TabIndex = 0;
            this._panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnPanelTopMouseDown);
            this._panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnPanelTopMouseMove);
            this._panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnPanelTopMouseUp);
            // 
            // _lblMiniMize
            // 
            this._lblMiniMize.Cursor = System.Windows.Forms.Cursors.Hand;
            this._lblMiniMize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblMiniMize.Location = new System.Drawing.Point(935, 7);
            this._lblMiniMize.Name = "_lblMiniMize";
            this._lblMiniMize.Size = new System.Drawing.Size(40, 26);
            this._lblMiniMize.TabIndex = 1;
            this._lblMiniMize.Text = "-";
            this._lblMiniMize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lblMiniMize.Click += new System.EventHandler(this.OnMiniMizeClick);
            this._lblMiniMize.MouseLeave += new System.EventHandler(this.OnMiniMizeMouseLeave);
            this._lblMiniMize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMiniMizeMouseMove);
            // 
            // _lblClose
            // 
            this._lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this._lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblClose.Location = new System.Drawing.Point(981, 7);
            this._lblClose.Name = "_lblClose";
            this._lblClose.Size = new System.Drawing.Size(40, 26);
            this._lblClose.TabIndex = 0;
            this._lblClose.Text = "X";
            this._lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lblClose.Click += new System.EventHandler(this.OnCloseClick);
            this._lblClose.MouseLeave += new System.EventHandler(this.OnCloseMouseLeave);
            this._lblClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnCloseMouseMove);
            // 
            // _panelBottom
            // 
            this._panelBottom.BackColor = System.Drawing.Color.White;
            this._panelBottom.BackgroundImage = global::QuanLySinhVien.Properties.Resources.footer;
            this._panelBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._panelBottom.Controls.Add(this._lbTime);
            this._panelBottom.Controls.Add(this._btnTroVe);
            this._panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelBottom.Location = new System.Drawing.Point(0, 620);
            this._panelBottom.Name = "_panelBottom";
            this._panelBottom.Size = new System.Drawing.Size(1024, 30);
            this._panelBottom.TabIndex = 1;
            // 
            // _lbTime
            // 
            this._lbTime.ForeColor = System.Drawing.Color.White;
            this._lbTime.Image = global::QuanLySinhVien.Properties.Resources.footer;
            this._lbTime.Location = new System.Drawing.Point(656, 5);
            this._lbTime.Name = "_lbTime";
            this._lbTime.Size = new System.Drawing.Size(353, 19);
            this._lbTime.TabIndex = 1;
            this._lbTime.Text = "00 : 00 : 00";
            this._lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _btnTroVe
            // 
            this._btnTroVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnTroVe.Dock = System.Windows.Forms.DockStyle.Left;
            this._btnTroVe.Image = global::QuanLySinhVien.Properties.Resources.back;
            this._btnTroVe.Location = new System.Drawing.Point(0, 0);
            this._btnTroVe.Name = "_btnTroVe";
            this._btnTroVe.Size = new System.Drawing.Size(49, 30);
            this._btnTroVe.TabIndex = 0;
            this._btnTroVe.UseVisualStyleBackColor = true;
            // 
            // _panelTopRight
            // 
            this._panelTopRight.BackgroundImage = global::QuanLySinhVien.Properties.Resources.background_top;
            this._panelTopRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._panelTopRight.Controls.Add(this.label1);
            this._panelTopRight.Controls.Add(this._lblBaoCao);
            this._panelTopRight.Controls.Add(this._lblTroGiup);
            this._panelTopRight.Controls.Add(this._lblDeTaiTT);
            this._panelTopRight.Controls.Add(this._lblDangKyDeTai);
            this._panelTopRight.Controls.Add(this._lblHuyDeTai);
            this._panelTopRight.Controls.Add(this._lblDiem);
            this._panelTopRight.Controls.Add(this._lblSinhVienTT);
            this._panelTopRight.Controls.Add(this._lblGiaoVienHD);
            this._panelTopRight.Controls.Add(this._menuTaiKhoan);
            this._panelTopRight.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelTopRight.Location = new System.Drawing.Point(0, 40);
            this._panelTopRight.Name = "_panelTopRight";
            this._panelTopRight.Size = new System.Drawing.Size(1024, 94);
            this._panelTopRight.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::QuanLySinhVien.Properties.Resources.background_top;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Xin chào:";
            // 
            // _lblBaoCao
            // 
            this._lblBaoCao.BackColor = System.Drawing.Color.Transparent;
            this._lblBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this._lblBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblBaoCao.Image = global::QuanLySinhVien.Properties.Resources.report;
            this._lblBaoCao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._lblBaoCao.Location = new System.Drawing.Point(823, 12);
            this._lblBaoCao.Name = "_lblBaoCao";
            this._lblBaoCao.Size = new System.Drawing.Size(100, 60);
            this._lblBaoCao.TabIndex = 7;
            this._lblBaoCao.Text = "Báo cáo";
            this._lblBaoCao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._lblBaoCao.MouseLeave += new System.EventHandler(this.OnLblBaoCaoMouseLeave);
            this._lblBaoCao.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnLblBaoCaoMouseMove);
            // 
            // _lblTroGiup
            // 
            this._lblTroGiup.BackColor = System.Drawing.Color.Transparent;
            this._lblTroGiup.Cursor = System.Windows.Forms.Cursors.Hand;
            this._lblTroGiup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTroGiup.Image = global::QuanLySinhVien.Properties.Resources.help;
            this._lblTroGiup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._lblTroGiup.Location = new System.Drawing.Point(912, 12);
            this._lblTroGiup.Name = "_lblTroGiup";
            this._lblTroGiup.Size = new System.Drawing.Size(100, 60);
            this._lblTroGiup.TabIndex = 6;
            this._lblTroGiup.Text = "Trợ giúp";
            this._lblTroGiup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._lblTroGiup.MouseLeave += new System.EventHandler(this.OnLblTroGiupMouseLeave);
            this._lblTroGiup.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnLblTroGiupMouseMove);
            // 
            // _lblDeTaiTT
            // 
            this._lblDeTaiTT.BackColor = System.Drawing.Color.Transparent;
            this._lblDeTaiTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this._lblDeTaiTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblDeTaiTT.Image = global::QuanLySinhVien.Properties.Resources.abc;
            this._lblDeTaiTT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._lblDeTaiTT.Location = new System.Drawing.Point(181, 12);
            this._lblDeTaiTT.Name = "_lblDeTaiTT";
            this._lblDeTaiTT.Size = new System.Drawing.Size(100, 60);
            this._lblDeTaiTT.TabIndex = 5;
            this._lblDeTaiTT.Text = "Đề tài thực tập";
            this._lblDeTaiTT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._lblDeTaiTT.MouseLeave += new System.EventHandler(this.OnLblDeTaiTTMouseLeave);
            this._lblDeTaiTT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnLblDeTaiTTMouseMove);
            // 
            // _lblDangKyDeTai
            // 
            this._lblDangKyDeTai.BackColor = System.Drawing.Color.Transparent;
            this._lblDangKyDeTai.Cursor = System.Windows.Forms.Cursors.Hand;
            this._lblDangKyDeTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblDangKyDeTai.Image = global::QuanLySinhVien.Properties.Resources.clipboard_paste1;
            this._lblDangKyDeTai.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._lblDangKyDeTai.Location = new System.Drawing.Point(287, 12);
            this._lblDangKyDeTai.Name = "_lblDangKyDeTai";
            this._lblDangKyDeTai.Size = new System.Drawing.Size(100, 60);
            this._lblDangKyDeTai.TabIndex = 4;
            this._lblDangKyDeTai.Text = "Đăng ký đề tai";
            this._lblDangKyDeTai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._lblDangKyDeTai.MouseLeave += new System.EventHandler(this.OnLblDangKyDeTaiMouseLeave);
            this._lblDangKyDeTai.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnLblDangKyDeTaiMouseMove);
            // 
            // _lblHuyDeTai
            // 
            this._lblHuyDeTai.BackColor = System.Drawing.Color.Transparent;
            this._lblHuyDeTai.Cursor = System.Windows.Forms.Cursors.Hand;
            this._lblHuyDeTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblHuyDeTai.Image = global::QuanLySinhVien.Properties.Resources.clipboard_paste;
            this._lblHuyDeTai.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._lblHuyDeTai.Location = new System.Drawing.Point(393, 12);
            this._lblHuyDeTai.Name = "_lblHuyDeTai";
            this._lblHuyDeTai.Size = new System.Drawing.Size(100, 60);
            this._lblHuyDeTai.TabIndex = 3;
            this._lblHuyDeTai.Text = "Hủy đề tài";
            this._lblHuyDeTai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._lblHuyDeTai.MouseLeave += new System.EventHandler(this.OnLblHuyDeTaiMouseLeave);
            this._lblHuyDeTai.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnLblHuyDeTaiMouseMove);
            // 
            // _lblDiem
            // 
            this._lblDiem.BackColor = System.Drawing.Color.Transparent;
            this._lblDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this._lblDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblDiem.Image = global::QuanLySinhVien.Properties.Resources.e;
            this._lblDiem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._lblDiem.Location = new System.Drawing.Point(509, 12);
            this._lblDiem.Name = "_lblDiem";
            this._lblDiem.Size = new System.Drawing.Size(100, 60);
            this._lblDiem.TabIndex = 2;
            this._lblDiem.Text = "Điểm thực tập";
            this._lblDiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._lblDiem.MouseLeave += new System.EventHandler(this.OnLblDiemMouseLeave);
            this._lblDiem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnLblDiemMouseMove);
            // 
            // _lblSinhVienTT
            // 
            this._lblSinhVienTT.BackColor = System.Drawing.Color.Transparent;
            this._lblSinhVienTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this._lblSinhVienTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblSinhVienTT.Image = global::QuanLySinhVien.Properties.Resources.f;
            this._lblSinhVienTT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._lblSinhVienTT.Location = new System.Drawing.Point(613, 12);
            this._lblSinhVienTT.Name = "_lblSinhVienTT";
            this._lblSinhVienTT.Size = new System.Drawing.Size(100, 60);
            this._lblSinhVienTT.TabIndex = 1;
            this._lblSinhVienTT.Text = "SV thực tập";
            this._lblSinhVienTT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._lblSinhVienTT.MouseLeave += new System.EventHandler(this.OnLblSinhVienTTMouseLeave);
            this._lblSinhVienTT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnLblSinhVienTTMouseMove);
            // 
            // _lblGiaoVienHD
            // 
            this._lblGiaoVienHD.BackColor = System.Drawing.Color.Transparent;
            this._lblGiaoVienHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this._lblGiaoVienHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblGiaoVienHD.Image = global::QuanLySinhVien.Properties.Resources.d;
            this._lblGiaoVienHD.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._lblGiaoVienHD.Location = new System.Drawing.Point(719, 12);
            this._lblGiaoVienHD.Name = "_lblGiaoVienHD";
            this._lblGiaoVienHD.Size = new System.Drawing.Size(100, 60);
            this._lblGiaoVienHD.TabIndex = 0;
            this._lblGiaoVienHD.Text = "GV hướng dẫn";
            this._lblGiaoVienHD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._lblGiaoVienHD.MouseLeave += new System.EventHandler(this.OnLblGiaoVienHDMouseLeave);
            this._lblGiaoVienHD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnLblGiaoVienHDMouseMove);
            // 
            // _menuTaiKhoan
            // 
            this._menuTaiKhoan.BackgroundImage = global::QuanLySinhVien.Properties.Resources.background_top;
            this._menuTaiKhoan.Dock = System.Windows.Forms.DockStyle.None;
            this._menuTaiKhoan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._taiKhoan});
            this._menuTaiKhoan.Location = new System.Drawing.Point(19, 48);
            this._menuTaiKhoan.Name = "_menuTaiKhoan";
            this._menuTaiKhoan.Size = new System.Drawing.Size(88, 24);
            this._menuTaiKhoan.TabIndex = 8;
            this._menuTaiKhoan.Text = "menuStrip1";
            // 
            // _taiKhoan
            // 
            this._taiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuThayDoiMK,
            this._menuDangXuat});
            this._taiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._taiKhoan.Name = "_taiKhoan";
            this._taiKhoan.Size = new System.Drawing.Size(80, 20);
            this._taiKhoan.Text = "Tài khoản";
            // 
            // _menuThayDoiMK
            // 
            this._menuThayDoiMK.Image = global::QuanLySinhVien.Properties.Resources.doipass;
            this._menuThayDoiMK.Name = "_menuThayDoiMK";
            this._menuThayDoiMK.Size = new System.Drawing.Size(186, 22);
            this._menuThayDoiMK.Text = "Thay đổi mật khẩu";
            // 
            // _menuDangXuat
            // 
            this._menuDangXuat.Name = "_menuDangXuat";
            this._menuDangXuat.Size = new System.Drawing.Size(186, 22);
            this._menuDangXuat.Text = "Đăng xuất";
            // 
            // _panelMain
            // 
            this._panelMain.BackgroundImage = global::QuanLySinhVien.Properties.Resources.background_software;
            this._panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelMain.Location = new System.Drawing.Point(0, 134);
            this._panelMain.Name = "_panelMain";
            this._panelMain.Size = new System.Drawing.Size(1024, 486);
            this._panelMain.TabIndex = 6;
            // 
            // MainStuden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySinhVien.Properties.Resources.image_blue_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 650);
            this.Controls.Add(this._panelMain);
            this.Controls.Add(this._panelTopRight);
            this.Controls.Add(this._panelBottom);
            this.Controls.Add(this._panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this._menuTaiKhoan;
            this.Name = "MainStuden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên thực tập";
            this.Load += new System.EventHandler(this.MainStuden_Load);
            this._panelTop.ResumeLayout(false);
            this._panelBottom.ResumeLayout(false);
            this._panelTopRight.ResumeLayout(false);
            this._panelTopRight.PerformLayout();
            this._menuTaiKhoan.ResumeLayout(false);
            this._menuTaiKhoan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panelTop;
        private System.Windows.Forms.Label _lblClose;
        private System.Windows.Forms.Label _lblMiniMize;
        private System.Windows.Forms.Panel _panelBottom;
        private System.Windows.Forms.Button _btnTroVe;
        private System.Windows.Forms.Label _lbTime;
        private System.Windows.Forms.Panel _panelTopRight;
        private System.Windows.Forms.Label _lblBaoCao;
        private System.Windows.Forms.Label _lblTroGiup;
        private System.Windows.Forms.Label _lblDeTaiTT;
        private System.Windows.Forms.Label _lblDangKyDeTai;
        private System.Windows.Forms.Label _lblHuyDeTai;
        private System.Windows.Forms.Label _lblDiem;
        private System.Windows.Forms.Label _lblSinhVienTT;
        private System.Windows.Forms.Label _lblGiaoVienHD;
        private System.Windows.Forms.Panel _panelMain;
        private System.Windows.Forms.MenuStrip _menuTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem _taiKhoan;
        private System.Windows.Forms.ToolStripMenuItem _menuThayDoiMK;
        private System.Windows.Forms.ToolStripMenuItem _menuDangXuat;
    }
}

