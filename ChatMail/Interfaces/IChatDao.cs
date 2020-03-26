using ChatMail.Models;
using System.Collections.Generic;

namespace ChatMail.Interfaces
{
    public interface IChatDao
    {
        Message CreateMessage();

        List<Message> GetAllMessages();
    }
}