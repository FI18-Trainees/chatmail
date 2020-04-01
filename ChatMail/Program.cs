using ChatMail.Models;
using ChatMail.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatMail
{
    static class Program
    {
        public static string currentUser;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginDao loginDao = new LoginDao();
            LoginView loginView = new LoginView(loginDao);

            Application.Run(loginView);
        }

        public static void Chat(string selectedUser)
        {
            currentUser = selectedUser;

            ChatDao chatDao = new ChatDao();
            ChatView chatView = new ChatView(chatDao);

            Thread chatThread = new Thread(new ParameterizedThreadStart(ChatView));
            chatThread.Start(chatView);
        }

        public static void Console()
        {
            ConsoleDao consoleDao = new ConsoleDao();
            ConsoleView consoleView = new ConsoleView(consoleDao);

            Thread consoleThread = new Thread(ConsoleView);
            consoleThread.Start(consoleView);
        }

        public static void Admin()
        {

        }

        private static void ChatView(object obj)
        {
            Application.Run((ChatView) obj);
        }

        private static void ConsoleView(object obj)
        {
            Application.Run((ConsoleView) obj);
        }
        private static void AdminView(object obj)
        {

        }
    }
}
