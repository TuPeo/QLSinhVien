using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class MainStuden : Form
    {
        #region Field
        public static string userName = string.Empty;
        private Timer _timDisplay;
        private bool _isMousePress = false;
        private Point _lastPoint;
        #endregion Field

        #region Method
        public MainStuden()
        {
            InitializeComponent();
            HandleCreated += OnHandleCreated;
        }
        #endregion Method

        #region Event
        private void OnHandleCreated(object sender, EventArgs e)
        {
            _timDisplay = new Timer();
            _timDisplay.Interval = 1;
            _timDisplay.Tick += OnTimerTick;
            _timDisplay.Enabled = true;

        }
        private void OnTimerTick(object sender, EventArgs e)
        {
            _timDisplay.Interval = 1000;
            DateTime dateTime = DateTime.Now;
            _lbTime.Text = string.Format("{0}",
                dateTime.ToString("F"));
        }

        private void OnPanelTopMouseMove(object sender, MouseEventArgs e)
        {
            if (_isMousePress)
            {
                //quyết định cho form chui ra ngoài màn hình
                Point currentPoint = e.Location;
                Point mainLocation = this.Location;
                int scaleX = currentPoint.X - _lastPoint.X;
                int scaleY = currentPoint.Y - _lastPoint.Y;
                this.Location = new Point(mainLocation.X + scaleX, mainLocation.Y + scaleY);
            }
        }

        private void OnPanelTopMouseUp(object sender, MouseEventArgs e)
        {
            _isMousePress = false;
        }

        private void OnPanelTopMouseDown(object sender, MouseEventArgs e)
        {
            _isMousePress = true;
            _lastPoint = e.Location;
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnCloseMouseMove(object sender, MouseEventArgs e)
        {
            _lblClose.BackColor = Color.Firebrick;
        }

        private void OnCloseMouseLeave(object sender, EventArgs e)
        {
            _lblClose.BackColor = Color.WhiteSmoke;
        }
        private void OnMiniMizeClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OnMiniMizeMouseMove(object sender, MouseEventArgs e)
        {
            _lblMiniMize.BackColor = Color.White;
        }

        private void OnMiniMizeMouseLeave(object sender, EventArgs e)
        {
            _lblMiniMize.BackColor = Color.WhiteSmoke;
        }

        private void OnLblTroGiupMouseMove(object sender, MouseEventArgs e)
        {
            _lblTroGiup.BackColor = Color.PaleTurquoise;
        }

        private void OnLblTroGiupMouseLeave(object sender, EventArgs e)
        {
            _lblTroGiup.BackColor = Color.Transparent;
        }

        private void OnLblBaoCaoMouseMove(object sender, MouseEventArgs e)
        {
            _lblBaoCao.BackColor = Color.PaleTurquoise;
        }

        private void OnLblBaoCaoMouseLeave(object sender, EventArgs e)
        {
            _lblBaoCao.BackColor = Color.Transparent;
        }

        private void OnLblGiaoVienHDMouseMove(object sender, MouseEventArgs e)
        {
            _lblGiaoVienHD.BackColor = Color.PaleTurquoise;
        }

        private void OnLblGiaoVienHDMouseLeave(object sender, EventArgs e)
        {
            _lblGiaoVienHD.BackColor = Color.Transparent;
        }

        private void OnLblSinhVienTTMouseMove(object sender, MouseEventArgs e)
        {
            _lblSinhVienTT.BackColor = Color.PaleTurquoise;
        }

        private void OnLblSinhVienTTMouseLeave(object sender, EventArgs e)
        {
            _lblSinhVienTT.BackColor = Color.Transparent;
        }

        private void OnLblDiemMouseMove(object sender, MouseEventArgs e)
        {
            _lblDiem.BackColor = Color.PaleTurquoise;
        }

        private void OnLblDiemMouseLeave(object sender, EventArgs e)
        {
            _lblDiem.BackColor = Color.Transparent;
        }

        private void OnLblHuyDeTaiMouseMove(object sender, MouseEventArgs e)
        {
            _lblHuyDeTai.BackColor = Color.PaleTurquoise;
        }

        private void OnLblHuyDeTaiMouseLeave(object sender, EventArgs e)
        {
            _lblHuyDeTai.BackColor = Color.Transparent;
        }

        private void OnLblDangKyDeTaiMouseMove(object sender, MouseEventArgs e)
        {
            _lblDangKyDeTai.BackColor = Color.PaleTurquoise;
        }

        private void OnLblDangKyDeTaiMouseLeave(object sender, EventArgs e)
        {
            _lblDangKyDeTai.BackColor = Color.Transparent;
        }

        private void OnLblDeTaiTTMouseMove(object sender, MouseEventArgs e)
        {
            _lblDeTaiTT.BackColor = Color.PaleTurquoise;
        }

        private void OnLblDeTaiTTMouseLeave(object sender, EventArgs e)
        {
            _lblDeTaiTT.BackColor = Color.Transparent;
        }
        #endregion Event

        private void MainStuden_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userName))
                this._taiKhoan.Text = userName;
        }
    }
}
