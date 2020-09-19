using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> Lista = new List<Articulo>();
            AccesoADatos Datos = new AccesoADatos();
            Articulo Articulo;

            try
            {
                Datos.SetearConsulta("select A.Id , A.Codigo , A.Nombre , A.Descripcion , M.Id ," +
                                     "C.Id , A.ImagenURL , A.Precio , C.Descripcion AS Categoria , M.Descripcion AS Marca" +
                                     " from Articulos AS A inner join Categorias AS C ON A.IdCategoria = C.Id " +
                                     "inner join Marcas AS M ON A.IdMarca = M.Id");
                Datos.EjecutarLector();

                while (Datos.lector.Read())
                {
                    Articulo = new Articulo();

                    Articulo.Id = Datos.lector.GetInt32(0);
                    Articulo.CodArt = Datos.lector.GetString(1);
                    Articulo.Nombre = Datos.lector["Nombre"].ToString();
                    Articulo.Descripcion = Datos.lector["Descripcion"].ToString();
                    Articulo.Marca = new Marca();
                    Articulo.Marca.Id = Datos.lector.GetInt32(4);
                    Articulo.Marca.Descripcion = Datos.lector["Marca"].ToString();
                    Articulo.Categoria = new Categoria();
                    Articulo.Categoria.Id = Datos.lector.GetInt32(5);
                    Articulo.Categoria.Descripcion = Datos.lector["Categoria"].ToString();
                    Articulo.ImagenURL = Datos.lector["ImagenURL"].ToString();
                    Articulo.Precio = Datos.lector.GetDecimal(7);

                    Lista.Add(Articulo);

                }

                return Lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }
        public void eliminar(int id)
        {
            AccesoADatos datos = new AccesoADatos();
            try
            {
                datos.SetearConsulta("delete from articulos where id =" + id);
                datos.EjecutarAccion();

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
        public void modificar(Articulo articulo)
        {
            AccesoADatos datos = new AccesoADatos();

            try
            {

                datos.SetearConsulta("update ARTICULOS set Codigo = @Codigo , Nombre = @Nombre , Descripcion = @Descripcion , Idmarca = @Idmarca , IdCategoria = @IdCategoria , ImagenURL = @ImagenURL , Precio = @Precio where Id = @Id");
                datos.comando.Parameters.Clear();
                datos.comando.Parameters.AddWithValue("@Codigo", articulo.CodArt);
                datos.comando.Parameters.AddWithValue("@Nombre", articulo.Nombre);
                datos.comando.Parameters.AddWithValue("@Descripcion", articulo.Descripcion);
                datos.comando.Parameters.AddWithValue("@IdMarca", articulo.Marca.Id);
                datos.comando.Parameters.AddWithValue("@IdCategoria", articulo.Categoria.Id);
                datos.comando.Parameters.AddWithValue("@ImagenURL", articulo.ImagenURL);
                datos.comando.Parameters.AddWithValue("@Precio", articulo.Precio);
                datos.comando.Parameters.AddWithValue("@Id", articulo.Id);

                datos.EjecutarAccion();

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
        public void agregar(Articulo articulo)
        {
            AccesoADatos datos = new AccesoADatos();
            try
            {
                datos.SetearConsulta("insert into ARTICULOS values ( @Codigo , @Nombre , @Descripcion , @Idmarca , @IdCategoria , @ImagenURL , @Precio )");
                datos.comando.Parameters.Clear();
                datos.AgregarParametros("@Codigo", articulo.CodArt);
                datos.AgregarParametros("@Nombre", articulo.Nombre);
                datos.AgregarParametros("@Descripcion", articulo.Descripcion);
                datos.AgregarParametros("@IdMarca", articulo.Marca.Id);
                datos.AgregarParametros("@IdCategoria", articulo.Categoria.Id);
                datos.AgregarParametros("@ImagenURL", articulo.ImagenURL);
                datos.AgregarParametros("@Precio", articulo.Precio);
                datos.EjecutarAccion();

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