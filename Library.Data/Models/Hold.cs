using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Models
{
    [Table("holds")]
    public class Hold
    {
        [Key]
        public int Id { get; set; }

        public DateTime HoldPlaced { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual LibraryCard LibraryCard { get; set; }
    }
}
