using Microsoft.EntityFrameworkCore;
using  FirstCore.MyModel;

namespace FirstCore.DB
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions option):base(option){}

        public DbSet<Customer> Customers { get; set; }
    }
}