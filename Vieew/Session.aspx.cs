using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vieew
{
    public partial class Session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] != null)
            {
                //CARTEL YA HA INICIADO SESION
                
                Response.Redirect("Articulos.aspx");

            }

        }
        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" && txtPass.Text == "")
            {
                lblCompletar.Visible = true;    
                lblFaltaPass.Visible = false;
                lblFaltaUser.Visible = false;
            }
            else if (txtUser.Text == "")
            {
                lblFaltaUser.Visible = true;
                lblCompletar.Visible = false;
            }
            else if (txtPass.Text == "")
            {
                lblFaltaPass.Visible = true;
                lblCompletar.Visible = false;
            }
            else
            {
                Session["userName"] = txtUser.Text;
                Response.Redirect("Articulos.aspx");
            }

        }
    }
}