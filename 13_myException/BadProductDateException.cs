using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_myException
{
    class BadProductDateException : ApplicationException
    {
        public DateTime ErrorDate { get; set; }
        public BadProductDateException(string message, DateTime dt)
            :base(message)
        {
            ErrorDate = dt;
        }
        public override string Message => "Error " + base.Message + "\n";
    }
}
