using ChatMail.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMail.ViewModels
{
    public class ChatViewModel
    {
        public List<Message> Messages { get; }

        public List<User> Users { get; }

        public ChatViewModel(List<Message> messages)
        {
            Messages = messages;
        }

        public ChatViewModel(List<Message> messages, List<User> users)
        {
            Messages = messages;
            Users = users;
        }
    }
}
