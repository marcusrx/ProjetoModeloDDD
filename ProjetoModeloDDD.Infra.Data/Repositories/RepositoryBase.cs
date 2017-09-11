using ProjetoModelo.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected ProjetoModeloContext Db = new ProjetoModeloContext();

        #region IMPLEMENTAÇÕES DA IRepositoryBase
        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);

            //Sem o design pattern "Unit of Work"
            Db.SaveChanges();
        }

        public TEntity GetByID(int ID)
        {
            return Db.Set<TEntity>().Find(ID);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }



        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion IMPLEMENTAÇÕES DA IRepositoryBase


        /// <summary>
        /// GetAll ignorando o lazy load
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TEntity> GetAllasNoTracking()
        {
            return Db.Set<TEntity>().AsNoTracking().ToList();
        }
    }
}
