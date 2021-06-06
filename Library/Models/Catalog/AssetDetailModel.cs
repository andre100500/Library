using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models.CheckoutModels;

namespace Library.Models.Catalog
{
    public class AssetDetailModel
    {
        public int AssetId { get; set; }
        public string Titel { get; set; }
        public string AuthorOrDirector { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Isbn { get; set; }
        public string Dewey { get; set; }
        public decimal Cost { get; set; }
        public string CurrentLocation { get; set; }
        public string ImageUrl { get; set; }
        public string PatronName { get; set; }

        public IEnumerable<AssetHoldModel> CurrentHolds { get; set; }

        public IEnumerable<CheckoutModel> CheckoutHistory { get; set; }
    }
}
