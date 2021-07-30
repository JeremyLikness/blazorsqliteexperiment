using Microsoft.EntityFrameworkCore;

namespace blazorsqliteexperiment
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> opts) : base(opts)
        {

        }

        public DbSet<Todo> TodoList { get; set; }
    }
}
