#region

using Factory.StoreDomainModule.Entities;
using Repository.Pattern.Repositories;
using Service.Pattern;

#endregion

namespace Factory.StoreServicesModule.Services
{
    public interface IProductService : IService<SerialProduct>
    {
    }

    public class SerialProductService : Service<SerialProduct>, IProductService
    {
        public SerialProductService(IRepositoryAsync<SerialProduct> repository)
            : base(repository)
        {
        }
    }
}