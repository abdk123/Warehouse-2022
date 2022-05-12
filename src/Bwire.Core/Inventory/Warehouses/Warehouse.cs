using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Bwire.Inventory.Indexes;
using Bwire.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bwire.Inventory.Warehouses
{
    public class Warehouse : BwireEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        #region Type
        public long? TypeId { get; set; }
        [ForeignKey("TypeId")]
        public virtual WarehouseType Type { get; set; }
        #endregion

        #region Country
        public long? CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
        #endregion

        #region City
        public long? CityId { get; set; }
        [ForeignKey("CityId")]
        public virtual City City { get; set; }
        #endregion

        #region Area
        public long? AreaId { get; set; }
        [ForeignKey("AreaId")]
        public virtual Area Area { get; set; }
        #endregion
    }
}
