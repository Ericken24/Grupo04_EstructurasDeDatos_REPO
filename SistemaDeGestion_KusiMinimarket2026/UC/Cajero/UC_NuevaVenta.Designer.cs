namespace SistemaDeGestion_KusiMinimarket2026.UC.Cajero
{
    partial class UC_NuevaVenta
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            lblPuntoVenta = new Label();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            dgvProductos = new DataGridView();
            colProductosSku = new DataGridViewTextBoxColumn();
            colProductosNombre = new DataGridViewTextBoxColumn();
            colProductosUnidad = new DataGridViewTextBoxColumn();
            colProductosPrecio = new DataGridViewTextBoxColumn();
            colProductosStock = new DataGridViewTextBoxColumn();
            lblCantidad = new Label();
            nudCantidad = new NumericUpDown();
            btnAgregar = new Button();
            lblCarrito = new Label();
            dgvCarrito = new DataGridView();
            colCarritoProducto = new DataGridViewTextBoxColumn();
            colCarritoCantidad = new DataGridViewTextBoxColumn();
            colCarritoPrecio = new DataGridViewTextBoxColumn();
            colCarritoImporte = new DataGridViewTextBoxColumn();
            btnDeshacer = new Button();
            btnVaciar = new Button();
            lblMetodoPago = new Label();
            cboMetodoPago = new ComboBox();
            lblReferencia = new Label();
            txtReferencia = new TextBox();
            lblTotal = new Label();
            btnCobrar = new Button();
            btnEnEspera = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // lblPuntoVenta
            // 
            lblPuntoVenta.AutoSize = true;
            lblPuntoVenta.BackColor = Color.Transparent;
            lblPuntoVenta.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblPuntoVenta.Location = new Point(15, 23);
            lblPuntoVenta.Name = "lblPuntoVenta";
            lblPuntoVenta.Size = new Size(272, 46);
            lblPuntoVenta.TabIndex = 0;
            lblPuntoVenta.Text = "Punto de venta";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.ForeColor = Color.DarkSlateGray;
            lblBuscar.Location = new Point(23, 96);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(339, 23);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar producto (nombre, SKU o código)";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.Black;
            txtBuscar.Location = new Point(23, 123);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(613, 29);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Honeydew;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.ColumnHeadersHeight = 30;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colProductosSku, colProductosNombre, colProductosUnidad, colProductosPrecio, colProductosStock });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle4;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = Color.Gainsboro;
            dgvProductos.Location = new Point(23, 167);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(613, 433);
            dgvProductos.TabIndex = 3;
            dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
            // 
            // colProductosSku
            // 
            colProductosSku.HeaderText = "SKU";
            colProductosSku.MinimumWidth = 6;
            colProductosSku.Name = "colProductosSku";
            colProductosSku.ReadOnly = true;
            colProductosSku.Width = 80;
            // 
            // colProductosNombre
            // 
            colProductosNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProductosNombre.HeaderText = "Producto";
            colProductosNombre.MinimumWidth = 150;
            colProductosNombre.Name = "colProductosNombre";
            colProductosNombre.ReadOnly = true;
            // 
            // colProductosUnidad
            // 
            colProductosUnidad.HeaderText = "Und.";
            colProductosUnidad.MinimumWidth = 6;
            colProductosUnidad.Name = "colProductosUnidad";
            colProductosUnidad.ReadOnly = true;
            colProductosUnidad.Width = 50;
            // 
            // colProductosPrecio
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            colProductosPrecio.DefaultCellStyle = dataGridViewCellStyle3;
            colProductosPrecio.HeaderText = "Precio S/";
            colProductosPrecio.MinimumWidth = 6;
            colProductosPrecio.Name = "colProductosPrecio";
            colProductosPrecio.ReadOnly = true;
            colProductosPrecio.Width = 70;
            // 
            // colProductosStock
            // 
            colProductosStock.DefaultCellStyle = dataGridViewCellStyle3;
            colProductosStock.HeaderText = "Stock";
            colProductosStock.MinimumWidth = 6;
            colProductosStock.Name = "colProductosStock";
            colProductosStock.ReadOnly = true;
            colProductosStock.Width = 60;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = Color.DarkSlateGray;
            lblCantidad.Location = new Point(23, 629);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(88, 23);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad:";
            // 
            // nudCantidad
            // 
            nudCantidad.DecimalPlaces = 2;
            nudCantidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCantidad.ForeColor = Color.Black;
            nudCantidad.Location = new Point(114, 624);
            nudCantidad.Margin = new Padding(3, 4, 3, 4);
            nudCantidad.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(91, 29);
            nudCantidad.TabIndex = 5;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkOliveGreen;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(217, 613);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(309, 51);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "\U0001f6d2 Agregar al carrito";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblCarrito
            // 
            lblCarrito.AutoSize = true;
            lblCarrito.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarrito.ForeColor = Color.DarkSlateGray;
            lblCarrito.Location = new Point(654, 96);
            lblCarrito.Name = "lblCarrito";
            lblCarrito.Size = new Size(157, 23);
            lblCarrito.TabIndex = 7;
            lblCarrito.Text = "Carrito de compra";
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToDeleteRows = false;
            dgvCarrito.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Honeydew;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvCarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvCarrito.BackgroundColor = Color.White;
            dgvCarrito.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvCarrito.ColumnHeadersHeight = 30;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { colCarritoProducto, colCarritoCantidad, colCarritoPrecio, colCarritoImporte });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvCarrito.DefaultCellStyle = dataGridViewCellStyle8;
            dgvCarrito.EnableHeadersVisualStyles = false;
            dgvCarrito.GridColor = Color.Gainsboro;
            dgvCarrito.Location = new Point(654, 123);
            dgvCarrito.Margin = new Padding(3, 4, 3, 4);
            dgvCarrito.MultiSelect = false;
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.RowTemplate.Height = 25;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.Size = new Size(526, 344);
            dgvCarrito.TabIndex = 8;
            // 
            // colCarritoProducto
            // 
            colCarritoProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCarritoProducto.HeaderText = "Producto";
            colCarritoProducto.MinimumWidth = 140;
            colCarritoProducto.Name = "colCarritoProducto";
            colCarritoProducto.ReadOnly = true;
            // 
            // colCarritoCantidad
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCarritoCantidad.DefaultCellStyle = dataGridViewCellStyle7;
            colCarritoCantidad.HeaderText = "Cant.";
            colCarritoCantidad.MinimumWidth = 6;
            colCarritoCantidad.Name = "colCarritoCantidad";
            colCarritoCantidad.ReadOnly = true;
            colCarritoCantidad.Width = 60;
            // 
            // colCarritoPrecio
            // 
            colCarritoPrecio.DefaultCellStyle = dataGridViewCellStyle7;
            colCarritoPrecio.HeaderText = "P. unit.";
            colCarritoPrecio.MinimumWidth = 6;
            colCarritoPrecio.Name = "colCarritoPrecio";
            colCarritoPrecio.ReadOnly = true;
            colCarritoPrecio.Width = 75;
            // 
            // colCarritoImporte
            // 
            colCarritoImporte.DefaultCellStyle = dataGridViewCellStyle7;
            colCarritoImporte.HeaderText = "Importe";
            colCarritoImporte.MinimumWidth = 6;
            colCarritoImporte.Name = "colCarritoImporte";
            colCarritoImporte.ReadOnly = true;
            colCarritoImporte.Width = 80;
            // 
            // btnDeshacer
            // 
            btnDeshacer.BackColor = Color.DarkOliveGreen;
            btnDeshacer.Cursor = Cursors.Hand;
            btnDeshacer.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeshacer.ForeColor = Color.White;
            btnDeshacer.Location = new Point(654, 480);
            btnDeshacer.Margin = new Padding(3, 4, 3, 4);
            btnDeshacer.Name = "btnDeshacer";
            btnDeshacer.Size = new Size(257, 48);
            btnDeshacer.TabIndex = 9;
            btnDeshacer.Text = "↩ Deshacer último";
            btnDeshacer.UseVisualStyleBackColor = false;
            btnDeshacer.Click += btnDeshacer_Click;
            // 
            // btnVaciar
            // 
            btnVaciar.BackColor = Color.Brown;
            btnVaciar.Cursor = Cursors.Hand;
            btnVaciar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVaciar.ForeColor = Color.White;
            btnVaciar.Location = new Point(922, 480);
            btnVaciar.Margin = new Padding(3, 4, 3, 4);
            btnVaciar.Name = "btnVaciar";
            btnVaciar.Size = new Size(257, 48);
            btnVaciar.TabIndex = 10;
            btnVaciar.Text = "🗑 Vaciar";
            btnVaciar.UseVisualStyleBackColor = false;
            btnVaciar.Click += btnVaciar_Click;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMetodoPago.ForeColor = Color.DarkSlateGray;
            lblMetodoPago.Location = new Point(654, 547);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(144, 23);
            lblMetodoPago.TabIndex = 11;
            lblMetodoPago.Text = "Método de pago";
            // 
            // cboMetodoPago
            // 
            cboMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMetodoPago.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMetodoPago.ForeColor = Color.Black;
            cboMetodoPago.FormattingEnabled = true;
            cboMetodoPago.Location = new Point(654, 573);
            cboMetodoPago.Margin = new Padding(3, 4, 3, 4);
            cboMetodoPago.Name = "cboMetodoPago";
            cboMetodoPago.Size = new Size(251, 29);
            cboMetodoPago.TabIndex = 12;
            cboMetodoPago.SelectedIndexChanged += cboMetodoPago_SelectedIndexChanged;
            // 
            // lblReferencia
            // 
            lblReferencia.AutoSize = true;
            lblReferencia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReferencia.ForeColor = Color.DarkSlateGray;
            lblReferencia.Location = new Point(928, 547);
            lblReferencia.Name = "lblReferencia";
            lblReferencia.Size = new Size(145, 23);
            lblReferencia.TabIndex = 13;
            lblReferencia.Text = "N.º de operación";
            // 
            // txtReferencia
            // 
            txtReferencia.Enabled = false;
            txtReferencia.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReferencia.ForeColor = Color.Black;
            txtReferencia.Location = new Point(928, 573);
            txtReferencia.Margin = new Padding(3, 4, 3, 4);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(251, 29);
            txtReferencia.TabIndex = 14;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.DarkOliveGreen;
            lblTotal.Location = new Point(654, 624);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(225, 37);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "TOTAL:  S/ 0.00";
            // 
            // btnCobrar
            // 
            btnCobrar.BackColor = Color.DarkOliveGreen;
            btnCobrar.Cursor = Cursors.Hand;
            btnCobrar.Enabled = false;
            btnCobrar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCobrar.ForeColor = Color.White;
            btnCobrar.Location = new Point(654, 693);
            btnCobrar.Margin = new Padding(3, 4, 3, 4);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(257, 56);
            btnCobrar.TabIndex = 16;
            btnCobrar.Text = "💵 Cobrar";
            btnCobrar.UseVisualStyleBackColor = false;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // btnEnEspera
            // 
            btnEnEspera.BackColor = Color.DarkOliveGreen;
            btnEnEspera.Cursor = Cursors.Hand;
            btnEnEspera.Enabled = false;
            btnEnEspera.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnEspera.ForeColor = Color.White;
            btnEnEspera.Location = new Point(922, 693);
            btnEnEspera.Margin = new Padding(3, 4, 3, 4);
            btnEnEspera.Name = "btnEnEspera";
            btnEnEspera.Size = new Size(257, 56);
            btnEnEspera.TabIndex = 17;
            btnEnEspera.Text = "⌚ Poner en espera";
            btnEnEspera.UseVisualStyleBackColor = false;
            btnEnEspera.Click += btnEnEspera_Click;
            // 
            // UC_NuevaVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblPuntoVenta);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(dgvProductos);
            Controls.Add(lblCantidad);
            Controls.Add(nudCantidad);
            Controls.Add(btnAgregar);
            Controls.Add(lblCarrito);
            Controls.Add(dgvCarrito);
            Controls.Add(btnDeshacer);
            Controls.Add(btnVaciar);
            Controls.Add(lblMetodoPago);
            Controls.Add(cboMetodoPago);
            Controls.Add(lblReferencia);
            Controls.Add(txtReferencia);
            Controls.Add(lblTotal);
            Controls.Add(btnCobrar);
            Controls.Add(btnEnEspera);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_NuevaVenta";
            Size = new Size(1200, 813);
            Load += UC_NuevaVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPuntoVenta;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private DataGridView dgvProductos;
        private Label lblCantidad;
        private NumericUpDown nudCantidad;
        private Button btnAgregar;
        private Label lblCarrito;
        private DataGridView dgvCarrito;
        private Button btnDeshacer;
        private Button btnVaciar;
        private Label lblMetodoPago;
        private ComboBox cboMetodoPago;
        private Label lblReferencia;
        private TextBox txtReferencia;
        private Label lblTotal;
        private Button btnCobrar;
        private Button btnEnEspera;
        private DataGridViewTextBoxColumn colProductosSku;
        private DataGridViewTextBoxColumn colProductosNombre;
        private DataGridViewTextBoxColumn colProductosUnidad;
        private DataGridViewTextBoxColumn colProductosPrecio;
        private DataGridViewTextBoxColumn colProductosStock;
        private DataGridViewCellStyle dataGridViewCellStyle1;
        private DataGridViewCellStyle dataGridViewCellStyle2;
        private DataGridViewCellStyle dataGridViewCellStyle3;
        private DataGridViewCellStyle dataGridViewCellStyle4;
        private DataGridViewTextBoxColumn colCarritoProducto;
        private DataGridViewTextBoxColumn colCarritoCantidad;
        private DataGridViewTextBoxColumn colCarritoPrecio;
        private DataGridViewTextBoxColumn colCarritoImporte;
        private DataGridViewCellStyle dataGridViewCellStyle5;
        private DataGridViewCellStyle dataGridViewCellStyle6;
        private DataGridViewCellStyle dataGridViewCellStyle7;
        private DataGridViewCellStyle dataGridViewCellStyle8;
    }
}
