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
    public class DisciplinaAppService : AppServiceBase<Disciplina>, IDisciplinaAppService
    {
        private readonly IDisciplinaService _disciplinaService;

        public DisciplinaAppService(IDisciplinaService disciplinaService)
            : base(disciplinaService)
        {
            _disciplinaService = disciplinaService;
        }
    }
}
