using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChatMail.ViewModels;

namespace ChatMail.Interfaces
{
    public interface IAdminView
    {
        void ShowUsers(AdminViewModel adminViewModel);
        string[] ReadUserInput();
        void AddUser_Clicked(object sender, EventArgs e);
    }
}
