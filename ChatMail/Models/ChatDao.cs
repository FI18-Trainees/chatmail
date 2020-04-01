using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChatMail.Database;
using ChatMail.Interfaces;
using ChatMail.Views;
using ChatMail.Logging;

namespace ChatMail.Models
{
    /// <summary>
    /// Chat Data Access Object - Handles all data flow from and to the viewPresenter and viewModel
    /// </summary>
    public class ChatDao : IChatDao
    {
        private User currentUser = new User(0, "Udo", "Biermann", "Beerman");
        // private List<Message> m_allMessages;
        private readonly DBHandler dBHandler = new DBHandler();

        /// <summary>
        /// Constructs a message and sends it to the dbHandler
        /// </summary>
        /// <param name="content">Content of the message</param>
        /// <param name="receieverId">UserID of the receiver</param>
        public void SendMessage(UserInput userInput)
        {
            Logger.debug("Sending message.", origin: "ChatMail.ChatDao");
            List<User> users = GetUsers();
            //int index = users.FindIndex(user => user.Displayname == userInput.SelectedUsername);
            // Send message via DBHandler
            // User messageReceiver = users[index];
            List<User> receiver = new List<User>
            {
                //messageReceiver
            };
            userInput.SelectedUsername.ForEach(username => receiver.Add(users[users.FindIndex(user => user.Displayname == username)]));
            Message message = new Message(userInput.Content, DateTime.Now, currentUser, receiver);
            dBHandler.InsertMessage(message);
        }

        /// <summary>
        /// Fetches reveived messages for current user from dbHandler
        /// </summary>
        /// <returns>List of received messages</returns>
        public List<Message> GetAllMessages()
        {
            Logger.debug("Fetching messages.", origin: "ChatMail.ChatDao");
            // Get messages via DBHandler
            return dBHandler.GetMessagesByReceiverId(currentUser.UId);
        }

        /// <summary>
        /// Fetches all users from dbHandler
        /// </summary>
        /// <returns>List of users</returns>
        public List<User> GetUsers()
        {
            Logger.debug("Fetching users.", origin: "ChatMail.ChatDao");
            // Get users via DBHandler
            return dBHandler.GetAllUsers();
        }

        /// <summary>
        /// retreives current user data
        /// </summary>
        /// <returns>Display name of current user</returns>
        public string Login()
        {
            Logger.debug("Logging user in and fetching required information.", origin: "ChatMail.ChatDao");
            // retreive user data via DBHandler
            string currentUserName = Program.currentUser;
            List<User> users = GetUsers();
            int index = users.FindIndex(user => user.Displayname == currentUserName);
            currentUser = users[index];
            return currentUserName;
        }

        public void Console()
        {
            Logger.debug("Opening Console", origin: "ChatMail.ChatDao");
            Program.Console();
        }

        public void Admin()
        {
            Logger.debug("Logging user Admin", origin: "ChatMail.ChatDao");
            Program.Admin();
        }
    }
}
