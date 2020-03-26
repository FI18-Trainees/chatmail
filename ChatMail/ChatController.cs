using System.Collections.Generic;
using System;
using DBConnectorTest;
using ChatMail.Models;
using System.Windows.Forms;
using ChatMail.Views;

namespace ChatMail
{
	public class ChatController
	{
		private string name;

		private List<User> allUser;

		private DBConnector databaseInstance;

		public List<Models.Message> ReceiveMessages(int userId)
		{
			throw new NotImplementedException();
		}

        internal void Submit(Models.Message message)
        {
            throw new NotImplementedException();
        }
    }
}

