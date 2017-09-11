using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetoModeloDDD.Application.Interface;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Application
{
    public class TipoMaoObraAppService : AppServiceBase<TipoMaoObra>, ITipoMaoObraAppService
    {
        private readonly ITipoMaoObraService _tipoMaoObraService;

        public TipoMaoObraAppService(ITipoMaoObraService tipoMaoObraService)
            : base(tipoMaoObraService)
        {
            _tipoMaoObraService = tipoMaoObraService;
        }

        public IEnumerable<TipoMaoObra> ObterTiposMaoDeObraComPerformance()
        {
            return _tipoMaoObraService.ObterMaoObraComPerformance(_tipoMaoObraService.GetAll());
        }
    }
}
