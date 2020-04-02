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

        /// <summary>
        /// Constructor of the presenter
        /// </summary>
        /// <param name="adminView">View of the presenter</param>
        /// <param name="adminDao">Data Access Object of the presenter</param>
        public AdminPresenter(AdminView adminView, AdminDao adminDao)
        {
            Logger.debug("Initalizing Admin Presenter.", origin: "ChatMail.AdminPresenter");
            m_adminView = adminView;
            m_adminDao = adminDao;

            Initialize();
        }

        /// <summary>
        /// Gets all users from dao and creates viewModel which is passed to the view
        /// </summary>
        private void Initialize()
        {
            Logger.debug("Initalizing components", origin: "ChatMail.AdminPresenter");
            
            List<User> users = m_adminDao.GetUsers();

            m_adminViewModel = ResolveViewModel(users);

            m_adminView.ShowUsers(m_adminViewModel);
        }

        /// <summary>
        /// Returns viewModel instance with users inside
        /// </summary>
        /// <param name="users">list of all users</param>
        /// <returns>viewModel with users inside</returns>
        private AdminViewModel ResolveViewModel(List<User> users)
        {
            return new AdminViewModel(users);
        }

        /// <summary>
        /// Gets user input and passes it to dao
        /// Updates viewModel and view
        /// </summary>
        public void AddUser_Clicked()
        {
            string[] result = m_adminView.ReadUserInput();
            if (result != null)
            {
                m_adminDao.AddUser(result [0], result[1], result[2]);
                Initialize();
            }
        }
    }
}
