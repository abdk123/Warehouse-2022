using AutoMapper;
using Bwire.Inventory.Suppliers.Dto;

namespace Bwire.Inventory.Suppliers.Map
{
    public class SupplierMapProfile : Profile
    {
        public SupplierMapProfile()
        {
            CreateMap<Supplier, SupplierDto>();
            CreateMap<CreateSupplierDto, Supplier>();
            CreateMap<Supplier, CreateSupplierDto>();
            CreateMap<UpdateSupplierDto, Supplier>();
            CreateMap<Supplier, UpdateSupplierDto>();
        }
    }
}
