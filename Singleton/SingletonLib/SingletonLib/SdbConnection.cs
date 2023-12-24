using System.Data.SqlClient;
using System.Diagnostics;

namespace SingletonLib
{
    public class SdbConnection
    {
        private static string _connectionString;

        private static SqlConnection _connection;

        private SdbConnection()
        {
            //_connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            //                    @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\DB.mdf; Integrated Security = True; Connect Timeout = 30"
            _connection = new SqlConnection(_connectionString);
        }

        private static SdbConnection _instance;

        private static readonly object _lock = new object();

        public static SdbConnection OpenConnection(string cString)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _connectionString = cString;
                        _instance = new SdbConnection();

                    }
                }
            }
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }
            return _instance;
        }

        public  SqlConnection GetConnection { get { return _connection; } }

        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();

            }
        }
    }
}
