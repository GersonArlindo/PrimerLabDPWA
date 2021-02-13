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
    public class PrestamosModel : PageModel
    {
        private readonly IPrestamoRepository _prestamoRepository;

        public PrestamosModel(IPrestamoRepository prestamoRepository)
        {
            _prestamoRepository = prestamoRepository;
        }

        [BindProperty]
        public IEnumerable<Prestamo> Prestamos { get; set; }

        public IActionResult OnGet()
        {
            Prestamos = _prestamoRepository.List();
            return Page();
        }
    }
}
