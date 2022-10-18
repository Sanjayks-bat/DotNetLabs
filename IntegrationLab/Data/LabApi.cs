using Microsoft.EntityFrameworkCore;
using Oops;

namespace IntegrationLab.Data
{
    public class LabApi: DbContext
    {
        public DbSet<Rectangle> Rectangles { get; set; }

        public LabApi(DbContextOptions<LabApi> options)
           : base(options)
        {
        }
        
    }
}
