using Bwire.Inventory.Indexes;
using Bwire.Shared;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bwire.Inventory.Suppliers
{
    public class Supplier : BwireEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }


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
