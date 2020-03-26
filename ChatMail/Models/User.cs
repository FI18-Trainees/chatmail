using MySql.Data.MySqlClient;
using System.Data;

namespace ChatMail.Models
{
	public class User
	{

        /// <summary>
        /// Properties
        /// </summary>
        public int UId { get; }
        public string Firstname { get; }
        public string Lastname { get; }
        public string Displayname { get; }

        /// <summary>
        /// Constructor of User
        /// </summary>
        /// <param name="uId">Id of user</param>
        /// <param name="firstname">first name of user</param>
        /// <param name="lastname">last name of user</param>
        /// <param name="displayname">displayname of user used in chat</param>
        public User(int uId, string firstname, string lastname, string displayname)
        {
            this.UId = uId;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Displayname = displayname;
        }

        /// <summary>
        /// Constructor of User
        /// </summary>
        /// <param name="firstname">first name of user</param>
        /// <param name="lastname">last name of user</param>
        /// <param name="displayname">displayname of user used in chat</param>
        public User(string firstname, string lastname, string displayname)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Displayname = displayname;
        }

        /// <summary>
        /// Constructor of User
        /// </summary>
        /// <param name="row">Data row containing uId, firstname, lastname, displayname</param>
        public User(DataRow row)
        {
            this.UId = int.Parse(row["uId"].ToString());
            this.Firstname = row["firstname"].ToString();
            this.Lastname = row["lastname"].ToString();
            this.Displayname = row["displayname"].ToString();
        }

        /// <summary>
        /// Constructor of User
        /// </summary>
        public User() { }
    }
}

