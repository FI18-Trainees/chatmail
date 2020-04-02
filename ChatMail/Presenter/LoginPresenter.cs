using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChatMail.Interfaces;
using ChatMail.Models;
using ChatMail.ViewModels;
using ChatMail.Views;
using ChatMail.Logging;

namespace ChatMail.Presenter
{
    class LoginPresenter
    {
        private readonly ILoginView m_loginView;
        private readonly ILoginDao m_loginDao;

        /// <summary>
        /// Constructor of the presenter
        /// </summary>
        /// <param name="loginView">View of the presenter</param>
        /// <param name="loginDao">Data Access Object of the presenter</param>
        public LoginPresenter(LoginView loginView, LoginDao loginDao)
        {
            Logger.debug("Initializing Login Presenter", origin: "ChatMail.LoginPresenter");
            m_loginView = loginView;
            m_loginDao = loginDao;

            Login();
        }

        /// <summary>
        /// Gets all users from dao and creates viewModel which is passed to the view
        /// </summary>
        public void Login()
        {
            Logger.debug("Logging user in and initalizing components", origin: "ChatMail.LoginPresenter");
            List<User> users = m_loginDao.GetUsers();

            LoginViewModel loginViewModel = ResolveViewModel(users);

            m_loginView.ShowUsers(loginViewModel);
        }

        /// <summary>
        /// Returns viewModel instance with users inside
        /// </summary>
        /// <param name="users">list of all users</param>
        /// <returns>viewModel with users inside</returns>
        private LoginViewModel ResolveViewModel(List<User> users)
        {
            Logger.debug("Creating new LoginViewModel with current data.", origin: "ChatMail.LoginPresenter");
            return new LoginViewModel(users);
        }

        /// <summary>
        /// Gets user input and passes it to dao
        /// Closes the view after transmission
        /// </summary>
        public void Login_Clicked()
        {
            Logger.debug("User clicked Login", origin: "ChatMail.ChatPresenter");
            string input = m_loginView.ReadUserInput();
            m_loginDao.Login(input);
            Close();
        }

        /// <summary>
        /// User clicked on Console menu item
        /// </summary>
        public void Console_Clicked()
        {
            Logger.debug("User clicked Console", origin: "ChatMail.ChatPresenter");
            m_loginDao.Console();
        }

        /// <summary>
        /// User clicked on the admin menu item
        /// </summary>
        public void Admin_Clicked()
        {
            Logger.debug("User clicked Admin", origin: "ChatMail.ChatPresenter");
            m_loginDao.Admin();
        }

        /// <summary>
        /// Gets called when form is closed
        /// </summary>
        public void Close_Clicked()
        {
            Logger.debug("User clicked close", origin: "ChatMail.ChatPresenter");
            Close();
        }

        /// <summary>
        /// Closes the view
        /// </summary>
        private void Close()
        {
            Logger.debug("Call View Close", origin: "ChatMail.ChatPresenter");
            m_loginView.CloseView(null, null);
        }
    }
}
