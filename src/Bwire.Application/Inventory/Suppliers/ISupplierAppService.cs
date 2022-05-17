using Abp.Application.Services;
using Bwire.Inventory.Suppliers.Dto;

namespace Bwire.Inventory.Suppliers
{
    public interface ISupplierAppService: IAsyncCrudAppService<SupplierDto, long, PagedSupplierResultRequestDto,CreateSupplierDto,UpdateSupplierDto>
    {
    }
}
