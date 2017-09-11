using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetoModelo.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class TipoMaoObraConfiguration : EntityTypeConfiguration<TipoMaoObra>
    {
        public TipoMaoObraConfiguration()
        {
            HasKey(tp => tp.ID);

            Property(tp => tp.Descricao)
                .IsRequired()
                .HasMaxLength(150);

        }
    }
}
