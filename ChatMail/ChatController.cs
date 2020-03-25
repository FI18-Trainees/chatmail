using System.Collections.Generic;
using System;
using ChatMail.Database;
using ChatMail.Models;

namespace ChatMail
{
	public class ChatController
	{
		private string name;

        private ChatGUI chatGUI;

		private List<User> allUser;

		private DBConnector databaseInstance;

		public void sendMessage(Message message)
		{

		}

		public List<Message> receiveMessages(int userId)
		{
			return null;
		}

	}

}

