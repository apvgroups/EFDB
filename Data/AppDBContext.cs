using Microsoft.EntityFrameworkCore;
namespace EFDB.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        { }
    }
}
