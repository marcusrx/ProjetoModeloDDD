using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Domain.Entities
{
    public class EquipeFuncionario : IDisposable
    {
        public int CodColigada { get; set; }
        public string Cod_ccusto { get; set; }
        public string Cod_equipe { get; set; }
        public string Chapa { get; set; }
        public DateTime Data_criacao { get; set; }
        public string usuario_criacao { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
