using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Domain.Entities
{
    public class Funcionario : IDisposable
    {
        public short CodColigada { get; set; }
        public string Chapa { get; set; }
        public Nullable<int> Cracha { get; set; }
        public string Nome { get; set; }
        public string CodCCusto { get; set; }
        public string CodFuncao { get; set; }
        public string Funcao { get; set; }
        public Nullable<DateTime> DataAdmissao { get; set; }
        public Nullable<DateTime> DataDemissao { get; set; }
        public string CodSituacao { get; set; }
        public string CodTipoMaoDeObra { get; set; }
        public Nullable<DateTime> DataCracha { get; set; }
        public string DescSituacao { get; set; }
        public string DescTipoMaoDeObra { get; set; }
        public int EmMobilizacao { get; set; }
        public bool Subempreiteiro { get; set; }
        public string JornadaLivre { get; set; }
        public string Alojamento { get; set; }

        public Equipe Equipe { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
