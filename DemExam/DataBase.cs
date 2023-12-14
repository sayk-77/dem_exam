using System;
using MySql.Data.MySqlClient;

namespace DemExam
{
    public class DataBase
    {
        private MySqlConnection _connection;

        public DataBase()
        {
            Initialize();
        }

        private void Initialize()
        {
            const string connectString = "server=localhost;user=root;database=trade;password=user_admin;";
            _connection = new MySqlConnection(connectString);
        }

        public void OpenConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return _connection;
        }
    }
}