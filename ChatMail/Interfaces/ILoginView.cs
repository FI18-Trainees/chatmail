using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChatMail.ViewModels;

namespace ChatMail.Interfaces
{
    public interface ILoginView
    {
        void ShowUsers(LoginViewModel loginViewModel);
        string ReadUserInput();
        void CloseView(object sender, EventArgs e);
        void OpenConsoleView(object sender, EventArgs e);
        void OpenAdminView(object sender, EventArgs e);
    }
}
