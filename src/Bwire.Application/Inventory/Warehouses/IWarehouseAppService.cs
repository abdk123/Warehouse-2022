using Abp.Application.Services;
using Bwire.Inventory.Warehouses.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bwire.Inventory.Warehouses
{
    public interface IWarehouseAppService : IApplicationService
    {
        Task<IList<WarehouseDto>> GetAllAsync();
        Task<WarehouseDto> GetByIdAsync(long id);
        WarehouseDto GetWarehouseById(long id);
        Task<CreateWarehouseDto> CreateAsync(CreateWarehouseDto warehouse);
        Task<UpdateWarehouseDto> UpdateAsync(UpdateWarehouseDto warehouse);
        Task DeleteAsync(long id);
    }
}
