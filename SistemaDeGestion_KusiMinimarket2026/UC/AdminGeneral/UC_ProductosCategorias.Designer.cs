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
            lblProductosCategorias = new Label();
            grpCategorias = new GroupBox();
            dgvCategorias = new DataGridView();
            colCatNombre = new DataGridViewTextBoxColumn();
            colCatActiva = new DataGridViewTextBoxColumn();
            dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblCatNombre = new Label();
            txtCatNombre = new TextBox();
            lblCatDescripcion = new Label();
            txtCatDescripcion = new TextBox();
            chkCatActiva = new CheckBox();
            btnNuevaCategoria = new Button();
            btnGuardarCategoria = new Button();
            grpProductos = new GroupBox();
            dgvProductos = new DataGridView();
            colProdSku = new DataGridViewTextBoxColumn();
            colProdNombre = new DataGridViewTextBoxColumn();
            colProdCompra = new DataGridViewTextBoxColumn();
            colProdVenta = new DataGridViewTextBoxColumn();
            colProdMinimo = new DataGridViewTextBoxColumn();
            colProdActivo = new DataGridViewTextBoxColumn();
            dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridViewCellStyle7 = new DataGridViewCellStyle();
            dataGridViewCellStyle8 = new DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            grpCategorias.SuspendLayout();
            grpProductos.SuspendLayout();
            SuspendLayout();
            // 
            // lblProductosCategorias
            // 
            lblProductosCategorias.AutoSize = true;
            lblProductosCategorias.BackColor = Color.Transparent;
            lblProductosCategorias.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblProductosCategorias.Location = new Point(13, 17);
            lblProductosCategorias.Name = "lblProductosCategorias";
            lblProductosCategorias.Size = new Size(325, 37);
            lblProductosCategorias.TabIndex = 0;
            lblProductosCategorias.Text = "Productos y categorías";
            // 
            // grpCategorias
            // 
            grpCategorias.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCategorias.ForeColor = Color.DarkOliveGreen;
            grpCategorias.Location = new Point(20, 70);
            grpCategorias.Name = "grpCategorias";
            grpCategorias.Size = new Size(300, 435);
            grpCategorias.TabIndex = 1;
            grpCategorias.TabStop = false;
            grpCategorias.Text = "Categorías";
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AllowUserToResizeRows = false;
            dgvCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvCategorias.BackgroundColor = Color.White;
            dgvCategorias.BorderStyle = BorderStyle.None;
            dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategorias.ColumnHeadersHeight = 30;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { colCatNombre, colCatActiva });
            dgvCategorias.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCategorias.EnableHeadersVisualStyles = false;
            dgvCategorias.GridColor = Color.Gainsboro;
            dgvCategorias.Location = new Point(10, 25);
            dgvCategorias.MultiSelect = false;
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.RowTemplate.Height = 25;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(280, 200);
            dgvCategorias.TabIndex = 2;
            dgvCategorias.SelectionChanged += dgvCategorias_SelectionChanged;
            // 
            // colCatNombre
            // 
            colCatNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCatNombre.MinimumWidth = 120;
            colCatNombre.HeaderText = "Nombre";
            colCatNombre.Name = "colCatNombre";
            colCatNombre.ReadOnly = true;
            // 
            // colCatActiva
            // 
            colCatActiva.HeaderText = "Activa";
            colCatActiva.Name = "colCatActiva";
            colCatActiva.ReadOnly = true;
            colCatActiva.Width = 60;
            // 
            // dataGridViewCellStyle1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            // 
            // dataGridViewCellStyle2
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            // 
            // dataGridViewCellStyle3
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Honeydew;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            // 
            // dataGridViewCellStyle4
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            // 
            // lblCatNombre
            // 
            lblCatNombre.AutoSize = true;
            lblCatNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCatNombre.ForeColor = Color.DarkSlateGray;
            lblCatNombre.Location = new Point(10, 238);
            lblCatNombre.Name = "lblCatNombre";
            lblCatNombre.Size = new Size(48, 17);
            lblCatNombre.TabIndex = 3;
            lblCatNombre.Text = "Nombre";
            // 
            // txtCatNombre
            // 
            txtCatNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCatNombre.ForeColor = Color.Black;
            txtCatNombre.Location = new Point(10, 258);
            txtCatNombre.Name = "txtCatNombre";
            txtCatNombre.Size = new Size(280, 25);
            txtCatNombre.TabIndex = 4;
            // 
            // lblCatDescripcion
            // 
            lblCatDescripcion.AutoSize = true;
            lblCatDescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCatDescripcion.ForeColor = Color.DarkSlateGray;
            lblCatDescripcion.Location = new Point(10, 290);
            lblCatDescripcion.Name = "lblCatDescripcion";
            lblCatDescripcion.Size = new Size(85, 17);
            lblCatDescripcion.TabIndex = 5;
            lblCatDescripcion.Text = "Descripción";
            // 
            // txtCatDescripcion
            // 
            txtCatDescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCatDescripcion.ForeColor = Color.Black;
            txtCatDescripcion.Location = new Point(10, 310);
            txtCatDescripcion.Multiline = true;
            txtCatDescripcion.Name = "txtCatDescripcion";
            txtCatDescripcion.Size = new Size(280, 50);
            txtCatDescripcion.TabIndex = 6;
            txtCatDescripcion.ScrollBars = ScrollBars.Vertical;
            // 
            // chkCatActiva
            // 
            chkCatActiva.AutoSize = true;
            chkCatActiva.Checked = true;
            chkCatActiva.CheckState = CheckState.Checked;
            chkCatActiva.Cursor = Cursors.Hand;
            chkCatActiva.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkCatActiva.ForeColor = Color.DarkSlateGray;
            chkCatActiva.Location = new Point(10, 368);
            chkCatActiva.Name = "chkCatActiva";
            chkCatActiva.Size = new Size(140, 21);
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
            btnNuevaCategoria.Location = new Point(10, 392);
            btnNuevaCategoria.Name = "btnNuevaCategoria";
            btnNuevaCategoria.Size = new Size(135, 34);
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
            btnGuardarCategoria.Location = new Point(155, 392);
            btnGuardarCategoria.Name = "btnGuardarCategoria";
            btnGuardarCategoria.Size = new Size(135, 34);
            btnGuardarCategoria.TabIndex = 9;
            btnGuardarCategoria.Text = "💾 Guardar";
            btnGuardarCategoria.UseVisualStyleBackColor = false;
            btnGuardarCategoria.Click += btnGuardarCategoria_Click;
            // 
            // grpProductos
            // 
            grpProductos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpProductos.ForeColor = Color.DarkOliveGreen;
            grpProductos.Location = new Point(340, 70);
            grpProductos.Name = "grpProductos";
            grpProductos.Size = new Size(600, 435);
            grpProductos.TabIndex = 10;
            grpProductos.TabStop = false;
            grpProductos.Text = "Productos de la categoría";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvProductos.ColumnHeadersHeight = 30;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colProdSku, colProdNombre, colProdCompra, colProdVenta, colProdMinimo, colProdActivo });
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle6;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = Color.Gainsboro;
            dgvProductos.Location = new Point(10, 25);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(580, 235);
            dgvProductos.TabIndex = 11;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // colProdSku
            // 
            colProdSku.HeaderText = "SKU";
            colProdSku.Name = "colProdSku";
            colProdSku.ReadOnly = true;
            colProdSku.Width = 80;
            // 
            // colProdNombre
            // 
            colProdNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProdNombre.MinimumWidth = 160;
            colProdNombre.HeaderText = "Producto";
            colProdNombre.Name = "colProdNombre";
            colProdNombre.ReadOnly = true;
            // 
            // colProdCompra
            // 
            colProdCompra.DefaultCellStyle = dataGridViewCellStyle8;
            colProdCompra.HeaderText = "P. compra";
            colProdCompra.Name = "colProdCompra";
            colProdCompra.ReadOnly = true;
            colProdCompra.Width = 80;
            // 
            // colProdVenta
            // 
            colProdVenta.DefaultCellStyle = dataGridViewCellStyle8;
            colProdVenta.HeaderText = "P. venta";
            colProdVenta.Name = "colProdVenta";
            colProdVenta.ReadOnly = true;
            colProdVenta.Width = 80;
            // 
            // colProdMinimo
            // 
            colProdMinimo.DefaultCellStyle = dataGridViewCellStyle8;
            colProdMinimo.HeaderText = "Mínimo";
            colProdMinimo.Name = "colProdMinimo";
            colProdMinimo.ReadOnly = true;
            colProdMinimo.Width = 65;
            // 
            // colProdActivo
            // 
            colProdActivo.HeaderText = "Activo";
            colProdActivo.Name = "colProdActivo";
            colProdActivo.ReadOnly = true;
            colProdActivo.Width = 60;
            // 
            // dataGridViewCellStyle5
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            // 
            // dataGridViewCellStyle6
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            // 
            // dataGridViewCellStyle7
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.Honeydew;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            // 
            // dataGridViewCellStyle8
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            // 
            // lblProductoSel
            // 
            lblProductoSel.AutoSize = true;
            lblProductoSel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductoSel.ForeColor = Color.DarkOliveGreen;
            lblProductoSel.Location = new Point(10, 272);
            lblProductoSel.Name = "lblProductoSel";
            lblProductoSel.Size = new Size(166, 17);
            lblProductoSel.TabIndex = 12;
            lblProductoSel.Text = "Seleccione un producto";
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.AutoSize = true;
            lblPrecioCompra.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioCompra.ForeColor = Color.DarkSlateGray;
            lblPrecioCompra.Location = new Point(10, 302);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new Size(122, 17);
            lblPrecioCompra.TabIndex = 13;
            lblPrecioCompra.Text = "Precio de compra";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioCompra.ForeColor = Color.Black;
            txtPrecioCompra.Location = new Point(10, 322);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(120, 25);
            txtPrecioCompra.TabIndex = 14;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioVenta.ForeColor = Color.DarkSlateGray;
            lblPrecioVenta.Location = new Point(150, 302);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(115, 17);
            lblPrecioVenta.TabIndex = 15;
            lblPrecioVenta.Text = "Precio de venta";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioVenta.ForeColor = Color.Black;
            txtPrecioVenta.Location = new Point(150, 322);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(120, 25);
            txtPrecioVenta.TabIndex = 16;
            // 
            // lblStockMinimo
            // 
            lblStockMinimo.AutoSize = true;
            lblStockMinimo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockMinimo.ForeColor = Color.DarkSlateGray;
            lblStockMinimo.Location = new Point(290, 302);
            lblStockMinimo.Name = "lblStockMinimo";
            lblStockMinimo.Size = new Size(92, 17);
            lblStockMinimo.TabIndex = 17;
            lblStockMinimo.Text = "Stock mínimo";
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStockMinimo.ForeColor = Color.Black;
            txtStockMinimo.Location = new Point(290, 322);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(120, 25);
            txtStockMinimo.TabIndex = 18;
            // 
            // chkProdActivo
            // 
            chkProdActivo.AutoSize = true;
            chkProdActivo.Cursor = Cursors.Hand;
            chkProdActivo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkProdActivo.ForeColor = Color.DarkSlateGray;
            chkProdActivo.Location = new Point(430, 324);
            chkProdActivo.Name = "chkProdActivo";
            chkProdActivo.Size = new Size(133, 21);
            chkProdActivo.TabIndex = 19;
            chkProdActivo.Text = "Producto activo";
            chkProdActivo.UseVisualStyleBackColor = true;
            // 
            // lblMargen
            // 
            lblMargen.AutoSize = true;
            lblMargen.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMargen.ForeColor = Color.Black;
            lblMargen.Location = new Point(10, 360);
            lblMargen.Name = "lblMargen";
            lblMargen.Size = new Size(107, 17);
            lblMargen.TabIndex = 20;
            lblMargen.Text = "Margen bruto: -";
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.BackColor = Color.DarkOliveGreen;
            btnGuardarProducto.Cursor = Cursors.Hand;
            btnGuardarProducto.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarProducto.ForeColor = Color.White;
            btnGuardarProducto.Location = new Point(10, 388);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(200, 38);
            btnGuardarProducto.TabIndex = 21;
            btnGuardarProducto.Text = "💾 Guardar producto";
            btnGuardarProducto.UseVisualStyleBackColor = false;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            grpCategorias.Controls.Add(dgvCategorias);
            grpCategorias.Controls.Add(lblCatNombre);
            grpCategorias.Controls.Add(txtCatNombre);
            grpCategorias.Controls.Add(lblCatDescripcion);
            grpCategorias.Controls.Add(txtCatDescripcion);
            grpCategorias.Controls.Add(chkCatActiva);
            grpCategorias.Controls.Add(btnNuevaCategoria);
            grpCategorias.Controls.Add(btnGuardarCategoria);
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
            // 
            // UC_ProductosCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblProductosCategorias);
            Controls.Add(grpCategorias);
            Controls.Add(grpProductos);
            Name = "UC_ProductosCategorias";
            Size = new Size(960, 610);
            Load += UC_ProductosCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            grpCategorias.ResumeLayout(false);
            grpCategorias.PerformLayout();
            grpProductos.ResumeLayout(false);
            grpProductos.PerformLayout();
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
