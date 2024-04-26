using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PnlRS.Data.Data;

public partial class MoviesDbContext : DbContext
{
    public MoviesDbContext()
    {
    }

    public MoviesDbContext(DbContextOptions<MoviesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<Casting> Castings { get; set; }

    public virtual DbSet<Certificate> Certificates { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Director> Directors { get; set; }

    public virtual DbSet<Film> Films { get; set; }

    public virtual DbSet<FilmGenre> FilmGenres { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<Studio> Studios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=MoviesDB; Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>(entity =>
        {
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Dob).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Casting>(entity =>
        {
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.CharacterName).HasMaxLength(255);

            entity.HasOne(d => d.Actor).WithMany(p => p.Castings)
                .HasForeignKey(d => d.ActorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Castings_Actor");

            entity.HasOne(d => d.Film).WithMany(p => p.Castings)
                .HasForeignKey(d => d.FilmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Castings_Film");
        });

        modelBuilder.Entity<Certificate>(entity =>
        {
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Director>(entity =>
        {
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Dob).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Film>(entity =>
        {
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

            entity.HasOne(d => d.Certificate).WithMany(p => p.Films)
                .HasForeignKey(d => d.CertificateId)
                .HasConstraintName("FK_Films_Certificate");

            entity.HasOne(d => d.Country).WithMany(p => p.Films)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_Films_Country");

            entity.HasOne(d => d.Director).WithMany(p => p.Films)
                .HasForeignKey(d => d.DirectorId)
                .HasConstraintName("FK_Films_Director");

            entity.HasOne(d => d.Language).WithMany(p => p.Films)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_Films_Language");

            entity.HasOne(d => d.Studio).WithMany(p => p.Films)
                .HasForeignKey(d => d.StudioId)
                .HasConstraintName("FK_Films_Studio");
        });

        modelBuilder.Entity<FilmGenre>(entity =>
        {
            entity.HasOne(d => d.Film).WithMany(p => p.FilmGenres)
                .HasForeignKey(d => d.FilmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FilmGenres_Films");

            entity.HasOne(d => d.Genre).WithMany(p => p.FilmGenres)
                .HasForeignKey(d => d.GenreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FilmGenres_FilmGenres");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Studio>(entity =>
        {
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
