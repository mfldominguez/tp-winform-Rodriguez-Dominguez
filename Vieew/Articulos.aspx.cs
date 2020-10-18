﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominios;
using Negocio;

namespace Vieew
{
    public partial class Articulos : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulos{ get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                ListaArticulos = negocio.Listar();
                if (!IsPostBack)
                {
                    if (Session[Session.SessionID + "userName"] != null)
                    {
                        lblBienvenida.Visible = true;
                        lblBienvenida.Text += Session[Session.SessionID + "userName"].ToString();
                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                if (IsPostBack)
                {
                    if (txtBuscar.Text != "")
                    {

                       ListaArticulos = ListaArticulos.FindAll(k => k.Nombre.ToLower().Contains(txtBuscar.Text.ToLower()));
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}