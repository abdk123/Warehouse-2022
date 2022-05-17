using Bwire.Inventory.Warehouses.Dto;
using Bwire.Inventory.Warehouses.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bwire.Inventory.Warehouses
{
    public class WarehouseAppService : BwireAppServiceBase, IWarehouseAppService
    {
        private readonly IWarehouseDomainService _warehouseDomainService;

        public WarehouseAppService(IWarehouseDomainService warehouseDomainService)
        {
            _warehouseDomainService = warehouseDomainService;
        }

        
        public async Task<CreateWarehouseDto> CreateAsync(CreateWarehouseDto dto)
        {
            var warehouse = ObjectMapper.Map<Warehouse>(dto);
            var createdWarehouse = await _warehouseDomainService.CreateAsync(warehouse); 
            return ObjectMapper.Map<CreateWarehouseDto>(createdWarehouse);
        }

        public async Task DeleteAsync(long id)
        {
            await _warehouseDomainService.DeleteAsync(id);
        }

        public async Task<IList<WarehouseDto>> GetAllAsync()
        {
            var warehouses = await _warehouseDomainService.GetAllAsync();
            return ObjectMapper.Map<IList<WarehouseDto>>(warehouses);
        }

        public WarehouseDto GetWarehouseById(long id)
        {
            var warehouse = _warehouseDomainService.GetById(id);
            return ObjectMapper.Map<WarehouseDto>(warehouse);
        }

        public async Task<WarehouseDto> GetByIdAsync(long id)
        {
           var warehouse = await _warehouseDomainService.GetByIdAsync(id);
            return ObjectMapper.Map<WarehouseDto>(warehouse);
        }

        public async Task<UpdateWarehouseDto> UpdateAsync(UpdateWarehouseDto dto)
        {
            var warehouse = await _warehouseDomainService.GetByIdAsync(dto.Id);
            ObjectMapper.Map<UpdateWarehouseDto, Warehouse>(dto, warehouse);

            var updatedWarehouse = await _warehouseDomainService.UpdateAsync(warehouse);
            return ObjectMapper.Map<UpdateWarehouseDto>(updatedWarehouse);
        }
    }
}
