using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LabUno.Data.interfaces;
using LabUno.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LabUno.Web.Pages
{
    public class EliminarEstudianteModel : PageModel
    {
        private readonly IEstudianteRepository _estudianteRepository;

        public EliminarEstudianteModel(IEstudianteRepository estudianteRepository)
        {
            _estudianteRepository = estudianteRepository;
        }

        [BindProperty]
        public Estudiante Estudiante { get; set; }
        public IActionResult OnGet(int id)
        {
            Estudiante = _estudianteRepository.GetById(id);
            if (Estudiante == null)
            {
                return NotFound();
            }
            return Page();
        }
        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var estudianteToDelete = _estudianteRepository.GetById(id);
            if (estudianteToDelete == null)

                return NotFound();
            estudianteToDelete.Codigo = Estudiante.Codigo;
            estudianteToDelete.Nombre = Estudiante.Nombre;
            estudianteToDelete.Apellido = Estudiante.Apellido;
            estudianteToDelete.Direccion = Estudiante.Direccion;

            _estudianteRepository.Delete(estudianteToDelete);
            return RedirectToPage("./Estudiantes");
        }
    }
}
