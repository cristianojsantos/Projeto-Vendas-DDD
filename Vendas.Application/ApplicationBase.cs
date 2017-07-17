using System.Collections.Generic;
using Vendas.Application.Interface;
using Vendas.Service.Interface;

namespace Vendas.Application
{
    public class ApplicationBase<TEntity> : IApplicationBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _service;

        public ApplicationBase(IServiceBase<TEntity> repository)
        {
            _service = repository;
        }

        public void Add(TEntity obj)
        {
            _service.Add(obj);
        }

        public void Dispose()
        {
            _service.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _service.GetAll();
        }

        public IEnumerable<TEntity> GetAllAsNoTracking()
        {
            return _service.GetAllAsNoTracking();
        }

        public TEntity GetById(int id)
        {
            return _service.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _service.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _service.Update(obj);
        }
    }
}
