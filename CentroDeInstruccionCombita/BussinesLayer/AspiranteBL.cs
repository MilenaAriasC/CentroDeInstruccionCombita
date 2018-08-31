using CentroDeInstruccionCombita.DataLayer;
using CentroDeInstruccionCombita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentroDeInstruccionCombita.BussinesLayer
{
    public class AspiranteBL
    {
        public AspiranteDL aspirantedl = new AspiranteDL();
        public List<Aspirante> listar()
        {
            return aspirantedl.Listar();
        }//fin listar
        public void guardar(Aspirante aspirante)
        {
            aspirantedl.Guardar(aspirante);
        }//fin guardar
        public void actualizar(Aspirante aspirante)
        {
            aspirantedl.Actualizar(aspirante);
        }//fin actualizar

        public void eliminar(int IdAspirante)
        {
            aspirantedl.Eliminar(IdAspirante);
        }//fin eliminar
        public Aspirante buscar (int IdAspirante)
        {
            return aspirantedl.Buscar(IdAspirante);
        }
       internal void guardar (object aspirante)
        {
            throw new NotFiniteNumberException();
        }
    }// fin de la clase
}// fin del namespace