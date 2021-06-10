using Library.Data.Models.Tags;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Models
{
    [Table("assets")]
    public class Asset
    {
        [Key]
        public Guid Id { get; set; }

        public decimal Cost { get; set; }

        [Url]
        public string ImageUrl { get; set; }

        //TODO: create lb Locatrion at file Models
        public LibraryBranch Location { get; set; }
        public List<AssetTag> AssetTags { get; set; }
    }
}
