using MySql.Data.MySqlClient;
using System.Data;

namespace ChatMail.Models
{
	public class User
	{
		private readonly int uId;

		private readonly string firstname;

		private readonly string lastname;

		private readonly string displayname;

        /// <summary>
        /// Constructor of the user
        /// </summary>
        /// <param name="uId">Id of user</param>
        /// <param name="firstname">first name of user</param>
        /// <param name="lastname">last name of user</param>
        /// <param name="displayname">displayname of user used in chat</param>
        public User(int uId, string firstname, string lastname, string displayname)
        {
            this.uId = uId;
            this.firstname = firstname;
            this.lastname = lastname;
            this.displayname = displayname;
        }

        public User(string firstname, string lastname, string displayname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.displayname = displayname;
        }

        public User(DataRow row)
        {
            this.uId = int.Parse(row["uId"].ToString());
            this.firstname = row["firstname"].ToString();
            this.lastname = row["lastname"].ToString();
            this.displayname = row["displayname"].ToString();
        }

        /// <summary>
        /// Getters for properties
        /// </summary>
        public int UId => uId;
        public string Firstname => firstname;
        public string Lastname => lastname;
        public string Displayname => displayname;
    }
}

