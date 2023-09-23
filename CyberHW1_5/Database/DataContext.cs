using ShopMVP.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ShopMVP.Database
{
    internal class DataContext : DbContext
    {
        public DbSet<Error> errors { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<KeyWord> keyWords { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<KeyParams> keyParams { get; set; }

        public DataContext()
        {
            if (Database.CanConnect())
            {
                //this.Database.EnsureDeleted();
                this.Database.EnsureCreated();
            }
        }
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
               .HasIndex(u => u.Number)
               .IsUnique();
            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .HasDefaultValue("00000000");
            modelBuilder.Entity<User>()
                .Property(u => u.Phone)
                .HasDefaultValue("000000000000");
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Login)
                .IsUnique();

            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .HasDefaultValue("Undefined");
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasDefaultValue(0);
            modelBuilder.Entity<Product>()
                .HasIndex(p => p.Number)
                .IsUnique();

            modelBuilder.Entity<KeyWord>()
                .Property(w => w.Count)
                .HasDefaultValue(0);
            modelBuilder.Entity<KeyWord>()
                .HasIndex(w => w.Word)
                .IsUnique();

            modelBuilder.Entity<Category>()
                .HasIndex(c => c.Name)
                .IsUnique();
            modelBuilder.Entity<Category>()
               .HasIndex(c => c.Number)
               .IsUnique();

            modelBuilder.Entity<Cart>()
                .Property(c => c.CreatedDate) 
                .HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<Error>()
                .Property(e => e.ErrorId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Error>()
                .HasIndex(e => e.ErrorId)
                .IsUnique();
            modelBuilder.Entity<Error>()
                .Property(e => e.Message)
                .HasDefaultValue("Undefined message");
            modelBuilder.Entity<Error>()
                .Property(e => e.Request)
                .HasDefaultValue("Undefined request");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder();
                builder.SetBasePath("E:\\Programming\\Csh_Education\\Entity_Framework_Core\\Homework\\CyberHW1\\ShopMVP\\Database\\");
                builder.AddJsonFile("dataconfig.json");
                var config = builder.Build();

                optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"),
                    options => options.EnableRetryOnFailure());
            }
        }
    }
}
