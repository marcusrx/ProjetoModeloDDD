using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Domain.Entities
{
    public class TipoMaoObra
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public virtual IEnumerable<Commodity> Commodities { get; set; }

        public bool TipoMObraComPerformance(TipoMaoObra tipoMO)
        {
            return tipoMO.Ativo && (tipoMO.ID.Equals(1) || tipoMO.ID.Equals(2));
        }

    }
}
