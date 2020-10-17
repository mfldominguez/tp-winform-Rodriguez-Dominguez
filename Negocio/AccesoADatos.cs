using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class AccesoADatos
    {
        public SqlConnection conexion { get; set; }
        public SqlCommand comando { get; set; }
        public SqlDataReader lector { get; set; }

        public AccesoADatos()
        {
           // conexion = new SqlConnection("data source = DESKTOP-I7DTO75\\SQLEXPRESS01 ; initial catalog = CATALOGO_DB ; integrated security = sspi");
            conexion = new SqlConnection("data source=DESKTOP-EEH48JR\\SQLEXPRESS; initial catalog= CATALOGO_DB ; integrated security= sspi");

            comando = new SqlCommand();

            comando.Connection = conexion;

        }

        public void SetearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;

        }

        public void EjecutarLector()
        {
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void CerrarConexion()
        {
            conexion.Close();
        }

        public void AgregarParametros(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);

        }

        public void EjecutarAccion()
        {
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}