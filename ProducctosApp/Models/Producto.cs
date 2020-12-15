using System;
using System.ComponentModel.DataAnnotations;
namespace ProducctosApp.Models
{
    public class Producto
    {
        public int Id {get; set;}
        [Required]  
        public string Nombre {get; set;}
        [Required] 
        public string Url {get; set;}
        [Required] 
        public string Descripcion {get; set;}
        [Required] 
        public int Precio {get; set;}
        [Required] 
        public string Celular {get; set;}
        public string Lugar {get; set;}
        [Required] 
        public string NombreUsuario {get; set;}

        [Required]
        public DateTime Fecha { get; set; }

    }
}