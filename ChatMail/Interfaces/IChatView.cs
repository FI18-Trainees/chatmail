using ChatMail.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMail.Interfaces
{
    interface IChatView
    {
        void ShowMessages(ChatViewModel chatViewModel);

        void ShowUsers(ChatViewModel m_chatViewModel);

        string ReadUserInput();

        void ShowError(string message);
    }
}
