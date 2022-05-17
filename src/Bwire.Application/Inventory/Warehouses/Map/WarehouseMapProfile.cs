using AutoMapper;
using Bwire.Inventory.Warehouses.Dto;

namespace Bwire.Inventory.Warehouses.Map
{
    public class WarehouseMapProfile: Profile
    {
        public WarehouseMapProfile()
        {
            CreateMap<Warehouse, WarehouseDto>();
            CreateMap<CreateWarehouseDto, Warehouse>();
            CreateMap<Warehouse, CreateWarehouseDto>();
            CreateMap<UpdateWarehouseDto, Warehouse>();
            CreateMap<Warehouse, UpdateWarehouseDto>();
        }
    }
}
