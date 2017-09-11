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
    public class CentroCustoAppService : AppServiceBase<CentroCusto>, ICentroCustoAppService
    {
        private readonly ICentroCustoService _centroCustoService;

        public CentroCustoAppService(ICentroCustoService centroCustoService)
            : base(centroCustoService)
        {
            _centroCustoService = centroCustoService;
        }
    }
}
