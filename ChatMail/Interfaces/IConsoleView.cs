using ChatMail.Models;
using ChatMail.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMail.Interfaces
{
    interface IConsoleView
    {
        void DisplayDebug(ConsoleViewModel viewModel);
    }
}
