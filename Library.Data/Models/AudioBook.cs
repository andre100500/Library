using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Models
{
    [Table("audio_books")]
    public class AudioBook
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid AssetId { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ASIN { get; set; }

        public int PublicationYear { get; set; }
        public int LengthMinutes { get; set; }
        public string Edition { get; set; }
        public string Publisher { get; set; }
        public string DeweyIndex { get; set; }
        public string Language { get; set; }
        public string Summary { get; set; }
        public Asset Asset { get; set; }
    }
}
