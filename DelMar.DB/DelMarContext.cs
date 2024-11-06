using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DelMar.DB
{
    public class DelMarContext : DbContext
    {
        public DelMarContext()
        {
                
        }

        public DelMarContext(DbContextOptions<DelMarContext> options):base(options)
        {
                
        }
    }
}
