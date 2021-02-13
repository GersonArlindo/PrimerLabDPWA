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
    public class EliminarPrestamoModel : PageModel
    {
        private readonly IPrestamoRepository _prestamoRepository;

        public EliminarPrestamoModel(IPrestamoRepository prestamoRepository)
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
            var prestamoToDelete = _prestamoRepository.GetById(id);
            if (prestamoToDelete == null)

                return NotFound();

            prestamoToDelete.CodigoEstudiante = Prestamo.CodigoEstudiante;
            prestamoToDelete.CodigoLibro = Prestamo.CodigoLibro;
            prestamoToDelete.Fecha = Prestamo.Fecha;

            _prestamoRepository.Delete(prestamoToDelete);
            return RedirectToPage("./Prestamos");
        }
    }
}
