using CentroDeInstruccionCombita.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CentroDeInstruccionCombita.DataLayer
{
    public class AspiranteDL
    {
        public ConexionBD Bd { get; set; }
        public SqlCommand cmd { get; set; }

        public AspiranteDL ()
        {
            Bd = new ConexionBD();
        }
        public List<Aspirante> Listar()
        {
            List<Aspirante> lAspirante = new List<Aspirante>();
            Bd.Cnx.Open();
           
            cmd = new SqlCommand("Select * from Aspirante asp, Ciudad c, Departamento d where asp.IdCiudad=c.IdCiudad and d.IdDepartamento=c.IdDepartamento ", Bd.Cnx);
            SqlDataReader rs;
            rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                Aspirante asp= new Aspirante();
                asp.IdAspirante = Convert.ToInt32(rs["IdAspirante"]);
                asp.PrimerApellido = rs["PrimerApellido"].ToString();
                asp.SegundoApellido = rs["SegundoApellido"].ToString();
                asp.PrimerNombre = rs["PrimerNombre"].ToString();
                asp.SegundoNombre = rs["SegundoNombre"].ToString();
                asp.FechaNacimiento = Convert.ToDateTime(rs["FechaNacimiento"]);
                asp.NumeroDocumento = rs["NumeroDocumento"].ToString();
                asp.FechaExpedicion = Convert.ToDateTime(rs["FechaExpedicion"]);
                asp.DireccionResidencia = rs["DireccionResidencia"].ToString();
                asp.Barrio = rs["Barrio"].ToString();
                asp.CorreoElectronico = rs["CorreoElectronico"].ToString();
                asp.TelefonoFijo1 = rs["TelefonoFijo1"].ToString();
                asp.TelefonoFijo2 = rs["TelefonoFijo2"].ToString();
                asp.TelefonoCelular = rs["TelefonoCelular"].ToString();
                asp.GrupoSanguineo = rs["GrupoSanguineo"].ToString();
                asp.FactorRh = rs["FactorRh"].ToString();
                asp.Estatura = rs["Estatura"].ToString();
                asp.Peso = rs["Peso"].ToString();
                asp.Eps = rs["Eps"].ToString();
                asp.NumeroHijo = rs["NumeroHijo"].ToString();
                asp.SerColombiano = rs["SerColombiano"].ToString();
                asp.SerBachiller = rs["SerBachiller"].ToString();
                asp.RegistroCivil = rs["RegistroCivil"].ToString();
                asp.Soltero = rs["Soltero"].ToString();
                asp.CarnetEps = rs["CarnetEps"].ToString();
                asp.ObservadorDecimoOnce = rs["ObservadorDecimoOnce"].ToString();
                asp.CertificadoFenix = rs["CertificadoFenix"].ToString();
                asp.LeyExento = rs["LeyExento"].ToString();
                asp.Ciudad.IdCiudad = Convert.ToInt32(rs["IdCiudad"]);
                asp.Ciudad.Nombre = rs["Nombre"].ToString();
                asp.IdCiudad = Convert.ToInt32(rs["IdCiudad"]);
                asp.Ciudad.Departamento.IdDepartamento = Convert.ToInt32(rs["IdDepartamento"]);
                asp.Ciudad.Departamento.Nombre = rs["Nombre"].ToString();
                lAspirante.Add(asp);

            }
            // CIERRE WHILE
            Bd.Cnx.Close();
            return lAspirante;

        }//fin de listar

         public Aspirante Buscar (int IdAspirante)
        {
            Bd.Cnx.Open();
            cmd = new SqlCommand("Select asp.IdAspirante, asp.PrimerApellido, asp.SegundoApellido,"+
                "asp.PrimerNombre, asp.SegundoNombre, asp.FechaNacimiento, asp.NumeroDocumento, asp.FechaExpedicion,"+
                "asp.DireccionResidencia, asp.Barrio, asp.CorreoElectronico, asp.TelefonoFijo1, asp.TelefonoFijo2, asp.TelefonoCelular,"+
                "asp.GrupoSanguineo, asp.FactorRh, asp.Estatura, asp.Peso, asp.Peso, asp.Eps, asp.NumeroHijo, asp.SerColombiano,"+
                "asp.SerBachiller, asp.RegistroCivil, asp.Soltero, asp.CarnetEps, asp.ObservadorDecimoOnce, asp.CertificadoFenix,"+
                "asp.LeyExento, c.IdCiudad, c.Nombre, d.IdDepartamento,"+
                "  d.Nombre from [Aspirante] asp, [Ciudad] c, Departamento d where asp.IdCiudad = c.IdCiudad and d.IdDepartamento = c.IdDepartamento AND asp.IdAspirante=" + IdAspirante, Bd.Cnx);
            SqlDataReader rs;
           rs = cmd.ExecuteReader();
            Aspirante asp = new Aspirante();
            while (rs.Read())
            {
                asp.IdAspirante = Convert.ToInt32(rs["IdAspirante"]);
                asp.PrimerApellido = rs["PrimerApellido"].ToString();
                asp.SegundoApellido = rs["SegundoApellido"].ToString();
                asp.PrimerNombre = rs["PrimerNombre"].ToString();
                asp.SegundoNombre = rs["SegundoNombre"].ToString();
                asp.FechaNacimiento = Convert.ToDateTime(rs["FechaNacimiento"]);
                asp.NumeroDocumento = rs["NumeroDocumento"].ToString();
                asp.FechaExpedicion = Convert.ToDateTime(rs["FechaExpedicion"]);
                asp.DireccionResidencia = rs["DireccionResidencia"].ToString();
                asp.Barrio = rs["Barrio"].ToString();
                asp.CorreoElectronico = rs["CorreoElectronico"].ToString();
                asp.TelefonoFijo1 = rs["TelefonoFijo1"].ToString();
                asp.TelefonoFijo2 = rs["TelefonoFijo2"].ToString();
                asp.TelefonoCelular = rs["TelefonoCelular"].ToString();
                asp.GrupoSanguineo = rs["GrupoSanguineo"].ToString();
                asp.FactorRh = rs["FactorRh"].ToString();
                asp.Estatura = rs["Estatura"].ToString();
                asp.Peso = rs["Peso"].ToString();
                asp.Eps = rs["Eps"].ToString();
                asp.NumeroHijo = rs["NumeroHijo"].ToString();
                asp.SerColombiano = rs["SerColombiano"].ToString();
                asp.SerBachiller = rs["SerBachiller"].ToString();
                asp.RegistroCivil = rs["RegistroCivil"].ToString();
                asp.Soltero = rs["Soltero"].ToString();
                asp.CarnetEps = rs["CarnetEps"].ToString();
                asp.ObservadorDecimoOnce = rs["ObservadorDecimoOnce"].ToString();
                asp.CertificadoFenix = rs["CertificadoFenix"].ToString();
                asp.LeyExento = rs["LeyExento"].ToString();
                asp.Ciudad.IdCiudad = Convert.ToInt32(rs["IdCiudad"]);
                asp.Ciudad.Nombre = rs["Nombre"].ToString();
                asp.IdCiudad = Convert.ToInt32(rs["IdCiudad"]);
                asp.Ciudad.Departamento.IdDepartamento = Convert.ToInt32(rs["IdDepartamento"]);
                asp.Ciudad.Departamento.Nombre = rs["Nombre"].ToString();
                

            }//fin del while buscar
            Bd.Cnx.Close();
            return asp;
        }// fin metodo buscar 
        public bool Guardar (Aspirante aspirante)
        {
            bool respuesta = false;
            Bd.Cnx.Open();
            cmd = new SqlCommand("Insert into Aspirante( PrimerApellido,SegundoApellido,PrimerNombre, SegundoNombre, FechaNacimiento, NumeroDocumento," +
               " FechaExpedicion,DireccionResidencia,Barrio, CorreoElectronico,TelefonoFijo1,TelefonoFijo2,TelefonoCelular,GrupoSanguineo,FactorRh,Estatura,Peso,Eps,NumeroHijo,SerColombiano,SerBachiller,RegistroCivil,"+
              " Soltero,CarnetEps,ObservadorDecimoOnce,CertificadoFenix,LeyExento,IdCiudad) values (@primerape,@segundoape,@primernom,@segundonom,"+
              "@fechanac,@documento,@fechaexpedicion,@dicresidencia,@barrio, @correo, @tel1,@tel2,@cel,@gruposan,@rh,@estatura,@peso,@eps,@hijos,@colombiano,@bachiller,"+
              "@registrocivil, @soltero, @carnet,@Observador,@fenix,@leyexento,@Idciud)", Bd.Cnx);
            cmd.Parameters.AddWithValue("@primerape",aspirante.PrimerApellido);
            cmd.Parameters.AddWithValue("@segundoape", aspirante.SegundoApellido);
            cmd.Parameters.AddWithValue("@primernom", aspirante.PrimerApellido);
            cmd.Parameters.AddWithValue("@segundonom", aspirante.SegundoNombre);
            cmd.Parameters.AddWithValue("@fechanac", aspirante.FechaNacimiento);
            cmd.Parameters.AddWithValue("@documento", aspirante.NumeroDocumento);
            cmd.Parameters.AddWithValue("@fechaexpedicion", aspirante.FechaExpedicion);
            cmd.Parameters.AddWithValue("@dicresidencia", aspirante.DireccionResidencia);
            cmd.Parameters.AddWithValue("@barrio", aspirante.Barrio);
            cmd.Parameters.AddWithValue("@correo", aspirante.CorreoElectronico);
            cmd.Parameters.AddWithValue("@tel1", aspirante.TelefonoFijo1);
            cmd.Parameters.AddWithValue("@tel2", aspirante.TelefonoFijo2);
            cmd.Parameters.AddWithValue("@cel", aspirante.TelefonoCelular);
            cmd.Parameters.AddWithValue("@gruposan",aspirante.GrupoSanguineo);
            cmd.Parameters.AddWithValue("@rh", aspirante.FactorRh);
            cmd.Parameters.AddWithValue("@estatura", aspirante.Estatura);
            cmd.Parameters.AddWithValue("@peso", aspirante.Peso);
            cmd.Parameters.AddWithValue("@eps", aspirante.Eps);
            cmd.Parameters.AddWithValue("@hijos", aspirante.NumeroHijo);
            cmd.Parameters.AddWithValue("@colombiano", aspirante.SerColombiano);
            cmd.Parameters.AddWithValue("@bachiller", aspirante.SerBachiller);
            cmd.Parameters.AddWithValue("@registrocivil", aspirante.RegistroCivil);
            cmd.Parameters.AddWithValue("@soltero", aspirante.Soltero);
            cmd.Parameters.AddWithValue("@carnet", aspirante.CarnetEps);
            cmd.Parameters.AddWithValue("@observador", aspirante.ObservadorDecimoOnce);
            cmd.Parameters.AddWithValue("@fenix", aspirante.CertificadoFenix);
            cmd.Parameters.AddWithValue("@leyexento", aspirante.LeyExento);
            cmd.Parameters.AddWithValue("@Idciud", aspirante.IdCiudad);
            cmd.ExecuteNonQuery();
            Bd.Cnx.Close();
            respuesta = true;
            return respuesta;
        

        }// fin metodo guardar 
        public bool Actualizar(Aspirante aspirante)
        {
            bool respuesta = false;
            Bd.Cnx.Open();
            cmd = new SqlCommand("Update Aspirante Set PrimerApellido= @primerape, SegundoApellido= @segundoape, PrimerNombre=@primernom, SegundoNombre=@segundonom,"+
                "FechaNacimiento=@fechanac, DireccionResidencia=@dicresidencia,Barrio=@barrio, CorreoElectronico=@correo, TelefonoFijo1=@tel1, TelefonoFijo2=@tel2, "+
                "TelefonoCelular=@cel, GrupoSanguineo=@gruposan, FactorRh=@rh, Estatura=@estatura, Peso=@peso, Eps=@eps, NumeroHijo=@hijos, SerColombiano=@colombiano," +
                "SerBachiller=@bachiller, RegistroCivil=@registrocivil, Soltero=@soltero, CarnetEps=@carnet, ObservadorDecimoOnce=@observador,"+
                "CertificadoFenix=@fenix, LeyExento=@leyexento, IdCiudad=@IdCiud where idAspirante="+aspirante.IdAspirante, Bd.Cnx);
            cmd.Parameters.AddWithValue("@primerape", aspirante.PrimerApellido);
            cmd.Parameters.AddWithValue("@segundoape", aspirante.SegundoApellido);
            cmd.Parameters.AddWithValue("@primernom", aspirante.PrimerApellido);
            cmd.Parameters.AddWithValue("@segundonom", aspirante.SegundoNombre);
            cmd.Parameters.AddWithValue("@fechanac", aspirante.FechaNacimiento);
            cmd.Parameters.AddWithValue("@documento", aspirante.NumeroDocumento);
            cmd.Parameters.AddWithValue("@fechaexpedicion", aspirante.FechaExpedicion);
            cmd.Parameters.AddWithValue("@dicresidencia", aspirante.DireccionResidencia);
            cmd.Parameters.AddWithValue("@barrio", aspirante.Barrio);
            cmd.Parameters.AddWithValue("@correo", aspirante.CorreoElectronico);
            cmd.Parameters.AddWithValue("@tel1", aspirante.TelefonoFijo1);
            cmd.Parameters.AddWithValue("@tel2", aspirante.TelefonoFijo2);
            cmd.Parameters.AddWithValue("@cel", aspirante.TelefonoCelular);
            cmd.Parameters.AddWithValue("@gruposan", aspirante.GrupoSanguineo);
            cmd.Parameters.AddWithValue("@rh", aspirante.FactorRh);
            cmd.Parameters.AddWithValue("@estatura", aspirante.Estatura);
            cmd.Parameters.AddWithValue("@peso", aspirante.Peso);
            cmd.Parameters.AddWithValue("@eps", aspirante.Eps);
            cmd.Parameters.AddWithValue("@hijos", aspirante.NumeroHijo);
            cmd.Parameters.AddWithValue("@colombiano", aspirante.SerColombiano);
            cmd.Parameters.AddWithValue("@bachiller", aspirante.SerBachiller);
            cmd.Parameters.AddWithValue("@registrocivil", aspirante.RegistroCivil);
            cmd.Parameters.AddWithValue("@soltero", aspirante.Soltero);
            cmd.Parameters.AddWithValue("@carnet", aspirante.CarnetEps);
            cmd.Parameters.AddWithValue("@observador", aspirante.ObservadorDecimoOnce);
            cmd.Parameters.AddWithValue("@fenix", aspirante.CertificadoFenix);
            cmd.Parameters.AddWithValue("@leyexento", aspirante.LeyExento);
            cmd.Parameters.AddWithValue("@Idciud", aspirante.IdCiudad);
            cmd.ExecuteNonQuery();
            Bd.Cnx.Close();
            respuesta = true;
            return respuesta;
        }//Fin Actualizar 

        public bool Eliminar(int IdAspirante)
        {
            bool respuesta = false;
            Bd.Cnx.Open();
            cmd = new SqlCommand("");
            cmd.Parameters.AddWithValue("@IdAspirante", IdAspirante);
            cmd.ExecuteNonQuery();
            Bd.Cnx.Close();
            respuesta = true;
            return respuesta;
        }//fin eliminar

    }//FIN CLASS ASPIRANTE
}//FIN NAMESPACE    
    