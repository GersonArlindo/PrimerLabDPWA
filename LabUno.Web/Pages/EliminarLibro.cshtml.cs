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
    public class EliminarLibroModel : PageModel
    {
        private readonly ILibroRepository _libroRepository;

        public EliminarLibroModel(ILibroRepository libroRepository)
        {
            _libroRepository = libroRepository;
        }

        [BindProperty]
        public Libro Libro { get; set; }
        public IActionResult OnGet(int id)
        {
            Libro = _libroRepository.GetById(id);
            if (Libro == null)
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
            var libroToDelete = _libroRepository.GetById(id);
            if (libroToDelete == null)

                return NotFound();
            libroToDelete.Isbn = Libro.Isbn;
            libroToDelete.Titulo = Libro.Titulo;
            libroToDelete.Autor = Libro.Autor;
            libroToDelete.Editorial = Libro.Editorial;
            libroToDelete.Disponible = Libro.Disponible;

            _libroRepository.Delete(libroToDelete);
            return RedirectToPage("./Libros");
        }
    }
}
