using System.Collections.Generic;
using System;
using DBConnectorTest;
using ChatMail.Models;

namespace ChatMail
{
	public class ChatController
	{
		private string name;

        private ChatGUI chatGUI;

		private List<User> allUser;

		private DBConnector databaseInstance;

		public void InitializeGUI()
		{

		}
		
		public void SendMessage(Message message)
		{

		}

		public List<Message> ReceiveMessages(int userId)
		{
			return null;
		}

	}

}

