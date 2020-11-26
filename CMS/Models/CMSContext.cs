using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CMS.Models
{
    public partial class CMSContext : DbContext
    {
        public CMSContext()
        {
        }

        public CMSContext(DbContextOptions<CMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Banner> Banners { get; set; }
        public virtual DbSet<Footer> Footers { get; set; }
        public virtual DbSet<Header> Headers { get; set; }
        public virtual DbSet<Main> Mains { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-L73GDJC\\SQLEXPRESS;Database=CMS;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banner>(entity =>
            {
                entity.HasKey(e => e.IdBanner)
                    .HasName("PK__Banner__9EAD8FB148F28CEE");

                entity.ToTable("Banner");

                entity.Property(e => e.IdBanner).HasColumnName("idBanner");

                entity.Property(e => e.Header)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("header");
            });

            modelBuilder.Entity<Footer>(entity =>
            {
                entity.HasKey(e => e.IdFooter)
                    .HasName("PK__Footer__78C8288FF9F83368");

                entity.ToTable("Footer");

                entity.Property(e => e.IdFooter).HasColumnName("idFooter");

                entity.Property(e => e.CategoryOne)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("categoryOne");

                entity.Property(e => e.CategoryThree)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("categoryThree");

                entity.Property(e => e.CategoryTwo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("categoryTwo");
            });

            modelBuilder.Entity<Header>(entity =>
            {
                entity.HasKey(e => e.IdHeader)
                    .HasName("PK__Header__0DC09BB8C6552F86");

                entity.ToTable("Header");

                entity.Property(e => e.IdHeader).HasColumnName("idHeader");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("companyName");

                entity.Property(e => e.LegendName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("legendName");

                entity.Property(e => e.Plans)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("plans");

                entity.Property(e => e.SubLegendName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("subLegendName");
            });

            modelBuilder.Entity<Main>(entity =>
            {
                entity.HasKey(e => e.IdMain)
                    .HasName("PK__Main__C365D82F1F173CBA");

                entity.ToTable("Main");

                entity.Property(e => e.IdMain).HasColumnName("idMain");

                entity.Property(e => e.CategoryFour)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("categoryFour");

                entity.Property(e => e.CategoryFourValue)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("categoryFourValue");

                entity.Property(e => e.CategoryOne)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("categoryOne");

                entity.Property(e => e.CategoryOneValue)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("categoryOneValue");

                entity.Property(e => e.CategoryThree)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("categoryThree");

                entity.Property(e => e.CategoryThreeValue)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("categoryThreeValue");

                entity.Property(e => e.CategoryTwo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("categoryTwo");

                entity.Property(e => e.CategoryTwoValue)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("categoryTwoValue");

                entity.Property(e => e.Header)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("header");

                entity.Property(e => e.Legend)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("legend");

                entity.Property(e => e.TableTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tableTitle");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.HasKey(e => e.IdPrice)
                    .HasName("PK__Price__3691D506A9A02C0A");

                entity.ToTable("Price");

                entity.Property(e => e.IdPrice).HasColumnName("idPrice");

                entity.Property(e => e.CardOneButton)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cardOneButton");

                entity.Property(e => e.CardThreeButton)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cardThreeButton");

                entity.Property(e => e.CardTwoButton)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cardTwoButton");

                entity.Property(e => e.Header)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("header");

                entity.Property(e => e.Legend)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("legend");

                entity.Property(e => e.PriceCardOneheader)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("priceCardOneheader");

                entity.Property(e => e.PriceCardThreeheader)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("priceCardThreeheader");

                entity.Property(e => e.PriceCardTwoheader)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("priceCardTwoheader");

                entity.Property(e => e.PriceOneBody)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("priceOneBody");

                entity.Property(e => e.PriceThreeBody)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("priceThreeBody");

                entity.Property(e => e.PriceTwoBody)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("priceTwoBody");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProduct)
                    .HasName("PK__Product__5EEC79D1F9FF041A");

                entity.ToTable("Product");

                entity.Property(e => e.IdProduct).HasColumnName("idProduct");

                entity.Property(e => e.ArticleFourBody)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("articleFourBody");

                entity.Property(e => e.ArticleFourheader)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("articleFourheader");

                entity.Property(e => e.ArticleOneBody)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("articleOneBody");

                entity.Property(e => e.ArticleOneheader)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("articleOneheader");

                entity.Property(e => e.ArticleThreeBody)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("articleThreeBody");

                entity.Property(e => e.ArticleThreeheader)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("articleThreeheader");

                entity.Property(e => e.ArticleTwoBody)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("articleTwoBody");

                entity.Property(e => e.ArticleTwoheader)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("articleTwoheader");

                entity.Property(e => e.Header)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("header");

                entity.Property(e => e.Legend)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("legend");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
