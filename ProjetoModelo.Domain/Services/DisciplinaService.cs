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
    public class DisciplinaService : ServiceBase<Disciplina>, IDisciplinaService
    {
        private readonly IDisciplinaRepository _disciplinaRepository;

        public DisciplinaService(IDisciplinaRepository disciplinaRepository)
            : base(disciplinaRepository)
        {
            _disciplinaRepository = disciplinaRepository;
        }
    }
}
