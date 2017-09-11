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
    public class ProjetoAppService : AppServiceBase<Projeto>, IProjetoAppService
    {
        private readonly IProjetoService _projetoService;
        public ProjetoAppService(IProjetoService projetoService) : base(projetoService)
        {
            _projetoService = projetoService;
        }
    }
}
