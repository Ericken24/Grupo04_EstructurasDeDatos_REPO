namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminGeneral
{
    partial class UC_DetalleSucursal
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
            lblDetalleSucursal = new Label();
            lblSucursal = new Label();
            cboSucursal = new ComboBox();
            lblInfoSucursal = new Label();
            lblResumenSuc = new Label();
            dgvVentas = new DataGridView();
            colVentasCodigo = new DataGridViewTextBoxColumn();
            colVentasFecha = new DataGridViewTextBoxColumn();
            colVentasCajero = new DataGridViewTextBoxColumn();
            colVentasEstado = new DataGridViewTextBoxColumn();
            colVentasTotal = new DataGridViewTextBoxColumn();
            grpDetalle = new GroupBox();
            lblCodigoTitulo = new Label();
            lblCodigo = new Label();
            lblCajeroTitulo = new Label();
            lblCajero = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // lblDetalleSucursal
            // 
            lblDetalleSucursal.AutoSize = true;
            lblDetalleSucursal.BackColor = Color.Transparent;
            lblDetalleSucursal.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblDetalleSucursal.Location = new Point(15, 23);
            lblDetalleSucursal.Name = "lblDetalleSucursal";
            lblDetalleSucursal.Size = new Size(349, 46);
            lblDetalleSucursal.TabIndex = 0;
            lblDetalleSucursal.Text = "Detalle por sucursal";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucursal.ForeColor = Color.DarkSlateGray;
            lblSucursal.Location = new Point(23, 104);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(81, 23);
            lblSucursal.TabIndex = 1;
            lblSucursal.Text = "Sucursal:";
            // 
            // cboSucursal
            // 
            cboSucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSucursal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSucursal.ForeColor = Color.Black;
            cboSucursal.FormattingEnabled = true;
            cboSucursal.Location = new Point(114, 99);
            cboSucursal.Margin = new Padding(3, 4, 3, 4);
            cboSucursal.Name = "cboSucursal";
            cboSucursal.Size = new Size(262, 29);
            cboSucursal.TabIndex = 2;
            cboSucursal.SelectedIndexChanged += cboSucursal_SelectedIndexChanged;
            // 
            // lblInfoSucursal
            // 
            lblInfoSucursal.AutoSize = true;
            lblInfoSucursal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoSucursal.ForeColor = Color.Black;
            lblInfoSucursal.Location = new Point(400, 104);
            lblInfoSucursal.Name = "lblInfoSucursal";
            lblInfoSucursal.Size = new Size(287, 23);
            lblInfoSucursal.TabIndex = 3;
            lblInfoSucursal.Text = "Código: -   ·   Distrito: -   ·   Estado: -";
            // 
            // lblResumenSuc
            // 
            lblResumenSuc.AutoSize = true;
            lblResumenSuc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResumenSuc.ForeColor = Color.DarkOliveGreen;
            lblResumenSuc.Location = new Point(23, 149);
            lblResumenSuc.Name = "lblResumenSuc";
            lblResumenSuc.Size = new Size(627, 23);
            lblResumenSuc.TabIndex = 4;
            lblResumenSuc.Text = "Ventas: S/ 0.00   ·   Compras: S/ 0.00   ·   Gastos: S/ 0.00   ·   Utilidad: S/ 0.00";
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
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { colVentasCodigo, colVentasFecha, colVentasCajero, colVentasEstado, colVentasTotal });
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
            dgvVentas.Location = new Point(23, 187);
            dgvVentas.Margin = new Padding(3, 4, 3, 4);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.RowTemplate.Height = 25;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(594, 487);
            dgvVentas.TabIndex = 5;
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
            colVentasFecha.Width = 115;
            // 
            // colVentasCajero
            // 
            colVentasCajero.HeaderText = "Cajero";
            colVentasCajero.MinimumWidth = 6;
            colVentasCajero.Name = "colVentasCajero";
            colVentasCajero.ReadOnly = true;
            colVentasCajero.Width = 105;
            // 
            // colVentasEstado
            // 
            colVentasEstado.HeaderText = "Estado";
            colVentasEstado.MinimumWidth = 6;
            colVentasEstado.Name = "colVentasEstado";
            colVentasEstado.ReadOnly = true;
            colVentasEstado.Width = 75;
            // 
            // colVentasTotal
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            colVentasTotal.DefaultCellStyle = dataGridViewCellStyle3;
            colVentasTotal.HeaderText = "Total S/";
            colVentasTotal.MinimumWidth = 6;
            colVentasTotal.Name = "colVentasTotal";
            colVentasTotal.ReadOnly = true;
            colVentasTotal.Width = 70;
            // 
            // grpDetalle
            // 
            grpDetalle.Controls.Add(lblCodigoTitulo);
            grpDetalle.Controls.Add(lblCodigo);
            grpDetalle.Controls.Add(lblCajeroTitulo);
            grpDetalle.Controls.Add(lblCajero);
            grpDetalle.Controls.Add(lblMetodoTitulo);
            grpDetalle.Controls.Add(lblMetodo);
            grpDetalle.Controls.Add(lblEstadoTitulo);
            grpDetalle.Controls.Add(lblEstado);
            grpDetalle.Controls.Add(dgvDetalle);
            grpDetalle.Controls.Add(lblTotalDetalle);
            grpDetalle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDetalle.ForeColor = Color.DarkOliveGreen;
            grpDetalle.Location = new Point(640, 187);
            grpDetalle.Margin = new Padding(3, 4, 3, 4);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Padding = new Padding(3, 4, 3, 4);
            grpDetalle.Size = new Size(434, 487);
            grpDetalle.TabIndex = 6;
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
            lblCodigoTitulo.TabIndex = 7;
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
            lblCodigo.TabIndex = 8;
            lblCodigo.Text = "-";
            // 
            // lblCajeroTitulo
            // 
            lblCajeroTitulo.AutoSize = true;
            lblCajeroTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCajeroTitulo.ForeColor = Color.DarkSlateGray;
            lblCajeroTitulo.Location = new Point(11, 67);
            lblCajeroTitulo.Name = "lblCajeroTitulo";
            lblCajeroTitulo.Size = new Size(66, 23);
            lblCajeroTitulo.TabIndex = 9;
            lblCajeroTitulo.Text = "Cajero:";
            // 
            // lblCajero
            // 
            lblCajero.AutoSize = true;
            lblCajero.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCajero.ForeColor = Color.Black;
            lblCajero.Location = new Point(83, 67);
            lblCajero.Name = "lblCajero";
            lblCajero.Size = new Size(17, 23);
            lblCajero.TabIndex = 10;
            lblCajero.Text = "-";
            // 
            // lblMetodoTitulo
            // 
            lblMetodoTitulo.AutoSize = true;
            lblMetodoTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMetodoTitulo.ForeColor = Color.DarkSlateGray;
            lblMetodoTitulo.Location = new Point(11, 96);
            lblMetodoTitulo.Name = "lblMetodoTitulo";
            lblMetodoTitulo.Size = new Size(149, 23);
            lblMetodoTitulo.TabIndex = 11;
            lblMetodoTitulo.Text = "Método de pago:";
            // 
            // lblMetodo
            // 
            lblMetodo.AutoSize = true;
            lblMetodo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMetodo.ForeColor = Color.Black;
            lblMetodo.Location = new Point(166, 96);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(17, 23);
            lblMetodo.TabIndex = 12;
            lblMetodo.Text = "-";
            // 
            // lblEstadoTitulo
            // 
            lblEstadoTitulo.AutoSize = true;
            lblEstadoTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstadoTitulo.ForeColor = Color.DarkSlateGray;
            lblEstadoTitulo.Location = new Point(11, 125);
            lblEstadoTitulo.Name = "lblEstadoTitulo";
            lblEstadoTitulo.Size = new Size(68, 23);
            lblEstadoTitulo.TabIndex = 13;
            lblEstadoTitulo.Text = "Estado:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.Black;
            lblEstado.Location = new Point(85, 125);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(17, 23);
            lblEstado.TabIndex = 14;
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
            dgvDetalle.Location = new Point(11, 163);
            dgvDetalle.Margin = new Padding(3, 4, 3, 4);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.RowTemplate.Height = 25;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(411, 253);
            dgvDetalle.TabIndex = 15;
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
            lblTotalDetalle.Location = new Point(11, 429);
            lblTotalDetalle.Name = "lblTotalDetalle";
            lblTotalDetalle.Size = new Size(225, 37);
            lblTotalDetalle.TabIndex = 16;
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
            btnPrimera.TabIndex = 17;
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
            btnAnterior.TabIndex = 18;
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
            btnSiguiente.TabIndex = 19;
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
            btnUltima.TabIndex = 20;
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
            lblPosicion.TabIndex = 21;
            lblPosicion.Text = "Venta 0 de 0";
            // 
            // UC_DetalleSucursal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblDetalleSucursal);
            Controls.Add(lblSucursal);
            Controls.Add(cboSucursal);
            Controls.Add(lblInfoSucursal);
            Controls.Add(lblResumenSuc);
            Controls.Add(dgvVentas);
            Controls.Add(grpDetalle);
            Controls.Add(btnPrimera);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(btnUltima);
            Controls.Add(lblPosicion);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_DetalleSucursal";
            Size = new Size(1097, 813);
            Load += UC_DetalleSucursal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            grpDetalle.ResumeLayout(false);
            grpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDetalleSucursal;
        private Label lblSucursal;
        private ComboBox cboSucursal;
        private Label lblInfoSucursal;
        private Label lblResumenSuc;
        private DataGridView dgvVentas;
        private DataGridViewTextBoxColumn colVentasCodigo;
        private DataGridViewTextBoxColumn colVentasFecha;
        private DataGridViewTextBoxColumn colVentasCajero;
        private DataGridViewTextBoxColumn colVentasEstado;
        private DataGridViewTextBoxColumn colVentasTotal;
        private DataGridViewCellStyle dataGridViewCellStyle1;
        private DataGridViewCellStyle dataGridViewCellStyle2;
        private DataGridViewCellStyle dataGridViewCellStyle3;
        private DataGridViewCellStyle dataGridViewCellStyle4;
        private GroupBox grpDetalle;
        private Label lblCodigoTitulo;
        private Label lblCodigo;
        private Label lblCajeroTitulo;
        private Label lblCajero;
        private Label lblMetodoTitulo;
        private Label lblMetodo;
        private Label lblEstadoTitulo;
        private Label lblEstado;
        private DataGridView dgvDetalle;
        private DataGridViewTextBoxColumn colDetalleProducto;
        private DataGridViewTextBoxColumn colDetalleCantidad;
        private DataGridViewTextBoxColumn colDetallePrecio;
        private DataGridViewTextBoxColumn colDetalleImporte;
        private DataGridViewCellStyle dataGridViewCellStyle5;
        private DataGridViewCellStyle dataGridViewCellStyle6;
        private DataGridViewCellStyle dataGridViewCellStyle7;
        private DataGridViewCellStyle dataGridViewCellStyle8;
        private Label lblTotalDetalle;
        private Button btnPrimera;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Button btnUltima;
        private Label lblPosicion;
    }
}
