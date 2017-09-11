using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repositories;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Domain.Services
{
    public class CentroCustoService : ServiceBase<CentroCusto>, ICentroCustoService
    {
        private readonly ICentroCustoRepository _centroCustoRepository;

        public CentroCustoService(ICentroCustoRepository centroCustoRepository) 
            : base(centroCustoRepository)
        {
            _centroCustoRepository = centroCustoRepository;
        }
    }
}
