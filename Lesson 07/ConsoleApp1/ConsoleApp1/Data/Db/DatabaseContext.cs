using ConsoleApp1.Data.Db.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data.Db
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        private DatabaseContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public static DatabaseContext Create()
        {
            return new DatabaseContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("AllProducts");

            // игнорирование конкретного св-ва
            // modelBuilder.Entity<Product>().Ignore(p => p.Name);

            // переопределение первичного ключа
            // modelBuilder.Entity<Product>().HasKey(p => p.Id);

            // сопоставление имен
            // modelBuilder.Entity<Product>().Property(p => p.ProductName).HasColumnName("Name");


            // настройка отношения one-to-many
            modelBuilder.Entity<Category>()
                .HasMany(cat => cat.Products)
                .WithRequired(prod => prod.Category)
                .HasForeignKey(prod => prod.CategoryId)
                .WillCascadeOnDelete(false);


            // игнорирование сущности
            // modelBuilder.Ignore<Product>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
