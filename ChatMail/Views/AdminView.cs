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
    public partial class AdminView : Form, IAdminView
    {
        /// <summary>
        /// Presenter of the view
        /// </summary>
        private readonly AdminPresenter m_presenter;

        /// <summary>
        /// Binding Source for the views DataGridView
        /// </summary>
        private readonly BindingSource bindingSource = new BindingSource();

        /// <summary>
        /// Constructor which initializes the view and sets EventHandlers
        /// </summary>
        public AdminView()
        {
            Logger.debug("Initializing Admin View.", origin: "ChatMail.AdminView");
            InitializeComponent();
            adminDataGridView.DataSource = bindingSource;

            Logger.debug("Registrating Event Handlers.", origin: "ChatMail.AdminView");
            bindingSource.AddingNew += new AddingNewEventHandler(BindingSource_AddingNew);
            adminAddUserButton.Click += new EventHandler(AddUser_Clicked);
            
        }

        /// <summary>
        /// Constructor with Data Access Object
        /// </summary>
        /// <param name="dao">Data Access Object of the presenter</param>
        public AdminView(AdminDao dao) : this()
        {
            m_presenter = new AdminPresenter(this, dao);
        }

        public void ShowUsers(AdminViewModel adminViewModel)
        {
            Logger.debug("Showing users.", origin: "ChatMail.AdminView");
            foreach (User user in adminViewModel.Users)
            {
                // bindingSource.AddNew();
                bindingSource.Add(user);
            }
        }

        /// <summary>
        /// Reads user input for adding new user
        /// </summary>
        /// <returns>Returns string array with values of the form elements</returns>
        public string[] ReadUserInput()
        {
            Logger.debug("Reading user input.", origin: "ChatMail.AdminView");
            string displayname = adminDisplaynameTextBox.Text;
            string firstname = adminFirstnameTextBox.Text;
            string lastname = adminLastnameTextBox.Text;

            if (displayname == String.Empty || firstname == String.Empty || lastname == String.Empty)
            {
                MessageBox.Show("Please enter valid values!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            } else
            {
                return new string[] { firstname, lastname, displayname};
            }
            
        }

        /// <summary>
        /// Adds user to user list
        /// </summary>
        /// <param name="sender">Object which triggered the event</param>
        /// <param name="e">Parameters of the Event</param>
        public void AddUser_Clicked(object sender, EventArgs e)
        {
            Logger.debug("User clicked Add User Button.", origin: "ChatMail.AdminView");
            m_presenter.AddUser_Clicked();
        }

        /// <summary>
        /// Gets called when user is added to the DataGridView
        /// </summary>
        /// <param name="sender">Object which triggered the event</param>
        /// <param name="e">Parameters of the Event</param>
        private void BindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            Logger.debug("Adding user to data source.", origin: "ChatMail.AdminView");
            e.NewObject = new User();
        }
    }
}
