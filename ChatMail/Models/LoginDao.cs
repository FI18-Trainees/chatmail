using ChatMail.Database;
using ChatMail.Interfaces;
using ChatMail.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChatMail.Models
{
    public class LoginDao : ILoginDao
    {
        private readonly DBHandler dBHandler = new DBHandler();
        public List<User> GetUsers()
        {
            // Retreive users from DBHandler
            return dBHandler.GetAllUsers();
        }

        public void Login(string selectedUser)
        {
            // Open ChatView and pass selectedUser
            Program.Chat(selectedUser);
        }
    }
}
