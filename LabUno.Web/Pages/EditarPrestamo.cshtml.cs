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
    public class EditarPrestamoModel : PageModel
    {
        private readonly IPrestamoRepository _prestamoRepository;

        public EditarPrestamoModel(IPrestamoRepository prestamoRepository)
        {
            _prestamoRepository = prestamoRepository;
        }

        [BindProperty]
        public Prestamo Prestamo { get; set; }
        public IActionResult OnGet(int id)
        {
            Prestamo = _prestamoRepository.GetById(id);
            if (Prestamo == null)
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
            var prestamoToUpdate = _prestamoRepository.GetById(id);
            if (prestamoToUpdate == null)

                return NotFound();

            prestamoToUpdate.CodigoEstudiante = Prestamo.CodigoEstudiante;
            prestamoToUpdate.CodigoLibro = Prestamo.CodigoLibro;
            prestamoToUpdate.Fecha = Prestamo.Fecha;

            _prestamoRepository.Update(prestamoToUpdate);
            return RedirectToPage("./Prestamos");
        }
    }
}
