using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Services;
using ProjetoModelo.Domain.Interfaces.Repositories;

namespace ProjetoModelo.Domain.Services
{
    public class TipoMaoObraService : ServiceBase<TipoMaoObra>, ITipoMaoObraService
    {
        private readonly ITipoMaoObraRepository _tipoMaoObraRespository;

        public TipoMaoObraService(ITipoMaoObraRepository tipoMaoObraRespository)
            : base(tipoMaoObraRespository)
        {
            _tipoMaoObraRespository = tipoMaoObraRespository;
        }

        public IEnumerable<TipoMaoObra> ObterMaoObraComPerformance(IEnumerable<TipoMaoObra> tiposMO)
        {
            return tiposMO.Where(tp => tp.TipoMObraComPerformance(tp));
        }
    }
}
