﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;
using ChatMail.Models;
using ChatMail.Logging;

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
            Logger.info("Initialised DBConnector.", "ChatMail.Database.Connector");
            Logger.debug("Connectionstring: " + this.connection.ConnectionString, "ChatMail.Database.Connector");
            if (open)
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
            Logger.info("Initialised DBConnector.", "ChatMail.Database.Connector");
            Logger.debug("Connectionstring: " + this.connection.ConnectionString, "ChatMail.Database.Connector");
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
                Logger.debug("Opening connection.", "ChatMail.Database.Connector");
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
                Logger.debug("Closing connection.", "ChatMail.Database.Connector");
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
            Logger.info("Executing \"" + sql + "\".", "ChatMail.Database.Connector");
            this.Open();

            using (MySqlCommand command = new MySqlCommand())
            {
                command.CommandText = sql;
                command.Connection = this.connection;
                DataTable result = new DataTable();
                result.Load(command.ExecuteReader());

                this.Close();
                Logger.debug("Returning query result.", "ChatMail.Database.Connector");
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
            Logger.info("Executing \"" + command.CommandText + "\".", "ChatMail.Database.Connector");
            this.Open();

            command.Connection = this.connection;
            DataTable result = new DataTable();
            result.Load(command.ExecuteReader());

            this.Close();
            Logger.debug("Returning query result.", "ChatMail.Database.Connector");
            return result;
        }
        /// <summary>
        /// Executes sql command
        /// </summary>
        /// <param name="command">MySqlCommand to execute</param>
        /// <returns>Count of affected rows</returns>
        public int ExecuteNonQuery(MySqlCommand command)
        {
            Logger.info("Executing \"" + command.CommandText + "\".", "ChatMail.Database.Connector");
            this.Open();

            command.Connection = this.connection;
            int x = command.ExecuteNonQuery();

            this.Close();
            Logger.debug("Returning query result.", "ChatMail.Database.Connector");
            return x;
        }
    }
}
