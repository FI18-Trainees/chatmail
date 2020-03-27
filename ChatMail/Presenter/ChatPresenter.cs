using ChatMail.Views;
using ChatMail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatMail.Interfaces;
using ChatMail.ViewModels;

namespace ChatMail.Presenter
{
    /// <summary>
    /// Presenter class which presents 
    /// </summary>
    class ChatPresenter
    {
        private readonly IChatView m_chatView;
        private readonly IChatDao m_dao;
        private ChatViewModel m_chatViewModel;
        private string m_currentUserDisplayname;

        public ChatPresenter(ChatView chatView, ChatDao dao)
        {
            m_chatView = chatView;
            m_dao = dao;

            Login();
            m_chatView.ShowUsername(m_currentUserDisplayname);
        }

        /// <summary>
        /// Handles initialization of the view and viewModel
        /// </summary>
        private void Login()
        {
            m_currentUserDisplayname = m_dao.Login();
            List<Message> messageList = m_dao.GetAllMessages();
            List<User> userList = m_dao.GetUsers();

            ChatViewModel chatViewModel = ResolveViewModel(messageList, userList);

            m_chatViewModel = chatViewModel;

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
            List<Message> messageList = m_dao.GetAllMessages();

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
            return new ChatViewModel(messageList, userList);
        }

        /// <summary>
        /// Checks for valid input
        /// Retreives information for new messages and passes to DAO
        /// </summary>
        public void SubmitClicked()
        {
            UserInput userInput = m_chatView.ReadUserInput();
            if (userInput.Content == string.Empty)
                return;
            if (userInput.SelectedUsername.Count() == 0)
                return;
            
            m_dao.SendMessage(userInput);
            Update();
        }

        public void TimerTick()
        {
            Update();      
        }
    }
}
