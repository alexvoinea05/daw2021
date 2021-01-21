using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AppDaw2021.Entities
{
    public partial class proiectDawContext : DbContext
    {
        public proiectDawContext()
        {
        }

        public proiectDawContext(DbContextOptions<proiectDawContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autor> Autors { get; set; }
        public virtual DbSet<Carte> Cartes { get; set; }
        public virtual DbSet<Categorie> Categories { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=AVOINEA-L\\MSSQLSERVER02;Persist Security Info=True;Database=proiectDaw;User ID=sa;Password=Qazwsx123;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Autor>(entity =>
            {
                entity.HasKey(e => e.IdAutor);

                entity.ToTable("Autor");

                entity.Property(e => e.IdAutor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_autor");

                entity.Property(e => e.NumeAutor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nume_autor");
            });

            modelBuilder.Entity<Carte>(entity =>
            {
                entity.HasKey(e => e.IdCarte);

                entity.ToTable("Carte");

                entity.Property(e => e.IdCarte)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_carte");

                entity.Property(e => e.Descriere)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("descriere");

                entity.Property(e => e.IdAutor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_autor");

                entity.Property(e => e.IdCategorie)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_categorie");

                entity.Property(e => e.IdReview)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_review");

                entity.Property(e => e.NumeCarte)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nume_carte");

                entity.HasOne(d => d.IdAutorNavigation)
                    .WithMany(p => p.Cartes)
                    .HasForeignKey(d => d.IdAutor)
                    .HasConstraintName("FK_Autor");

                entity.HasOne(d => d.IdCategorieNavigation)
                    .WithMany(p => p.Cartes)
                    .HasForeignKey(d => d.IdCategorie)
                    .HasConstraintName("FK_Categorie");

                entity.HasOne(d => d.IdReviewNavigation)
                    .WithMany(p => p.Cartes)
                    .HasForeignKey(d => d.IdReview)
                    .HasConstraintName("FK_Review");
            });

            modelBuilder.Entity<Categorie>(entity =>
            {
                entity.HasKey(e => e.IdCategorie);

                entity.ToTable("Categorie");

                entity.Property(e => e.IdCategorie)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_categorie");

                entity.Property(e => e.GenCategorie)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gen_categorie");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasKey(e => e.IdReview);

                entity.ToTable("Review");

                entity.Property(e => e.IdReview)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_review");

                entity.Property(e => e.Comentariu)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comentariu");

                entity.Property(e => e.IdCarte)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_carte");

                entity.Property(e => e.IdUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_user");

                entity.Property(e => e.Nota)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nota");

                entity.HasOne(d => d.IdCarteNavigation)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.IdCarte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Carte");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.ToTable("User");

                entity.Property(e => e.IdUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_user");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Nume)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nume");

                entity.Property(e => e.Parola)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parola");

                entity.Property(e => e.Prenume)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("prenume");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
