using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LabUno.Models
{
    public class Estudiante : EntityBase
    {
        [Required(ErrorMessage = "El campo Codigo no puede estar vacio")]
        [Display(Name = "Codigo de Estudiante")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "El campo Nombre no puede estar vacio")]
        [Display(Name = "Nombre de Estudiante")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Apellido no puede estar vacio")]
        [Display(Name = "Apellido de Estudiante")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El campo Direccion no puede estar vacio")]
        [Display(Name = "Direccion de Estudiante")]
        [MaxLength(50)]
        public string Direccion { get; set; }
    }
}
