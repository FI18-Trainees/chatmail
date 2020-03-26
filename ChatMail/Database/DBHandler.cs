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
        private readonly DBConnector databaseInstance;
        
        /// <summary>
        /// Constructor of DBHandler
        /// Handles config/connection string for database connection
        /// </summary>
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

        /// <summary>
        /// Gets list of all registered users
        /// </summary>
        /// <returns>List of user objects</returns>
        public List<User> GetAllUsers()
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
        /// <summary>
        /// Gets User by UserID
        /// </summary>
        /// <param name="uId">User id to search for</param>
        /// <returns>User object, null if not found</returns>
        public User GetUserByUserId(int uId)
        {
            string sql = File.ReadAllText(@"SQL\selectUserByUId.sql");

            MySqlCommand command = new MySqlCommand(sql);
            command.Parameters.Add("@UID", MySqlDbType.Int32);
            command.Parameters["@UID"].Value = uId;

            DataTable dt = this.databaseInstance.Execute(command);
            foreach (DataRow row in dt.Rows)
            {
                return new User(row);
            }
            return null;
        }
        /// <summary>
        /// Use with caution.
        /// Gets a list of all sent messages
        /// </summary>
        /// <returns>List of all message objects</returns>
        public List<Message> GetAllMessages()
        {
            string sql = File.ReadAllText(@"SQL\selectAllMessages.sql");

            DataTable dt = this.databaseInstance.Execute(sql);
            List<Message> output = new List<Message>();

            foreach (DataRow row in dt.Rows)
            {
                int mId = int.Parse(row["mId"].ToString());
                int senderId = int.Parse(row["senderId"].ToString());
                User sender = this.GetUserByUserId(senderId);
                List<User> receiverList = this.GetReceiversByMessageId(mId);
                output.Add(new Message(row, sender, receiverList));
            }

            return output;
        }
        /// <summary>
        /// Gets Messages by receiver user id
        /// </summary>
        /// <param name="rId">ID of user that received messages</param>
        /// <returns>List of message objects sent to the user</returns>
        public List<Message> GetMessagesByReceiverId(int rId)
        {
            string sql = File.ReadAllText(@"SQL\selectMessageByRId.sql");

            MySqlCommand command = new MySqlCommand(sql);
            command.Parameters.Add("@RID", MySqlDbType.Int32);
            command.Parameters["@RID"].Value = rId;

            DataTable dt = this.databaseInstance.Execute(command);
            List<Message> output = new List<Message>();

            foreach (DataRow row in dt.Rows)
            {
                int mId = int.Parse(row["mId"].ToString());
                int senderId = int.Parse(row["senderId"].ToString());
                User sender = this.GetUserByUserId(senderId);
                List<User> receiverList = this.GetReceiversByMessageId(mId);
                output.Add(new Message(row, sender, receiverList));
            }

            return output;
        }
        /// <summary>
        /// Gets Message by MessageID
        /// </summary>
        /// <param name="mId">message id to search for</param>
        /// <returns>Message object, null if not found</returns>
        public Message GetMessageByMessageId(int mId)
        {
            string sql = File.ReadAllText(@"SQL\selectMessageByMessageId.sql");

            MySqlCommand command = new MySqlCommand(sql);
            command.Parameters.Add("@MID", MySqlDbType.Int32);
            command.Parameters["@MID"].Value = mId;

            DataTable dt = this.databaseInstance.Execute(command);

            foreach (DataRow row in dt.Rows)
            {
                int senderId = int.Parse(row["senderId"].ToString());
                User sender = this.GetUserByUserId(senderId);
                List<User> receiverList = this.GetReceiversByMessageId(mId);
                return new Message(row, sender, receiverList);
            }

            return null;
        }
        /// <summary>
        /// Gets a list of all receivers of a message
        /// </summary>
        /// <param name="mId">Message ID to scan</param>
        /// <returns>List of all receivers of this message</returns>
        public List<User> GetReceiversByMessageId(int mId)
        {
            string sql = File.ReadAllText(@"SQL\selectReceiverByMId.sql");

            MySqlCommand command = new MySqlCommand(sql);
            command.Parameters.Add("@MID", MySqlDbType.Int32);
            command.Parameters["@MID"].Value = mId;

            DataTable dt = this.databaseInstance.Execute(command);
            List<User> output = new List<User>();

            foreach (DataRow row in dt.Rows)
            {
                output.Add(new User(row));
            }

            return output;
        }
        /// <summary>
        /// Inserts MessageReceiver relation to database
        /// </summary>
        /// <param name="mId"></param>
        /// <param name="rId"></param>
        /// <returns></returns>
        private bool InsertMessageReceiver(int mId, int rId)
        {
            string sql = File.ReadAllText(@"SQL\InsertMessageReceiver.sql");

            MySqlCommand command = new MySqlCommand(sql);
            command.Parameters.Add("@MID", MySqlDbType.Int32);
            command.Parameters["@MID"].Value = mId;
            command.Parameters.Add("@RID", MySqlDbType.Int32);
            command.Parameters["@RID"].Value = rId;

            int result = this.databaseInstance.ExecuteNonQuery(command);
            return result != 0;
        }
        /// <summary>
        /// Inserts Message in database
        /// </summary>
        /// <param name="message">Message object to insert</param>
        /// <returns>info about success</returns>
        public bool InsertMessage(Message message)
        {
            string sql = File.ReadAllText(@"SQL\InsertMessage.sql");

            MySqlCommand command = new MySqlCommand(sql);
            command.Parameters.Add("@CONTENT", MySqlDbType.String);
            command.Parameters["@CONTENT"].Value = message.Content;
            command.Parameters.Add("@TIMESTAMP", MySqlDbType.DateTime);
            command.Parameters["@TIMESTAMP"].Value = message.Timestamp;
            command.Parameters.Add("@SENDERID", MySqlDbType.Int32);
            command.Parameters["@SENDERID"].Value = message.Sender.UId;

            bool success = true;

            DataTable dt = this.databaseInstance.Execute(command);
            
            // get id of inserted message
            int mId = -1;
            foreach (DataRow row in dt.Rows)
            {
                mId = int.Parse(row["ID"].ToString());
                break;
            }
            if (mId == -1)
            {
                return false; // return error on no inserted row
            }

            // insert receiver details
            foreach (User user in message.Receiver)
            {
                bool suc = this.InsertMessageReceiver(mId, user.UId);
                if (!suc)
                {
                    success = false;
                }
            }

            return success;
        }
        /// <summary>
        /// Inserts User in database
        /// </summary>
        /// <param name="user">User object ot insert</param>
        /// <returns>Info about success</returns>
        public bool InsertUser(User user)
        {
            string sql = File.ReadAllText(@"SQL\insertUser.sql");

            MySqlCommand command = new MySqlCommand(sql);
            command.Parameters.Add("@FIRSTNAME", MySqlDbType.String);
            command.Parameters["@FIRSTNAME"].Value = user.Firstname;
            command.Parameters.Add("@LASTNAME", MySqlDbType.String);
            command.Parameters["@LASTNAME"].Value = user.Lastname;
            command.Parameters.Add("@DISPLAYNAME", MySqlDbType.String);
            command.Parameters["@DISPLAYNAME"].Value = user.Displayname;

            int result = this.databaseInstance.ExecuteNonQuery(command);
            return result != 0;
        }
    }
}