using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class FormularioArticulo : Form
    {
        private Articulo articulo = null;


        public FormularioArticulo()
        {
            InitializeComponent();
            lblSeparacionCentavos.Visible = true;
        }

        public FormularioArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Detalles del articulo";
            txtCodigo.Enabled = false;
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;
            txtPrecio.Enabled = false;
            txtDescripcion.Enabled = false;
            txtImagen.Enabled = false;
            cboMarca.Enabled = false;
            cboCategoria.Enabled = false;
            btnGuardar.Visible = false;
            btnCancelar.Text = "Cerrar";
            pnlModifcar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormularioArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.PrecioFormat;
                    txtImagen.Text = articulo.ImagenUrl;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    cargarImagen(articulo.ImagenUrl);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxImagen.Load("https://www.thermaxglobal.com/wp-content/uploads/2020/05/image-not-found.jpg");
            }
        }

        private void checkBoxModifcar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxModifcar.Checked)
            {
                txtCodigo.Enabled = true;
                txtNombre.Enabled = true;
                txtDescripcion.Enabled = true;
                txtPrecio.Enabled = true;
                txtDescripcion.Enabled = true;
                txtImagen.Enabled = true;
                cboMarca.Enabled = true;
                cboCategoria.Enabled = true;
                btnGuardar.Visible = true;
                btnCancelar.Text = "Cancelar";
                Text = "Editar articulo";
                lblSeparacionCentavos.Visible = true;
                txtPrecio.Text = txtPrecio.Text.Replace("$", "");
                txtPrecio.Text = txtPrecio.Text.Replace(".", "");
                txtPrecio.Text = txtPrecio.Text.Replace(" ", "");
            }
            else
            {
                txtCodigo.Enabled = false;
                txtNombre.Enabled = false;
                txtDescripcion.Enabled = false;
                txtPrecio.Enabled = false;
                txtDescripcion.Enabled = false;
                txtImagen.Enabled = false;
                cboMarca.Enabled = false;
                cboCategoria.Enabled = false;
                btnGuardar.Visible = false;
                btnCancelar.Text = "Cerrar";
                Text = "Detalles del articulo";
                lblSeparacionCentavos.Visible = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;
                if (validarPrecio(txtPrecio.Text))
                    return;

                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.ImagenUrl = txtImagen.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;

                if (articulo.Id != 0)
                {
                    articuloNegocio.modificar(articulo);
                    MessageBox.Show("Articulo modificado correctamente");
                }
                else
                {
                    articuloNegocio.agregar(articulo);
                    MessageBox.Show("Articulo agregado correctamente");
                }

                Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private bool validarFiltro()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("El campo codigo no puede estar vacio");
                return true;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo nombre no puede estar vacio");
                return true;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("El campo precio no puede estar vacio");
                return true;
            }
            return false;
        }

        private bool validarPrecio(string precio)
        {
            int contador = 0;
            foreach (char c in precio)
            {
                if (!char.IsNumber(c))
                {
                    if (c == ',')
                        contador++;
                    else
                    {
                        MessageBox.Show("El campo precio solo puede contener numeros y una coma para separar los centavos.");
                        return true;
                    }
                }
            }
            if (contador > 1)
            {
                MessageBox.Show("El campo precio solo puede contener una coma para separar los centavos.");
                return true;
            }

            return false;
        }
    }
}
