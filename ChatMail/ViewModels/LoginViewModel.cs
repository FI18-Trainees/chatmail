using ChatMail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMail.ViewModels
{
    public class LoginViewModel
    {
        public List<User> Users { get; }

        public LoginViewModel (List<User> users)
        {
            this.Users = users;
        }
    }
}
