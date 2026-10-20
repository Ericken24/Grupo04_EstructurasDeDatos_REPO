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
            lblHistorialVentas = new Label();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            dgvVentas = new DataGridView();
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
            lblTotalDetalle = new Label();
            btnPrimera = new Button();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            btnUltima = new Button();
            lblPosicion = new Label();
            btnAnularUltima = new Button();
            dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewCellStyle4 = new DataGridViewCellStyle();
            colVentasCodigo = new DataGridViewTextBoxColumn();
            colVentasFecha = new DataGridViewTextBoxColumn();
            colVentasMetodo = new DataGridViewTextBoxColumn();
            colVentasEstado = new DataGridViewTextBoxColumn();
            colVentasTotal = new DataGridViewTextBoxColumn();
            dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridViewCellStyle7 = new DataGridViewCellStyle();
            dataGridViewCellStyle8 = new DataGridViewCellStyle();
            colDetalleProducto = new DataGridViewTextBoxColumn();
            colDetalleCantidad = new DataGridViewTextBoxColumn();
            colDetallePrecio = new DataGridViewTextBoxColumn();
            colDetalleImporte = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            grpDetalle.SuspendLayout();
            SuspendLayout();
            // 
            // lblHistorialVentas
            // 
            lblHistorialVentas.AutoSize = true;
            lblHistorialVentas.BackColor = Color.Transparent;
            lblHistorialVentas.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblHistorialVentas.Text = "Historial de ventas";
            lblHistorialVentas.Location = new Point(13, 17);
            lblHistorialVentas.Name = "lblHistorialVentas";
            lblHistorialVentas.Size = new Size(278, 37);
            lblHistorialVentas.TabIndex = 0;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.ForeColor = Color.DarkSlateGray;
            lblBuscar.Text = "Buscar por código:";
            lblBuscar.Location = new Point(20, 78);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(130, 17);
            lblBuscar.TabIndex = 1;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.Black;
            txtBuscar.Location = new Point(165, 74);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(375, 25);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
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
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { colVentasCodigo, colVentasFecha, colVentasMetodo, colVentasEstado, colVentasTotal });
            dgvVentas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.GridColor = Color.Gainsboro;
            dgvVentas.Location = new Point(20, 110);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowTemplate.Height = 25;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(520, 395);
            dgvVentas.TabIndex = 3;
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
            colVentasFecha.Width = 125;
            // 
            // colVentasMetodo
            // 
            colVentasMetodo.HeaderText = "Método";
            colVentasMetodo.Name = "colVentasMetodo";
            colVentasMetodo.ReadOnly = true;
            colVentasMetodo.Width = 110;
            // 
            // colVentasEstado
            // 
            colVentasEstado.HeaderText = "Estado";
            colVentasEstado.Name = "colVentasEstado";
            colVentasEstado.ReadOnly = true;
            colVentasEstado.Width = 80;
            // 
            // colVentasTotal
            // 
            colVentasTotal.DefaultCellStyle = dataGridViewCellStyle4;
            colVentasTotal.HeaderText = "Total S/";
            colVentasTotal.Name = "colVentasTotal";
            colVentasTotal.ReadOnly = true;
            colVentasTotal.Width = 75;
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
            grpDetalle.Text = "Detalle de la venta";
            grpDetalle.Location = new Point(560, 110);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(380, 400);
            grpDetalle.TabIndex = 4;
            // 
            // lblCodigoTitulo
            // 
            lblCodigoTitulo.AutoSize = true;
            lblCodigoTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigoTitulo.ForeColor = Color.DarkSlateGray;
            lblCodigoTitulo.Text = "Código:";
            lblCodigoTitulo.Location = new Point(10, 28);
            lblCodigoTitulo.Name = "lblCodigoTitulo";
            lblCodigoTitulo.Size = new Size(50, 17);
            lblCodigoTitulo.TabIndex = 5;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigo.ForeColor = Color.Black;
            lblCodigo.Text = "-";
            lblCodigo.Location = new Point(125, 28);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(12, 17);
            lblCodigo.TabIndex = 6;
            // 
            // lblFechaTitulo
            // 
            lblFechaTitulo.AutoSize = true;
            lblFechaTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaTitulo.ForeColor = Color.DarkSlateGray;
            lblFechaTitulo.Text = "Fecha:";
            lblFechaTitulo.Location = new Point(10, 52);
            lblFechaTitulo.Name = "lblFechaTitulo";
            lblFechaTitulo.Size = new Size(45, 17);
            lblFechaTitulo.TabIndex = 7;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = Color.Black;
            lblFecha.Text = "-";
            lblFecha.Location = new Point(125, 52);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(12, 17);
            lblFecha.TabIndex = 8;
            // 
            // lblMetodoTitulo
            // 
            lblMetodoTitulo.AutoSize = true;
            lblMetodoTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMetodoTitulo.ForeColor = Color.DarkSlateGray;
            lblMetodoTitulo.Text = "Método de pago:";
            lblMetodoTitulo.Location = new Point(10, 76);
            lblMetodoTitulo.Name = "lblMetodoTitulo";
            lblMetodoTitulo.Size = new Size(107, 17);
            lblMetodoTitulo.TabIndex = 9;
            // 
            // lblMetodo
            // 
            lblMetodo.AutoSize = true;
            lblMetodo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMetodo.ForeColor = Color.Black;
            lblMetodo.Text = "-";
            lblMetodo.Location = new Point(125, 76);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(12, 17);
            lblMetodo.TabIndex = 10;
            // 
            // lblEstadoTitulo
            // 
            lblEstadoTitulo.AutoSize = true;
            lblEstadoTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstadoTitulo.ForeColor = Color.DarkSlateGray;
            lblEstadoTitulo.Text = "Estado:";
            lblEstadoTitulo.Location = new Point(10, 100);
            lblEstadoTitulo.Name = "lblEstadoTitulo";
            lblEstadoTitulo.Size = new Size(51, 17);
            lblEstadoTitulo.TabIndex = 11;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.Black;
            lblEstado.Text = "-";
            lblEstado.Location = new Point(125, 100);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(12, 17);
            lblEstado.TabIndex = 12;
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
            dgvDetalle.Location = new Point(10, 130);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.RowTemplate.Height = 25;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(360, 215);
            dgvDetalle.TabIndex = 13;
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
            lblTotalDetalle.Text = "TOTAL:  S/ 0.00";
            lblTotalDetalle.Location = new Point(10, 358);
            lblTotalDetalle.Name = "lblTotalDetalle";
            lblTotalDetalle.Size = new Size(190, 30);
            lblTotalDetalle.TabIndex = 14;
            // 
            // btnPrimera
            // 
            btnPrimera.BackColor = Color.DarkOliveGreen;
            btnPrimera.Cursor = Cursors.Hand;
            btnPrimera.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrimera.ForeColor = Color.White;
            btnPrimera.Text = "⏮ Primera";
            btnPrimera.UseVisualStyleBackColor = false;
            btnPrimera.Location = new Point(20, 520);
            btnPrimera.Name = "btnPrimera";
            btnPrimera.Size = new Size(120, 38);
            btnPrimera.TabIndex = 15;
            btnPrimera.Click += btnPrimera_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.DarkOliveGreen;
            btnAnterior.Cursor = Cursors.Hand;
            btnAnterior.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnterior.ForeColor = Color.White;
            btnAnterior.Text = "◀ Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Location = new Point(150, 520);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(120, 38);
            btnAnterior.TabIndex = 16;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.DarkOliveGreen;
            btnSiguiente.Cursor = Cursors.Hand;
            btnSiguiente.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Text = "Siguiente ▶";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Location = new Point(280, 520);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(120, 38);
            btnSiguiente.TabIndex = 17;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnUltima
            // 
            btnUltima.BackColor = Color.DarkOliveGreen;
            btnUltima.Cursor = Cursors.Hand;
            btnUltima.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUltima.ForeColor = Color.White;
            btnUltima.Text = "Última ⏭";
            btnUltima.UseVisualStyleBackColor = false;
            btnUltima.Location = new Point(410, 520);
            btnUltima.Name = "btnUltima";
            btnUltima.Size = new Size(120, 38);
            btnUltima.TabIndex = 18;
            btnUltima.Click += btnUltima_Click;
            // 
            // lblPosicion
            // 
            lblPosicion.AutoSize = true;
            lblPosicion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPosicion.ForeColor = Color.DarkSlateGray;
            lblPosicion.Text = "Venta 0 de 0";
            lblPosicion.Location = new Point(560, 531);
            lblPosicion.Name = "lblPosicion";
            lblPosicion.Size = new Size(95, 17);
            lblPosicion.TabIndex = 19;
            // 
            // btnAnularUltima
            // 
            btnAnularUltima.BackColor = Color.Brown;
            btnAnularUltima.Cursor = Cursors.Hand;
            btnAnularUltima.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnularUltima.ForeColor = Color.White;
            btnAnularUltima.Text = "↩ Anular última venta";
            btnAnularUltima.UseVisualStyleBackColor = false;
            btnAnularUltima.Location = new Point(725, 520);
            btnAnularUltima.Name = "btnAnularUltima";
            btnAnularUltima.Size = new Size(215, 38);
            btnAnularUltima.TabIndex = 20;
            btnAnularUltima.Click += btnAnularUltima_Click;
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
            // 
            // UC_HistorialVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Name = "UC_HistorialVentas";
            Size = new Size(960, 610);
            Load += UC_HistorialVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            grpDetalle.ResumeLayout(false);
            grpDetalle.PerformLayout();
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
