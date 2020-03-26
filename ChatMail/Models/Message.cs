using System;
using System.Collections.Generic;
using System.Data;

namespace ChatMail.Models
{
	public class Message
	{

        /// <summary>
        /// Properties
        /// </summary>
        public int MId { get; }
        public string Content { get; }
        public DateTime Timestamp { get; }
        public User Sender { get; }
        public List<User> Receiver { get; }

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
            this.MId = mId;
            this.Content = content;
            this.Timestamp = timestamp;
            this.Sender = sender;
            this.Receiver = receiver;
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
            this.Content = content;
            this.Timestamp = timestamp;
            this.Sender = sender;
            this.Receiver = receiver;
        }

        /// <summary>
        /// Constructor for Message
        /// </summary>
        /// <param name="row">DataRow object containing mId, content, timestamp</param>
        /// <param name="sender">User object of sender</param>
        /// <param name="receiver">List of user object that receive the message</param>
        public Message(DataRow row, User sender, List<User> receiver)
        {
            this.MId = int.Parse(row["mId"].ToString());
            this.Content = row["content"].ToString();
            this.Timestamp = DateTime.Parse(row["timestamp"].ToString());
            this.Sender = sender;
            this.Receiver = receiver;
        }

        /// <summary>
        /// Generates string of message.
        /// </summary>
        /// <returns>String of message.</returns>
        public string Display()
        {
            string time = this.Timestamp.ToString("yyyy.MM.dd HH:mm:ss");
            return "[" + time + "] (" + this.Sender.Displayname + "): " + this.Content;
        }
    }
}
