using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ThirdMVCApp.Models;

public partial class SecondMvcappDbContext : DbContext
{
    public SecondMvcappDbContext()
    {
    }

    public SecondMvcappDbContext(DbContextOptions<SecondMvcappDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=SuyashConnect");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
