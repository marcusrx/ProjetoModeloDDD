using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> GetByName(string name)
        {
            return Db.Produtos.Where(p => p.Nome == name);
        }
    }
}
