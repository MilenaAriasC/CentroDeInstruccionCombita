using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CentroDeInstruccionCombita.DataLayer
{
    public class BachillerDL
    {
        public ConexionBD Bd { get; set; }
        public SqlCommand cmd { get; set; }

        public BachillerDL()
        {
            Bd = new ConexionBD();
        }
    }
}//Fin Namespace