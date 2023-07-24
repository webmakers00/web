using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace web1.ef
{
    public class Bookconfig:IEntityTypeConfiguration<Book>
    {
       
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("T_books");
        }
    }
}
