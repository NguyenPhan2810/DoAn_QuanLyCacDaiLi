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
            catch
            {
                MessageBox.Show("Can not open connection ! ");
                return null;
            }
        }

        public static void ExecuteQuery(String sql)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            try
            {
                var cnn = OpenConnection();
                cmd.Connection = cnn;
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Can not execute query ! ");
            }
        }

        public static DataSet GetDataSet(String sql)
        {
            var cnn = OpenConnection();
            var da = new SqlDataAdapter(sql, cnn);
            var ds = new DataSet();
            da.Fill(ds);
            cnn.Close();
            return ds;
        }

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
