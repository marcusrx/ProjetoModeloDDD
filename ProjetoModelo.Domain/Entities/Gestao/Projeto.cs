using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Domain.Entities
{
    public class Projeto
    {
        public int ID { get; set; }
        public string Empresa { get; set; }
        public string AreaAtuacao { get; set; }
        public string Regiao { get; set; }
        public string Nome { get; set; }

        public virtual IEnumerable<CentroCusto> CentrosCusto { get; set; }

        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
