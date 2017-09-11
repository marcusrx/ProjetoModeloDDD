using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Domain.Entities
{
    public class Commodity
    {
        public int CommodityID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int TipoMaoObraID { get; set; }
        public int DisciplinaID { get; set; }

        public virtual TipoMaoObra TipoMaoDeObra { get; set; }
        public virtual Disciplina Disciplina { get; set; }
    }
}
