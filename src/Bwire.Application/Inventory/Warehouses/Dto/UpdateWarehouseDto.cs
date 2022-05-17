using Abp.Application.Services.Dto;
using Bwire.Constrantes;
using System.ComponentModel.DataAnnotations;

namespace Bwire.Inventory.Warehouses.Dto
{
    public class UpdateWarehouseDto : EntityDto
    {
        [Required]
        [MaxLength(AppConst.SingleLineLength)]
        public string Name { get; set; }

        [MaxLength(AppConst.MultiLineLength)]
        public string Description { get; set; }
        public long? TypeId { get; set; }
        public long? CountryId { get; set; }
        public long? CityId { get; set; }
        public long? AreaId { get; set; }
    }
}
