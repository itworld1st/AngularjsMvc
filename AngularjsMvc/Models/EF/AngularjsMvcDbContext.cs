using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AngularjsMvc.Models.EF
{
    public class AngularjsMvcDbContext : DbContext
    {
        public AngularjsMvcDbContext() : base("name = AngularjsMvcDbContext")
        {
        }

        // setting EF convention
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // use singular table name
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
    }
}