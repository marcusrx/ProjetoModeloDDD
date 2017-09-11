using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetoModelo.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class CommodityConfiguration : EntityTypeConfiguration<Commodity>
    {
        public CommodityConfiguration()
        {
            HasKey(c => c.CommodityID);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);
            Property(c => c.Descricao)
                .HasMaxLength(150);
            HasRequired(c => c.TipoMaoDeObra)
                .WithMany()
                .HasForeignKey(c => c.TipoMaoObraID);
            HasRequired(c => c.Disciplina)
                .WithMany()
                .HasForeignKey(c => c.DisciplinaID);
        }
    }
}
