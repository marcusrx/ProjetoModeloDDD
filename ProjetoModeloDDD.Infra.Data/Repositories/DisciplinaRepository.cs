using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repositories;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class DisciplinaRepository : RepositoryBase<Disciplina>, IDisciplinaRepository
    {
    }
}
