using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChatMail.Logging;
using ChatMail.Models;
using ChatMail.Interfaces;
using ChatMail.ViewModels;
using ChatMail.Views;

namespace ChatMail.Presenter
{
    class AdminPresenter
    {
        private readonly IAdminView m_adminView;
        private readonly IAdminDao m_adminDao;
        private AdminViewModel m_adminViewModel;

        public AdminPresenter(AdminView adminView, AdminDao dao)
        {
            Logger.debug("Initalizing Admin Presenter.", origin: "ChatMail.AdminPresenter");
            m_adminView = adminView;
            m_adminDao = dao;

            Initialize();
        }

        private void Initialize()
        {
            Logger.debug("Initalizing components", origin: "ChatMail.AdminPresenter");
            
            List<User> users = m_adminDao.GetUsers();

            m_adminViewModel = ResolveViewModel(users);

            m_adminView.ShowUsers(m_adminViewModel);
        }

        private AdminViewModel ResolveViewModel(List<User> users)
        {
            return new AdminViewModel(users);
        }

        public void AddUser_Clicked()
        {

        }
    }
}
