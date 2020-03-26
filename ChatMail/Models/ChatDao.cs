using ChatMail.Interfaces;
using DBConnectorTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMail.Models
{
    public class ChatDao : IChatDao
    {
        private List<Message> m_allMessages;
        // TODO: insert DBHandler after Merge

        public Message CreateMessage()
        {
            throw new NotImplementedException();
        }

        public List<Message> GetAllMessages()
        {
            List<Message> messages = new List<Message>(1);
            messages.Add(new Message(1, "Test", new DateTime(), new User(1, "Udo", "Biermann", "Beerman"), new List<User>(1)));
            return messages;
        }
    }
}
