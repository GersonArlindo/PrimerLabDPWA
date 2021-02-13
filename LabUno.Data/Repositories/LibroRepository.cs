using LabUno.Data.interfaces;
using LabUno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabUno.Data.Repositories
{
    public class LibroRepository : Repository<Libro>, ILibroRepository
    {
        private readonly ApplicationDbContext _db;
        public LibroRepository(ApplicationDbContext db): base(db)
        {

        }

        public object Libros => throw new NotImplementedException();

        public void DeleteDisponible()
        {
           var disponibles = _db.Libros.Where(c => c.Disponible == true).ToList();
            _db.RemoveRange(disponibles);
            _db.SaveChanges();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
