using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;
using System.IO;
using ChatMail.Models;
using Newtonsoft.Json;

namespace ChatMail.Database
{
    class DBHandler
    {
        private DBConnector databaseInstance;
        public DBHandler()
        {
            string PathToJson;
            if (File.Exists("config/config.json"))
            {
                PathToJson = "config/config.json";
            }
            else
            {
                PathToJson = "config/config-default.json";
            }
            ConnectionDetails config;
            using (StreamReader r = new StreamReader(PathToJson))
            {
                string json = r.ReadToEnd();
                config = JsonConvert.DeserializeObject<ConnectionDetails>(json);
            }

            this.databaseInstance = new DBConnector(config);
        }

        public List<User> getAllUsers()
        {
            string sql = File.ReadAllText(@"SQL\selectAllUsers.sql");

            DataTable dt = this.databaseInstance.Execute(sql);
            List<User> output = new List<User>();

            foreach(DataRow row in dt.Rows)
            {
                output.Add(new User(row));
            }

            return output;
        }
    }
}