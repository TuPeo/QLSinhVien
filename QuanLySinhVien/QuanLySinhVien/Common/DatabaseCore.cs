using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace QuanLySinhVien.Common
{
    partial class DatabaseCore
    {
        #region Field
        /// <summary>
        /// khởi tạo đối tượng SQLiteConnection
        /// </summary>
        private static SQLiteConnection _sqLiteConnection;

        /// <summary>
        /// khởi tạo đối tượng SQLiteCommand
        /// </summary>
        private static SQLiteCommand _sqLiteCommand;

        /// <summary>
        /// khởi tạo đối tượng SQLiteDataAdapter
        /// </summary>
        private static SQLiteDataAdapter _sqLiteDataAdapter;

        /// <summary>
        /// tên của database
        /// </summary>
        private static string _FILE_NAME = @"QLSVThucTap.db";

        /// <summary>
        /// Lỗi khi bị exeption
        /// </summary>
        private const string _EXCUTE_QUERY_ERROR = @"Excute query error";

        /// <summary>
        /// Object đồng bộ
        /// </summary>
        private static readonly object Obj = new object();
        #endregion Field

        #region Method

        /// <summary>
        /// hàm tạo csdl, nếu chưa có thì tạo mới., nếu có rồi thì hủy tạo
        /// </summary>
        public static void CreateDatabase()
        {
            try
            {
                lock(Obj)
                {
                    if (!File.Exists(_FILE_NAME)
                    {
                        SQLiteConnection.CreateFile(_FILE_NAME);
                        _sqLiteConnection=new SQLiteConnection("Data Source=" + _FILE_NAME + ";Version=3;New=False;Compress=True;");
                        ExecuteCreateDatabase();
                    }
                    _sqLiteConnection=new SQLiteConnection("Data Source=" + _FILE_NAME + ";Version=3;New=False;Compress=True;");
                }
            }
            catch(Exception ex)
            {

            }
        }


        /// <summary>
        /// hàm thực hiện các câu lệnh truy vấn như Insert, Update. Delete
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static int ExecuteQuery(string query)
        {
            try
            {
                lock(Obj)
                {
                    if (_sqLiteConnection.State==ConnectionState.Closed)
                    {
                        _sqLiteConnection.Open();
                    }
                    _sqLiteCommand = _sqLiteConnection.CreateCommand();
                    _sqLiteCommand.CommandText = query;

                    int rowEffect = _sqLiteCommand.ExecuteNonQuery();
                    _sqLiteConnection.Close();
                    return rowEffect;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(_EXCUTE_QUERY_ERROR);
            }
        }


        public static DataTable GetDataTable(string query)
        {
            try
            {
                lock(Obj)
                {
                    DataTable dataTable = new DataTable();
                    if (_sqLiteConnection.State == ConnectionState.Closed) ;
                    {
                        _sqLiteConnection.Open();
                    }

                    _sqLiteCommand = _sqLiteConnection.CreateCommand();
                    string commandText = query;

                    if (null != _sqLiteDataAdapter)
                    {
                        _sqLiteDataAdapter.Dispose();
                    }

                    _sqLiteDataAdapter = new SQLiteDataAdapter(commandText, _sqLiteConnection);
                    _sqLiteDataAdapter.Fill(dataTable);
                    _sqLiteConnection.Close();
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(_EXCUTE_QUERY_ERROR);
            }
        }
        /// <summary>
        /// Hàm lấy danh sách dữ liệu
        /// </summary>
        /// <param name="query">Câu lệnh truy vấn</param>
        /// <returns>Danh sách các dữ liệu kiểu bảng</returns>
        public static DataTable GetDatatable(string query)
        {
            try
            {
                lock (Obj)
                {
                    DataTable dtb = new DataTable();
                    if (_sqLiteConnection.State == ConnectionState.Closed)
                    {
                        _sqLiteConnection.Open();
                    }

                    _sqLiteCommand = _sqLiteConnection.CreateCommand();
                    string commandText = query;

                    if (null != _sqLiteDataAdapter)
                    {
                        _sqLiteDataAdapter.Dispose();
                    }

                    _sqLiteDataAdapter = new SQLiteDataAdapter(commandText, _sqLiteConnection);
                    _sqLiteDataAdapter.Fill(dtb);
                    _sqLiteConnection.Close();
                    return dtb;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(_EXCUTE_QUERY_ERROR);
            }
        }

        /// <summary>
        /// Giải phóng kết nối CSDL
        /// </summary>
        public static void ReleaseConnect()
        {
            if (null != _sqLiteConnection)
            {
                _sqLiteConnection.Dispose();
            }

            if (null != _sqLiteCommand)
            {
                _sqLiteCommand.Dispose();
            }

            if (null != _sqLiteDataAdapter)
            {
                _sqLiteDataAdapter.Dispose();
            }
        }
        #endregion Method
    }
}
