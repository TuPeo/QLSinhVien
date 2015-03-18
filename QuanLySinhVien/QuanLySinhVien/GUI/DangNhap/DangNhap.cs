using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien.GUI
{
    public partial class DangNhap : Form
    {
        #region Method
        public DangNhap()
        {
            InitializeComponent();
        }
        #endregion Method

        #region Event
        private void OnCloseClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnDangNhapClick(object sender, EventArgs e)
        {
            if (_txtTenDangNhap.Text == "Lê Văn Hùng" && _txtMatKhau.Text == "1234567890987654321")
            {
                MainStuden.userName = _txtTenDangNhap.Text;
                MainStuden studen = new MainStuden();
                studen.Show();
                this.Hide();
            }
        }

        private void OnHuyClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnCloseMouseMove(object sender, MouseEventArgs e)
        {
            _lblClose.BackColor = Color.Firebrick;
        }

        private void OnCloseMouseLeave(object sender, EventArgs e)
        {
            _lblClose.BackColor = Color.White;
        }
        #endregion Event
    }
}
