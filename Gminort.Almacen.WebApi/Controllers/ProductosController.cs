using AutoMapper;
using Gminort.Almacen.WebApi.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gminort.Almacen.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ProductosController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductoDto>>> Listar() 
        {
            var productos = await context.Productos.ToListAsync();
            var productosDto = mapper.Map<List<ProductoDto>>(productos);

            return productosDto;
        }
    }
}
