using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ProjetoConfiguration : EntityTypeConfiguration<Projeto>
    {
        public ProjetoConfiguration()
        {
            HasKey(p => p.ID);
            Property(p => p.Empresa)
                .IsRequired()
                .HasMaxLength(150);
            Property(p => p.AreaAtuacao)
                .IsRequired()
                .HasMaxLength(150);
            Property(p => p.Regiao)
                .IsRequired()
                .HasMaxLength(150);
            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);

        }
    }
}
