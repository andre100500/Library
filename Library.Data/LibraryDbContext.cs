using Library.Data.Models;
using Library.Data.Models.Assets;
using Library.Data.Models.Contexts;
using Library.Data.Models.Tags;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Library.Data
{
    public class LibraryDbContext : Context
    {
        public DbContextOptions _options { get; set; }

        public LibraryDbContext(DbContextOptions options)
        {
            _options = options;
        }

        protected override void OnModelCreating (ModelBuilder model)
        {
            SeedInitialAssetStatuses(model);
            LinkAssets(model);
            LinkAssetTags(model);
        }

        private static void LinkAssetTags(ModelBuilder model)
        {
            model.Entity<AssetTag>()
                .HasKey(at => new
            {
                at.AssetId , 
                at.TagId
            });

            model.Entity<AssetTag>()
                .HasOne(a => a.Asset)
                .WithMany(ats => ats.AssetTags)
                .HasForeignKey(aid => aid.AssetId);

            model.Entity<AssetTag>()
                .HasOne(a => a.Tag)
                .WithMany(ats => ats.AssetTags)
                .HasForeignKey(tid => tid.TagId);
        }

        private static void LinkAssets(ModelBuilder model)
        {
            model.Entity<Book>().HasOne(book => book.Asset);
            model.Entity<AudioBook>().HasOne(ab => ab.Asset);
            model.Entity<AudioCd>().HasOne(ac => ac.Asset);
            model.Entity<DVD>().HasOne(dvd => dvd.Asset);
            model.Entity<Periodical>().HasOne(pd => pd.Asset);
        }

        private static void SeedInitialAssetStatuses(ModelBuilder model)
        {
            var defStatus = new List<AvailabilityStatus>
            {
                new()
                {
                    Id = 1,
                    Name = "Status Lost",
                    Description = "The item is lost."
                },
                new() 
                {
                     Id = 2,
                     Name = "Status Good",
                     Description = "The item is in good condition."
                },
                 new() 
                 {
                     Id = 3,
                     Name = "Status Unknown",
                     Description = "The item is in unknown whereabouts and condition."
                 },
                 new() 
                 {
                     Id = 4,
                     Name = "Status Destroyed",
                     Description = "The item has been destroyed."
                 },
            };
            model.Entity<AvailabilityStatus>().HasData(defStatus);
        }
    }
}
