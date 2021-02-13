using LabUno.Data.interfaces;
using LabUno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabUno.Data.Repositories
{
    public class EstudianteRepository : Repository<Estudiante>, IEstudianteRepository
    {
        private readonly ApplicationDbContext _db;
        public EstudianteRepository(ApplicationDbContext db) : base(db)
        {

        }

        public void DeleteCodigos()
        {
            
        }
    }
}
