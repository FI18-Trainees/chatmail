using ChatMail.Interfaces;
using ChatMail.Models;
using ChatMail.ViewModels;
using ChatMail.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            m_loginView = loginView;
            m_loginDao = loginDao;

            Login();
        }

        /// <summary>
        /// Gets all users from dao and creates viewModel which is passed to the view
        /// </summary>
        private void Login()
        {
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
            return new LoginViewModel(users);
        }

        /// <summary>
        /// Gets user input and passes it to dao
        /// Closes the view after transmission
        /// </summary>
        public void Login_Clicked()
        {
            string input = m_loginView.ReadUserInput();
            m_loginDao.Login(input);
            Close();
        }

        /// <summary>
        /// Gets called when form is closed
        /// </summary>
        public void Close_Clicked()
        {
            Close();
        }

        /// <summary>
        /// Closes the view
        /// </summary>
        private void Close()
        {
            m_loginView.CloseView();
        }
    }
}
