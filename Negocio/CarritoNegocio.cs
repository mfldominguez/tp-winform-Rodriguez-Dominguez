using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominios;

namespace Negocio
{
    public class CarritoNegocio
    {
        public Carrito AgregarItem(Articulo articulo)
        {
            Carrito Carrito = new Carrito();

            Carrito.Codigo = articulo.CodArt;
            Carrito.Nombre = articulo.Nombre;
            Carrito.Precio = articulo.Precio;

            return Carrito;
        }

        public List<Carrito> CargarLista(List<Carrito> lista, Carrito item)
        {
            foreach (Carrito producto in lista)
            {
                if (producto.Codigo == item.Codigo)
                {
                    producto.Cantidad += item.Cantidad;
                    return lista;
                }
            }

            lista.Add(item);

            return lista;
        }

        public decimal SumarImporte(List<Carrito> listaCarrito)
        {
            decimal result = 0;

            foreach (Carrito item in listaCarrito)
            {
                result += item.Precio * item.Cantidad;
            }

            return result;
        }

        public List<Carrito> ModificarCantidad(List<Carrito> listaCarrito, string codigo, string operacion)
        {
            if (operacion == "resta")
            {
                foreach (var item in listaCarrito)
                {
                    if (item.Codigo == codigo)
                    {
                        if (item.Cantidad > 1)
                        {
                            item.Cantidad--;
                            if (item.Cantidad == 0)
                            {
                                listaCarrito = EliminarArticulo(listaCarrito, item.Codigo);
                                break;
                            }
                        }
                    }
                }
            }

            if (operacion == "suma")
            {
                foreach (var item in listaCarrito)
                {
                    if (item.Codigo == codigo)
                    {
                        item.Cantidad++;
                    }
                }
            }

            return listaCarrito;
        }

        public List<Carrito> EliminarArticulo(List<Carrito> listaCarrito, string codigo)
        {
            foreach (var item in listaCarrito)
            {
                if (item.Codigo == codigo)
                {
                    listaCarrito.Remove(item);
                    break;
                }
            }

            return listaCarrito;
        }
    }
}
