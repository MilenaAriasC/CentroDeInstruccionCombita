﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CentroDeInstruccionCombita.DataLayer
{
    public class ConexionBD
    {
        public SqlConnection Cnx { get; set; }
        public ConexionBD()
        {
            Cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CSProyecto"].ToString());
        }
    }
}