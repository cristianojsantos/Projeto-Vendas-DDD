using Vendas.Domain;
using Vendas.Infra.Repository.Interface;
using Vendas.Service.Interface;

namespace Vendas.Service
{
    public class SubCategoriaService : ServiceBase<SubCategoria>, ISubCategoriaService
    {
        private readonly ISubCategoriaRepository _repository;

        public SubCategoriaService(ISubCategoriaRepository repository)
            :base(repository)
        {
            _repository = repository;
        }
    }
}
