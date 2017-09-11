using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoModelo.Domain.Interfaces.Services;
using ProjetoModelo.Domain.Interfaces.Repositories;


namespace ProjetoModelo.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;
        
        /// <summary>
        /// Construtor para realizar a injeção de dependência do repositonio no Serviço
        /// </summary>
        /// <param name="repository"></param>
        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        #region IMPLEMENTAÇÕES DO iServiceBase<T>
        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public TEntity GetByID(int ID)
        {
            return _repository.GetByID(ID);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
        #endregion

    }
}
