using ChatMail.Models;
using ChatMail.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatMail
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ChatDao dao = new ChatDao();
            ChatView view = new ChatView(dao);

            Application.Run(view);
        }
    }
}
