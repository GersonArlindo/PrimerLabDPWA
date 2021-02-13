using LabUno.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LabUno.Data.interfaces
{
    public interface ILibroRepository : IRepository<Libro>
    {
        object Libros { get; }

        void DeleteDisponible();
        Task SaveChangesAsync();
    }
}
