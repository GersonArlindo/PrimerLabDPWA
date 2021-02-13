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
    public class CrearLibroModel : PageModel
    {
        private readonly ILibroRepository _libroRepository;

        public CrearLibroModel(ILibroRepository libroRepository)
        {
            _libroRepository = libroRepository;
        }
        [BindProperty]
        public Libro Libro { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _libroRepository.Insert(Libro);
            return RedirectToPage("./Libros");
        }
    }
}
