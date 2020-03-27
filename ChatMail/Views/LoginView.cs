using ChatMail.Interfaces;
using ChatMail.Models;
using ChatMail.Presenter;
using ChatMail.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            InitializeComponent();

            userSelectLoginButton.Click += new EventHandler(LoginClick);
        }

        /// <summary>
        /// Constructor with Data Access Object
        /// </summary>
        /// <param name="dao">Data Access Object of the presenter</param>
        public LoginView(LoginDao dao) : this()
        {
            m_Presenter = new LoginPresenter(this, dao);
        }

        /// <summary>
        /// Adds users to ComboBox
        /// </summary>
        /// <param name="loginViewModel"></param>
        public void ShowUsers(LoginViewModel loginViewModel)
        {
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
            // Get selected value in ComboBox
            return userSelectComboBox.Text;
        }

        /// <summary>
        /// Closes the view
        /// </summary>
        public void CloseView()
        {
            this.Close();
        }
    }
}
