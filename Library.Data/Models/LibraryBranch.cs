using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Models
{
    [Table("library_branchs")]
    public class LibraryBranch
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Telephone { get; set; }
        [Url]
        public string ImageUrl { get; set; }

        public DateTime CreateOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public DateTime OpenDate { get; set; }

        public string Description { get; set; }

        public virtual IEnumerable<Asset> LibraryAssets { get; set; }
        public virtual IEnumerable<Patron> Patrons { get; set; }
    }
}
