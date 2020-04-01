using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChatMail.Interfaces;
using ChatMail.Logging;

namespace ChatMail.Models
{
    public class ConsoleDao : IConsoleDao
    {
        public List<LogEntry> GetLogEntries()
        {
            return Logger.LogEntries;
        }
    }
}
