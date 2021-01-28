using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace IZBankingATMClassLibrary
{
    public class Database
    {
        public Database()
        {
            initClass();

        }

        private void initClass()
        {
            _server = "localhost";
            _database = "izbankingatm";
            _uid = "root";
            _password = "";

            SetupConnection();
        }

        private MySqlConnection _connection;
        private string _server;
        private string _database;
        private string _uid;
        private string _password;

        public MySqlConnection connection { get { return _connection; } }

        private void SetupConnection()
        {
            string connectionString = "Server=" + _server + ";Database=" + _database + ";User Id=" + _uid + ";Password=" + _password;
            _connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Close();
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
