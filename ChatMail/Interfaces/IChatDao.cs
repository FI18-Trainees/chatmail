using ChatMail.Models;
using System.Collections.Generic;

namespace ChatMail.Interfaces
{
    public interface IChatDao
    {
        void SendMessage(Message message);

        List<Message> GetAllMessages();
    }
}