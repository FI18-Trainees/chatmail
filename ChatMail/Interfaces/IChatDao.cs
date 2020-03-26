using ChatMail.Models;
using ChatMail.Views;
using System.Collections.Generic;

namespace ChatMail.Interfaces
{
    public interface IChatDao
    {
        void SendMessage(UserInput userInput);

        List<Message> GetAllMessages();
        List<User> GetUsers();
    }
}