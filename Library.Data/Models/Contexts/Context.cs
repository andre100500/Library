using Library.Data.Models.Assets;
using Library.Data.Models.Tags;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Models.Contexts
{
    public class Context : DbContext
    {
        public virtual DbSet<AudioBook> AudioBooks { get; set; }
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
