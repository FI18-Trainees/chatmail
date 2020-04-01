using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMail.Logging
{
    public static class Logger
    {
        public static List<LogEntry> LogEntries = new List<LogEntry>();
        public static bool logToDebug { get; set; } = false;
        public static LogLevel loggerLevel { get; set; } = LogLevel.Info;

        /// <summary>
        /// Creates logentry and adds it to LogEntries and displays message if needed
        /// </summary>
        /// <param name="content">Body of message</param>
        /// <param name="origin">Where this message came from (e.g. ChatMail.Frontend)</param>
        /// <param name="logLevel">LogLevel of this message</param>
        private static void log(string content, string origin = "ChatMail", LogLevel logLevel = LogLevel.Debug)
        {
            LogEntry newEntry = new LogEntry(content, origin, logLevel);
            LogEntries.Add(newEntry);

            if (logToDebug && loggerLevel <= newEntry.LogLevel)
            {
                Debug.WriteLine(newEntry.display());
            }
        }
        /// <summary>
        /// Creates logentry with LogLevel Debug
        /// </summary>
        /// <param name="content">Body of message</param>
        /// <param name="origin">Where this message came from (e.g. ChatMail.Frontend)</param>
        public static void debug(string content, string origin = "ChatMail")
        {
            log(content, origin, LogLevel.Debug);
        }
        /// <summary>
        /// Creates logentry with LogLevel Info
        /// </summary>
        /// <param name="content">Body of message</param>
        /// <param name="origin">Where this message came from (e.g. ChatMail.Frontend)</param>
        public static void info(string content, string origin = "ChatMail")
        {
            log(content, origin, LogLevel.Info);
        }
        /// <summary>
        /// Creates logentry with LogLevel Warning
        /// </summary>
        /// <param name="content">Body of message</param>
        /// <param name="origin">Where this message came from (e.g. ChatMail.Frontend)</param>
        public static void warning(string content, string origin = "ChatMail")
        {
            log(content, origin, LogLevel.Warning);
        }
        /// <summary>
        /// Creates logentry with LogLevel Critical
        /// </summary>
        /// <param name="content">Body of message</param>
        /// <param name="origin">Where this message came from (e.g. ChatMail.Frontend)</param>
        public static void critical(string content, string origin = "ChatMail")
        {
            log(content, origin, LogLevel.Critical);
        }
    }
}
