using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChatMail.Interfaces;
using ChatMail.ViewModels;
using ChatMail.Logging;
using ChatMail.Views;

namespace ChatMail.Presenter
{
    class ConsolePresenter
    {
        private readonly IConsoleView m_consoleView;
        private readonly IConsoleDao m_consoleDao;
        private ConsoleViewModel m_consoleViewModel;

        public ConsolePresenter(ConsoleView consoleView, IConsoleDao dao)
        {
            Logger.debug("Initalizing Console Presenter.", origin: "ChatMail.ConsolePresenter");
            m_consoleView = consoleView;
            m_consoleDao = dao;

            Initialize();
        }

        private void Initialize()
        {
            Logger.debug("Initalizing components", origin: "ChatMail.ConsolePresenter");

            List<LogEntry> logEntries = m_consoleDao.GetLogEntries();

            m_consoleViewModel = ResolveViewModel(logEntries);

            m_consoleView.DisplayDebug(m_consoleViewModel);
        }

        private ConsoleViewModel ResolveViewModel(List<LogEntry> logEntries)
        {
            return new ConsoleViewModel(logEntries);
        }
    }
}
