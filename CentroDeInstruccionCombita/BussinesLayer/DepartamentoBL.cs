using CentroDeInstruccionCombita.DataLayer;
using CentroDeInstruccionCombita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentroDeInstruccionCombita.BussinesLayer
{
    public class DepartamentoBL
    {
        public DepartamentoDL departamentoDL = new DepartamentoDL();
        public List<Departamento> List()
        {
            return departamentoDL.Listar();
        }
    }
}