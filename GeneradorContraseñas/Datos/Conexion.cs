using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GeneradorContraseñas.Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private static Conexion Con = null;

        //Constructor

        private Conexion()
        {
            this.Servidor = ".\\SQLEXPRESS"; /*Servidor local*/
            this.Base = "DBGenCon";
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();

            try
            {
                Cadena.ConnectionString = $"Data Source={this.Servidor}; Initial Catalog={this.Base}; Integrated Security=True";

            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }

            return Cadena;
        }

        public static Conexion crearInstancia() 
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }

    }
}
