using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChatMail.Interfaces;
using ChatMail.Database;
using ChatMail.Logging;

namespace ChatMail.Models
{
    public class AdminDao : IAdminDao
    {
        private readonly DBHandler dBHandler = new DBHandler();

        /// <summary>
        /// Gets all users from DBHandler
        /// </summary>
        /// <returns>List of all users</returns>
        public List<User> GetUsers()
        {
            Logger.debug("Fetching users", origin: "ChatMail.AdminDao");
            // Retreive users from DBHandler
            return dBHandler.GetAllUsers();
        }

        public void AddUser(string firstname, string lastname, string displayname)
        {
            User user = new User(firstname, lastname, displayname);
            dBHandler.InsertUser(user);
        }
    }
}
