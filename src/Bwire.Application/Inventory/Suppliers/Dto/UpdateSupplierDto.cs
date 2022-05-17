using Abp.Application.Services.Dto;

namespace Bwire.Inventory.Suppliers.Dto
{
    public class UpdateSupplierDto : EntityDto<long>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long? TypeId { get; set; }
        public long? CountryId { get; set; }
        public long? CityId { get; set; }
        public long? AreaId { get; set; }
    }
}
