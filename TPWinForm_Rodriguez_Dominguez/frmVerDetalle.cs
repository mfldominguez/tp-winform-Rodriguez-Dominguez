using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForm_Rodriguez_Dominguez
{
    public partial class frmVerDetalle : Form
    {
        public frmVerDetalle()
        {
            InitializeComponent();
        }
        private void frmVerDetalle_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
