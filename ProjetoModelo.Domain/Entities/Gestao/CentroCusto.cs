using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Domain.Entities
{
    public class CentroCusto
    {
        public int ID { get; set; }
        public String CodCentroCusto { get; set; }
        public string Desc { get; set; }

        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public int ProjetoID { get; set; }
        public virtual Projeto Projeto { get; set; }

    }
}
