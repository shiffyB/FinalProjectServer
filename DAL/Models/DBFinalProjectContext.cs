using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DAL.Models
{
    public partial class DBFinalProjectContext : DbContext
    {
        public DBFinalProjectContext()
        {
        }

        public DBFinalProjectContext(DbContextOptions<DBFinalProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCategory> TblCategories { get; set; }
        public virtual DbSet<TblCompany> TblCompanies { get; set; }
        public virtual DbSet<TblDivisionType> TblDivisionTypes { get; set; }
        public virtual DbSet<TblItemsOfOrder> TblItemsOfOrders { get; set; }
        public virtual DbSet<TblOrder> TblOrders { get; set; }
        public virtual DbSet<TblOrderApply> TblOrderApplies { get; set; }
        public virtual DbSet<TblProduct> TblProducts { get; set; }
        public virtual DbSet<TblSale> TblSales { get; set; }
        public virtual DbSet<TblSalePattern> TblSalePatterns { get; set; }
        public virtual DbSet<TblSalePatternsParam> TblSalePatternsParams { get; set; }
        public virtual DbSet<TblStatus> TblStatuses { get; set; }
        public virtual DbSet<TblStore> TblStores { get; set; }
        public virtual DbSet<TblUpdate> TblUpdates { get; set; }
        public virtual DbSet<TblUpdatesType> TblUpdatesTypes { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=DBFinalProject;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hebrew_CI_AS");

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__TblCateg__19093A0B8692A26A");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblCompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("PK__TblCompa__2D971CAC09776A1A");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TblDivisionType>(entity =>
            {
                entity.HasKey(e => e.DivisionId)
                    .HasName("PK__TblDivis__20EFC6A8AB1553BF");

                entity.Property(e => e.DivisionId).ValueGeneratedNever();

                entity.Property(e => e.DivisionName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TblItemsOfOrder>(entity =>
            {
                entity.HasKey(e => e.ItemOfOrderId)
                    .HasName("PK__TblItems__8A5963C8363380CA");

                entity.ToTable("TblItemsOfOrder");

                entity.HasOne(d => d.OrderApply)
                    .WithMany(p => p.TblItemsOfOrders)
                    .HasForeignKey(d => d.OrderApplyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblItemsO__Order__4CA06362");
            });

            modelBuilder.Entity<TblOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__TblOrder__C3905BCFB1EF671F");

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.HasOne(d => d.Buyer)
                    .WithMany(p => p.TblOrders)
                    .HasForeignKey(d => d.BuyerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblOrders__Buyer__44FF419A");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblOrders)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblOrders__Produ__4316F928");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblOrders)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblOrders__Statu__440B1D61");
            });

            modelBuilder.Entity<TblOrderApply>(entity =>
            {
                entity.HasKey(e => e.OrderApplyId)
                    .HasName("PK__TblOrder__988A86EC11E33E81");

                entity.Property(e => e.ApplyDate).HasColumnType("datetime");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TblOrderApplies)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblOrderA__Order__47DBAE45");

                entity.HasOne(d => d.Update)
                    .WithMany(p => p.TblOrderApplies)
                    .HasForeignKey(d => d.UpdateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblOrderA__Updat__49C3F6B7");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblOrderApplies)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblOrderA__UserI__48CFD27E");
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__TblProdu__B40CC6CD22E75E66");

                entity.Property(e => e.BarCode).HasMaxLength(25);

                entity.Property(e => e.Link).HasMaxLength(200);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TblProducts)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblProduc__Compa__2C3393D0");

                entity.HasOne(d => d.DivisionType)
                    .WithMany(p => p.TblProducts)
                    .HasForeignKey(d => d.DivisionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblProduc__Divis__2E1BDC42");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.TblProducts)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblProduc__Store__2D27B809");
            });

            modelBuilder.Entity<TblSale>(entity =>
            {
                entity.HasKey(e => e.SaleId)
                    .HasName("PK__TblSales__1EE3C3FF3281402F");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.PatternParam)
                    .WithMany(p => p.TblSales)
                    .HasForeignKey(d => d.PatternParamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblSales__Patter__36B12243");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.TblSales)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblSales__StoreI__35BCFE0A");
            });

            modelBuilder.Entity<TblSalePattern>(entity =>
            {
                entity.HasKey(e => e.PatternId)
                    .HasName("PK__TblSaleP__0A631B524628F988");

                entity.Property(e => e.PatternDescription)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TblSalePatternsParam>(entity =>
            {
                entity.HasKey(e => e.PatternParamId)
                    .HasName("PK__TblSaleP__1240C5B181D95867");

                entity.HasOne(d => d.Pattern)
                    .WithMany(p => p.TblSalePatternsParams)
                    .HasForeignKey(d => d.PatternId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblSalePa__Patte__32E0915F");
            });

            modelBuilder.Entity<TblStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__TblStatu__C8EE2063703C4217");

                entity.ToTable("TblStatus");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblStore>(entity =>
            {
                entity.HasKey(e => e.StoreId)
                    .HasName("PK__TblStore__3B82F101945BDC78");

                entity.Property(e => e.Lat).HasMaxLength(20);

                entity.Property(e => e.Lng).HasMaxLength(20);

                entity.Property(e => e.StoreAddress).HasMaxLength(50);

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TblUpdate>(entity =>
            {
                entity.HasKey(e => e.UpdateId)
                    .HasName("PK__TblUpdat__7A0CF3C590145F7E");

                entity.HasOne(d => d.UpdateType)
                    .WithMany(p => p.TblUpdates)
                    .HasForeignKey(d => d.UpdateTypeId)
                    .HasConstraintName("FK__TblUpdate__Updat__3B75D760");
            });

            modelBuilder.Entity<TblUpdatesType>(entity =>
            {
                entity.HasKey(e => e.UpdateTypeId)
                    .HasName("PK__TblUpdat__C6E976319F0A7C59");

                entity.Property(e => e.UpdateTypeName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.AutoUserId)
                    .HasName("PK__TblUsers__B611B60ECF4A0694");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.UserAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.Update)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.UpdateId)
                    .HasConstraintName("FK__TblUsers__Update__3E52440B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
