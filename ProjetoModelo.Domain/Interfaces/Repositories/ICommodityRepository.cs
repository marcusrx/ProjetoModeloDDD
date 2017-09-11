using ProjetoModelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Domain.Interfaces.Repositories
{
    public interface ICommodityRepository : IRepositoryBase<Commodity>
    {
        IEnumerable<Commodity> GetByName(string name);
    }
}
