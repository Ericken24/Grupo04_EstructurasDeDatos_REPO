namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminGeneral
{
    partial class UC_ProductosCategorias
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            lblProductosCategorias = new Label();
            grpCategorias = new GroupBox();
            dgvCategorias = new DataGridView();
            colCatNombre = new DataGridViewTextBoxColumn();
            colCatActiva = new DataGridViewTextBoxColumn();
            lblCatNombre = new Label();
            txtCatNombre = new TextBox();
            lblCatDescripcion = new Label();
            txtCatDescripcion = new TextBox();
            chkCatActiva = new CheckBox();
            btnNuevaCategoria = new Button();
            btnGuardarCategoria = new Button();
            grpProductos = new GroupBox();
            dgvProductos = new DataGridView();
            lblProductoSel = new Label();
            lblPrecioCompra = new Label();
            txtPrecioCompra = new TextBox();
            lblPrecioVenta = new Label();
            txtPrecioVenta = new TextBox();
            lblStockMinimo = new Label();
            txtStockMinimo = new TextBox();
            chkProdActivo = new CheckBox();
            lblMargen = new Label();
            btnGuardarProducto = new Button();
            colProdSku = new DataGridViewTextBoxColumn();
            colProdNombre = new DataGridViewTextBoxColumn();
            colProdCompra = new DataGridViewTextBoxColumn();
            colProdVenta = new DataGridViewTextBoxColumn();
            colProdMinimo = new DataGridViewTextBoxColumn();
            colProdActivo = new DataGridViewTextBoxColumn();
            grpCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            grpProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // lblProductosCategorias
            // 
            lblProductosCategorias.AutoSize = true;
            lblProductosCategorias.BackColor = Color.Transparent;
            lblProductosCategorias.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblProductosCategorias.Location = new Point(15, 23);
            lblProductosCategorias.Name = "lblProductosCategorias";
            lblProductosCategorias.Size = new Size(402, 46);
            lblProductosCategorias.TabIndex = 0;
            lblProductosCategorias.Text = "Productos y categorías";
            // 
            // grpCategorias
            // 
            grpCategorias.Controls.Add(dgvCategorias);
            grpCategorias.Controls.Add(lblCatNombre);
            grpCategorias.Controls.Add(txtCatNombre);
            grpCategorias.Controls.Add(lblCatDescripcion);
            grpCategorias.Controls.Add(txtCatDescripcion);
            grpCategorias.Controls.Add(chkCatActiva);
            grpCategorias.Controls.Add(btnNuevaCategoria);
            grpCategorias.Controls.Add(btnGuardarCategoria);
            grpCategorias.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCategorias.ForeColor = Color.DarkOliveGreen;
            grpCategorias.Location = new Point(23, 93);
            grpCategorias.Margin = new Padding(3, 4, 3, 4);
            grpCategorias.Name = "grpCategorias";
            grpCategorias.Padding = new Padding(3, 4, 3, 4);
            grpCategorias.Size = new Size(343, 580);
            grpCategorias.TabIndex = 1;
            grpCategorias.TabStop = false;
            grpCategorias.Text = "Categorías";
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Honeydew;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategorias.BackgroundColor = Color.White;
            dgvCategorias.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCategorias.ColumnHeadersHeight = 30;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { colCatNombre, colCatActiva });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.DarkOliveGreen;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCategorias.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCategorias.EnableHeadersVisualStyles = false;
            dgvCategorias.GridColor = Color.Gainsboro;
            dgvCategorias.Location = new Point(11, 33);
            dgvCategorias.Margin = new Padding(3, 4, 3, 4);
            dgvCategorias.MultiSelect = false;
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.RowTemplate.Height = 25;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(320, 267);
            dgvCategorias.TabIndex = 2;
            dgvCategorias.SelectionChanged += dgvCategorias_SelectionChanged;
            // 
            // colCatNombre
            // 
            colCatNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCatNombre.HeaderText = "Nombre";
            colCatNombre.MinimumWidth = 120;
            colCatNombre.Name = "colCatNombre";
            colCatNombre.ReadOnly = true;
            // 
            // colCatActiva
            // 
            colCatActiva.HeaderText = "Activa";
            colCatActiva.MinimumWidth = 6;
            colCatActiva.Name = "colCatActiva";
            colCatActiva.ReadOnly = true;
            colCatActiva.Width = 60;
            // 
            // lblCatNombre
            // 
            lblCatNombre.AutoSize = true;
            lblCatNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCatNombre.ForeColor = Color.DarkSlateGray;
            lblCatNombre.Location = new Point(11, 317);
            lblCatNombre.Name = "lblCatNombre";
            lblCatNombre.Size = new Size(76, 23);
            lblCatNombre.TabIndex = 3;
            lblCatNombre.Text = "Nombre";
            // 
            // txtCatNombre
            // 
            txtCatNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCatNombre.ForeColor = Color.Black;
            txtCatNombre.Location = new Point(11, 344);
            txtCatNombre.Margin = new Padding(3, 4, 3, 4);
            txtCatNombre.Name = "txtCatNombre";
            txtCatNombre.Size = new Size(319, 29);
            txtCatNombre.TabIndex = 4;
            // 
            // lblCatDescripcion
            // 
            lblCatDescripcion.AutoSize = true;
            lblCatDescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCatDescripcion.ForeColor = Color.DarkSlateGray;
            lblCatDescripcion.Location = new Point(11, 387);
            lblCatDescripcion.Name = "lblCatDescripcion";
            lblCatDescripcion.Size = new Size(103, 23);
            lblCatDescripcion.TabIndex = 5;
            lblCatDescripcion.Text = "Descripción";
            // 
            // txtCatDescripcion
            // 
            txtCatDescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCatDescripcion.ForeColor = Color.Black;
            txtCatDescripcion.Location = new Point(11, 413);
            txtCatDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtCatDescripcion.Multiline = true;
            txtCatDescripcion.Name = "txtCatDescripcion";
            txtCatDescripcion.ScrollBars = ScrollBars.Vertical;
            txtCatDescripcion.Size = new Size(319, 65);
            txtCatDescripcion.TabIndex = 6;
            // 
            // chkCatActiva
            // 
            chkCatActiva.AutoSize = true;
            chkCatActiva.Checked = true;
            chkCatActiva.CheckState = CheckState.Checked;
            chkCatActiva.Cursor = Cursors.Hand;
            chkCatActiva.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkCatActiva.ForeColor = Color.DarkSlateGray;
            chkCatActiva.Location = new Point(11, 491);
            chkCatActiva.Margin = new Padding(3, 4, 3, 4);
            chkCatActiva.Name = "chkCatActiva";
            chkCatActiva.Size = new Size(155, 27);
            chkCatActiva.TabIndex = 7;
            chkCatActiva.Text = "Categoría activa";
            chkCatActiva.UseVisualStyleBackColor = true;
            // 
            // btnNuevaCategoria
            // 
            btnNuevaCategoria.BackColor = Color.DarkOliveGreen;
            btnNuevaCategoria.Cursor = Cursors.Hand;
            btnNuevaCategoria.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevaCategoria.ForeColor = Color.White;
            btnNuevaCategoria.Location = new Point(11, 523);
            btnNuevaCategoria.Margin = new Padding(3, 4, 3, 4);
            btnNuevaCategoria.Name = "btnNuevaCategoria";
            btnNuevaCategoria.Size = new Size(154, 45);
            btnNuevaCategoria.TabIndex = 8;
            btnNuevaCategoria.Text = "➕ Nueva";
            btnNuevaCategoria.UseVisualStyleBackColor = false;
            btnNuevaCategoria.Click += btnNuevaCategoria_Click;
            // 
            // btnGuardarCategoria
            // 
            btnGuardarCategoria.BackColor = Color.DarkOliveGreen;
            btnGuardarCategoria.Cursor = Cursors.Hand;
            btnGuardarCategoria.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarCategoria.ForeColor = Color.White;
            btnGuardarCategoria.Location = new Point(177, 523);
            btnGuardarCategoria.Margin = new Padding(3, 4, 3, 4);
            btnGuardarCategoria.Name = "btnGuardarCategoria";
            btnGuardarCategoria.Size = new Size(154, 45);
            btnGuardarCategoria.TabIndex = 9;
            btnGuardarCategoria.Text = "💾 Guardar";
            btnGuardarCategoria.UseVisualStyleBackColor = false;
            btnGuardarCategoria.Click += btnGuardarCategoria_Click;
            // 
            // grpProductos
            // 
            grpProductos.Controls.Add(dgvProductos);
            grpProductos.Controls.Add(lblProductoSel);
            grpProductos.Controls.Add(lblPrecioCompra);
            grpProductos.Controls.Add(txtPrecioCompra);
            grpProductos.Controls.Add(lblPrecioVenta);
            grpProductos.Controls.Add(txtPrecioVenta);
            grpProductos.Controls.Add(lblStockMinimo);
            grpProductos.Controls.Add(txtStockMinimo);
            grpProductos.Controls.Add(chkProdActivo);
            grpProductos.Controls.Add(lblMargen);
            grpProductos.Controls.Add(btnGuardarProducto);
            grpProductos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpProductos.ForeColor = Color.DarkOliveGreen;
            grpProductos.Location = new Point(372, 93);
            grpProductos.Margin = new Padding(3, 4, 3, 4);
            grpProductos.Name = "grpProductos";
            grpProductos.Padding = new Padding(3, 4, 3, 4);
            grpProductos.Size = new Size(814, 580);
            grpProductos.TabIndex = 10;
            grpProductos.TabStop = false;
            grpProductos.Text = "Productos de la categoría";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Honeydew;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvProductos.ColumnHeadersHeight = 30;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colProdSku, colProdNombre, colProdCompra, colProdVenta, colProdMinimo, colProdActivo });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.DarkOliveGreen;
            dataGridViewCellStyle9.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle9;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = Color.Gainsboro;
            dgvProductos.Location = new Point(11, 33);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(797, 313);
            dgvProductos.TabIndex = 11;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // lblProductoSel
            // 
            lblProductoSel.AutoSize = true;
            lblProductoSel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductoSel.ForeColor = Color.DarkOliveGreen;
            lblProductoSel.Location = new Point(11, 363);
            lblProductoSel.Name = "lblProductoSel";
            lblProductoSel.Size = new Size(197, 23);
            lblProductoSel.TabIndex = 12;
            lblProductoSel.Text = "Seleccione un producto";
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.AutoSize = true;
            lblPrecioCompra.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioCompra.ForeColor = Color.DarkSlateGray;
            lblPrecioCompra.Location = new Point(11, 403);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new Size(150, 23);
            lblPrecioCompra.TabIndex = 13;
            lblPrecioCompra.Text = "Precio de compra";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioCompra.ForeColor = Color.Black;
            txtPrecioCompra.Location = new Point(11, 429);
            txtPrecioCompra.Margin = new Padding(3, 4, 3, 4);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(137, 29);
            txtPrecioCompra.TabIndex = 14;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioVenta.ForeColor = Color.DarkSlateGray;
            lblPrecioVenta.Location = new Point(171, 403);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(133, 23);
            lblPrecioVenta.TabIndex = 15;
            lblPrecioVenta.Text = "Precio de venta";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioVenta.ForeColor = Color.Black;
            txtPrecioVenta.Location = new Point(171, 429);
            txtPrecioVenta.Margin = new Padding(3, 4, 3, 4);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(137, 29);
            txtPrecioVenta.TabIndex = 16;
            // 
            // lblStockMinimo
            // 
            lblStockMinimo.AutoSize = true;
            lblStockMinimo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockMinimo.ForeColor = Color.DarkSlateGray;
            lblStockMinimo.Location = new Point(331, 403);
            lblStockMinimo.Name = "lblStockMinimo";
            lblStockMinimo.Size = new Size(122, 23);
            lblStockMinimo.TabIndex = 17;
            lblStockMinimo.Text = "Stock mínimo";
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStockMinimo.ForeColor = Color.Black;
            txtStockMinimo.Location = new Point(331, 429);
            txtStockMinimo.Margin = new Padding(3, 4, 3, 4);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(137, 29);
            txtStockMinimo.TabIndex = 18;
            // 
            // chkProdActivo
            // 
            chkProdActivo.AutoSize = true;
            chkProdActivo.Cursor = Cursors.Hand;
            chkProdActivo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkProdActivo.ForeColor = Color.DarkSlateGray;
            chkProdActivo.Location = new Point(491, 432);
            chkProdActivo.Margin = new Padding(3, 4, 3, 4);
            chkProdActivo.Name = "chkProdActivo";
            chkProdActivo.Size = new Size(152, 27);
            chkProdActivo.TabIndex = 19;
            chkProdActivo.Text = "Producto activo";
            chkProdActivo.UseVisualStyleBackColor = true;
            // 
            // lblMargen
            // 
            lblMargen.AutoSize = true;
            lblMargen.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMargen.ForeColor = Color.Black;
            lblMargen.Location = new Point(11, 480);
            lblMargen.Name = "lblMargen";
            lblMargen.Size = new Size(132, 23);
            lblMargen.TabIndex = 20;
            lblMargen.Text = "Margen bruto: -";
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.BackColor = Color.DarkOliveGreen;
            btnGuardarProducto.Cursor = Cursors.Hand;
            btnGuardarProducto.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarProducto.ForeColor = Color.White;
            btnGuardarProducto.Location = new Point(11, 517);
            btnGuardarProducto.Margin = new Padding(3, 4, 3, 4);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(229, 51);
            btnGuardarProducto.TabIndex = 21;
            btnGuardarProducto.Text = "💾 Guardar producto";
            btnGuardarProducto.UseVisualStyleBackColor = false;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // colProdSku
            // 
            colProdSku.HeaderText = "SKU";
            colProdSku.MinimumWidth = 6;
            colProdSku.Name = "colProdSku";
            colProdSku.ReadOnly = true;
            colProdSku.Width = 80;
            // 
            // colProdNombre
            // 
            colProdNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProdNombre.HeaderText = "Producto";
            colProdNombre.MinimumWidth = 160;
            colProdNombre.Name = "colProdNombre";
            colProdNombre.ReadOnly = true;
            // 
            // colProdCompra
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            colProdCompra.DefaultCellStyle = dataGridViewCellStyle6;
            colProdCompra.HeaderText = "P. compra";
            colProdCompra.MinimumWidth = 6;
            colProdCompra.Name = "colProdCompra";
            colProdCompra.ReadOnly = true;
            colProdCompra.Width = 80;
            // 
            // colProdVenta
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            colProdVenta.DefaultCellStyle = dataGridViewCellStyle7;
            colProdVenta.HeaderText = "P. venta";
            colProdVenta.MinimumWidth = 6;
            colProdVenta.Name = "colProdVenta";
            colProdVenta.ReadOnly = true;
            colProdVenta.Width = 80;
            // 
            // colProdMinimo
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            colProdMinimo.DefaultCellStyle = dataGridViewCellStyle8;
            colProdMinimo.HeaderText = "Mínimo";
            colProdMinimo.MinimumWidth = 8;
            colProdMinimo.Name = "colProdMinimo";
            colProdMinimo.ReadOnly = true;
            colProdMinimo.Width = 75;
            // 
            // colProdActivo
            // 
            colProdActivo.HeaderText = "Activo";
            colProdActivo.MinimumWidth = 6;
            colProdActivo.Name = "colProdActivo";
            colProdActivo.ReadOnly = true;
            colProdActivo.Width = 60;
            // 
            // UC_ProductosCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblProductosCategorias);
            Controls.Add(grpCategorias);
            Controls.Add(grpProductos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_ProductosCategorias";
            Size = new Size(1200, 813);
            Load += UC_ProductosCategorias_Load;
            grpCategorias.ResumeLayout(false);
            grpCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            grpProductos.ResumeLayout(false);
            grpProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductosCategorias;
        private GroupBox grpCategorias;
        private DataGridView dgvCategorias;
        private DataGridViewTextBoxColumn colCatNombre;
        private DataGridViewTextBoxColumn colCatActiva;
        private DataGridViewCellStyle dataGridViewCellStyle1;
        private DataGridViewCellStyle dataGridViewCellStyle2;
        private DataGridViewCellStyle dataGridViewCellStyle3;
        private DataGridViewCellStyle dataGridViewCellStyle4;
        private Label lblCatNombre;
        private TextBox txtCatNombre;
        private Label lblCatDescripcion;
        private TextBox txtCatDescripcion;
        private CheckBox chkCatActiva;
        private Button btnNuevaCategoria;
        private Button btnGuardarCategoria;
        private GroupBox grpProductos;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn colProdSku;
        private DataGridViewTextBoxColumn colProdNombre;
        private DataGridViewTextBoxColumn colProdCompra;
        private DataGridViewTextBoxColumn colProdVenta;
        private DataGridViewTextBoxColumn colProdMinimo;
        private DataGridViewTextBoxColumn colProdActivo;
        private DataGridViewCellStyle dataGridViewCellStyle5;
        private DataGridViewCellStyle dataGridViewCellStyle6;
        private DataGridViewCellStyle dataGridViewCellStyle7;
        private DataGridViewCellStyle dataGridViewCellStyle8;
        private Label lblProductoSel;
        private Label lblPrecioCompra;
        private TextBox txtPrecioCompra;
        private Label lblPrecioVenta;
        private TextBox txtPrecioVenta;
        private Label lblStockMinimo;
        private TextBox txtStockMinimo;
        private CheckBox chkProdActivo;
        private Label lblMargen;
        private Button btnGuardarProducto;
    }
}
