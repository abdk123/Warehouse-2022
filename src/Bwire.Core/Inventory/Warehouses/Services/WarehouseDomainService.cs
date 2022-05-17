using Abp.Domain.Repositories;
using Bwire.Inventory.Warehouses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bwire.Inventory.Warehouses.Services
{
    public class WarehouseDomainService : IWarehouseDomainService
    {
        private readonly IRepository<Warehouse, long> _warehouseRepository;

        public WarehouseDomainService(IRepository<Warehouse, long> warehouseRepository)
        {
            _warehouseRepository = warehouseRepository;
        }

        public async Task<Warehouse> CreateAsync(Warehouse warehouse)
        {
            var id = await _warehouseRepository.InsertAndGetIdAsync(warehouse);
            return await _warehouseRepository.GetAsync(id);
        }

        public async Task DeleteAsync(long id)
        {
            var warehouse = await _warehouseRepository.GetAsync(id);
            if (warehouse != null)
                await _warehouseRepository.DeleteAsync(warehouse);
        }

        public async Task<IList<Warehouse>> GetAllAsync()
        {
            return await _warehouseRepository.GetAllListAsync();
        }

        public Warehouse GetById(long id)
        {
            return _warehouseRepository.Get(id);
        }

        public async Task<Warehouse> GetByIdAsync(long id)
        {
            return await _warehouseRepository.GetAsync(id);
        }

        public async Task<Warehouse> UpdateAsync(Warehouse warehouse)
        {
            return await _warehouseRepository.UpdateAsync(warehouse);
        }
    }
}
