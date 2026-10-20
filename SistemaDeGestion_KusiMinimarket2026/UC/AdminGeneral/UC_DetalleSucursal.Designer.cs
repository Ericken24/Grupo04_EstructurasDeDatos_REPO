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
            dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridViewCellStyle7 = new DataGridViewCellStyle();
            dataGridViewCellStyle8 = new DataGridViewCellStyle();
            lblTotalDetalle = new Label();
            btnPrimera = new Button();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            btnUltima = new Button();
            lblPosicion = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            grpDetalle.SuspendLayout();
            SuspendLayout();
            // 
            // lblDetalleSucursal
            // 
            lblDetalleSucursal.AutoSize = true;
            lblDetalleSucursal.BackColor = Color.Transparent;
            lblDetalleSucursal.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblDetalleSucursal.Location = new Point(13, 17);
            lblDetalleSucursal.Name = "lblDetalleSucursal";
            lblDetalleSucursal.Size = new Size(296, 37);
            lblDetalleSucursal.TabIndex = 0;
            lblDetalleSucursal.Text = "Detalle por sucursal";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucursal.ForeColor = Color.DarkSlateGray;
            lblSucursal.Location = new Point(20, 78);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(70, 17);
            lblSucursal.TabIndex = 1;
            lblSucursal.Text = "Sucursal:";
            // 
            // cboSucursal
            // 
            cboSucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSucursal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSucursal.ForeColor = Color.Black;
            cboSucursal.FormattingEnabled = true;
            cboSucursal.Location = new Point(100, 74);
            cboSucursal.Name = "cboSucursal";
            cboSucursal.Size = new Size(230, 25);
            cboSucursal.TabIndex = 2;
            cboSucursal.SelectedIndexChanged += cboSucursal_SelectedIndexChanged;
            // 
            // lblInfoSucursal
            // 
            lblInfoSucursal.AutoSize = true;
            lblInfoSucursal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoSucursal.ForeColor = Color.Black;
            lblInfoSucursal.Location = new Point(350, 78);
            lblInfoSucursal.Name = "lblInfoSucursal";
            lblInfoSucursal.Size = new Size(300, 17);
            lblInfoSucursal.TabIndex = 3;
            lblInfoSucursal.Text = "Código: -   ·   Distrito: -   ·   Estado: -";
            // 
            // lblResumenSuc
            // 
            lblResumenSuc.AutoSize = true;
            lblResumenSuc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResumenSuc.ForeColor = Color.DarkOliveGreen;
            lblResumenSuc.Location = new Point(20, 112);
            lblResumenSuc.Name = "lblResumenSuc";
            lblResumenSuc.Size = new Size(625, 17);
            lblResumenSuc.TabIndex = 4;
            lblResumenSuc.Text = "Ventas: S/ 0.00   ·   Compras: S/ 0.00   ·   Gastos: S/ 0.00   ·   Utilidad: S/ 0.00";
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AllowUserToResizeRows = false;
            dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.BorderStyle = BorderStyle.None;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.ColumnHeadersHeight = 30;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { colVentasCodigo, colVentasFecha, colVentasCajero, colVentasEstado, colVentasTotal });
            dgvVentas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.GridColor = Color.Gainsboro;
            dgvVentas.Location = new Point(20, 140);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowTemplate.Height = 25;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(520, 365);
            dgvVentas.TabIndex = 5;
            dgvVentas.SelectionChanged += dgvVentas_SelectionChanged;
            // 
            // colVentasCodigo
            // 
            colVentasCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colVentasCodigo.MinimumWidth = 130;
            colVentasCodigo.HeaderText = "Código";
            colVentasCodigo.Name = "colVentasCodigo";
            colVentasCodigo.ReadOnly = true;
            // 
            // colVentasFecha
            // 
            colVentasFecha.HeaderText = "Fecha";
            colVentasFecha.Name = "colVentasFecha";
            colVentasFecha.ReadOnly = true;
            colVentasFecha.Width = 115;
            // 
            // colVentasCajero
            // 
            colVentasCajero.HeaderText = "Cajero";
            colVentasCajero.Name = "colVentasCajero";
            colVentasCajero.ReadOnly = true;
            colVentasCajero.Width = 105;
            // 
            // colVentasEstado
            // 
            colVentasEstado.HeaderText = "Estado";
            colVentasEstado.Name = "colVentasEstado";
            colVentasEstado.ReadOnly = true;
            colVentasEstado.Width = 75;
            // 
            // colVentasTotal
            // 
            colVentasTotal.DefaultCellStyle = dataGridViewCellStyle4;
            colVentasTotal.HeaderText = "Total S/";
            colVentasTotal.Name = "colVentasTotal";
            colVentasTotal.ReadOnly = true;
            colVentasTotal.Width = 70;
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
            // grpDetalle
            // 
            grpDetalle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDetalle.ForeColor = Color.DarkOliveGreen;
            grpDetalle.Location = new Point(560, 140);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(380, 365);
            grpDetalle.TabIndex = 6;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "Detalle de la venta";
            // 
            // lblCodigoTitulo
            // 
            lblCodigoTitulo.AutoSize = true;
            lblCodigoTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigoTitulo.ForeColor = Color.DarkSlateGray;
            lblCodigoTitulo.Location = new Point(10, 28);
            lblCodigoTitulo.Name = "lblCodigoTitulo";
            lblCodigoTitulo.Size = new Size(55, 17);
            lblCodigoTitulo.TabIndex = 7;
            lblCodigoTitulo.Text = "Código:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigo.ForeColor = Color.Black;
            lblCodigo.Location = new Point(125, 28);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(10, 17);
            lblCodigo.TabIndex = 8;
            lblCodigo.Text = "-";
            // 
            // lblCajeroTitulo
            // 
            lblCajeroTitulo.AutoSize = true;
            lblCajeroTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCajeroTitulo.ForeColor = Color.DarkSlateGray;
            lblCajeroTitulo.Location = new Point(10, 50);
            lblCajeroTitulo.Name = "lblCajeroTitulo";
            lblCajeroTitulo.Size = new Size(55, 17);
            lblCajeroTitulo.TabIndex = 9;
            lblCajeroTitulo.Text = "Cajero:";
            // 
            // lblCajero
            // 
            lblCajero.AutoSize = true;
            lblCajero.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCajero.ForeColor = Color.Black;
            lblCajero.Location = new Point(125, 50);
            lblCajero.Name = "lblCajero";
            lblCajero.Size = new Size(10, 17);
            lblCajero.TabIndex = 10;
            lblCajero.Text = "-";
            // 
            // lblMetodoTitulo
            // 
            lblMetodoTitulo.AutoSize = true;
            lblMetodoTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMetodoTitulo.ForeColor = Color.DarkSlateGray;
            lblMetodoTitulo.Location = new Point(10, 72);
            lblMetodoTitulo.Name = "lblMetodoTitulo";
            lblMetodoTitulo.Size = new Size(115, 17);
            lblMetodoTitulo.TabIndex = 11;
            lblMetodoTitulo.Text = "Método de pago:";
            // 
            // lblMetodo
            // 
            lblMetodo.AutoSize = true;
            lblMetodo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMetodo.ForeColor = Color.Black;
            lblMetodo.Location = new Point(125, 72);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(10, 17);
            lblMetodo.TabIndex = 12;
            lblMetodo.Text = "-";
            // 
            // lblEstadoTitulo
            // 
            lblEstadoTitulo.AutoSize = true;
            lblEstadoTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstadoTitulo.ForeColor = Color.DarkSlateGray;
            lblEstadoTitulo.Location = new Point(10, 94);
            lblEstadoTitulo.Name = "lblEstadoTitulo";
            lblEstadoTitulo.Size = new Size(55, 17);
            lblEstadoTitulo.TabIndex = 13;
            lblEstadoTitulo.Text = "Estado:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.Black;
            lblEstado.Location = new Point(125, 94);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(10, 17);
            lblEstado.TabIndex = 14;
            lblEstado.Text = "-";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.AllowUserToResizeRows = false;
            dgvDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvDetalle.BackgroundColor = Color.White;
            dgvDetalle.BorderStyle = BorderStyle.None;
            dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDetalle.ColumnHeadersHeight = 30;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { colDetalleProducto, colDetalleCantidad, colDetallePrecio, colDetalleImporte });
            dgvDetalle.DefaultCellStyle = dataGridViewCellStyle6;
            dgvDetalle.EnableHeadersVisualStyles = false;
            dgvDetalle.GridColor = Color.Gainsboro;
            dgvDetalle.Location = new Point(10, 122);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.RowTemplate.Height = 25;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(360, 190);
            dgvDetalle.TabIndex = 15;
            // 
            // colDetalleProducto
            // 
            colDetalleProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDetalleProducto.MinimumWidth = 110;
            colDetalleProducto.HeaderText = "Producto";
            colDetalleProducto.Name = "colDetalleProducto";
            colDetalleProducto.ReadOnly = true;
            // 
            // colDetalleCantidad
            // 
            colDetalleCantidad.DefaultCellStyle = dataGridViewCellStyle8;
            colDetalleCantidad.HeaderText = "Cant.";
            colDetalleCantidad.Name = "colDetalleCantidad";
            colDetalleCantidad.ReadOnly = true;
            colDetalleCantidad.Width = 55;
            // 
            // colDetallePrecio
            // 
            colDetallePrecio.DefaultCellStyle = dataGridViewCellStyle8;
            colDetallePrecio.HeaderText = "P. unit.";
            colDetallePrecio.Name = "colDetallePrecio";
            colDetallePrecio.ReadOnly = true;
            colDetallePrecio.Width = 70;
            // 
            // colDetalleImporte
            // 
            colDetalleImporte.DefaultCellStyle = dataGridViewCellStyle8;
            colDetalleImporte.HeaderText = "Importe";
            colDetalleImporte.Name = "colDetalleImporte";
            colDetalleImporte.ReadOnly = true;
            colDetalleImporte.Width = 75;
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
            // lblTotalDetalle
            // 
            lblTotalDetalle.AutoSize = true;
            lblTotalDetalle.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDetalle.ForeColor = Color.DarkOliveGreen;
            lblTotalDetalle.Location = new Point(10, 322);
            lblTotalDetalle.Name = "lblTotalDetalle";
            lblTotalDetalle.Size = new Size(259, 30);
            lblTotalDetalle.TabIndex = 16;
            lblTotalDetalle.Text = "TOTAL:  S/ 0.00";
            // 
            // btnPrimera
            // 
            btnPrimera.BackColor = Color.DarkOliveGreen;
            btnPrimera.Cursor = Cursors.Hand;
            btnPrimera.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrimera.ForeColor = Color.White;
            btnPrimera.Location = new Point(20, 520);
            btnPrimera.Name = "btnPrimera";
            btnPrimera.Size = new Size(120, 38);
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
            btnAnterior.Location = new Point(150, 520);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(120, 38);
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
            btnSiguiente.Location = new Point(280, 520);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(120, 38);
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
            btnUltima.Location = new Point(410, 520);
            btnUltima.Name = "btnUltima";
            btnUltima.Size = new Size(120, 38);
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
            lblPosicion.Location = new Point(560, 531);
            lblPosicion.Name = "lblPosicion";
            lblPosicion.Size = new Size(92, 17);
            lblPosicion.TabIndex = 21;
            lblPosicion.Text = "Venta 0 de 0";
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
            // 
            // UC_DetalleSucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Name = "UC_DetalleSucursal";
            Size = new Size(960, 610);
            Load += UC_DetalleSucursal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            grpDetalle.ResumeLayout(false);
            grpDetalle.PerformLayout();
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
