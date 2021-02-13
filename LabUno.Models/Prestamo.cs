using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LabUno.Models
{
    public class Prestamo : EntityBase
    {
        [Required(ErrorMessage = "El campo CodigoEstudiante no puede estar vacio.")]
        [MinLength(5, ErrorMessage = "El CodigoEstudiante no puede tener menos de 5 caracteres")]
        [MaxLength(10, ErrorMessage = "El CodigoEstudiante no puede tener mas de 10 caracteres")]
        [Display(Name = "Codigo del Estudiante")]
        public string CodigoEstudiante { get; set; }
        [Required(ErrorMessage = "El campo CodigoLibro no puede estar vacio.")]
        [Display(Name = "Codigo del Libro")]
        public string CodigoLibro { get; set; }
        [Required(ErrorMessage = "El campo Fecha no puede estar vacio.")]
        [Display(Name = "Fecha de Prestamo")]
        public DateTime Fecha { get; set; }

    }
}
