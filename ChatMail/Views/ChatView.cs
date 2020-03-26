using ChatMail.Interfaces;
using ChatMail.Presenter;
using ChatMail.ViewModels;
using ChatMail.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChatMail.Views
{
    /// <summary>
    /// View of the chat GUI
    /// </summary>
    public partial class ChatView : Form, IChatView
    {
        private readonly ChatPresenter m_presenter;


        /// <summary>
        /// Constructor with initialization
        /// </summary>
        public ChatView()
        {
            InitializeComponent();

            sendMessageSubmitButton.Click += new EventHandler(SubmitClick);
        }

        /// <summary>
        /// Constructor with Chat Data Access Object for MVPVM handling
        /// </summary>
        /// <param name="dao"></param>
        public ChatView(ChatDao dao) : this()
        {
            m_presenter = new ChatPresenter(this, dao);
        }

        /// <summary>
        /// Displays given messages in the corresponding TextBox
        /// </summary>
        /// <param name="messages"></param>
        public void ShowMessages(IEnumerable<ChatViewModel> messages)
        {
            receivedMessagesTextBox.Clear();

            foreach (ChatViewModel viewModel in messages)
            {
                receivedMessagesTextBox.Text += viewModel.Content + Environment.NewLine;
            }
        }

        /// <summary>
        /// Displays an error message in a message box
        /// </summary>
        /// <param name="message"></param>
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// reads the entered text in the input text-box
        /// </summary>
        /// <returns></returns>
        public string ReadUserInput()
        {
            return sendMessageInputTextBox.Text;
        }

        /// <summary>
        /// fired when the user clicks the submit button
        /// </summary>
        /// <param name="sender">Object which triggered the event</param>
        /// <param name="e">Arguments of the event</param>
        private void SubmitClick(object sender, EventArgs e)
        {
            m_presenter.SubmitClicked();
        }
    }
}
