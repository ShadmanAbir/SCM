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

        public DbSet<Category> Category { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<RequisitionMaster> RequisitionMaster { get; set; }
        public DbSet<RequisitionDetail> RequisitionDetail { get; set; }
    }
}
