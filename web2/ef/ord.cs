using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//Scaffold-DbContext "Data Source=d:\web\mgf.db" Microsoft.EntityFrameworkCore.Sqlite -OutputDir Models
namespace web2.ef
{
    public class ord
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // 自增主键       
        public long Id { get; set; } //自动增加
        public int ordid { get; set; } //如“4052”
        public string? cusna { get; set; } //如 “李天虎”
        public int cusid { get; set; } //如 “ltf”
        public int n { get; set; } //m套
        public int dstar { get; set; }  //下单日期
        public int dend { get; set; }// 出货日期
        public int first { get; set; }//  加急到数天九
        public string? des { get; set; } // 备注
        public int isdel { get; set; } // 订单作废，如重复
        public int isend { get; set; } // 订单出货
        public List<step> istep { get; set; } = new List<step>(); //工序
    }
    public class step
    {   
        public string name { get; set; } //工序名 “木工”
        public bool isstar { get; set; } //是否开始
        public bool isend { get; set; } //是否结束
        public int dstar { get; set; } //开始时间
        public int dend { get; set; } //结束时间
        public int month { get; set; } //工序工钱计算月份
        public List <boy> iboy { get; set;}=new List<boy>();    
    }
    public class boy
    {                  
        public string name { get; set; } //员工名字  
        public int n { get; set; } //自动增加  
        public int allmoney { get; set; } //自动增加  
    }
    public class ordcng : IEntityTypeConfiguration<ord>
    {
        public void Configure(EntityTypeBuilder<ord> builder)
        {
            builder.ToTable(nameof(ord));
        }
    }
    public class boycnf : IEntityTypeConfiguration<boy>
    {
        public void Configure(EntityTypeBuilder<boy> builder)
        {
            builder.ToTable(nameof(boy));
        }
    }
      public class stepcng : IEntityTypeConfiguration<step>
    {
        public void Configure(EntityTypeBuilder<step> builder)
        {
            builder.ToTable(nameof(step));
        }
    }

    public class Mydbcontext:DbContext
    {
        public DbSet<ord> ords { get; set;}
        public DbSet<boy> boys { get; set;}
        public DbSet<step> steps { get; set;}
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


//Add-Migration InitialCreate
//Update-Database
