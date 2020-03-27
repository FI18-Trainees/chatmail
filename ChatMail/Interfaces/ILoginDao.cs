using ChatMail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMail.Interfaces
{
    public interface ILoginDao
    {
        List<User> GetUsers();
        void Login(string selectedUser);
    }
}
