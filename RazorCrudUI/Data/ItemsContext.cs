using Microsoft.EntityFrameworkCore;
using RazorCrudUI.Models;

namespace RazorCrudUI.Data;

public class ItemsContext : DbContext
{
    public ItemsContext(DbContextOptions<ItemsContext> options) : base(options)
    {
    }

    // whatever you name this collection will be your table name
    public DbSet<ItemModel> Items { get; set; } = default!;
}