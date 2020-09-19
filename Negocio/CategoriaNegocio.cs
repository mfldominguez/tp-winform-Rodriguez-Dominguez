using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> ListarCategorias()
        {
            List<Categoria> Lista = new List<Categoria>();
            AccesoADatos datos = new AccesoADatos();
            Categoria categoria;

            try
            {
                datos.SetearConsulta("select * from CATEGORIAS");
                datos.EjecutarLector();

                while (datos.lector.Read())
                {
                    categoria = new Categoria();

                    categoria.Descripcion = datos.lector["Descripcion"].ToString();
                    categoria.Id = datos.lector.GetInt32(0);

                    Lista.Add(categoria);

                }

                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
