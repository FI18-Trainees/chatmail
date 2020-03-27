using ChatMail.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMail.Interfaces
{
    public interface ILoginView
    {
        void ShowUsers(LoginViewModel loginViewModel);
        string ReadUserInput();
        void CloseView();
    }
}
