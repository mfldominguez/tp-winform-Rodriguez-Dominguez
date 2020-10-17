using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace TPWinForm_Rodriguez_Dominguez
{
    public partial class frmAMArticulo : Form
    {
        private Articulo articulo = null;
        public frmAMArticulo()
        {
            InitializeComponent();
        }

        public frmAMArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmAMArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                cboVAMCategoria.DataSource = negocio.ListarCategorias();
                cboVAMCategoria.ValueMember = "Id";
                cboVAMCategoria.DisplayMember = "Descripcion";

                cboVAMMarca.DataSource = negocio.ListarMarcas();
                cboVAMMarca.ValueMember = "Id";
                cboVAMMarca.DisplayMember = "Descripcion";


                if (articulo != null)
                {

                    Text = "MODIFICAR ARTICULO";
                    btnAgregar.Text = "MODIFICAR";



                    txtVAMCodArt.Text = articulo.CodArt;
                    txtVAMDescripcion.Text = articulo.Descripcion;
                    txtVAMImagenURL.Text = articulo.ImagenURL;
                    txtVAMNombre.Text = articulo.Nombre;
                    txtVAMPrecio.Text = articulo.Precio.ToString("F2");
                    cboVAMCategoria.SelectedValue = articulo.Categoria.Id;
                    cboVAMMarca.SelectedValue = articulo.Marca.Id;

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();


            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.CodArt = txtVAMCodArt.Text;
                articulo.Nombre = txtVAMNombre.Text;
                articulo.Descripcion = txtVAMDescripcion.Text;
                articulo.Marca = (Marca)cboVAMMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboVAMCategoria.SelectedItem;
                articulo.ImagenURL = txtVAMImagenURL.Text;
                articulo.Precio = Convert.ToInt32(txtVAMPrecio.Text);


                if (articulo.Id != 0)
                    articuloNegocio.modificar(articulo);
                else
                    articuloNegocio.agregar(articulo);

                Dispose();




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtVAMPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
