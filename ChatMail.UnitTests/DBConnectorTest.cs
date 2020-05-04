using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChatMail.Database;
using ChatMail.Models;
using System.IO;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;
using ChatMail.Exceptions;

namespace ChatMail.UnitTests
{
    [TestClass]
    public class DBConnectorTest
    {
        [TestMethod]
        public void Open_ValidConfig_ThrowsNoError()
        {
            ConnectionDetails validConfig;
            using (StreamReader r = new StreamReader("config/config-default.json"))
            {
                string json = r.ReadToEnd();
                validConfig = JsonConvert.DeserializeObject<ConnectionDetails>(json);
            }
            DBConnector db = new DBConnector(validConfig);

            db.Open();
            db.Close();
        }

        [TestMethod]
        public void Open_InvalidConfig_ThrowsError()
        {
            ConnectionDetails invalidConfig;
            using (StreamReader r = new StreamReader("config/config-default.json"))
            {
                string json = r.ReadToEnd();
                invalidConfig = JsonConvert.DeserializeObject<ConnectionDetails>(json);
            }
            invalidConfig.Port += 10;
            DBConnector db = new DBConnector(invalidConfig);

            Assert.ThrowsException<DatabaseConnectionError>(db.Open);
        }

        [TestMethod]
        public void Execute_ValidSQLStatement_ReturnsDataTable()
        {
            ConnectionDetails validConfig;
            using (StreamReader r = new StreamReader("config/config-default.json"))
            {
                string json = r.ReadToEnd();
                validConfig = JsonConvert.DeserializeObject<ConnectionDetails>(json);
            }
            DBConnector db = new DBConnector(validConfig);
            string validSQL = "SELECT * FROM chatmail.user";

            var dt = db.Execute(validSQL);

            Assert.IsInstanceOfType(dt, typeof(DataTable));
        }

        [TestMethod]
        public void Execute_ValidSQLCommand_ReturnsDataTable()
        {
            ConnectionDetails validConfig;
            using (StreamReader r = new StreamReader("config/config-default.json"))
            {
                string json = r.ReadToEnd();
                validConfig = JsonConvert.DeserializeObject<ConnectionDetails>(json);
            }
            DBConnector db = new DBConnector(validConfig);
            MySqlCommand validCommand = new MySqlCommand("SELECT * FROM chatmail.user");

            var dt = db.Execute(validCommand);

            Assert.IsInstanceOfType(dt, typeof(DataTable));
        }

        [TestMethod]
        public void Execute_InvalidSQLStatement_ReturnsDataTable()
        {
            ConnectionDetails validConfig;
            using (StreamReader r = new StreamReader("config/config-default.json"))
            {
                string json = r.ReadToEnd();
                validConfig = JsonConvert.DeserializeObject<ConnectionDetails>(json);
            }
            DBConnector db = new DBConnector(validConfig);
            string invalidSQL = "SELECT * FROM_WRONG chatmail.user";

            Action toTest = () => db.Execute(invalidSQL);
            Assert.ThrowsException<MySqlException>(toTest);
        }

        [TestMethod]
        public void Execute_InvalidSQLCommand_ReturnsDataTable()
        {
            ConnectionDetails validConfig;
            using (StreamReader r = new StreamReader("config/config-default.json"))
            {
                string json = r.ReadToEnd();
                validConfig = JsonConvert.DeserializeObject<ConnectionDetails>(json);
            }
            DBConnector db = new DBConnector(validConfig);
            MySqlCommand invalidCommand = new MySqlCommand("SELECT * FROM_WRONG chatmail.user");

            Action toTest = () => db.Execute(invalidCommand);
            Assert.ThrowsException<MySqlException>(toTest);
        }
    }
}
