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
        private ChatPresenter m_presenter;

        public ChatView()
        {
            InitializeComponent();
        }

        public ChatView(ChatDao dao) : this()
        {
            m_presenter = new ChatPresenter(this, dao);
        }

        public void ShowMessages(IEnumerable<ChatViewModel> messages)
        {
            foreach (ChatViewModel viewModel in messages)
            {
                recievedMessagesTextBox.Text += viewModel.Content;
            }
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void m_submit_Click(object sender, EventArgs e)
        {
            m_presenter.SubmitClicked();
        }
    }
}
