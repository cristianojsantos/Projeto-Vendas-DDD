using System.Collections.Generic;

namespace Vendas.Application.Interface
{
    public interface IApplicationBase<TEntity> where TEntity: class
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
