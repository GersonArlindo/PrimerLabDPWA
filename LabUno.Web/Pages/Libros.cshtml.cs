using LabUno.Data.Repositories;
using LabUno.Data.interfaces;
using LabUno.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace LabUno.Web.Pages
{
    public class LibrosModel : PageModel
    {
        private readonly ILibroRepository _libroRepository;

        public LibrosModel(ILibroRepository libroRepository)
        {
            _libroRepository = libroRepository;
        }

        [BindProperty]
        public IEnumerable<Libro> Libros { get; set; }

        public IActionResult OnGet()
        {
            //Libros = new List<Libro>();
            Libros = _libroRepository.List();
            return Page();
        }
    }
}
