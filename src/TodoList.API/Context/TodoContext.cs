using Microsoft.EntityFrameworkCore;
using TodoList.API.Model;

namespace TodoList.API.Context;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        :base(options)
    {       
    }

    public DbSet<TodoItem> TodoItems { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseInMemoryDatabase("TodoDb");
    //}
}
