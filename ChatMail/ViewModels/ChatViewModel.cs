﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChatMail.Models;
using ChatMail.Logging;

namespace ChatMail.ViewModels
{
    public class ChatViewModel
    {
        /// <summary>
        /// Messages of the viewModel
        /// </summary>
        public List<Message> Messages { get; }

        /// <summary>
        /// Users of the viewModel
        /// </summary>
        public List<User> Users { get; }

        /// <summary>
        /// Constructor of the viewModel
        /// </summary>
        public ChatViewModel(List<Message> messages, List<User> users)
        {
            Logger.debug("Initalizing ChatViewModel with current data.", origin: "ChatMail.ChatViewModel");
            Messages = messages;
            Users = users;
        }
    }
}
