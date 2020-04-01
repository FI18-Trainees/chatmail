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
using ChatMail.Models;
using ChatMail.Presenter;
using ChatMail.ViewModels;
using ChatMail.Logging;


namespace ChatMail.Views
{
    public partial class LoginView : Form, ILoginView
    {
        /// <summary>
        /// Presenter of the view
        /// </summary>
        private readonly LoginPresenter m_Presenter;

        /// <summary>
        /// Constructor which initializes the view and sets EventHandlers
        /// </summary>
        public LoginView()
        {
            Logger.debug("Initializing Login View.", origin: "ChatMail.LoginView");
            InitializeComponent();

            userSelectLoginButton.Click += new EventHandler(LoginClick);
            loginConsoleMenuItem.Click += new EventHandler(OpenConsoleView);
            loginAdminMenuItem.Click += new EventHandler(OpenAdminView);
            loginCloseMenuItem.Click += new EventHandler(CloseView);
        }

        /// <summary>
        /// Constructor with Data Access Object
        /// </summary>
        /// <param name="dao">Data Access Object of the presenter</param>
        public LoginView(LoginDao dao) : this()
        {
            Logger.debug("Initializing Login Presenter.", origin: "ChatMail.LoginView");
            m_Presenter = new LoginPresenter(this, dao);
        }

        /// <summary>
        /// Adds users to ComboBox
        /// </summary>
        /// <param name="loginViewModel"></param>
        public void ShowUsers(LoginViewModel loginViewModel)
        {
            Logger.debug("Displaying users.", origin: "ChatMail.LoginView");
            foreach (User user in loginViewModel.Users)
            {
                // Add user to ComboBox
                userSelectComboBox.Items.Add(user.Displayname);
            }
        }

        /// <summary>
        /// Login button is clicked
        /// Checks if username was selected
        /// </summary>
        /// <param name="sender">Object which triggered the event</param>
        /// <param name="e">Parameters for the event</param>
        public void LoginClick(object sender, EventArgs e)
        {
            Logger.debug("User clicked Login.", origin: "ChatMail.LoginView");
            if (userSelectComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a receiver!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            m_Presenter.Login_Clicked();
        }

        /// <summary>
        /// Gets selected username
        /// </summary>
        /// <returns>selected username</returns>
        public string ReadUserInput()
        {
            Logger.debug("Reading user input.", origin: "ChatMail.LoginView");
            // Get selected value in ComboBox
            return userSelectComboBox.Text;
        }

        /// <summary>
        /// Closes the view
        /// </summary>
        public void CloseView(object sender, EventArgs e)
        {
            Logger.debug("Close View.", origin: "ChatMail.LoginView");
            Close();
        }

        public void OpenConsoleView(object sender, EventArgs e)
        {
            Logger.debug("Opening Console View.", origin: "ChatMail.LoginView");
            m_Presenter.Console_Clicked();
        }

        public void OpenAdminView(object sender, EventArgs e)
        {
            Logger.debug("Opening Admin View.", origin: "ChatMail.LoginView");
            m_Presenter.Admin_Clicked();
        }
    }
}
