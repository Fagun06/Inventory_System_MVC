using Inventory_System_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory_System_MVC.Data
{

    public class InventoryDbContext : DbContext
		{
			public InventoryDbContext(DbContextOptions options) : base(options)
			{

			}
			public DbSet<Register> Register { get; set; }
			

    }
	
}
