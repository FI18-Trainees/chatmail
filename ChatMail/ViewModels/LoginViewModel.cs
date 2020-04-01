using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChatMail.Models;
using ChatMail.Logging;

namespace ChatMail.ViewModels
{
    public class LoginViewModel
    {
        /// <summary>
        /// List of all users
        /// </summary>
        public List<User> Users { get; }

        /// <summary>
        /// Constructor of the viewModel
        /// </summary>
        /// <param name="users">List of all users</param>
        public LoginViewModel (List<User> users)
        {
            Logger.debug("Initalizing LoginViewModel with current data.", origin: "ChatMail.LoginViewModel");
            this.Users = users;
        }
    }
}
