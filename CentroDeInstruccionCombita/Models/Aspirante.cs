using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CentroDeInstruccionCombita.Models
{
    public class Aspirante
    {
        //[DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:dd/MM/yyyy}")]//Nos permite mostrar solo la fecha

        public int IdAspirante { get; set; }
        public String PrimerApellido { get; set; }
        public String SegundoApellido { get; set; }
        public String PrimerNombre { get; set; }
        public String SegundoNombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String NumeroDocumento { get; set; }
        public DateTime FechaExpedicion { get; set; }
        public String DireccionResidencia { get; set; }
        public String Barrio { get; set; }
        public String CorreoElectronico { get; set; }
        public String TelefonoFijo1 { get; set; }
        public String TelefonoFijo2 { get; set; }
        public String TelefonoCelular { get; set; }
        public String GrupoSanguineo { get; set; }
        public String FactorRh { get; set; }
        public String Estatura { get; set; }
        public String Peso { get; set; }
        public String Eps { get; set; }
        public String NumeroHijo { get; set; }
        public String SerColombiano { get; set; }
        public String SerBachiller { get; set; }
        public String RegistroCivil { get; set; }
        public String Soltero { get; set; }
        public String CarnetEps { get; set; }
        public String ObservadorDecimoOnce { get; set; }
        public String CertificadoFenix { get; set; }
        public String LeyExento { get; set; }
        public Ciudad Ciudad { get; set; }
        public int IdCiudad { get; set; }

        public Aspirante ()
        {
            Ciudad = new Ciudad();
        }


        /*public String documento { get; set; }
         public Programa programa { get; set; }//asociacion equivalente a la foranea
         public int IdPrograma { get; set; }
         public Aprendiz()
         {
             programa = new Programa(); //SI NO SE INSTANCIA EL VALOR SERA NULO EN POCAS PALABRAS EN LA FORANEA
         }*/
    }
}