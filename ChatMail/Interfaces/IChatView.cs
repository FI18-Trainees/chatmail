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
        void ShowMessages(IEnumerable<ChatViewModel> chatViewModelList);

        string ReadUserInput();

        void ShowError(string message);
    }
}
