using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewWeb
{
    public partial class Articulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session[Session.SessionID + "nombreusuario"] != null)
                {
                    lblBienvenida.Visible = true;
                    lblBienvenida.Text += Session[Session.SessionID + "nombreusuario"].ToString();
                }

            }
        }
    }
}