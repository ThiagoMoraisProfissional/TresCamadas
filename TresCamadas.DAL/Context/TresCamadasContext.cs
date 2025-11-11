using Microsoft.EntityFrameworkCore;
using TresCamadas.DAL.Maps;
using TresCamadas.Model.Models;

namespace TresCamadas.DAL.Context
{
    public class TresCamadasContext: DbContext
    {
        public TresCamadasContext(DbContextOptions<TresCamadasContext> options) : base(options)
        {
            
        }

        //Modelos
        public DbSet<ClienteModel> Clientes { get; set; }

        //Mapeamento
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configurar mapeamento

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ClienteMap());
            //outras entidades..
        }
    }
}
