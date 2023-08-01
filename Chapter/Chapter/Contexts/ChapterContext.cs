using Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
    public class ChapterContext : DbContext
    {
        public ChapterContext() { }
        public ChapterContext(DbContextOptions<ChapterContext>options) : base(options) 
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) 
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-4SLU9M3\\SQLEXPRESS; initial catalogue = Chapter; Integrated Security = true ");
                //optionsBuilder.UseSqlServer("Data Source = DESKTOP-4SLU9M3\\SQLEXPRESS; initial catalogue = Chapter; user id = sa; password = 12345");
            }
        }
        public DbSet<Livro> Livros { get; set; }
    }
}
