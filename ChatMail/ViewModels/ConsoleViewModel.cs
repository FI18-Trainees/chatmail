using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChatMail.Logging;

namespace ChatMail.ViewModels
{
    public class ConsoleViewModel
    {
        public List<LogEntry> LogEntries { get; }

        public ConsoleViewModel(List<LogEntry> logEntries)
        {
            Logger.debug("Initalizing ConsoleViewModel with current data.", origin: "ChatMail.ConsoleViewModel");
            LogEntries = logEntries;
        }
    }
}
