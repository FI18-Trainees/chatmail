namespace System
{
	public class User
	{
		private readonly int uId;

		private readonly string firstname;

		private readonly string lastname;

		private readonly string displayname;


        public User(int uId, string firstname, string lastname, string displayname)
        {
            this.uId = uId;
            this.firstname = firstname;
            this.lastname = lastname;
            this.displayname = displayname;
        }

        public int UId => uId;
        public string Firstname => firstname;
        public string Lastname => lastname;
        public string Displayname => displayname;
    }
}

