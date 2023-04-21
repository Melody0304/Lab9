using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace MyApplication
{
    public class MyContext : DbContext
    {
        public DbSet<MyEntity> MyEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MyEntity>().HasKey(x => x.Id);
        }
    }

    public class MyEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
