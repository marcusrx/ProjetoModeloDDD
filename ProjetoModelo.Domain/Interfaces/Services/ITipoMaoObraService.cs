using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoModelo.Domain.Entities;


namespace ProjetoModelo.Domain.Interfaces.Services
{
    public interface ITipoMaoObraService : IServiceBase<TipoMaoObra>
    {
        IEnumerable<TipoMaoObra> ObterMaoObraComPerformance(IEnumerable<TipoMaoObra> tiposMO);
    }
}
