using Microsoft.EntityFrameworkCore;

namespace FirstApi.Data
{
    public class FirstApiContext:DbContext
    {
        public DbSet<Employee> Employees{ get; set; }

        public FirstApiContext(DbContextOptions<FirstApiContext> options)
           : base(options)
        {
        }
    }
}
