using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Models.Tags
{
    [Table("asset_tags")]
    public class AssetTag
    {
        [Key]
        public Guid AssetId { get; set; }
        public int TagId { get; set; }

        public Tag Tag { get; set; }
        public Asset Asset { get; set; }
    }
}
