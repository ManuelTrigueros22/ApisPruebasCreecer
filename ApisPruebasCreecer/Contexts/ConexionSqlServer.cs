using ApisPruebasCreecer.Models;
using Microsoft.EntityFrameworkCore;

namespace ApisPruebasCreecer.Contexts
{
    public class ConexionSqlServer:DbContext
    {
        public ConexionSqlServer(DbContextOptions<ConexionSqlServer> options) : base(options)
        {
            //
        }

        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Departamento> Departamento { get; set;}
    }
}
