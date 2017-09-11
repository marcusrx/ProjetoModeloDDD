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
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            :base(produtoRepository)
        {
            _produtoRepository = produtoRepository;

        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.GetByName(nome);
        }
    }
}
