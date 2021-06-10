using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Models.Tags
{
    [Table("dvds")]
    public class DVD
    {
        [Key] 
        public int Id { get; set; }
        [Required] 
        public Guid AssetId { get; set; }
        [Required] 
        public string Title { get; set; }
        [Required] 
        public int Year { get; set; }
        [Required] 
        public string Director { get; set; }
        [Required] 
        public int LengthMinutes { get; set; }

        public string Edition { get; set; }
        public string UPC { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public string AlternativeTitle { get; set; }

        public Asset Asset { get; set; }
    }
}
