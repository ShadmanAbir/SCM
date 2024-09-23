using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SCM.Model.Items;
using SCM.Model.Requisitions;
using static System.Reflection.Metadata.BlobBuilder;

namespace SCM.Model
{
    public class SCMContext : IdentityDbContext
    {
        public SCMContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Category_tbl> Category_tbl { get; set; }
        public DbSet<ItemBase_tbl> ItemBase_tbl { get; set; }
        public DbSet<ItemMaster_tbl> BorrowdItemMaster_tblBooks { get; set; }
        public DbSet<RequisitionMaster_tbl> RequisitionMaster_tbl { get; set; }
        public DbSet<RequisitionDetail_tbl> RequisitionDetail_tbl { get; set; }
    }
}
