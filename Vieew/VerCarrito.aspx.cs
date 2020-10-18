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
    public partial class VerCarrito : System.Web.UI.Page
    {
        public List<Carrito> listaCarrito { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                CarritoNegocio carroNegocio = new CarritoNegocio();
                listaCarrito = new List<Carrito>();


                if (Session["userName"] != null)
                {
                    if (Session["listaCarrito"] != null)
                    {
                        listaCarrito = (List<Carrito>)Session["listaCarrito"];
                    }
                    else
                    {
                        Session["listaCarrito"] = listaCarrito;
                    }


                    if (listaCarrito.Count > 0)
                    {
                        lblCarritoVacio.Visible = false;
                        lblTextPrecio.Visible = true;
                        lblPrecioFinal.Visible = true;

                        if (Request.QueryString["cElim"] != null)
                        {
                            listaCarrito = carroNegocio.EliminarArticulo(listaCarrito, Request.QueryString["cElim"]);
                            Response.Redirect("VerCarrito.aspx");
                        }
                        else if (Request.QueryString["cArt"] != "")
                        {
                            listaCarrito = carroNegocio.ModificarCantidad(listaCarrito, Request.QueryString["cArt"], Request.QueryString["cant"]);
                            Response.Redirect("VerCarrito.aspx?cArt=&cant=");
                        }
                        lblPrecioFinal.Text = carroNegocio.SumarImporte(listaCarrito).ToString("F2");
                        Session["listaCarrito"] = listaCarrito;
                    }
                }
                else
                {
                    Response.Redirect("Session.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Articulos.aspx");
        }
    }
}