using ChatMail.Database;
using ChatMail.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMail.Models
{
    public class ChatDao : IChatDao
    {
        private User currentUser = new User(0, "Udo", "Biermann", "Beerman");
        private readonly List<Message> m_allMessages;
        private readonly DBHandler dBHandler = new DBHandler();
        // TODO: insert DBHandler after Merge

        public void SendMessage(string content, int receieverId)
        {
            // Send message via DBHandler
            User messageReceiver = dBHandler.GetUserByUserId(receieverId);
            List<User> receiver = new List<User>
            {
                messageReceiver
            };
            Message message = new Message(content, new DateTime(), currentUser, receiver);
            dBHandler.InsertMessage(message);
        }

        public List<Message> GetAllMessages()
        {
            List<Message> messages = new List<Message>
            {
                new Message(1, "Test", new DateTime(), new User(1, "Udo", "Biermann", "Beerman"), new List<User>())
            };
            return messages;

            // Get messages via DBHandler
        }

        public void Login(int uId)
        {
            currentUser = new User(uId, "Udo", "Biermann", "Beerman");
            // retreive user data via DBHandler
        }
    }
}
