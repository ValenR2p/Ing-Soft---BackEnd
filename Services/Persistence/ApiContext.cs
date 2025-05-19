using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Clients { get; set; }
        public DbSet<Cobranza> Receipts { get; set; }
        public DbSet<DetalleFactura> FactureDetail { get; set; }
        public DbSet<DetalleOrden> OrderDetail { get; set; }
        public DbSet<Factura> Factures { get; set; }
        public DbSet<FormaCobranza> PurchaseMethods { get; set; }
        public DbSet<OrdenDeCompra> Orders { get; set; }
        public DbSet<Producto> Products { get; set; }
        public DbSet<Proveedor> Providers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Clients");
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Cobranza>(entity =>
            {
                entity.ToTable("Receipts");
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Id).ValueGeneratedOnAdd();

                entity.HasOne(t => t.Facture)
                      .WithMany()
                      .HasForeignKey(t => t.FactureId);

                entity.HasOne(t => t.Method)
                      .WithMany()
                      .HasForeignKey(t => t.PaymentMethod)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DetalleFactura>(entity =>
            {
                entity.ToTable("FactureDetail");
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Id).ValueGeneratedOnAdd();

                entity.HasOne(t => t.Facture)
                      .WithMany()
                      .HasForeignKey(t => t.FactureId);

                entity.HasOne(t => t.Product)
                      .WithMany()
                      .HasForeignKey(t => t.ProductId);
            });

            modelBuilder.Entity<DetalleOrden>(entity =>
            {
                entity.ToTable("OrderDetail");
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Id).ValueGeneratedOnAdd();

                entity.HasOne(t => t.Order)
                      .WithMany()
                      .HasForeignKey(t => t.OrderId);

                entity.HasOne(t => t.Product)
                      .WithMany()
                      .HasForeignKey(t => t.ProductId);
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.ToTable("Factures");
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Id).ValueGeneratedOnAdd();

                entity.HasOne(t => t.Client)
                      .WithMany()
                      .HasForeignKey(t => t.ClientId);

                entity.HasOne(t => t.Method)
                      .WithMany()
                      .HasForeignKey(t => t.PaymentMethod)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<FormaCobranza>(entity =>
            {
                entity.ToTable("PurchaseMethods");
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Id).ValueGeneratedOnAdd();

                entity.HasData(
                    new FormaCobranza
                    {
                        Id = 1,
                        Description = "Debito"
                    },
                    new FormaCobranza
                    {
                        Id = 2,
                        Description = "Credito"
                    },
                    new FormaCobranza
                    {
                        Id = 3,
                        Description = "QR"
                    }
                    );
            });

            modelBuilder.Entity<OrdenDeCompra>(entity =>
            {
                entity.ToTable("Orders");
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Id).ValueGeneratedOnAdd();

                entity.HasOne(t => t.Provider)
                      .WithMany()
                      .HasForeignKey(t => t.ProviderId);
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.ToTable("Products");
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.ToTable("Providers");
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Id).ValueGeneratedOnAdd();
            });
        }

    }
}
