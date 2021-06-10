using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Models.Assets
{
    [Table("periodicals")]
    public class Periodical
    {
        [Key]
        public int Id { get; set; }
        [Required] 
        public Guid AssetId { get; set; }
        [Required] 
        public string UniformTitle { get; set; }
        [Required] 
        public string Publisher { get; set; }
        [Required] 
        public string ISSN { get; set; }

        public DateTime DateOfPublication { get; set; }

        public string Description { get; set; }
        public string Language { get; set; } = "eu-us";

        public Asset Asset { get; set; }
    }
}
