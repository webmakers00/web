using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System.ComponentModel.DataAnnotations;
//Scaffold-DbContext "Data Source=d:\web\mgf.db" Microsoft.EntityFrameworkCore.Sqlite -OutputDir Models
namespace web2.ef
{
    public class ord
    {
        [Key]        
        public long Id { get; set; }
        public int myid { get; set; }
        public List<stre> ords { get; set;}
    }
    public class st
    {
        public long Id { get; set; } = 0;
        public int myid { get; set; }

    }


    public class ordcng : IEntityTypeConfiguration<ord>
    {
        public void Configure(EntityTypeBuilder<ord> builder)
        {
            builder.ToTable(nameof(ord));
        }
    }

  

    
    public class Mydbcontext:DbContext
    {
        public DbSet<ord> ords { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("data source=d:\\web\\mm.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }





}
