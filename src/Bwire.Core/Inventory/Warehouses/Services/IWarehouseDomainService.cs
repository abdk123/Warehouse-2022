using Abp.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bwire.Inventory.Warehouses.Services
{
    public interface IWarehouseDomainService : IDomainService
    {
        Task<IList<Warehouse>> GetAllAsync();
        Task<Warehouse> GetByIdAsync(long id);
        Warehouse GetById(long id);
        Task<Warehouse> CreateAsync(Warehouse warehouse);
        Task<Warehouse> UpdateAsync(Warehouse warehouse);
        Task DeleteAsync(long id);
    }
}
