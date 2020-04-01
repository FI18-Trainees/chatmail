using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using ChatMail.Database;
using ChatMail.Interfaces;
using ChatMail.Views;
using ChatMail.Logging;

namespace ChatMail.Models
{
    public class LoginDao : ILoginDao
    {
        private readonly DBHandler dBHandler = new DBHandler();
        
        /// <summary>
        /// Gets all users from DBHandler
        /// </summary>
        /// <returns>List of all users</returns>
        public List<User> GetUsers()
        {
            Logger.debug("Fetching users", origin: "ChatMail.LoginDao");
            // Retreive users from DBHandler
            return dBHandler.GetAllUsers();
        }

        /// <summary>
        /// Calls method to open chat view and passes selected user
        /// </summary>
        /// <param name="selectedUser">selected username</param>
        public void Login(string selectedUser)
        {
            Logger.debug("Logging user in", origin: "ChatMail.LoginDao");
            // Open ChatView and pass selectedUser
            Program.Chat(selectedUser);
        }
    }
}
