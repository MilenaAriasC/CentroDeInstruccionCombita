using CentroDeInstruccionCombita.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CentroDeInstruccionCombita.DataLayer
{
    public class DepartamentoDL
    {
        public ConexionBD Bd { get; set; }
        public SqlCommand cmd { get; set; }

        public DepartamentoDL()// constructor
        {
            Bd = new ConexionBD();
        } // fin constructor
        public List<Departamento> Listar()
        {
            List<Departamento> listDepartamento = new List<Departamento>();
            Bd.Cnx.Open();
            cmd = new SqlCommand("Select* From Departamento", Bd.Cnx);
            SqlDataReader rs;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                Departamento dep = new Departamento();
                dep.IdDepartamento = Convert.ToInt32(rs["IdDepartamento"]);
                dep.Nombre = rs["Nombre"].ToString();
                listDepartamento.Add(dep);

            }//FIN WHILE 
            Bd.Cnx.Close();
            return listDepartamento;




        }




        }
    }//Fin  namespace
