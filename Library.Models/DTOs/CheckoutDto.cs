using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.DTOs
{
    public class CheckoutDto
    {
        [Key]
        public int Id { get; set; }

        public LibraryAssetDto LibraryAsset { get; set; }
        public LibraryCardDto LibraryCard { get; set; }

        public DateTime CheckedOutSince { get; set; }
        public DateTime CheckedOutUntil { get; set; }
    }
}
