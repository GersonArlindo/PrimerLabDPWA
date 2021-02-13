using System.ComponentModel.DataAnnotations;

namespace LabUno.Models
{
    public class Libro : EntityBase
    {
        [Required(ErrorMessage = "El campo ISBN no puede estar vacio.")]
        [MinLength(5, ErrorMessage ="El ISBN no puede tener menos de 5 caracteres")]
        [MaxLength(10, ErrorMessage = "El ISBN no puede tener mas de 10 caracteres")]
        [Display(Name = "Codigo de Libro")]
        public string Isbn { get; set; }
        [Required(ErrorMessage = "El campo Titulo no puede estar vacio.")]
        [Display(Name = "Titulo de Libro")]
        public string Titulo { get; set; }
        [Display(Name = "Editorial de Libro")]
        public string Editorial { get; set; }
        [Display(Name = "Autor de Libro")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "Debe marcar una opcion.")]
        public bool Disponible { get; set; }
    }
}
