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
    public class DBConnector
    {
        readonly MySqlConnection connection = new MySqlConnection();

        /// <summary>
        /// Constructor of DBConnector
        /// </summary>
        /// <param name="server">server, info for connection string</param>
        /// <param name="port">port, info for connection string</param>
        /// <param name="database">database, info for connection string</param>
        /// <param name="user">user, info for connection string</param>
        /// <param name="password">password, info for connection string</param>
        /// <param name="open">Whether or not connection should be opened, default false</param>
        public DBConnector(string server, string port, string database, string user, string password, bool open = false)
        {
            this.connection.ConnectionString = "server=" + server + ";port=" + port + ";database=" + database + ";userid=" + user + ";password=" + password;
            if(open)
            {
                this.Open();
            }
        }
        /// <summary>
        /// Construcot of DBConnector
        /// </summary>
        /// <param name="config">ConnectionDetails containing all info for connection string</param>
        /// <param name="open">Whether or not connection should be opened, default false</param>
        public DBConnector(ConnectionDetails config, bool open = false)
        {
            this.connection.ConnectionString = "server=" + config.Server + ";port=" + config.Port + ";database=" + config.Database + ";userid=" + config.User + ";password=" + config.Password;
            if (open)
            {
                this.Open();
            }
        }

        /// <summary>
        /// Opens database connection if closed
        /// </summary>
        public void Open()
        {
            if(this.connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        /// <summary>
        /// Closes database connection if opened
        /// </summary>
        public void Close()
        {
            if (this.connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Executes sql statement
        /// </summary>
        /// <param name="sql">sql clause</param>
        /// <returns>Fetched Datatable</returns>
        public DataTable Execute(string sql)
        {
            this.Open();

            using (MySqlCommand command = new MySqlCommand())
            {
                command.CommandText = sql;
                command.Connection = this.connection;
                DataTable result = new DataTable();
                result.Load(command.ExecuteReader());

                this.Close();

                return result;
            }
        }
        /// <summary>
        /// Executes sql command
        /// </summary>
        /// <param name="command">MySqlCommand to execute</param>
        /// <returns>Fetched Datatable</returns>
        public DataTable Execute(MySqlCommand command)
        {
            this.Open();

            command.Connection = this.connection;
            DataTable result = new DataTable();
            result.Load(command.ExecuteReader());

            this.Close();

            return result;
        }
        /// <summary>
        /// Executes sql command
        /// </summary>
        /// <param name="command">MySqlCommand to execute</param>
        /// <returns>Count of affected rows</returns>
        public int ExecuteNonQuery(MySqlCommand command)
        {
            this.Open();

            command.Connection = this.connection;
            int x = command.ExecuteNonQuery();

            this.Close();

            return x;
        }
    }
}
