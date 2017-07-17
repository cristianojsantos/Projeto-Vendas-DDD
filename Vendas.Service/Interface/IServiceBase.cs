using System.Collections.Generic;

namespace Vendas.Service.Interface
{
    public interface IServiceBase<TEntity> where TEntity: class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAllAsNoTracking();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
