using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;
using ProjetoModelo.Domain.Entities;


namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class CentroCustoConfiguration : EntityTypeConfiguration<CentroCusto>
    {
        public CentroCustoConfiguration()
        {
            HasKey(cc => cc.ID);
            Property(cc => cc.CodCentroCusto)
                .IsRequired()
                .HasMaxLength(30);
            Property(cc => cc.Desc)
                .IsRequired()
                .HasMaxLength(150);

            HasRequired(cc => cc.Projeto)
                .WithMany()
                .HasForeignKey(cc => cc.ProjetoID);
        }
    }
}
