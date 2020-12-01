using System;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsFinal
{
    static class DataProvider
    {
        // lớp này xử lí việc kết nối tới SQL Server và thực thi truy vấn
        public static readonly string connectionStr = @"Data Source=DESKTOP-749KHNV\SQLEXPRESS;
                                                      Initial Catalog=User Accounts;
                                                      Integrated Security=True";
        static readonly SqlConnection connection = new SqlConnection(connectionStr);
        static SqlDataAdapter adapter;
        static SqlCommand command;

        //--
        public static DataTable ExecuteReader(string query)
        {
            connection.Open();

            command = new SqlCommand(query, connection);
            adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);

            connection.Close();
            return data;

        }

        //--
        public static bool ExecuteNonQuery(string query)
        {
            try
            {
                connection.Open();
                command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                connection.Close();
                return true;
            }
            catch (Exception)
            {
                connection.Close();
                return false;
            }
        }

        //--
        public static object ExecuteScalar(string query)
        {
            connection.Open();
            command = new SqlCommand(query, connection);
            object data = command.ExecuteScalar();

            connection.Close();
            return data;
        }
    }
}