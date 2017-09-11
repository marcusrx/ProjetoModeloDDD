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
    public class CommodityService : ServiceBase<Commodity>, ICommodityService
    {
        private readonly ICommodityRepository _commodityRepository;

        public CommodityService(ICommodityRepository commodityRepository)
            : base(commodityRepository)
        {
            _commodityRepository = commodityRepository;
        }

        public IEnumerable<Commodity> BuscarPorNome(string nome)
        {
            return _commodityRepository.GetByName(nome);
        }

        public IEnumerable<Commodity> ObterCommoditiesComPerformance(IEnumerable<Commodity> commodities)
        {
            return commodities.Where(c => c.TipoMaoDeObra.TipoMObraComPerformance(c.TipoMaoDeObra));
        }
    }
}
