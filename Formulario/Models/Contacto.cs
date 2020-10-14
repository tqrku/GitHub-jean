using System;
using System.ComponentModel.DataAnnotations;

namespace formulario.Models
{
    public class Contacto
    {


        [Required(ErrorMessage = "Por favor ingrese Nombre")]
        [Display(Name="Nombre")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Apellido")]
        [Display(Name="Apellido")]
        public String LastName { get; set; }
        
    
        public String Response { get; set; }


        
        
    }
}
