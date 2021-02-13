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
    public class EditarLibroModel : PageModel
    {
        private readonly ILibroRepository _libroRepository;

        public EditarLibroModel(ILibroRepository libroRepository)
        {
            _libroRepository = libroRepository;
        }

        [BindProperty]
        public Libro Libro { get; set; }
        public IActionResult OnGet(int id)
        {
            Libro = _libroRepository.GetById(id);
            if(Libro == null)
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
            var libroToUpdate = _libroRepository.GetById(id);
            if(libroToUpdate == null)
            
                return NotFound();

            libroToUpdate.Isbn = Libro.Isbn;
            libroToUpdate.Titulo = Libro.Titulo;
            libroToUpdate.Autor = Libro.Autor;
            libroToUpdate.Editorial = Libro.Editorial;
            libroToUpdate.Disponible = Libro.Disponible;

            _libroRepository.Update(libroToUpdate);
            return RedirectToPage("./Libros");
        }
    }
}
