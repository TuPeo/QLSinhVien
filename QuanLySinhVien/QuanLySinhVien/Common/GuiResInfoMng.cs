using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.Common
{
    /// <summary>
    /// Class quản lý toàn bộ hoạt động của hệ thống
    /// </summary>
    class GuiResInfoMng
    {
        #region Delegate
        /// <summary>
        /// Delegate truyền thông điệp đến các form
        /// </summary>
        /// <param name="e">Event ID</param>
        /// <param name="data">Dữ liệu bất kỳ</param>
        internal delegate void DelegateGuiEvent(GuiEventID e, object data);

        /// <summary>
        /// Event quản lý việc truyền dữ liệu
        /// </summary>
        public static event DelegateGuiEvent GuiEventHandle;
        #endregion Delegate

        #region Enum
        /// <summary>
        /// Định nghĩa các form/màn hình
        /// </summary>
        public enum ScreenID
        {
            None,
            SplashScreen,
            LogInScreen,
            LogOutScreen,
            BackUpDbScreen,
            SoftWareInfoScreen,
            InputBookScreen,
            SellBookScreen,
            SupplyCustomerScreen,
            MailToSupply,
            ReportBookAvailable,
            ReportSupplyCustomer,
            ReportReceipt,
            ViewLogScreen,
            UserManageScreen,
            RulerScreen,
            Author,
            BookType
        }
        #endregion Enum

        #region Inner Class
        /// <summary>
        /// Class định nghĩa event ID
        /// </summary>
        internal class GuiEventID
        {
            /// <summary>
            /// Định nghĩa các event ID
            /// </summary>
            internal enum EventID
            {
                /// <summary>
                /// None
                /// </summary>
                None,

                /// <summary>
                /// Event thay đổi màn hình
                /// </summary>
                ChangeScreen,

                /// <summary>
                /// Event thay đổi người sử dụng
                /// </summary>
                ChangeUser,

                /// <summary>
                /// Event thông báo LogInScreen
                /// </summary>
                Login,

                /// <summary>
                /// Event thông báo Logout
                /// </summary>
                LogOut,

                /// <summary>
                /// Cho phép button click
                /// </summary>
                EnableButton,

                /// <summary>
                /// Không cho phép button click
                /// </summary>
                DisableButton,
            }

            /// <summary>
            /// ID của event
            /// </summary>
            public EventID ID = EventID.None;
        }
        #endregion Inner Class

        #region Constant
        #endregion Constant

        #region Field
        private static List<ScreenID> _listScreenID;
        private const string _SCREEN_ID_NOT_FOUND = @"Not found screen";
        #endregion Field

        #region Property;
        #endregion Property

        #region Constructor
        #endregion Constructor

        #region Method
        /// <summary>
        /// Hàm thay đổi màn hình
        /// </summary>
        /// <param name="screenID">ID của màn hình</param>
        public static void ChangeScreen(ScreenID screenID, bool IsTrackBackScreen = false)
        {
            //Nếu màn hình muốn thay đổi chính là màn hình hiện tại thỉ bỏ qua
            if (GetCurrentScreen() == screenID && IsTrackBackScreen == false)
            {
                return;
            }

            Log.Write("Change to screen " + screenID);
            //Lấy ra tên của màn hình
            string screenName = GetScreenName(screenID);

            //Lấy ra handle của màn hình
            UserControl userControl = GetIntanceScreen(screenID);

            //Lấy ra form main hiện hành
            MainWindow mainWindow = Program.MainForm as MainWindow;

            if (mainWindow != null)
            {
                //Thay đổi màn hình
                mainWindow.ChangeControlOfPanel(userControl);

                //Thông báo đến cho các màn hình khác là có sự thay đổi màn hình
                SendInternalEvent(new GuiEventID()
                {
                    ID = GuiEventID.EventID.ChangeScreen
                }, screenName);

                //Ghi lại lịch sử thay đổi màn hình
                if (_listScreenID == null)
                {
                    _listScreenID = new List<ScreenID>();
                }

                //Nếu không phải trackbackscreen thì ta mới thêm screen đó vào list
                //tránh tình trạng quay vòng screen
                if (IsTrackBackScreen == false)
                {
                    if (screenID != ScreenID.SplashScreen)
                    {
                        _listScreenID.Add(screenID);
                    }
                }
            }
        }

        /// <summary>
        /// Hàm lấy tên của màn hình thông qua ID
        /// </summary>
        /// <param name="screenID">ScreenID của màn hình</param>
        /// <returns>Tên màn hình</returns>
        public static string GetScreenName(ScreenID screenID)
        {
            string str = "";
            switch (screenID)
            {
                case ScreenID.SplashScreen:
                    str = @"Đang khởi động chương trình";
                    break;
                case ScreenID.LogInScreen:
                case ScreenID.LogOutScreen:
                    str = @"Đăng nhập vào hệ thống";
                    break;
                case ScreenID.BackUpDbScreen:
                    str = @"Sao lưu CSDL";
                    break;
                case ScreenID.SoftWareInfoScreen:
                    str = @"Thông tin phần mềm";
                    break;
                case ScreenID.InputBookScreen:
                    str = @"Quản lý nhập sách vào kho sách";
                    break;
                case ScreenID.SellBookScreen:
                    str = @"Quản lý bán sách";
                    break;
                case ScreenID.SupplyCustomerScreen:
                    str = @"Quản lý nhà cung cấp sách";
                    break;
                case ScreenID.MailToSupply:
                    str = @"Gửi mail cho nhà cung cấp";
                    break;
                case ScreenID.ReportBookAvailable:
                    str = @"Báo cáo danh mục sách khả dụng";
                    break;
                case ScreenID.ReportSupplyCustomer:
                    str = @"Báo cáo danh sách nhà cung cấp";
                    break;
                case ScreenID.ReportReceipt:
                    str = @"Báo cáo tài chính, doanh thu";
                    break;
                case ScreenID.ViewLogScreen:
                    str = @"Xem log của hệ thống";
                    break;
                case ScreenID.UserManageScreen:
                    str = @"Quản lý nhân viên, tài khoản sử dụng";
                    break;
                case ScreenID.RulerScreen:
                    str = @"Phân quyền cho nhân viên";
                    break;
                case ScreenID.Author:
                    str = @"Quản lý tác giả";
                    break;
                case ScreenID.BookType:
                    str = @"Quản lý thể loại sách";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(_SCREEN_ID_NOT_FOUND);
            }
            return str;
        }

        /// <summary>
        /// Hàm lấy ra handle của screen
        /// </summary>
        /// <param name="screenID">ScreenID tương ứng</param>
        /// <returns>Handle của screenID</returns>
        private static UserControl GetIntanceScreen(ScreenID screenID)
        {
            UserControl intance = null;
            switch (screenID)
            {
                case ScreenID.SplashScreen:
                    intance = new SplashScreen();
                    break;
                case ScreenID.LogInScreen:
                    intance = new Login();
                    break;
                case ScreenID.LogOutScreen:
                    break;
                case ScreenID.BackUpDbScreen:
                    break;
                case ScreenID.SoftWareInfoScreen:
                    break;
                case ScreenID.InputBookScreen:
                    intance = new InputBook();
                    break;
                case ScreenID.SellBookScreen:
                    break;
                case ScreenID.SupplyCustomerScreen:
                    break;
                case ScreenID.MailToSupply:
                    break;
                case ScreenID.ReportBookAvailable:
                    break;
                case ScreenID.ReportSupplyCustomer:
                    break;
                case ScreenID.ReportReceipt:
                    break;
                case ScreenID.ViewLogScreen:
                    intance = new ViewLog();
                    break;
                case ScreenID.UserManageScreen:
                    break;
                case ScreenID.RulerScreen:
                    intance = new PhanQuyen();
                    break;
                case ScreenID.Author:
                    intance = new Author();
                    break;
                case ScreenID.BookType:
                    intance = new BookType();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(_SCREEN_ID_NOT_FOUND);
            }
            return intance;
        }

        /// <summary>
        /// Hàm gửi event đến toàn bộ các form
        /// </summary>
        /// <param name="e">EventID muốn thông báo</param>
        /// <param name="data">Nội dung muốn thông báo</param>
        public static void SendInternalEvent(GuiEventID e, object data)
        {
            if (GuiEventHandle != null)
            {
                GuiEventHandle(e, data);
            }
        }

        /// <summary>
        /// Back lại screen trước đó
        /// </summary>
        /// <param name="count"></param>
        public static void TrackBackScreen(int count = 1)
        {
            if (_listScreenID.Count <= 1)
            {
                return;
            }

            if (count > 0)
            {
                for (int i = 1; i <= count; i++)
                {
                    if (_listScreenID.Count > 1)
                    {
                        int index = _listScreenID.Count;
                        _listScreenID.RemoveAt(index - 1);
                    }
                }
            }
            if (_listScreenID.Count > 0)
            {
                if (_listScreenID[_listScreenID.Count - 1] != ScreenID.SplashScreen)
                {
                    ChangeScreen(_listScreenID[_listScreenID.Count - 1], true);
                }
            }
        }

        /// <summary>
        /// Hàm lấy ảnh của màn hình splash screen
        /// </summary>
        /// <returns>Trả về ảnh kích thước 1024x690</returns>
        public static Bitmap GetBitmapSplashScreen()
        {
            Bitmap bmp = null;
            //Thực hiện việc đọc cấu hình để lấy được ảnh khi khởi động
            //sẽ có 3 ảnh đó là background_splash_screen_1,2,3
            //Chọn 1 trong 3 cái để hiển thị
            return Properties.Resources.background_splash_screen_1;
        }

        /// <summary>
        /// Hàm lấy ra form main
        /// </summary>
        /// <returns></returns>
        public static MainWindow GetMainWindow()
        {
            MainWindow mainWindow = Program.MainForm as MainWindow;
            return mainWindow;
        }

        /// <summary>
        /// Hàm lấy screenID hiện tại
        /// </summary>
        /// <returns>ScreenID</returns>
        public static ScreenID GetCurrentScreen()
        {
            if (null == _listScreenID || _listScreenID.Count == 0)
            {
                return ScreenID.None;
            }
            return _listScreenID[_listScreenID.Count - 1];
        }

        /// <summary>
        /// Hàm kiểm tra xem màn hình hiện tại có được phép thêm mới dữ liệu hay ko
        /// </summary>
        /// <returns>True nếu đươc phép, false nếu ko đươc phép</returns>
        public static bool CanInsert()
        {
            return false;
        }

        /// <summary>
        /// Hàm kiểm tra xem màn hình hiện tại có được phép sửa dữ liệu hay ko
        /// </summary>
        /// <returns>True nếu đươc phép, false nếu ko đươc phép</returns>
        public static bool CanUpdate()
        {
            return false;
        }

        /// <summary>
        /// Hàm kiểm tra xem màn hình hiện tại có được phép xóa dữ liệu hay ko
        /// </summary>
        /// <returns>True nếu đươc phép, false nếu ko đươc phép</returns>
        public static bool CanDelete()
        {
            return false;
        }

        /// <summary>
        /// Hàm kiểm tra xem màn hình hiện tại có được xem dữ liệu hay ko
        /// </summary>
        /// <returns>True nếu đươc phép, false nếu ko đươc phép</returns>
        public static bool CanView()
        {
            return false;
        }
        #endregion Method
    }
}
