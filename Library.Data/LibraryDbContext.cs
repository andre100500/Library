using Library.Data.Models;
using Library.Data.Models.Tags;
using Microsoft.EntityFrameworkCore;
using System;

namespace Library.Data
{
    public class LibraryDbContext : DbContext
    {
        public DbContextOptions _options { get; set; }

        public LibraryDbContext(DbContextOptions options)
        {
            _options = options;
        }

        public virtual DbSet<AudioBook> AudiBooks { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BranchHours> BranchHours { get; set; }
        public virtual DbSet<CheckoutHistory> CheckoutHistories { get; set; }
        public virtual DbSet<Checkout> Checkouts { get; set; }
        public virtual DbSet<AudioCd> AudioCds { get; set; }
        public virtual DbSet<DVD> Dvds { get; set; }
        public virtual DbSet<Hold> Holds { get; set; }
        public virtual DbSet<Asset> LibraryAssets { get; set; }
        public virtual DbSet<LibraryBranch> LibraryBranches { get; set; }
        public virtual DbSet<LibraryCard> LibraryCards { get; set; }
        public virtual DbSet<Patron> Patrons { get; set; }
        public virtual DbSet<Periodical> Periodicals { get; set; }
        public virtual DbSet<AvailabilityStatus> Statuses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
    }
}
