using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace QuanLyCacDaiLi
{
    class DatabaseHelper
    {
        private static string databaseName = "QLDL";
        private static SqlConnection cnn = null;

        // Return true if succeeded, false otherwise
        public static bool Init()
        {
            var loadingForm = new LoadingForm(ConfigurationManager.ConnectionStrings[databaseName].ConnectionString);
            loadingForm.Show();

            OpenConnection().Close();

            loadingForm.Close();
            return cnn != null;
        }

        public static SqlConnection OpenConnection()
        {

            try
            {
                if (cnn == null)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings[databaseName].ConnectionString;
                    cnn = new SqlConnection(connectionString);
                }

                cnn.Open();
                return cnn;
            }
            catch (Exception e)
            {
                cnn = null;
                MessageBox.Show(@"Không thể kết nối tới cơ sở dữ liệu. Hãy kiểm tra 'connection string', kiểm tra tên server trong connection string và chắc rằng có cơ sở dữ liệu tên 'QLDL' đang chạy trên máy ! "
                            + "\n\n\nChi tiết: " + e.Message, "lỗi");
                throw e;
                return null;
            }
        }

        // Return number of rows affected
        public static int ExecuteQuery(String sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            var numOfRowsAffected = -1;

            try
            {
                var cnn = OpenConnection();
                cmd.Connection = cnn;
                numOfRowsAffected = cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Can not execute query ! ");
                throw e;
            }

            return numOfRowsAffected;
        }

        //public static DataSet GetDataSet(String sql)
        //{
        //    var cnn = OpenConnection();
        //    var da = new SqlDataAdapter(sql, cnn);
        //    var ds = new DataSet();
        //    da.Fill(ds);
        //    cnn.Close();
        //    return ds;
        //}

        public static DataTable GetDataTable(String sql)
        {
            var cnn = OpenConnection();
            var da = new SqlDataAdapter(sql, cnn);
            var ds = new DataSet();
            da.Fill(ds);
            cnn.Close();

            return ds.Tables[0];
        }
    }
}
