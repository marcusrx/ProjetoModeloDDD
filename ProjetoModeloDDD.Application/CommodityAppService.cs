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
    public class CommodityAppService : AppServiceBase<Commodity>, ICommodityAppService
    {
        private readonly ICommodityService _commodityService;
        public CommodityAppService(ICommodityService commodityService)
            :base(commodityService)
        {
            _commodityService = commodityService;
        }
        public IEnumerable<Commodity> BuscarPorNome(string nome)
        {
            return _commodityService.BuscarPorNome(nome);
        }

        public IEnumerable<Commodity> ObterCommoditiesComPerformance()
        {
            return _commodityService.ObterCommoditiesComPerformance(_commodityService.GetAll());
        }
    }
}
