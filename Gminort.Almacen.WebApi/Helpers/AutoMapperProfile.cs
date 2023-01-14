using AutoMapper;
using Gminort.Almacen.WebApi.Dtos;
using Gminort.Almacen.WebApi.Entidades;

namespace Gminort.Almacen.WebApi.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Producto, ProductoDto>().ReverseMap();
        }
    }
}
