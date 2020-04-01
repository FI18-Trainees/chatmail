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
        private readonly AdminPresenter m_presenter;

        private BindingSource bindingSource = new BindingSource();

        public AdminView()
        {
            Logger.debug("Initializing Admin/ View.", origin: "ChatMail.AdminView");
            InitializeComponent();
            adminDataGridView.DataSource = bindingSource;

            Logger.debug("Registrating Event Handlers", origin: "ChatMail.AdminView");
            bindingSource.AddingNew += new AddingNewEventHandler(bindingSource_AddingNew);
            bindingSource.ListChanged += new ListChangedEventHandler(bindingSource_ListChanged);
            bindingSource.AddNew();
            
        }

        public AdminView(AdminDao dao) : this()
        {
            m_presenter = new AdminPresenter(this, dao);
        }

        public void ShowUsers(AdminViewModel adminViewModel)
        {
            foreach (User user in adminViewModel.Users)
            {
                bindingSource.AddNew();
            }
        }

        public string[] ReadUserInput()
        {
            return null; 
        }

        public void AddUser_Clicked(object sender, EventArgs e)
        {
            m_presenter.AddUser_Clicked();
        }

        private void bindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new User();
        }

        private void bindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            // MessageBox.Show(e.ListChangedType.ToString());
        }
    }
}
