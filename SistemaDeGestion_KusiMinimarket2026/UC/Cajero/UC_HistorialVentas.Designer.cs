namespace SistemaDeGestion_KusiMinimarket2026.UC.Cajero
{
    partial class UC_HistorialVentas
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
            lblHistorialVentas = new Label();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            dgvVentas = new DataGridView();
            colVentasCodigo = new DataGridViewTextBoxColumn();
            colVentasFecha = new DataGridViewTextBoxColumn();
            colVentasMetodo = new DataGridViewTextBoxColumn();
            colVentasEstado = new DataGridViewTextBoxColumn();
            colVentasTotal = new DataGridViewTextBoxColumn();
            grpDetalle = new GroupBox();
            lblCodigoTitulo = new Label();
            lblCodigo = new Label();
            lblFechaTitulo = new Label();
            lblFecha = new Label();
            lblMetodoTitulo = new Label();
            lblMetodo = new Label();
            lblEstadoTitulo = new Label();
            lblEstado = new Label();
            dgvDetalle = new DataGridView();
            colDetalleProducto = new DataGridViewTextBoxColumn();
            colDetalleCantidad = new DataGridViewTextBoxColumn();
            colDetallePrecio = new DataGridViewTextBoxColumn();
            colDetalleImporte = new DataGridViewTextBoxColumn();
            lblTotalDetalle = new Label();
            btnPrimera = new Button();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            btnUltima = new Button();
            lblPosicion = new Label();
            btnAnularUltima = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // lblHistorialVentas
            // 
            lblHistorialVentas.AutoSize = true;
            lblHistorialVentas.BackColor = Color.Transparent;
            lblHistorialVentas.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblHistorialVentas.Location = new Point(15, 23);
            lblHistorialVentas.Name = "lblHistorialVentas";
            lblHistorialVentas.Size = new Size(331, 46);
            lblHistorialVentas.TabIndex = 0;
            lblHistorialVentas.Text = "Historial de ventas";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.ForeColor = Color.DarkSlateGray;
            lblBuscar.Location = new Point(23, 104);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(160, 23);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar por código:";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.Black;
            txtBuscar.Location = new Point(189, 99);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(428, 29);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Honeydew;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVentas.ColumnHeadersHeight = 30;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { colVentasCodigo, colVentasFecha, colVentasMetodo, colVentasEstado, colVentasTotal });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvVentas.DefaultCellStyle = dataGridViewCellStyle4;
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.GridColor = Color.Gainsboro;
            dgvVentas.Location = new Point(23, 147);
            dgvVentas.Margin = new Padding(3, 4, 3, 4);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.RowTemplate.Height = 25;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(594, 527);
            dgvVentas.TabIndex = 3;
            dgvVentas.SelectionChanged += dgvVentas_SelectionChanged;
            // 
            // colVentasCodigo
            // 
            colVentasCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colVentasCodigo.HeaderText = "Código";
            colVentasCodigo.MinimumWidth = 130;
            colVentasCodigo.Name = "colVentasCodigo";
            colVentasCodigo.ReadOnly = true;
            // 
            // colVentasFecha
            // 
            colVentasFecha.HeaderText = "Fecha";
            colVentasFecha.MinimumWidth = 6;
            colVentasFecha.Name = "colVentasFecha";
            colVentasFecha.ReadOnly = true;
            colVentasFecha.Width = 125;
            // 
            // colVentasMetodo
            // 
            colVentasMetodo.HeaderText = "Método";
            colVentasMetodo.MinimumWidth = 6;
            colVentasMetodo.Name = "colVentasMetodo";
            colVentasMetodo.ReadOnly = true;
            colVentasMetodo.Width = 110;
            // 
            // colVentasEstado
            // 
            colVentasEstado.HeaderText = "Estado";
            colVentasEstado.MinimumWidth = 6;
            colVentasEstado.Name = "colVentasEstado";
            colVentasEstado.ReadOnly = true;
            colVentasEstado.Width = 80;
            // 
            // colVentasTotal
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            colVentasTotal.DefaultCellStyle = dataGridViewCellStyle3;
            colVentasTotal.HeaderText = "Total S/";
            colVentasTotal.MinimumWidth = 6;
            colVentasTotal.Name = "colVentasTotal";
            colVentasTotal.ReadOnly = true;
            colVentasTotal.Width = 75;
            // 
            // grpDetalle
            // 
            grpDetalle.Controls.Add(lblCodigoTitulo);
            grpDetalle.Controls.Add(lblCodigo);
            grpDetalle.Controls.Add(lblFechaTitulo);
            grpDetalle.Controls.Add(lblFecha);
            grpDetalle.Controls.Add(lblMetodoTitulo);
            grpDetalle.Controls.Add(lblMetodo);
            grpDetalle.Controls.Add(lblEstadoTitulo);
            grpDetalle.Controls.Add(lblEstado);
            grpDetalle.Controls.Add(dgvDetalle);
            grpDetalle.Controls.Add(lblTotalDetalle);
            grpDetalle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDetalle.ForeColor = Color.DarkOliveGreen;
            grpDetalle.Location = new Point(640, 147);
            grpDetalle.Margin = new Padding(3, 4, 3, 4);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Padding = new Padding(3, 4, 3, 4);
            grpDetalle.Size = new Size(434, 533);
            grpDetalle.TabIndex = 4;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "Detalle de la venta";
            // 
            // lblCodigoTitulo
            // 
            lblCodigoTitulo.AutoSize = true;
            lblCodigoTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigoTitulo.ForeColor = Color.DarkSlateGray;
            lblCodigoTitulo.Location = new Point(11, 37);
            lblCodigoTitulo.Name = "lblCodigoTitulo";
            lblCodigoTitulo.Size = new Size(73, 23);
            lblCodigoTitulo.TabIndex = 5;
            lblCodigoTitulo.Text = "Código:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigo.ForeColor = Color.Black;
            lblCodigo.Location = new Point(90, 37);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(17, 23);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "-";
            // 
            // lblFechaTitulo
            // 
            lblFechaTitulo.AutoSize = true;
            lblFechaTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaTitulo.ForeColor = Color.DarkSlateGray;
            lblFechaTitulo.Location = new Point(11, 69);
            lblFechaTitulo.Name = "lblFechaTitulo";
            lblFechaTitulo.Size = new Size(60, 23);
            lblFechaTitulo.TabIndex = 7;
            lblFechaTitulo.Text = "Fecha:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = Color.Black;
            lblFecha.Location = new Point(77, 69);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(17, 23);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "-";
            // 
            // lblMetodoTitulo
            // 
            lblMetodoTitulo.AutoSize = true;
            lblMetodoTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMetodoTitulo.ForeColor = Color.DarkSlateGray;
            lblMetodoTitulo.Location = new Point(11, 101);
            lblMetodoTitulo.Name = "lblMetodoTitulo";
            lblMetodoTitulo.Size = new Size(149, 23);
            lblMetodoTitulo.TabIndex = 9;
            lblMetodoTitulo.Text = "Método de pago:";
            // 
            // lblMetodo
            // 
            lblMetodo.AutoSize = true;
            lblMetodo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMetodo.ForeColor = Color.Black;
            lblMetodo.Location = new Point(166, 101);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(17, 23);
            lblMetodo.TabIndex = 10;
            lblMetodo.Text = "-";
            // 
            // lblEstadoTitulo
            // 
            lblEstadoTitulo.AutoSize = true;
            lblEstadoTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstadoTitulo.ForeColor = Color.DarkSlateGray;
            lblEstadoTitulo.Location = new Point(11, 133);
            lblEstadoTitulo.Name = "lblEstadoTitulo";
            lblEstadoTitulo.Size = new Size(68, 23);
            lblEstadoTitulo.TabIndex = 11;
            lblEstadoTitulo.Text = "Estado:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.Black;
            lblEstado.Location = new Point(85, 133);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(17, 23);
            lblEstado.TabIndex = 12;
            lblEstado.Text = "-";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Honeydew;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvDetalle.BackgroundColor = Color.White;
            dgvDetalle.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvDetalle.ColumnHeadersHeight = 30;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { colDetalleProducto, colDetalleCantidad, colDetallePrecio, colDetalleImporte });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.DarkOliveGreen;
            dataGridViewCellStyle8.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvDetalle.DefaultCellStyle = dataGridViewCellStyle8;
            dgvDetalle.EnableHeadersVisualStyles = false;
            dgvDetalle.GridColor = Color.Gainsboro;
            dgvDetalle.Location = new Point(11, 173);
            dgvDetalle.Margin = new Padding(3, 4, 3, 4);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.RowTemplate.Height = 25;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(411, 287);
            dgvDetalle.TabIndex = 13;
            // 
            // colDetalleProducto
            // 
            colDetalleProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDetalleProducto.HeaderText = "Producto";
            colDetalleProducto.MinimumWidth = 110;
            colDetalleProducto.Name = "colDetalleProducto";
            colDetalleProducto.ReadOnly = true;
            // 
            // colDetalleCantidad
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            colDetalleCantidad.DefaultCellStyle = dataGridViewCellStyle7;
            colDetalleCantidad.HeaderText = "Cant.";
            colDetalleCantidad.MinimumWidth = 6;
            colDetalleCantidad.Name = "colDetalleCantidad";
            colDetalleCantidad.ReadOnly = true;
            colDetalleCantidad.Width = 55;
            // 
            // colDetallePrecio
            // 
            colDetallePrecio.DefaultCellStyle = dataGridViewCellStyle7;
            colDetallePrecio.HeaderText = "P. unit.";
            colDetallePrecio.MinimumWidth = 6;
            colDetallePrecio.Name = "colDetallePrecio";
            colDetallePrecio.ReadOnly = true;
            colDetallePrecio.Width = 70;
            // 
            // colDetalleImporte
            // 
            colDetalleImporte.DefaultCellStyle = dataGridViewCellStyle7;
            colDetalleImporte.HeaderText = "Importe";
            colDetalleImporte.MinimumWidth = 6;
            colDetalleImporte.Name = "colDetalleImporte";
            colDetalleImporte.ReadOnly = true;
            colDetalleImporte.Width = 75;
            // 
            // lblTotalDetalle
            // 
            lblTotalDetalle.AutoSize = true;
            lblTotalDetalle.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDetalle.ForeColor = Color.DarkOliveGreen;
            lblTotalDetalle.Location = new Point(11, 477);
            lblTotalDetalle.Name = "lblTotalDetalle";
            lblTotalDetalle.Size = new Size(225, 37);
            lblTotalDetalle.TabIndex = 14;
            lblTotalDetalle.Text = "TOTAL:  S/ 0.00";
            // 
            // btnPrimera
            // 
            btnPrimera.BackColor = Color.DarkOliveGreen;
            btnPrimera.Cursor = Cursors.Hand;
            btnPrimera.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrimera.ForeColor = Color.White;
            btnPrimera.Location = new Point(23, 693);
            btnPrimera.Margin = new Padding(3, 4, 3, 4);
            btnPrimera.Name = "btnPrimera";
            btnPrimera.Size = new Size(137, 51);
            btnPrimera.TabIndex = 15;
            btnPrimera.Text = "⏮ Primera";
            btnPrimera.UseVisualStyleBackColor = false;
            btnPrimera.Click += btnPrimera_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.DarkOliveGreen;
            btnAnterior.Cursor = Cursors.Hand;
            btnAnterior.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnterior.ForeColor = Color.White;
            btnAnterior.Location = new Point(171, 693);
            btnAnterior.Margin = new Padding(3, 4, 3, 4);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(137, 51);
            btnAnterior.TabIndex = 16;
            btnAnterior.Text = "◀ Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.DarkOliveGreen;
            btnSiguiente.Cursor = Cursors.Hand;
            btnSiguiente.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Location = new Point(320, 693);
            btnSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(137, 51);
            btnSiguiente.TabIndex = 17;
            btnSiguiente.Text = "Siguiente ▶";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnUltima
            // 
            btnUltima.BackColor = Color.DarkOliveGreen;
            btnUltima.Cursor = Cursors.Hand;
            btnUltima.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUltima.ForeColor = Color.White;
            btnUltima.Location = new Point(469, 693);
            btnUltima.Margin = new Padding(3, 4, 3, 4);
            btnUltima.Name = "btnUltima";
            btnUltima.Size = new Size(137, 51);
            btnUltima.TabIndex = 18;
            btnUltima.Text = "Última ⏭";
            btnUltima.UseVisualStyleBackColor = false;
            btnUltima.Click += btnUltima_Click;
            // 
            // lblPosicion
            // 
            lblPosicion.AutoSize = true;
            lblPosicion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPosicion.ForeColor = Color.DarkSlateGray;
            lblPosicion.Location = new Point(640, 708);
            lblPosicion.Name = "lblPosicion";
            lblPosicion.Size = new Size(110, 23);
            lblPosicion.TabIndex = 19;
            lblPosicion.Text = "Venta 0 de 0";
            // 
            // btnAnularUltima
            // 
            btnAnularUltima.BackColor = Color.Brown;
            btnAnularUltima.Cursor = Cursors.Hand;
            btnAnularUltima.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnularUltima.ForeColor = Color.White;
            btnAnularUltima.Location = new Point(829, 693);
            btnAnularUltima.Margin = new Padding(3, 4, 3, 4);
            btnAnularUltima.Name = "btnAnularUltima";
            btnAnularUltima.Size = new Size(246, 51);
            btnAnularUltima.TabIndex = 20;
            btnAnularUltima.Text = "↩ Anular última venta";
            btnAnularUltima.UseVisualStyleBackColor = false;
            btnAnularUltima.Click += btnAnularUltima_Click;
            // 
            // UC_HistorialVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblHistorialVentas);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(dgvVentas);
            Controls.Add(grpDetalle);
            Controls.Add(btnPrimera);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(btnUltima);
            Controls.Add(lblPosicion);
            Controls.Add(btnAnularUltima);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_HistorialVentas";
            Size = new Size(1097, 813);
            Load += UC_HistorialVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            grpDetalle.ResumeLayout(false);
            grpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHistorialVentas;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private DataGridView dgvVentas;
        private GroupBox grpDetalle;
        private Label lblCodigoTitulo;
        private Label lblCodigo;
        private Label lblFechaTitulo;
        private Label lblFecha;
        private Label lblMetodoTitulo;
        private Label lblMetodo;
        private Label lblEstadoTitulo;
        private Label lblEstado;
        private DataGridView dgvDetalle;
        private Label lblTotalDetalle;
        private Button btnPrimera;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Button btnUltima;
        private Label lblPosicion;
        private Button btnAnularUltima;
        private DataGridViewTextBoxColumn colVentasCodigo;
        private DataGridViewTextBoxColumn colVentasFecha;
        private DataGridViewTextBoxColumn colVentasMetodo;
        private DataGridViewTextBoxColumn colVentasEstado;
        private DataGridViewTextBoxColumn colVentasTotal;
        private DataGridViewCellStyle dataGridViewCellStyle1;
        private DataGridViewCellStyle dataGridViewCellStyle2;
        private DataGridViewCellStyle dataGridViewCellStyle3;
        private DataGridViewCellStyle dataGridViewCellStyle4;
        private DataGridViewTextBoxColumn colDetalleProducto;
        private DataGridViewTextBoxColumn colDetalleCantidad;
        private DataGridViewTextBoxColumn colDetallePrecio;
        private DataGridViewTextBoxColumn colDetalleImporte;
        private DataGridViewCellStyle dataGridViewCellStyle5;
        private DataGridViewCellStyle dataGridViewCellStyle6;
        private DataGridViewCellStyle dataGridViewCellStyle7;
        private DataGridViewCellStyle dataGridViewCellStyle8;
    }
}
