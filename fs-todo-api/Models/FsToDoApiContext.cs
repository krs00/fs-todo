using Microsoft.EntityFrameworkCore;

namespace FsToDoApi.Models
{
  public class FsToDoApiContext : DbContext
  {
    public DbSet<ToDo> ToDos { get; set; }

    public FsToDoApiContext(DbContextOptions<FsToDoApiContext> options) : base(options)
    {
    }

        protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<ToDo>()
        .HasData(
          new ToDo { ToDoId = 1, Title = "Wash Dishes", Description = "wash all the dishes in the sink!", Completed = false }
        );

    }
  }
}