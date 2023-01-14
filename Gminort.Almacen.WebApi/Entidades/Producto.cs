using System.ComponentModel.DataAnnotations;

namespace Gminort.Almacen.WebApi.Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(90)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(500)]
        public string Descripcion { get; set; }
        [Required]     
        public int Cantidad { get; set;}
    }
}
