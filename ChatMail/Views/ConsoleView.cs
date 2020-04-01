using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChatMail.Interfaces;
using ChatMail.Logging;
using ChatMail.Models;
using ChatMail.Presenter;
using ChatMail.ViewModels;

namespace ChatMail.Views
{
    public partial class ConsoleView : Form, IConsoleView
    {
        private readonly ConsolePresenter m_presenter;

        public ConsoleView()
        {
            Logger.debug("Initializing Console View.", origin: "ChatMail.ConsoleView");
            InitializeComponent();

            Logger.debug("Registrating EventHandlers.", origin: "ChatMail.ConsoleView");
            
        }

        public ConsoleView(ConsoleDao dao) : this()
        {
            m_presenter = new ConsolePresenter(this, dao);
        }

        public void DisplayDebug(ConsoleViewModel viewModel)
        {
            Logger.debug("Displaying debug messages", origin: "ChatMail.ConsoleView");
            consoleViewListBox.Items.Clear();

            foreach (LogEntry entry in viewModel.LogEntries)
            {
                consoleViewListBox.Items.Add(entry.Display());
            }
        }
    }
}
