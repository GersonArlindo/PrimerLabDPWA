using LabUno.Data.interfaces;
using LabUno.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabUno.Data.Repositories
{
    public class PrestamoRepository : Repository<Prestamo>, IPrestamoRepository
    {
        private readonly ApplicationDbContext _db;
        public PrestamoRepository(ApplicationDbContext db) : base(db)
        {
        }

        public void DeleteRango()
        {
            throw new NotImplementedException();
        }
    }
}
