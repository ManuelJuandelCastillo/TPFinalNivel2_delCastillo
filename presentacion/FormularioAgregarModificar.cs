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
    public partial class FormularioAgregarModificar : Form
    {
        // Creacion inicial para saber si se abre el formulario para agregar o modificar
        private Categoria categoria = null;
        private Marca marca = null;

        string seleccionMarcaCat;

        // Constructor para agregar una nueva categoria o marca
        public FormularioAgregarModificar(string valor)
        {
            InitializeComponent();
            Text = "Nueva " + valor;
            seleccionMarcaCat = valor;
        }

        // Constructor para modificar una categoria
        public FormularioAgregarModificar(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            txtDescripcion.Text = categoria.Descripcion;
            Text = "Modificar Categoria";
            seleccionMarcaCat = "Categoria";
        }

        // Constructor para modificar una marca
        public FormularioAgregarModificar(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            txtDescripcion.Text = marca.Descripcion;
            Text = "Modificar Marca";
            seleccionMarcaCat = "Marca";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Debe completar el campo descripcion");
                return;
            }
            try
            {
                if (seleccionMarcaCat == "Marca")
                {
                    MarcaNegocio negocioMarca = new MarcaNegocio();
                    // Si marca es null es porque elegimos agregar una nueva marca
                    if (marca == null)
                        marca = new Marca();
                    marca.Descripcion = txtDescripcion.Text;

                    // si el Id es distinto de 0 es porque estamos modificando una marca
                    if (marca.Id != 0) 
                    {
                        negocioMarca.modificarMarca(marca);
                        MessageBox.Show("Marca modificada correctamente");
                    }
                    else
                    {
                        negocioMarca.agregarMarca(marca);
                        MessageBox.Show("Marca agregada correctamente");
                    }
                }
                else
                {
                    CategoriaNegocio negocioCat = new CategoriaNegocio();
                    // Si categoria es null es porque elegimos agregar una nueva categoria
                    if (categoria == null)
                        categoria = new Categoria();

                    categoria.Descripcion = txtDescripcion.Text;

                    // si el Id es distinto de 0 es porque estamos modificando una categoria
                    if (categoria.Id != 0)
                    {
                        negocioCat.modificarCategoria(categoria);
                        MessageBox.Show("Categoria modificada correctamente");
                    }
                    else
                    {
                        negocioCat.agregarCategoria(categoria);
                        MessageBox.Show("Categoria agregada correctamente");
                    }

                }
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }   

    }
}
