using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMail.Exceptions
{
    [Serializable]
    public class DatabaseConnectionError : Exception
    {
        public DatabaseConnectionError()
        { }

        public DatabaseConnectionError(string message)
            : base(message)
        { }

        public DatabaseConnectionError(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
