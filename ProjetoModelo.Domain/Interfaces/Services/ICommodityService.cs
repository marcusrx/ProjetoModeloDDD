using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Domain.Interfaces.Services
{
    public interface ICommodityService : IServiceBase<Commodity>
    {
        IEnumerable<Commodity> BuscarPorNome(string nome);
        IEnumerable<Commodity> ObterCommoditiesComPerformance(IEnumerable<Commodity> commodities);
    }
}
