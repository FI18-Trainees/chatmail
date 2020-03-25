using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;
using ChatMail.Models;

namespace ChatMail.Database
{
    class DBConnector
    {
        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Variablen
        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        MySqlConnection connection = new MySqlConnection();

        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Konstruktoren
        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        public DBConnector(string server, string port, string database, string user, string password, bool open = false)
        {
            this.connection.ConnectionString = "server=" + server + ";port=" + port + ";database=" + database + ";userid=" + user + ";password=" + password;
            if(open)
            {
                this.Open();
            }
        }
        public DBConnector(ConnectionDetails config, bool open = false)
        {
            this.connection.ConnectionString = "server=" + config.Server + ";port=" + config.Port + ";database=" + config.Database + ";userid=" + config.User + ";password=" + config.Password;
            if (open)
            {
                this.Open();
            }
        }

        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Methoden
        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Open()
        {
            if(this.connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void Close()
        {
            if (this.connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public DataTable Execute(string sql)
        {
            this.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = sql;
            command.Connection = this.connection;
            DataTable result = new DataTable();
            result.Load(command.ExecuteReader());
            
            this.Close();

            return result;
        }
    }
}
