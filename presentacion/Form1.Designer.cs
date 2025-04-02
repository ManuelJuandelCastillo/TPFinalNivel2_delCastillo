namespace presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabArticulos = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboOrderByPrecio = new System.Windows.Forms.ComboBox();
            this.cboSeleccionFiltro = new System.Windows.Forms.ComboBox();
            this.cboCampoFiltro = new System.Windows.Forms.ComboBox();
            this.lblFiltroTitulo = new System.Windows.Forms.Label();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.tabCategorias = new System.Windows.Forms.TabPage();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.tabMarcas = new System.Windows.Forms.TabPage();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chbOrderByPrecio = new System.Windows.Forms.CheckBox();
            this.btnFiltrarArticulos = new System.Windows.Forms.Button();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.panelContenedor.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabArticulos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.tabCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.tabMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.tabControl1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(800, 446);
            this.panelContenedor.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabArticulos);
            this.tabControl1.Controls.Add(this.tabCategorias);
            this.tabControl1.Controls.Add(this.tabMarcas);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 446);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabArticulos
            // 
            this.tabArticulos.Controls.Add(this.panel2);
            this.tabArticulos.Controls.Add(this.btnEliminarArticulo);
            this.tabArticulos.Controls.Add(this.btnAgregarArticulo);
            this.tabArticulos.Controls.Add(this.btnDetalles);
            this.tabArticulos.Controls.Add(this.panel1);
            this.tabArticulos.Controls.Add(this.txtBuscar);
            this.tabArticulos.Controls.Add(this.lblBuscar);
            this.tabArticulos.Controls.Add(this.pbxArticulo);
            this.tabArticulos.Controls.Add(this.dgvArticulos);
            this.tabArticulos.Location = new System.Drawing.Point(4, 22);
            this.tabArticulos.Name = "tabArticulos";
            this.tabArticulos.Padding = new System.Windows.Forms.Padding(3);
            this.tabArticulos.Size = new System.Drawing.Size(792, 420);
            this.tabArticulos.TabIndex = 0;
            this.tabArticulos.Text = "Articulos";
            this.tabArticulos.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLimpiarFiltro);
            this.panel2.Controls.Add(this.btnFiltrarArticulos);
            this.panel2.Controls.Add(this.chbOrderByPrecio);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.cboOrderByPrecio);
            this.panel2.Controls.Add(this.cboSeleccionFiltro);
            this.panel2.Controls.Add(this.cboCampoFiltro);
            this.panel2.Controls.Add(this.lblFiltroTitulo);
            this.panel2.Controls.Add(this.lblSeleccion);
            this.panel2.Controls.Add(this.lblFiltrarPor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 74);
            this.panel2.TabIndex = 5;
            // 
            // cboOrderByPrecio
            // 
            this.cboOrderByPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderByPrecio.Enabled = false;
            this.cboOrderByPrecio.FormattingEnabled = true;
            this.cboOrderByPrecio.Items.AddRange(new object[] {
            "De mayor a menor",
            "De menor a mayor"});
            this.cboOrderByPrecio.Location = new System.Drawing.Point(332, 50);
            this.cboOrderByPrecio.Name = "cboOrderByPrecio";
            this.cboOrderByPrecio.Size = new System.Drawing.Size(123, 21);
            this.cboOrderByPrecio.TabIndex = 6;
            // 
            // cboSeleccionFiltro
            // 
            this.cboSeleccionFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeleccionFiltro.Enabled = false;
            this.cboSeleccionFiltro.FormattingEnabled = true;
            this.cboSeleccionFiltro.Location = new System.Drawing.Point(179, 50);
            this.cboSeleccionFiltro.Name = "cboSeleccionFiltro";
            this.cboSeleccionFiltro.Size = new System.Drawing.Size(123, 21);
            this.cboSeleccionFiltro.TabIndex = 5;
            // 
            // cboCampoFiltro
            // 
            this.cboCampoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampoFiltro.FormattingEnabled = true;
            this.cboCampoFiltro.Items.AddRange(new object[] {
            "Marca",
            "Categoria"});
            this.cboCampoFiltro.Location = new System.Drawing.Point(26, 49);
            this.cboCampoFiltro.Name = "cboCampoFiltro";
            this.cboCampoFiltro.Size = new System.Drawing.Size(123, 21);
            this.cboCampoFiltro.TabIndex = 4;
            this.cboCampoFiltro.SelectedIndexChanged += new System.EventHandler(this.cboCampoFiltro_SelectedIndexChanged);
            // 
            // lblFiltroTitulo
            // 
            this.lblFiltroTitulo.AutoSize = true;
            this.lblFiltroTitulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroTitulo.Location = new System.Drawing.Point(353, 0);
            this.lblFiltroTitulo.Name = "lblFiltroTitulo";
            this.lblFiltroTitulo.Size = new System.Drawing.Size(82, 19);
            this.lblFiltroTitulo.TabIndex = 2;
            this.lblFiltroTitulo.Text = "Filtrar lista";
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(176, 33);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(84, 13);
            this.lblSeleccion.TabIndex = 1;
            this.lblSeleccion.Text = "Seleccione una:";
            // 
            // lblFiltrarPor
            // 
            this.lblFiltrarPor.AutoSize = true;
            this.lblFiltrarPor.Location = new System.Drawing.Point(23, 33);
            this.lblFiltrarPor.Name = "lblFiltrarPor";
            this.lblFiltrarPor.Size = new System.Drawing.Size(53, 13);
            this.lblFiltrarPor.TabIndex = 0;
            this.lblFiltrarPor.Text = "Filtrar por:";
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(298, 309);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(80, 28);
            this.btnEliminarArticulo.TabIndex = 4;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(212, 309);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(80, 28);
            this.btnAgregarArticulo.TabIndex = 3;
            this.btnAgregarArticulo.Text = "Agregar";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(126, 309);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(80, 28);
            this.btnDetalles.TabIndex = 2;
            this.btnDetalles.Text = "Ver detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(101, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 3);
            this.panel1.TabIndex = 4;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(101, 23);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(221, 14);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBuscar.Location = new System.Drawing.Point(35, 26);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(48, 13);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "buscar...";
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(432, 57);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(307, 246);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArticulo.TabIndex = 1;
            this.pbxArticulo.TabStop = false;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle43;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle44;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(38, 57);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle45;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(343, 246);
            this.dgvArticulos.StandardTab = true;
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // tabCategorias
            // 
            this.tabCategorias.Controls.Add(this.btnModificarCategoria);
            this.tabCategorias.Controls.Add(this.btnAgregarCategoria);
            this.tabCategorias.Controls.Add(this.dgvCategoria);
            this.tabCategorias.Location = new System.Drawing.Point(4, 22);
            this.tabCategorias.Name = "tabCategorias";
            this.tabCategorias.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategorias.Size = new System.Drawing.Size(792, 420);
            this.tabCategorias.TabIndex = 1;
            this.tabCategorias.Text = "Categorias";
            this.tabCategorias.UseVisualStyleBackColor = true;
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificarCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.btnModificarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModificarCategoria.Location = new System.Drawing.Point(410, 163);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(257, 54);
            this.btnModificarCategoria.TabIndex = 2;
            this.btnModificarCategoria.Text = "Modificar categoria selecionada";
            this.btnModificarCategoria.UseVisualStyleBackColor = false;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.btnAgregarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarCategoria.Location = new System.Drawing.Point(410, 85);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(257, 54);
            this.btnAgregarCategoria.TabIndex = 1;
            this.btnAgregarCategoria.Text = "Agregar nueva categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.AllowUserToDeleteRows = false;
            this.dgvCategoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategoria.DefaultCellStyle = dataGridViewCellStyle47;
            this.dgvCategoria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategoria.Location = new System.Drawing.Point(84, 48);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle48;
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(188, 272);
            this.dgvCategoria.TabIndex = 2;
            // 
            // tabMarcas
            // 
            this.tabMarcas.Controls.Add(this.btnModificarMarca);
            this.tabMarcas.Controls.Add(this.btnAgregarMarca);
            this.tabMarcas.Controls.Add(this.dgvMarca);
            this.tabMarcas.Location = new System.Drawing.Point(4, 22);
            this.tabMarcas.Name = "tabMarcas";
            this.tabMarcas.Size = new System.Drawing.Size(792, 420);
            this.tabMarcas.TabIndex = 2;
            this.tabMarcas.Text = "Marcas";
            this.tabMarcas.UseVisualStyleBackColor = true;
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.btnModificarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModificarMarca.Location = new System.Drawing.Point(410, 163);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(257, 54);
            this.btnModificarMarca.TabIndex = 5;
            this.btnModificarMarca.Text = "Modificar marca selecionada";
            this.btnModificarMarca.UseVisualStyleBackColor = false;
            this.btnModificarMarca.Click += new System.EventHandler(this.btnModificarMarca_Click);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.btnAgregarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarMarca.Location = new System.Drawing.Point(410, 85);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(257, 54);
            this.btnAgregarMarca.TabIndex = 4;
            this.btnAgregarMarca.Text = "Agregar nueva marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // dgvMarca
            // 
            this.dgvMarca.AllowUserToAddRows = false;
            this.dgvMarca.AllowUserToDeleteRows = false;
            this.dgvMarca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarca.Location = new System.Drawing.Point(84, 48);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.ReadOnly = true;
            this.dgvMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarca.Size = new System.Drawing.Size(188, 272);
            this.dgvMarca.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(8, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 3);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(453, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(327, 3);
            this.panel4.TabIndex = 8;
            // 
            // chbOrderByPrecio
            // 
            this.chbOrderByPrecio.AutoSize = true;
            this.chbOrderByPrecio.Location = new System.Drawing.Point(332, 32);
            this.chbOrderByPrecio.Name = "chbOrderByPrecio";
            this.chbOrderByPrecio.Size = new System.Drawing.Size(115, 17);
            this.chbOrderByPrecio.TabIndex = 9;
            this.chbOrderByPrecio.Text = "Ordenar por Precio";
            this.chbOrderByPrecio.UseVisualStyleBackColor = true;
            this.chbOrderByPrecio.CheckedChanged += new System.EventHandler(this.chbOrderByPrecio_CheckedChanged);
            // 
            // btnFiltrarArticulos
            // 
            this.btnFiltrarArticulos.Location = new System.Drawing.Point(485, 47);
            this.btnFiltrarArticulos.Name = "btnFiltrarArticulos";
            this.btnFiltrarArticulos.Size = new System.Drawing.Size(123, 23);
            this.btnFiltrarArticulos.TabIndex = 10;
            this.btnFiltrarArticulos.Text = "Filtrar";
            this.btnFiltrarArticulos.UseVisualStyleBackColor = true;
            this.btnFiltrarArticulos.Click += new System.EventHandler(this.btnFiltrarArticulos_Click);
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(638, 48);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(123, 23);
            this.btnLimpiarFiltro.TabIndex = 11;
            this.btnLimpiarFiltro.Text = "Limpiar filtros";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelContenedor.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabArticulos.ResumeLayout(false);
            this.tabArticulos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.tabCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.tabMarcas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabArticulos;
        private System.Windows.Forms.TabPage tabCategorias;
        private System.Windows.Forms.TabPage tabMarcas;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboSeleccionFiltro;
        private System.Windows.Forms.ComboBox cboCampoFiltro;
        private System.Windows.Forms.Label lblFiltroTitulo;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Label lblFiltrarPor;
        private System.Windows.Forms.ComboBox cboOrderByPrecio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chbOrderByPrecio;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Button btnFiltrarArticulos;
    }
}

