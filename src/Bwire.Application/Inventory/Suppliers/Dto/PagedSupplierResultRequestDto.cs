using Abp.Application.Services.Dto;

namespace Bwire.Inventory.Suppliers.Dto
{
    public class PagedSupplierResultRequestDto: PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
