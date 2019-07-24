using Microsoft.EntityFrameworkCore;
using ProjetoCsharp.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCsharp.Models.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> option) : base(option)
        {
            Database.EnsureCreated();
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
