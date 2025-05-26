﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace project1.Models;

public partial class LibraryManagementAppContext : DbContext
{
    public LibraryManagementAppContext()
    {
    }

    public LibraryManagementAppContext(DbContextOptions<LibraryManagementAppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookCheckout> BookCheckouts { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-KJV18OK;Database=LibraryManagementApp;Trusted_Connection=True;trust server certificate= true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Authors__3214EC0747601E31");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Books__3214EC07CE29B019");

            entity.Property(e => e.Title).HasMaxLength(200);

            entity.HasOne(d => d.Author).WithMany(p => p.Books)
                .HasForeignKey(d => d.AuthorId)
                .HasConstraintName("FK__Books__AuthorId__398D8EEE");
        });

        modelBuilder.Entity<BookCheckout>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BookChec__3214EC07E7632D26");

            entity.HasOne(d => d.Book).WithMany(p => p.BookCheckouts)
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("FK__BookCheck__BookI__3E52440B");

            entity.HasOne(d => d.Member).WithMany(p => p.BookCheckouts)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK__BookCheck__Membe__3F466844");
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Members__3214EC0714A38247");

            entity.Property(e => e.FullName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
