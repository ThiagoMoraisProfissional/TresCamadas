using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TresCamadas.Model.Models;

namespace TresCamadas.DAL.Maps
{
    public class ClienteMap: IEntityTypeConfiguration<ClienteModel>
    {

        public void Configure(EntityTypeBuilder<ClienteModel> builder)
        {
            // Mapeamento da tabela CLIENTES
            builder.ToTable("CLIENTES");

            // Mapeamento da chave primária
            builder.HasKey(x => x.Id);

            // Mapeamento das colunas
            builder.Property(x => x.Id).HasColumnName("ID").IsRequired();
            builder.Property(x => x.Nome).HasColumnName("NOME").IsRequired();
            builder.Property(x => x.Idade).HasColumnName("IDADE").IsRequired();
            builder.Property(x => x.DataNascimento).HasColumnName("DATA_NASC").IsRequired();
        }
    }
}
