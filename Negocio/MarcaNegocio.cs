using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> ListarMarcas()
        {
            List<Marca> Lista = new List<Marca>();
            AccesoADatos datos = new AccesoADatos();
            Marca marca;

            try
            {
                datos.SetearConsulta("select * from MARCAS");
                datos.EjecutarLector();

                while (datos.lector.Read())
                {
                    marca = new Marca();

                    marca.Descripcion = datos.lector["Descripcion"].ToString();
                    marca.Id = Convert.ToInt32(datos.lector["Id"].ToString());

                    Lista.Add(marca);

                }

                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
