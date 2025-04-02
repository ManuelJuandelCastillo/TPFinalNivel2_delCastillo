using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace presentacion
{
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos;

        bool filtroActivo = false;
        public Form1()
        {
            InitializeComponent();
        }

        // Carga inicial de la ventana
        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCategorias();
            cargarMarcas();

            cargarArticulos();
            ocultarColumnas();
            
            cargarArticulos(); // esta segunda carga la hice porque despues de ocultar las columnas si bien la primera fila 
                               // se muestra en azul, no tiene la flecha a la izquierda que muestra la seleccion
                               // por lo que al querer eliminar o ver detalles tiraba seleccion null
            cargarImagen(dgvArticulos.CurrentRow.Cells["ImagenUrl"].Value.ToString());

            validarDGV();
        }

        // Eventos de la hoja de Articulos
        private void cargarArticulos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }       

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Codigo"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Categoria"].Visible = false;
            dgvArticulos.Columns["Precio"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://www.thermaxglobal.com/wp-content/uploads/2020/05/image-not-found.jpg");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string busqueda = txtBuscar.Text.ToLower();

            if (busqueda == "")
            {
                listaFiltrada = listaArticulos;
            }
            else
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToLower().Contains(busqueda) || x.Marca.Descripcion.ToLower().Contains(busqueda));
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro quieres eliminar este articulo?", "Eliminar articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado);
                    if (filtroActivo)
                    {
                        btnFiltrarArticulos.PerformClick();
                    }
                    else
                    {
                        cargarArticulos();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            FormularioArticulo agregarArticulo = new FormularioArticulo();
            agregarArticulo.ShowDialog();
            if (filtroActivo)
            {
                btnFiltrarArticulos.PerformClick();
            }
            else
            {
                cargarArticulos();
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            FormularioArticulo verDetalles = new FormularioArticulo(seleccionado);
            verDetalles.ShowDialog();

            if (filtroActivo)
            {
                btnFiltrarArticulos.PerformClick();
            }
            else
            {
                cargarArticulos();
            }
        }


        // Eventos de la hoja de Categorias
        private void cargarCategorias()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                dgvCategoria.DataSource = negocio.listar();
                dgvCategoria.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            FormularioAgregarModificar formulario = new FormularioAgregarModificar("Categoria");
            formulario.ShowDialog();
            cargarCategorias();
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
            FormularioAgregarModificar formulario = new FormularioAgregarModificar(categoria);
            formulario.ShowDialog();
            cargarCategorias();

        }


        // Eventos de la hoja de Marcas
        private void cargarMarcas()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                dgvMarca.DataSource = negocio.listar();
                dgvMarca.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            FormularioAgregarModificar formulario = new FormularioAgregarModificar("Marca");
            formulario.ShowDialog();
            cargarMarcas();
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = (Marca)dgvMarca.CurrentRow.DataBoundItem;
            FormularioAgregarModificar formulario = new FormularioAgregarModificar(marca);
            formulario.ShowDialog();
            cargarMarcas();
        }


        // Eventos de la seccion de Filtros
        private void cboCampoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtrarPor = cboCampoFiltro.Text;
            cboSeleccionFiltro.Enabled = true;

            if (filtrarPor == "Categoria")
            {
                try
                {
                    CategoriaNegocio negocio = new CategoriaNegocio();
                    cboSeleccionFiltro.DataSource = null;
                    cboSeleccionFiltro.DataSource = negocio.listar();
                    cboSeleccionFiltro.ValueMember = "Id";
                    cboSeleccionFiltro.DisplayMember = "Descripcion";
                    lblSeleccion.Text = "Seleccione una categoria";
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                
            }
            if (filtrarPor == "Marca")
            {
                try
                {
                    MarcaNegocio negocio = new MarcaNegocio();
                    cboSeleccionFiltro.DataSource = null;
                    cboSeleccionFiltro.DataSource = negocio.listar();
                    cboSeleccionFiltro.ValueMember = "Id";
                    cboSeleccionFiltro.DisplayMember = "Descripcion";
                    lblSeleccion.Text = "Seleccione una marca";
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void chbOrderByPrecio_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOrderByPrecio.Checked)
            {
                cboOrderByPrecio.Enabled = true;
                cboOrderByPrecio.SelectedIndex = 0;
            }
            else
            {
                cboOrderByPrecio.Enabled = false;
                cboOrderByPrecio.SelectedIndex = -1;
            }
        }

        private void btnFiltrarArticulos_Click(object sender, EventArgs e)
        {
            filtroActivo = true;
            ArticuloNegocio negocio = new ArticuloNegocio();

            if (chbOrderByPrecio.Checked)
            {
                if (cboCampoFiltro.SelectedIndex == -1)
                {
                    // ordenar lista completa por precio
                    if (cboOrderByPrecio.Text == "De menor a mayor")
                    {
                        // ordenar de menor a mayor
                        dgvArticulos.DataSource = negocio.filtrar("asc");
                    }
                    else
                    {
                        // ordenar de mayor a menor
                        dgvArticulos.DataSource = negocio.filtrar("desc");
                    }
                }
                else
                {
                    // ordenar lista filtrada por campo y precio
                    string campo = cboCampoFiltro.Text;
                    int id = (int)cboSeleccionFiltro.SelectedValue;
                    if (cboOrderByPrecio.Text == "De menor a mayor")
                    {
                        dgvArticulos.DataSource = negocio.filtrar(campo, id, "asc");
                        validarDGV();
                    }
                    else
                    {
                        dgvArticulos.DataSource = negocio.filtrar(campo, id, "desc");
                        validarDGV();
                    }

                }
            }
            else
            {
                if (cboCampoFiltro.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un campo para filtrar");
                }
                else
                {
                    string campo = cboCampoFiltro.Text;
                    int id = (int)cboSeleccionFiltro.SelectedValue;
                    dgvArticulos.DataSource = negocio.filtrar(campo, id);
                    validarDGV();
                }
            }
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            cboCampoFiltro.SelectedIndex = -1;
            cboSeleccionFiltro.DataSource = null;
            cboSeleccionFiltro.Enabled = false;
            chbOrderByPrecio.Checked = false;
            cargarArticulos();
            ocultarColumnas();
            filtroActivo = false;
        }

        private void validarDGV()
        {
            if (dgvArticulos.Rows.Count == 0)
            {
                btnDetalles.Enabled = false;
                btnEliminarArticulo.Enabled = false;
            }
            else
            {
                btnDetalles.Enabled = true;
                btnEliminarArticulo.Enabled = true;
            }
        }
    }
}
