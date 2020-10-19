using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bono.Models
{
    [Table("t_bono")]
    public class Bonos
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Nombre")]
        [Display(Name="Nombre")]
         [Column("Name")]
        public String Name { get; set; }


        [Required(ErrorMessage = "Por favor ingrese Apellido")]
        [Display(Name="Apellido")]
        [Column("lastname")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su Distrito")]
        [Display(Name="Distrito")]
         [Column("distrito")]
        public String Distrito { get; set; }


        [Required(ErrorMessage = "Por favor ingrese su edad")]
        [Display(Name="Edad")]
         [Column("edad")]
        public String Edad { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el autor")]
        [Display(Name="Autor")]
         [Column("autor")]
        public String Autor { get; set; }


        [NotMapped]
        public String Response { get; set; }

    }
}