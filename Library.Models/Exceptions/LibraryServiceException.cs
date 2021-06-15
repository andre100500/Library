using Library.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.Exceptions
{
    public class LibraryServiceException : Exception
    {
        public Reason _reason { get; set; }

        public LibraryServiceException(Reason reason)
        {
            _reason = reason;
        }
    }
}
