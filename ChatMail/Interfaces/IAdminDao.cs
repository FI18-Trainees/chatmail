using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChatMail.Models;

namespace ChatMail.Interfaces
{
    interface IAdminDao
    {
        List<User> GetUsers();
        void AddUser(string firstname, string lastname, string displayname);
    }
}
