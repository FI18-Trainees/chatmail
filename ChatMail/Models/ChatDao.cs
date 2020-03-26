using ChatMail.Database;
using ChatMail.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void SendMessage(string content, int receieverId)
        {
            // Send message via DBHandler
            User messageReceiver = dBHandler.GetUserByUserId(receieverId);
            List<User> receiver = new List<User>
            {
                messageReceiver
            };
            Message message = new Message(content, DateTime.Now, currentUser, receiver);
            dBHandler.InsertMessage(message);
        }

        /// <summary>
        /// Fetches reveived messages for current user from dbHandler
        /// </summary>
        /// <returns>List of received messages</returns>
        public List<Message> GetAllMessages()
        {
            // Get messages via DBHandler
            return dBHandler.GetMessagesByReceiverId(currentUser.UId);
        }

        /// <summary>
        /// Fetches all users from dbHandler
        /// </summary>
        /// <returns>List of users</returns>
        public List<User> GetUsers()
        {
            // Get users via DBHandler
            return dBHandler.GetAllUsers();
        }

        /// <summary>
        /// log in the user and retreives user info corresponding to its ID
        /// </summary>
        /// <param name="uId"></param>
        public void Login(int uId)
        {
            currentUser = new User(uId, "Udo", "Biermann", "Beerman");
            // retreive user data via DBHandler
        }
    }
}
