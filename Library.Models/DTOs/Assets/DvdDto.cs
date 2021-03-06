using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.DTOs.Assets
{
    public class DvdDto
    {
        public int Id { get; set; }
        public string AssetId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public int LengthMinutes { get; set; }
        public string Edition { get; set; }
        public string UPC { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public string AlternativeTitle { get; set; }
        public LibraryAssetDto Asset { get; set; }
    }
}
