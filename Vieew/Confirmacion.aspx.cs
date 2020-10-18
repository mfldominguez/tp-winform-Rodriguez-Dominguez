using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vieew
{
    public partial class Confirmacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnEliminar_Click1(object sender, EventArgs e)
        {
            string codArt = Request.QueryString["cElim"];
            Response.Redirect("VerCarrito.aspx?cElim=" + codArt);

        }

        protected void btnCancealr_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerCarrito.aspx");
        }
    }
}