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
    class ChatPresenter
    {
        private readonly IChatView m_chatView;
        private readonly IChatDao m_dao;
        private IEnumerable<ChatViewModel> m_chatViewModelList;

        public ChatPresenter(ChatView chatView, ChatDao dao)
        {
            m_chatView = chatView;
            m_dao = dao;

            Update();
        }

        private void Update()
        {
            List<Message> messageList = m_dao.GetAllMessages();

            IEnumerable<ChatViewModel> chatViewModelList = ResolveViewModelArray(messageList);

            m_chatViewModelList = chatViewModelList;

            m_chatView.ShowMessages(m_chatViewModelList);
        }

        private IEnumerable<ChatViewModel> ResolveViewModelArray(IEnumerable<Message> messageList)
        {
            foreach (Message message in messageList)
            {
                yield return new ChatViewModel(message);
            }
        }

        public void SubmitClicked()
        {
            string messageContent = m_chatView.ReadUserInput();
            if (messageContent  != string.Empty)
            {
                m_dao.SendMessage(messageContent, 0);
                Update();
            } else
            {
                m_chatView.ShowError("Enter a valid message!");
            }
            
            
        }
    }
}
