using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChatMail.Logging;

namespace ChatMail.Interfaces
{
    interface IConsoleDao
    {
        List<LogEntry> GetLogEntries();
    }
}
