using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Models.Tags
{
    [Table("tags")]
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public List<AssetTag> AssetTags { get; set; }
    }
}
