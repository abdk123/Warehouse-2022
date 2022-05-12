using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Bwire.Shared;

namespace Bwire.Inventory.Indexes
{
    public class IndexEntity : BwireEntity
    {
        public string Name { get; set; }
        public int Order { get; set; }
    }
}
