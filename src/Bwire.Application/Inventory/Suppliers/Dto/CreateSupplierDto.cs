using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bwire.Inventory.Suppliers.Dto
{
    public class CreateSupplierDto : EntityDto<long>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long? TypeId { get; set; }
        public long? CountryId { get; set; }
        public long? CityId { get; set; }
        public long? AreaId { get; set; }
    }
}
