using ChatMail.Interfaces;
using ChatMail.Presenter;
using ChatMail.ViewModels;
using ChatMail.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChatMail.Views
{
    public partial class ChatView : Form, IChatView
    {
        private readonly ChatPresenter m_presenter;

        public ChatView()
        {
            InitializeComponent();

            sendMessageSubmitButton.Click += new EventHandler(SubmitClick);
        }

        public ChatView(ChatDao dao) : this()
        {
            m_presenter = new ChatPresenter(this, dao);
        }

        public void ShowMessages(IEnumerable<ChatViewModel> messages)
        {
            foreach (ChatViewModel viewModel in messages)
            {
                receivedMessagesTextBox.Text += viewModel.Content;
            }
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string ReadUserInput()
        {
            return sendMessageInputTextBox.Text;
        }

        private void SubmitClick(object sender, EventArgs e)
        {
            m_presenter.SubmitClicked();
        }
    }
}
