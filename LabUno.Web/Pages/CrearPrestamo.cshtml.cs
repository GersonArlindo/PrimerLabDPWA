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
    public class CrearPrestamoModel : PageModel
    {
        private readonly IPrestamoRepository _prestamoRepository;

        public CrearPrestamoModel(IPrestamoRepository prestamoRepository)
        {
            _prestamoRepository = prestamoRepository;
        }
        [BindProperty]
        public Prestamo Prestamo { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _prestamoRepository.Insert(Prestamo);
            return RedirectToPage("./Prestamos");
        }
    }
}
