using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Domain.Entities
{
    public class Disciplina
    {
        public int DisciplinaID { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual IEnumerable<Commodity> Commodities { get; set; }
    }
}
