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
    public partial class frmInicio : Form
    {
        private List<Articulo> lista;
        public frmInicio()
        {
            InitializeComponent();
        }

        private void cargarDatos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                lista = negocio.Listar();
                dgvArticulos.DataSource = lista;
                dgvArticulos.Columns[0].Visible = false;
                dgvArticulos.Columns[1].Visible = false;
                dgvArticulos.Columns[2].MinimumWidth = 130;
                dgvArticulos.Columns[3].Visible = false;
                dgvArticulos.Columns[4].MinimumWidth = 100;
                dgvArticulos.Columns[5].MinimumWidth = 100;
                dgvArticulos.Columns[6].Visible = false;
                dgvArticulos.Columns[7].Visible = false;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void dgvArticulos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmVerDetalle VD = new frmVerDetalle();
                Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                VD.txtCodigoD.Text = articulo.CodArt.ToString();
                VD.txtNombreD.Text = articulo.Nombre.ToString();
                VD.txtDescripcionD.Text = articulo.Descripcion.ToString();
                VD.txtMarcaD.Text = articulo.Marca.ToString();
                VD.txtCategoriaD.Text = articulo.Categoria.ToString();
                VD.txtPrecioD.Text = articulo.Precio.ToString("F2");

                if (articulo.ImagenURL != "")
                {
                    VD.picArticulo.Load(articulo.ImagenURL);
                }
                VD.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
