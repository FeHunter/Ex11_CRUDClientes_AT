using Ex11_CRUDClientes_AT.Models;
using Microsoft.EntityFrameworkCore;

namespace Ex11_CRUDClientes_AT.Data
{
    public class Contexto : DbContext
    {
        DbSet<Cliente> Clientes { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }
}
