using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace web1;

public partial class MgfContext : DbContext
{
    public MgfContext()
    {
    }

    public MgfContext(DbContextOptions<MgfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TBook> TBooks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=d:\\\\\\\\web\\\\\\\\mgf.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TBook>(entity =>
        {
            entity.ToTable("T_books");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
