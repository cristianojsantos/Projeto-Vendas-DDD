using System.Collections.Generic;

namespace Vendas.Infra.Repository.Interface
{
    public interface IRepositoryBase<TEntity> where TEntity: class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAllAsNoTracking();
        void Update(TEntity obj);

        void Update(int id);
        void Remove(TEntity obj);

        void Remove(int id);
        void Dispose();
    }
}
