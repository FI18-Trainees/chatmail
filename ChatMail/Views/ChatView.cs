using ChatMail.Interfaces;
using ChatMail.Presenter;
using ChatMail.ViewModels;
using ChatMail.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Message = ChatMail.Models.Message;
using System.Threading;
using System.Timers;

namespace ChatMail.Views
{
    /// <summary>
    /// View of the chat GUI
    /// </summary>
    public partial class ChatView : Form, IChatView
    {
        private readonly ChatPresenter m_presenter;

        public delegate void Tick();
        public Tick myTick;
        private readonly Thread myThread;
        System.Timers.Timer timer;

        /// <summary>
        /// Constructor with initialization
        /// </summary>
        public ChatView()
        {
            InitializeComponent();

            sendMessageSubmitButton.Click += new EventHandler(SubmitClick);

            myTick = new Tick(MessageTimer_Tick);

            myThread = new Thread(new ThreadStart(ThreadMethod));
            myThread.Start();
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
        /// Displays given viewModel in the corresponding TextBox
        /// </summary>
        /// <param name="messages"></param>
        public void ShowMessages(ChatViewModel viewModel)
        {
            receivedMessagesTextBox.Clear();

            foreach (Message message in viewModel.Messages)
            {
                receivedMessagesTextBox.Text += message.Content + Environment.NewLine;
            }
        }

        /// <summary>
        /// Adds users to listbox
        /// </summary>
        /// <param name="viewModel">viewModel with the users</param>
        public void ShowUsers(ChatViewModel viewModel)
        {
            sendMessageReceiverListBox.Items.Clear();

            foreach (User user in viewModel.Users)
            {
                sendMessageReceiverListBox.Items.Add(user.Displayname);
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

        public void ShowUsername(string username)
        {
            this.Text = "ChatMail: " + username;
        }

        /// <summary>
        /// reads the entered text in the input text-box
        /// </summary>
        /// <returns></returns>
        public UserInput ReadUserInput()
        {
            List<string> selectedUsers = new List<string>();
            foreach(string username in sendMessageReceiverListBox.SelectedItems)
            {
                selectedUsers.Add(username);
            }

            return new UserInput(sendMessageInputTextBox.Text, selectedUsers);
        }

        /// <summary>
        /// fired when the user clicks the submit button
        /// </summary>
        /// <param name="sender">Object which triggered the event</param>
        /// <param name="e">Arguments of the event</param>
        private void SubmitClick(object sender, EventArgs e)
        {
            if (sendMessageReceiverListBox.SelectedIndex == -1)
            {
                ShowError("Please select a receiver!");
                return;
            }
            m_presenter.SubmitClicked();

        }

        public void MessageTimer_Tick()
        {
            m_presenter.TimerTick();
        }

        private void ChatView_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
        }

        /// <summary>
        /// Method running in another thread handling timer actions
        /// </summary>
        private void ThreadMethod()
        {
            TimerClass timerClass = new TimerClass(this);

            timer = new System.Timers.Timer
            {
                Interval = 5000
            };
            timer.Elapsed += new ElapsedEventHandler(timerClass.Run);
            timer.Start();
        }
    }

    /// <summary>
    /// Class which represents the user input
    /// </summary>
    public class UserInput
    {
        public string Content { get; }
        public List<string> SelectedUsername { get; }


        /// <summary>
        /// Constructor for the user input
        /// </summary>
        /// <param name="content">content of textbox</param>
        /// <param name="selectedUsername">selected receiver</param>
        public UserInput(string content, List<string> selectedUsername)
        {
            Content = content;
            SelectedUsername = selectedUsername;
        }
    }

    /// <summary>
    /// Class for delegate access of timer to update the messages
    /// </summary>
    public class TimerClass
    {
        readonly ChatView m_chatView;

        /// <summary>
        /// Constructor of the TimerClass
        /// </summary>
        /// <param name="chatView"></param>
        public TimerClass(ChatView chatView)
        {
            m_chatView = chatView;
        }

        /// <summary>
        /// Invoking timer tick on chatView
        /// </summary>
        /// <param name="sender">Sender of the event</param>
        /// <param name="e">Parameters of the event</param>
        public void Run(object sender, ElapsedEventArgs e)
        {
            m_chatView.Invoke(m_chatView.myTick);
        }
    }
}
