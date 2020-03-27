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
        private readonly LoginPresenter m_Presenter;
        public LoginView()
        {
            InitializeComponent();

            userSelectLoginButton.Click += new EventHandler(LoginClick);
        }

        public LoginView(LoginDao dao) : this()
        {
            m_Presenter = new LoginPresenter(this, dao);
        }

        public void ShowUsers(LoginViewModel loginViewModel)
        {
            foreach (User user in loginViewModel.Users)
            {
                // Add user to ComboBox
                userSelectComboBox.Items.Add(user.Displayname);
            }
        }

        public void LoginClick(object sender, EventArgs e)
        {
            if (userSelectComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a receiver!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            m_Presenter.Login_Clicked();
        }

        public string ReadUserInput()
        {
            // Get selected value in ComboBox
            return userSelectComboBox.Text;
        }

        public void CloseView()
        {
            this.Close();
        }
    }
}
