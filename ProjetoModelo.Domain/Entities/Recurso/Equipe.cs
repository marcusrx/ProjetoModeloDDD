using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Domain.Entities
{
    public class Equipe : IDisposable
    {
        #region Propriedades

        public int CodColigada { get; set; }
        public string cod_ccusto { get; set; }
        public int CodEquipe { get; set; }
        public int CodCelula { get; set; }
        public string SeqEquipe { get; set; }
        public string DescEquipe { get; set; }
        public string CodSupervisor { get; set; }

        #endregion

        
        #region Extra properties

        public List<Funcionario> Funcionarios { get; set; }
        public int QtdFuncsEquipe { get; set; }

        #endregion

        

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
