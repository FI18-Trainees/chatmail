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

        public ChatPresenter(ChatView chatView, ChatDao dao)
        {
            m_chatView = chatView;
            m_dao = dao;

            Login();
        }

        private void Login()
        {
            List<Message> messageList = m_dao.GetAllMessages();
            List<User> userList = m_dao.GetUsers();

            ChatViewModel chatViewModel = ResolveViewModelArray(messageList, userList);

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

            ChatViewModel chatViewModel = ResolveViewModelArray(messageList, m_chatViewModel.Users);

            m_chatViewModel = chatViewModel;

            m_chatView.ShowMessages(m_chatViewModel);
        }

        /// <summary>
        /// returns new viewModel with all messages
        /// </summary>
        /// <param name="messageList"></param>
        /// <returns></returns>
        private ChatViewModel ResolveViewModelArray(List<Message> messageList)
        {
            return new ChatViewModel(messageList);
        }

        /// <summary>
        /// returns new viewModel with all messages and users
        /// </summary>
        /// <param name="messageList"></param>
        /// <returns></returns>
        private ChatViewModel ResolveViewModelArray(List<Message> messageList, List<User> userList)
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
            if (userInput.SelectedUsername == string.Empty)
                return;
            
            m_dao.SendMessage(userInput);
            Update();
        }
    }
}
