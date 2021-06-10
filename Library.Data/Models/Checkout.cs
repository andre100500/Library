using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Data.Models
{
    [Table("checkouts")]
    public class Checkout
    {
        [Key]
        public int Id { get; set; }
        [Required] 
        public Asset Asset { get; set; }

        public DateTime CheckedOutSince { get; set; }
        public DateTime CheckedOutUntil { get; set; }

        public LibraryCard LibraryCard { get; set; }    
    }
}