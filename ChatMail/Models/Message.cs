using System;
using System.Collections.Generic;

namespace ChatMail.Models
{
	public class Message
	{
		private readonly int mId;

		private readonly string content;

		private readonly DateTime timestamp;

		private readonly User sender;

		private readonly List<User> receiver;

        /// <summary>
        /// Constructor for the message
        /// </summary>
        /// <param name="mId">Id of message</param>
        /// <param name="content">Content of message</param>
        /// <param name="timestamp">Timestamp of message</param>
        /// <param name="sender">User which sent the message</param>
        /// <param name="receiver">Users which recieves the message</param>
        public Message(int mId, string content, DateTime timestamp, User sender, List<User> receiver)
        {
            this.mId = mId;
            this.content = content;
            this.timestamp = timestamp;
            this.sender = sender;
            this.receiver = receiver;
        }

		/// <summary>
        /// Getters for properties
        /// </summary>
        public int MId => mId;
        public string Content => content;
        public DateTime Timestamp => timestamp;
        public User Sender => sender;
        public List<User> Receiver => receiver;
    }



}

