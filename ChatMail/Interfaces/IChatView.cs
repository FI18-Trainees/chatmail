﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChatMail.Models;
using ChatMail.ViewModels;
using ChatMail.Views;

namespace ChatMail.Interfaces
{
    interface IChatView
    {
        void ShowMessages(ChatViewModel chatViewModel);
        void ShowUsers(ChatViewModel m_chatViewModel);
        UserInput ReadUserInput();
        void ShowError(string message);
        void ShowUsername(string m_currentUserDisplayname);
        void CloseView(object sender, EventArgs e);
        void OpenConsoleView(object sender, EventArgs e);
        void OpenAdminView(object sender, EventArgs e);
    }
}
