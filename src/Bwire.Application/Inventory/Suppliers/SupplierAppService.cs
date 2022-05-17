using Abp.Application.Services;
using Abp.Domain.Repositories;
using Bwire.Inventory.Suppliers.Dto;
using Bwire.Inventory.Suppliers.Services;
using System.Threading.Tasks;

namespace Bwire.Inventory.Suppliers
{
    public class SupplierAppService : AsyncCrudAppService<Supplier, SupplierDto, long, PagedSupplierResultRequestDto, CreateSupplierDto, UpdateSupplierDto>, ISupplierAppService
    {
        private readonly ISupplierDomainService _supplierDomainService;
        public SupplierAppService(IRepository<Supplier,long> repository,ISupplierDomainService supplierDomainService)
            :base(repository)
        {
            _supplierDomainService = supplierDomainService;
            
        }
       
    }
}
