using CentroDeInstruccionCombita.DataLayer;
using CentroDeInstruccionCombita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentroDeInstruccionCombita.BussinesLayer
{
    public class CiudadBL
    {
        public CiudadDL ciudadDL = new CiudadDL();
        public List<Ciudad> listar()
        {
            return ciudadDL.Listar();
        } //fin listar
    }
}