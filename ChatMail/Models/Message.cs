using System;
using System.Collections.Generic;
using System.Data;

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
        /// Constructor for Message
        /// </summary>
        /// <param name="mId">Message ID</param>
        /// <param name="content">Raw message content</param>
        /// <param name="timestamp">Timestamp of message</param>
        /// <param name="sender">User object of sender</param>
        /// <param name="receiver">List of user object that receive the message</param>
        public Message(int mId, string content, DateTime timestamp, User sender, List<User> receiver)
        {
            this.mId = mId;
            this.content = content;
            this.timestamp = timestamp;
            this.sender = sender;
            this.receiver = receiver;
        }

        /// <summary>
        /// Constructor for Message
        /// </summary>
        /// <param name="content">Raw message content</param>
        /// <param name="timestamp">Timestamp of message</param>
        /// <param name="sender">User object of sender</param>
        /// <param name="receiver">List of user object that receive the message</param>
        public Message(string content, DateTime timestamp, User sender, List<User> receiver)
        {
            this.content = content;
            this.timestamp = timestamp;
            this.sender = sender;
            this.receiver = receiver;
        }

        /// <summary>
        /// Constructor for Message
        /// </summary>
        /// <param name="row">DataRow object containing mId, content, timestamp</param>
        /// <param name="sender">User object of sender</param>
        /// <param name="receiver">List of user object that receive the message</param>
        public Message(DataRow row, User sender, List<User> receiver)
        {
            this.mId = int.Parse(row["mId"].ToString());
            this.content = row["content"].ToString();
            this.timestamp = DateTime.Parse(row["timestamp"].ToString());
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

        /// <summary>
        /// Generates string of message.
        /// </summary>
        /// <returns>String of message.</returns>
        public string display()
        {
            string time = this.timestamp.ToString("yyyy.MM.dd HH:mm:ss");
            return "[" + time + "] (" + this.sender.Displayname + "): " + this.content;
        }
    }
}
