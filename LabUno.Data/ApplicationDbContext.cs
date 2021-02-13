using LabUno.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabUno.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }
            public DbSet<Libro> Libros { get; set; }
            public DbSet<Estudiante> Estudiantes { get; set; }
            public DbSet<Prestamo> Prestamos { get; set; }

    }
}
