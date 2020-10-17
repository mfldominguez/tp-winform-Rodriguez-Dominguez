using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominios;
using Negocio;

namespace Vieew
{
    public partial class Detalles : System.Web.UI.Page
    {
        public Articulo articulo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            List<Articulo> lista;

            try
            {
                lista = articuloNegocio.Listar();
                string codigo = Request.QueryString["cArt"];
                articulo = lista.Find(A => A.CodArt == codigo);
                lblPrecio.Text = articulo.Precio.ToString("F2");
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }

        }

        protected void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            if (txtBoxCantidad.Text == "" ||
                !int.TryParse(txtBoxCantidad.Text, out int result))
            {
                lblCompletar.Visible = true;
            }
            else
            {

                CarritoNegocio carritoNegocio = new CarritoNegocio();
                Carrito item = new Carrito();
                List<Carrito> listaCarrito = new List<Carrito>();

                item = carritoNegocio.AgregarItem(articulo);
                item.Cantidad = Convert.ToInt32(txtBoxCantidad.Text);

                if (Session["listaCarrito"] != null)
                {
                    listaCarrito = (List<Carrito>)Session["listaCarrito"];
                    Session["listaCarrito"] = carritoNegocio.CargarLista(listaCarrito, item);
                }
                else
                {
                    listaCarrito.Add(item);
                    Session["listaCarrito"] = listaCarrito;
                }
                Response.Redirect("Home.aspx");
            }
        }

        protected void btnVolverAlCatalogo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Articulos.aspx");
        }
    }
}