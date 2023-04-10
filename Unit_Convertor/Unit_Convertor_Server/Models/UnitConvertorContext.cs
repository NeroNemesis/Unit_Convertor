using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Unit_Convertor_Server.Models;

public partial class UnitConvertorContext : DbContext
{
    public UnitConvertorContext()
    {
    }

    public UnitConvertorContext(DbContextOptions<UnitConvertorContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Distance> Distances { get; set; }

    public virtual DbSet<DistanceUnit> DistanceUnits { get; set; }

    public virtual DbSet<Temperature> Temperatures { get; set; }

    public virtual DbSet<TemperatureUnit> TemperatureUnits { get; set; }

    public virtual DbSet<Weight> Weights { get; set; }

    public virtual DbSet<WeightUnit> WeightUnits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Unit_Convertor;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Distance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Distance__3214EC07B3DF2CB9");

            entity.ToTable("Distance");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ufrom)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UFrom");
            entity.Property(e => e.Uto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UTo");
        });

        modelBuilder.Entity<DistanceUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Distance__3214EC07BB2C208A");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Unit)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Temperature>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Temperat__3214EC07218ACD25");

            entity.ToTable("Temperature");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ufrom)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UFrom");
            entity.Property(e => e.Uto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UTo");
        });

        modelBuilder.Entity<TemperatureUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Temperat__3214EC073408C8BD");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Unit)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Weight>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Weight__3214EC0710DD0C0B");

            entity.ToTable("Weight");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ufrom)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UFrom");
            entity.Property(e => e.Uto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UTo");
        });

        modelBuilder.Entity<WeightUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WeightUn__3214EC07E84C2A6C");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Unit)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
