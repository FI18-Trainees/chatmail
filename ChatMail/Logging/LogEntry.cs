using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMail.Logging
{
    public class LogEntry
    {
        public string Content { get; }
        public string Origin { get; }
        public DateTime Timestamp { get; }
        public LogLevel LogLevel { get;  }

        /// <summary>
        /// Constructor of LogEntry
        /// </summary>
        /// <param name="content">Body of message</param>
        /// <param name="origin">Where this message came from (e.g. ChatMail.Frontend)</param>
        /// <param name="logLevel">LogLevel of this message</param>
        public LogEntry(string content, string origin, LogLevel logLevel)
        {
            if (!content.StartsWith("ChatMail"))
            {
                content = "ChatMail." + content;
            }
            this.Content = content;
            this.Origin = origin;
            this.Timestamp = DateTime.Now;
            this.LogLevel = logLevel;
        }

        /// <summary>
        /// Displays human readable version of logentry
        /// </summary>
        /// <returns>hum readable string</returns>
        public string display()
        {
            string time = this.Timestamp.ToString("yyyy.MM.dd HH:mm:ss");
            return "[" + this.LogLevel.ToString() + "] [" + time + "] " + this.Origin + ": " + this.Content;
        }
    }
}
