using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetoModelo.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class DisciplinaConfiguration : EntityTypeConfiguration<Disciplina>
    {
        public DisciplinaConfiguration()
        {
            HasKey(d => d.DisciplinaID);

            Property(d => d.Nome)
                .IsRequired()
                .HasMaxLength(150);


        }
    }
}
