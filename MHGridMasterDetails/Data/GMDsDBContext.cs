using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MHGridMasterDetails.Data
{
    public partial class GMDsDBContext : DbContext
    {
        public GMDsDBContext()
        {
        }

        public GMDsDBContext(DbContextOptions<GMDsDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompanyStock> CompanyStock { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Import> Import { get; set; }
        public virtual DbSet<Level> Level { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Tanker> Tanker { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserLogin> UserLogin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=GMDsDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("company");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("company_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CompanyName)
                    .HasColumnName("company_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CompanyStock>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.ToTable("company_stock");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CumulativeQtyInStock)
                    .HasColumnName("cumulative_qty_in_stock")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CompanyStock)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_company_stock_product");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.AddedDate)
                    .HasColumnName("added_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AltDescription)
                    .HasColumnName("alt_description")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("is_active");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.AddedDate)
                    .HasColumnName("added_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AltDescription)
                    .HasColumnName("alt_description")
                    .HasMaxLength(150);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(150);

                entity.Property(e => e.IsActive).HasColumnName("is_active");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.Property(e => e.GenderId).HasColumnName("gender_id");

                entity.Property(e => e.AddedDate)
                    .HasColumnName("added_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AltDescription)
                    .HasColumnName("alt_description")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .HasColumnName("is_active")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Import>(entity =>
            {
                entity.ToTable("import");

                entity.Property(e => e.ImportId)
                    .HasColumnName("import_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddedDate)
                    .HasColumnName("added_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.PriceImport)
                    .HasColumnName("price_import")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.QtyDelivered)
                    .HasColumnName("qty_delivered")
                    .HasMaxLength(50);

                entity.Property(e => e.QtyImported)
                    .HasColumnName("qty_imported")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TankerId).HasColumnName("tanker_id");
            });

            modelBuilder.Entity<Level>(entity =>
            {
                entity.Property(e => e.LevelId).HasColumnName("level_id");

                entity.Property(e => e.AddedDate)
                    .HasColumnName("added_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AltDescription)
                    .HasColumnName("alt_description")
                    .HasMaxLength(50);

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("is_active");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProductDescription)
                    .HasColumnName("product_description")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("is_active");
            });

            modelBuilder.Entity<Tanker>(entity =>
            {
                entity.Property(e => e.TankerId)
                    .HasColumnName("tanker_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TankerName)
                    .HasColumnName("tanker_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserCode);

                entity.Property(e => e.UserCode).HasColumnName("user_code");

                entity.Property(e => e.AddedDate)
                    .HasColumnName("added_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AltDescription)
                    .HasColumnName("alt_description")
                    .HasMaxLength(150);

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(150);

                entity.Property(e => e.GenderId).HasColumnName("gender_id");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.LevelId).HasColumnName("level_id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddedDate)
                    .HasColumnName("added_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
