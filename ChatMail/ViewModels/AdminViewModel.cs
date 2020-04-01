using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChatMail.Logging;
using ChatMail.Models;

namespace ChatMail.ViewModels
{
    public class AdminViewModel
    {
        /// <summary>
        /// List of all users
        /// </summary>
        public List<User> Users { get; }

        /// <summary>
        /// Constructor of the viewModel
        /// </summary>
        /// <param name="users">List of all users</param>
        public AdminViewModel(List<User> users)
        {
            Logger.debug("Initalizing AdminViewModel with current data.", origin: "ChatMail.AdminViewModel");
            this.Users = users;
        }
    }
}
