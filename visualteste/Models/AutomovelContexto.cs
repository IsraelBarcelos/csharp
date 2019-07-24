using Microsoft.EntityFrameworkCore;

namespace visualteste.Models
{
    public class AutomovelContexto : DbContext
    {
        public AutomovelContexto(DbContextOptions<AutomovelContexto> options) : base(options)
        {

        }

        public DbSet<Automovel> Automoveis{ get;set;}
    }
}