using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models.Patron;

namespace Library.Models.Patron
{
    public class PatronIndexModel
    {
        public PaginationResult<Patron> PageOfPatrons { get; set; }
    }
}
