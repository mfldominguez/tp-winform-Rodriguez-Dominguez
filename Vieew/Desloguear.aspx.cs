using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vieew
{
    public partial class Desloguear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Articulos.aspx");
        }
        
        protected void btnDesloguear_Click(object sender, EventArgs e)
        {
            Session["userName"] = null;

            Response.Redirect("Articulos.aspx");
        }

    }
}