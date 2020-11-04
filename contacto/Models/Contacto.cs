using System.ComponentModel.DataAnnotations;
namespace contacto.Models
{
    public class Contacto
    {
        [Required]
        [Display(Name="nombre del producto")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name="precio del producto")]
        public int Precio { get; set; }

        [Required]
        public string Mensaje { get; set; }
    }
}