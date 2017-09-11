using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetoModelo.Domain.Entities;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface ITipoMaoObraAppService : IAppServiceBase<TipoMaoObra>
    {
        IEnumerable<TipoMaoObra> ObterTiposMaoDeObraComPerformance();
    }
}
