﻿using LabUno.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabUno.Data.interfaces
{
    public interface IEstudianteRepository : IRepository<Estudiante>{

        void DeleteCodigos();
    }
}
