using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentroDeInstruccionCombita.Models
{
    public class Ciudad
    {
        public int IdCiudad { get; set; }
        public String Nombre { get; set; }
        public Departamento Departamento { get; set; }
        public int IdDepartamento { get; set; }

        public Ciudad ()
        {
            Departamento = new Departamento();

        }
    }
}