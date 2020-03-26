using ChatMail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMail.ViewModels
{
    public class ChatViewModel
    {
        private readonly Message m_message;

        public ChatViewModel(Message message)
        {
            m_message = message;
        }

        public int MId
        {
            get { return m_message.MId; }
        }

        public string Content
        {
            get { return m_message.Content; }
        }

        public DateTime Timestamp
        {
            get { return m_message.Timestamp; }
        }

        public User Sender
        {
            get { return m_message.Sender; }
        }

        public List<User> Receiver
        {
            get { return m_message.Receiver; }
        }

        public Message Message
        {
            get { return m_message; }
        }
    }
}
