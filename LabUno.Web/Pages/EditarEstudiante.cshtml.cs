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
    public class EditarEstudianteModel : PageModel
    {
        private readonly IEstudianteRepository _estudianteRepository;

        public EditarEstudianteModel(IEstudianteRepository estudianteRepository)
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
            var estudianteToUpdate = _estudianteRepository.GetById(id);
            if (estudianteToUpdate == null)

                return NotFound();

            estudianteToUpdate.Codigo = Estudiante.Codigo;
            estudianteToUpdate.Nombre = Estudiante.Nombre;
            estudianteToUpdate.Apellido = Estudiante.Apellido;
            estudianteToUpdate.Direccion = Estudiante.Direccion;

            _estudianteRepository.Update(estudianteToUpdate);
            return RedirectToPage("./Estudiantes");
        }
    }
}
