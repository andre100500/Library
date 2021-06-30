using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.DTOs.Assets
{
    public class AudioBookDto
    {
        public int Id { get; set; }

        public string AssetId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ASIN { get; set; }

        public int PublicationYear { get; set; }
        public int LengthMinutes { get; set; }

        public string Version { get; set; }
        public string Publisher { get; set; }
        public int Index { get; set; }
        public string Language { get; set; }
        public string Summary { get; set; }

        public LibraryAssetDto Asset { get; set; }
    }
}
