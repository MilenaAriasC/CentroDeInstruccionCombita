using CentroDeInstruccionCombita.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CentroDeInstruccionCombita.DataLayer
{
    public class CiudadDL
    {
        public ConexionBD Bd { get; set; }
        public SqlCommand  cmd { get; set; }

        public CiudadDL() // constructor
        {
            Bd = new ConexionBD();
        }//fin constructor 

        public List<Ciudad> Listar()
        {
            List<Ciudad> listCiudad= new List<Ciudad>();

            Bd.Cnx.Open();
            cmd = new SqlCommand("Select * From Ciudad", Bd.Cnx);
            SqlDataReader rs;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                Ciudad ciu = new Ciudad();
                ciu.IdCiudad = Convert.ToInt32(rs["IdCiudad"]);
                ciu.Nombre = rs["Nombre"].ToString();
                ciu.Departamento.IdDepartamento = Convert.ToInt32(rs["IdDepartamento"]);
                ciu.Departamento.Nombre = rs["Nombre"].ToString();
                ciu.IdDepartamento = Convert.ToInt32(rs["IdDepartamento"]);
                listCiudad.Add(ciu);


            }//fin while
            Bd.Cnx.Close();
            return listCiudad;



        }// Fin Listar 




    }
}// fin namespace