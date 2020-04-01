using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChatMail.Views;
using ChatMail.Models;
using ChatMail.Interfaces;
using ChatMail.ViewModels;
using ChatMail.Logging;

namespace ChatMail.Presenter
{
    /// <summary>
    /// Presenter class which presents 
    /// </summary>
    class ChatPresenter
    {
        private readonly IChatView m_chatView;
        private readonly IChatDao m_chatDao;
        private ChatViewModel m_chatViewModel;
        private string m_currentUserDisplayname;

        public ChatPresenter(ChatView chatView, ChatDao dao)
        {
            Logger.debug("Initalizing Chat Presenter.", origin: "ChatMail.ChatPresenter");
            m_chatView = chatView;
            m_chatDao = dao;

            Login();
            m_chatView.ShowUsername(m_currentUserDisplayname);
        }

        /// <summary>
        /// Handles initialization of the view and viewModel
        /// </summary>
        private void Login()
        {
            Logger.debug("Loggin user in and initializing components.", origin: "ChatMail.ChatPresenter");
            m_currentUserDisplayname = m_chatDao.Login();
            List<Message> messageList = m_chatDao.GetAllMessages();
            List<User> userList = m_chatDao.GetUsers();

            m_chatViewModel = ResolveViewModel(messageList, userList);

            m_chatView.ShowMessages(m_chatViewModel);
            m_chatView.ShowUsers(m_chatViewModel);
        }

        /// <summary>
        /// Fetches new Messages from DAO
        /// Provides list of viewModels with messages
        /// Calls ShowMessages on view
        /// </summary>
        private void Update()
        {
            Logger.debug("Updating presenter and distributing data.", origin: "ChatMail.ChatPresenter");
            List<Message> messageList = m_chatDao.GetAllMessages();

            ChatViewModel chatViewModel = ResolveViewModel(messageList, m_chatViewModel.Users);

            m_chatViewModel = chatViewModel;

            m_chatView.ShowMessages(m_chatViewModel);
        }

        /// <summary>
        /// returns new viewModel with all messages and users
        /// </summary>
        /// <param name="messageList"></param>
        /// <returns></returns>
        private ChatViewModel ResolveViewModel(List<Message> messageList, List<User> userList)
        {
            Logger.debug("Creating new ChatViewModel with current data.", origin: "ChatMail.ChatPresenter");
            return new ChatViewModel(messageList, userList);
        }

        /// <summary>
        /// Checks for valid input
        /// Retreives information for new messages and passes to DAO
        /// </summary>
        public void SubmitClicked()
        {
            Logger.debug("User submitted a message.", origin: "ChatMail.ChatPresenter");
            UserInput userInput = m_chatView.ReadUserInput();
            if (userInput.Content == string.Empty)
                return;
            if (userInput.SelectedUsername.Count() == 0)
                return;
            
            m_chatDao.SendMessage(userInput);
            Update();
        }

        public void Console_Clicked()
        {
            Logger.debug("User clicked Console", origin: "ChatMail.ChatPresenter");
            m_chatDao.Console();
        }

        public void Admin_Clicked()
        {
            Logger.debug("User clicked Admin", origin: "ChatMail.ChatPresenter");
            m_chatDao.Admin();
        }

        public void TimerTick()
        {
            Update();      
        }
    }
}
