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
            lblPuntoVenta = new Label();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            dgvProductos = new DataGridView();
            lblCantidad = new Label();
            nudCantidad = new NumericUpDown();
            btnAgregar = new Button();
            lblCarrito = new Label();
            dgvCarrito = new DataGridView();
            btnDeshacer = new Button();
            btnVaciar = new Button();
            lblMetodoPago = new Label();
            cboMetodoPago = new ComboBox();
            lblReferencia = new Label();
            txtReferencia = new TextBox();
            lblTotal = new Label();
            btnCobrar = new Button();
            btnEnEspera = new Button();
            dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewCellStyle4 = new DataGridViewCellStyle();
            colProductosSku = new DataGridViewTextBoxColumn();
            colProductosNombre = new DataGridViewTextBoxColumn();
            colProductosUnidad = new DataGridViewTextBoxColumn();
            colProductosPrecio = new DataGridViewTextBoxColumn();
            colProductosStock = new DataGridViewTextBoxColumn();
            dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridViewCellStyle7 = new DataGridViewCellStyle();
            dataGridViewCellStyle8 = new DataGridViewCellStyle();
            colCarritoProducto = new DataGridViewTextBoxColumn();
            colCarritoCantidad = new DataGridViewTextBoxColumn();
            colCarritoPrecio = new DataGridViewTextBoxColumn();
            colCarritoImporte = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblPuntoVenta
            // 
            lblPuntoVenta.AutoSize = true;
            lblPuntoVenta.BackColor = Color.Transparent;
            lblPuntoVenta.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblPuntoVenta.Text = "Punto de venta";
            lblPuntoVenta.Location = new Point(13, 17);
            lblPuntoVenta.Name = "lblPuntoVenta";
            lblPuntoVenta.Size = new Size(219, 37);
            lblPuntoVenta.TabIndex = 0;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.ForeColor = Color.DarkSlateGray;
            lblBuscar.Text = "Buscar producto (nombre, SKU o código)";
            lblBuscar.Location = new Point(20, 72);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(255, 17);
            lblBuscar.TabIndex = 1;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.Black;
            txtBuscar.Location = new Point(20, 92);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(440, 25);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeight = 30;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colProductosSku, colProductosNombre, colProductosUnidad, colProductosPrecio, colProductosStock });
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = Color.Gainsboro;
            dgvProductos.Location = new Point(20, 125);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(440, 325);
            dgvProductos.TabIndex = 3;
            dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
            // 
            // colProductosSku
            // 
            colProductosSku.HeaderText = "SKU";
            colProductosSku.Name = "colProductosSku";
            colProductosSku.ReadOnly = true;
            colProductosSku.Width = 80;
            // 
            // colProductosNombre
            // 
            colProductosNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProductosNombre.MinimumWidth = 150;
            colProductosNombre.HeaderText = "Producto";
            colProductosNombre.Name = "colProductosNombre";
            colProductosNombre.ReadOnly = true;
            // 
            // colProductosUnidad
            // 
            colProductosUnidad.HeaderText = "Und.";
            colProductosUnidad.Name = "colProductosUnidad";
            colProductosUnidad.ReadOnly = true;
            colProductosUnidad.Width = 50;
            // 
            // colProductosPrecio
            // 
            colProductosPrecio.DefaultCellStyle = dataGridViewCellStyle4;
            colProductosPrecio.HeaderText = "Precio S/";
            colProductosPrecio.Name = "colProductosPrecio";
            colProductosPrecio.ReadOnly = true;
            colProductosPrecio.Width = 70;
            // 
            // colProductosStock
            // 
            colProductosStock.DefaultCellStyle = dataGridViewCellStyle4;
            colProductosStock.HeaderText = "Stock";
            colProductosStock.Name = "colProductosStock";
            colProductosStock.ReadOnly = true;
            colProductosStock.Width = 60;
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
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = Color.DarkSlateGray;
            lblCantidad.Text = "Cantidad:";
            lblCantidad.Location = new Point(20, 472);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(63, 17);
            lblCantidad.TabIndex = 4;
            // 
            // nudCantidad
            // 
            nudCantidad.DecimalPlaces = 2;
            nudCantidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCantidad.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.ForeColor = Color.Black;
            nudCantidad.Location = new Point(100, 468);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(80, 25);
            nudCantidad.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkOliveGreen;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Text = "🛒 Agregar al carrito";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Location = new Point(190, 460);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(270, 38);
            btnAgregar.TabIndex = 6;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblCarrito
            // 
            lblCarrito.AutoSize = true;
            lblCarrito.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarrito.ForeColor = Color.DarkSlateGray;
            lblCarrito.Text = "Carrito de compra";
            lblCarrito.Location = new Point(480, 72);
            lblCarrito.Name = "lblCarrito";
            lblCarrito.Size = new Size(120, 17);
            lblCarrito.TabIndex = 7;
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToDeleteRows = false;
            dgvCarrito.AllowUserToResizeRows = false;
            dgvCarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvCarrito.BackgroundColor = Color.White;
            dgvCarrito.BorderStyle = BorderStyle.None;
            dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvCarrito.ColumnHeadersHeight = 30;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { colCarritoProducto, colCarritoCantidad, colCarritoPrecio, colCarritoImporte });
            dgvCarrito.DefaultCellStyle = dataGridViewCellStyle6;
            dgvCarrito.EnableHeadersVisualStyles = false;
            dgvCarrito.GridColor = Color.Gainsboro;
            dgvCarrito.Location = new Point(480, 95);
            dgvCarrito.MultiSelect = false;
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.RowTemplate.Height = 25;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.Size = new Size(460, 255);
            dgvCarrito.TabIndex = 8;
            // 
            // colCarritoProducto
            // 
            colCarritoProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCarritoProducto.MinimumWidth = 140;
            colCarritoProducto.HeaderText = "Producto";
            colCarritoProducto.Name = "colCarritoProducto";
            colCarritoProducto.ReadOnly = true;
            // 
            // colCarritoCantidad
            // 
            colCarritoCantidad.DefaultCellStyle = dataGridViewCellStyle8;
            colCarritoCantidad.HeaderText = "Cant.";
            colCarritoCantidad.Name = "colCarritoCantidad";
            colCarritoCantidad.ReadOnly = true;
            colCarritoCantidad.Width = 60;
            // 
            // colCarritoPrecio
            // 
            colCarritoPrecio.DefaultCellStyle = dataGridViewCellStyle8;
            colCarritoPrecio.HeaderText = "P. unit.";
            colCarritoPrecio.Name = "colCarritoPrecio";
            colCarritoPrecio.ReadOnly = true;
            colCarritoPrecio.Width = 75;
            // 
            // colCarritoImporte
            // 
            colCarritoImporte.DefaultCellStyle = dataGridViewCellStyle8;
            colCarritoImporte.HeaderText = "Importe";
            colCarritoImporte.Name = "colCarritoImporte";
            colCarritoImporte.ReadOnly = true;
            colCarritoImporte.Width = 80;
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
            // btnDeshacer
            // 
            btnDeshacer.BackColor = Color.DarkOliveGreen;
            btnDeshacer.Cursor = Cursors.Hand;
            btnDeshacer.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeshacer.ForeColor = Color.White;
            btnDeshacer.Text = "↩ Deshacer último";
            btnDeshacer.UseVisualStyleBackColor = false;
            btnDeshacer.Location = new Point(480, 360);
            btnDeshacer.Name = "btnDeshacer";
            btnDeshacer.Size = new Size(225, 36);
            btnDeshacer.TabIndex = 9;
            btnDeshacer.Click += btnDeshacer_Click;
            // 
            // btnVaciar
            // 
            btnVaciar.BackColor = Color.Brown;
            btnVaciar.Cursor = Cursors.Hand;
            btnVaciar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVaciar.ForeColor = Color.White;
            btnVaciar.Text = "🗑 Vaciar";
            btnVaciar.UseVisualStyleBackColor = false;
            btnVaciar.Location = new Point(715, 360);
            btnVaciar.Name = "btnVaciar";
            btnVaciar.Size = new Size(225, 36);
            btnVaciar.TabIndex = 10;
            btnVaciar.Click += btnVaciar_Click;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMetodoPago.ForeColor = Color.DarkSlateGray;
            lblMetodoPago.Text = "Método de pago";
            lblMetodoPago.Location = new Point(480, 410);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(100, 17);
            lblMetodoPago.TabIndex = 11;
            // 
            // cboMetodoPago
            // 
            cboMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMetodoPago.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMetodoPago.FormattingEnabled = true;
            cboMetodoPago.ForeColor = Color.Black;
            cboMetodoPago.Location = new Point(480, 430);
            cboMetodoPago.Name = "cboMetodoPago";
            cboMetodoPago.Size = new Size(220, 25);
            cboMetodoPago.TabIndex = 12;
            cboMetodoPago.SelectedIndexChanged += cboMetodoPago_SelectedIndexChanged;
            // 
            // lblReferencia
            // 
            lblReferencia.AutoSize = true;
            lblReferencia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReferencia.ForeColor = Color.DarkSlateGray;
            lblReferencia.Text = "N.º de operación";
            lblReferencia.Location = new Point(720, 410);
            lblReferencia.Name = "lblReferencia";
            lblReferencia.Size = new Size(105, 17);
            lblReferencia.TabIndex = 13;
            // 
            // txtReferencia
            // 
            txtReferencia.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReferencia.Enabled = false;
            txtReferencia.ForeColor = Color.Black;
            txtReferencia.Location = new Point(720, 430);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(220, 25);
            txtReferencia.TabIndex = 14;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.DarkOliveGreen;
            lblTotal.Text = "TOTAL:  S/ 0.00";
            lblTotal.Location = new Point(480, 468);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(260, 30);
            lblTotal.TabIndex = 15;
            // 
            // btnCobrar
            // 
            btnCobrar.BackColor = Color.DarkOliveGreen;
            btnCobrar.Cursor = Cursors.Hand;
            btnCobrar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCobrar.ForeColor = Color.White;
            btnCobrar.Text = "💵 Cobrar";
            btnCobrar.UseVisualStyleBackColor = false;
            btnCobrar.Enabled = false;
            btnCobrar.Location = new Point(480, 520);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(225, 42);
            btnCobrar.TabIndex = 16;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // btnEnEspera
            // 
            btnEnEspera.BackColor = Color.DarkOliveGreen;
            btnEnEspera.Cursor = Cursors.Hand;
            btnEnEspera.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnEspera.ForeColor = Color.White;
            btnEnEspera.Text = "⌚ Poner en espera";
            btnEnEspera.UseVisualStyleBackColor = false;
            btnEnEspera.Enabled = false;
            btnEnEspera.Location = new Point(715, 520);
            btnEnEspera.Name = "btnEnEspera";
            btnEnEspera.Size = new Size(225, 42);
            btnEnEspera.TabIndex = 17;
            btnEnEspera.Click += btnEnEspera_Click;
            // 
            // UC_NuevaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Name = "UC_NuevaVenta";
            Size = new Size(960, 610);
            Load += UC_NuevaVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
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
