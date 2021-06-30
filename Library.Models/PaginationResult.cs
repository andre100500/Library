using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class PaginationResult<T>
    {
        public List<T> Results { get; set; }

        public int PerPages { get; set; }
        public int NumberPage { get; set; }
        public int Total { get; set; }
        public int TotalAmount { get; set; }

        public bool HasNextPage { get; set; }
        public bool HasPreviousPage { get; set; }
    }
}
