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

        public LoginPresenter(LoginView loginView, LoginDao loginDao)
        {
            m_loginView = loginView;
            m_loginDao = loginDao;

            Login();
        }

        private void Login()
        {
            List<User> users = m_loginDao.GetUsers();

            LoginViewModel loginViewModel = ResolveViewModel(users);

            m_loginView.ShowUsers(loginViewModel);
        }

        private LoginViewModel ResolveViewModel(List<User> users)
        {
            return new LoginViewModel(users);
        }

        public void Login_Clicked()
        {
            string input = m_loginView.ReadUserInput();
            m_loginDao.Login(input);
            Close();
        }

        public void Close_Clicked()
        {
            Close();
        }

        private void Close()
        {
            m_loginView.CloseView();
        }
    }
}
