using Microsoft.EntityFrameworkCore;
using Store.API.Domain.Models;

namespace Store.API.Persistence.Contexts
{
    // DbContext, a class EF Core uses to map your models to database tables.
    public class AppDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // OnModelCreating(ModelBuilder builder) se llama cuando el modelo para un contexto derivado se ha inicializado, pero antes de que el modelo se haya bloqueado y utilizado para inicializar el contexto. La implementación predeterminada de este método no hace nada, pero se puede anular en una clase derivada de modo que el modelo se pueda configurar aún más antes de que se bloquee.

        // Crearemos conjuntos (DbSets) que le asignaremos a los modelos tablas de base de datos.

        // Además, deberemos asignar las propiedades a las columnas de las tablas.

        // Este método se llama cuando el modelo para un contexto derivado se ha inicializado, pero antes de que el modelo se haya bloqueado y utilizado para inicializar el contexto. La implementación predeterminada de este método no hace nada, pero se puede anular en una clase derivada de modo que el modelo se pueda configurar aún más antes de que se bloquee.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Fluent API - Code First
            modelBuilder.Entity<Brand>().ToTable("Brands");
            modelBuilder.Entity<Brand>().HasKey(brand => brand.BrandId);
            modelBuilder.Entity<Brand>().Property(brand => brand.BrandId).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Brand>().Property(brand => brand.Name).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Brand>().Property(brand => brand.Description).IsRequired().HasColumnType("TEXT");

            modelBuilder.Entity<Brand>().HasData
            (
                new Brand 
                { 
                    BrandId = 100, 
                    Name = "Nike", 
                    Description = "Es una empresa multinacional estadounidense dedicada al diseño, desarrollo, fabricación y comercialización de equipamiento deportivo: balones, calzado, ropa, equipo, accesorios y otros artículos deportivos." 
                },
                new Brand
                {
                    BrandId = 101,
                    Name = "Adidas",
                    Description = "Es una compañía multinacional alemana fundada en 1949 dedicada a la fabricación de equipamiento deportivo y productos de moda (bolsos, camisas, relojes, anteojos, etc.)."
                }
            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=store_api_db;Username=postgres;Password=andromeda");
        }
    }
}