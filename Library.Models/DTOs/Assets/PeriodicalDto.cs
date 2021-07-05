using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.DTOs.Assets
{
    public class PeriodicalDto
    {
        public int Id { get; set; }
        public string AssetId { get; set; }
        public string UniformTitle { get; set; }
        public string Publisher { get; set; }
        public string ISSN { get; set; }
        public DateTime DateOfPublication { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public LibraryAssetDto Asset { get; set; }
    }
}
