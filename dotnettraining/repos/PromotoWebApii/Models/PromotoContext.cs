using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PromotoWebApii.Models
{
    public partial class PromotoContext : DbContext
    {
        public PromotoContext()
        {
        }

        public PromotoContext(DbContextOptions<PromotoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Pincode> Pincodes { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=smartdb.database.windows.net;Database=Promoto; User ID=dbAdmin;Password=password@123$");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("OrderID")
                    .IsFixedLength(true);

                entity.Property(e => e.CustomerName).HasMaxLength(250);

                entity.Property(e => e.Dop)
                    .HasColumnType("datetime")
                    .HasColumnName("DOP");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.HasOne(d => d.PidNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Pid)
                    .HasConstraintName("FK__Orders__PID__60A75C0F");
            });

            modelBuilder.Entity<Pincode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pincode");

                entity.Property(e => e.AreaVillage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dist)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DIST");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Pincode1)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Pincode");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATE");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Products__C57755205C197346");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.Category).HasMaxLength(100);

                entity.Property(e => e.Pname)
                    .HasMaxLength(250)
                    .HasColumnName("PName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
