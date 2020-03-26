using ChatMail.Models;
using System.Collections.Generic;

namespace ChatMail.Interfaces
{
    public interface IChatDao
    {
        void SendMessage(string message, int receivcerId);

        List<Message> GetAllMessages();
    }
}