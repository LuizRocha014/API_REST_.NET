using Microsoft.EntityFrameworkCore;
using WEB_REST_PRO.Models;

namespace WEB_REST_PRO.Data
{
    public class DataContext:  DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        
        {
                
        }

        public DbSet<Usuario> Usuario { get; set; }





    }
}
