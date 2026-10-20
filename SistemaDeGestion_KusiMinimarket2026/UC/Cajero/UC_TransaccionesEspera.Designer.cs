namespace SistemaDeGestion_KusiMinimarket2026.UC.Cajero
{
    partial class UC_TransaccionesEspera
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
            lblEnEspera = new Label();
            lblSiguiente = new Label();
            lblCantidad = new Label();
            dgvCola = new DataGridView();
            grpDetalle = new GroupBox();
            dgvDetalle = new DataGridView();
            lblTotalDetalle = new Label();
            grpCobro = new GroupBox();
            lblMetodoPago = new Label();
            cboMetodoPago = new ComboBox();
            lblReferencia = new Label();
            txtReferencia = new TextBox();
            btnAtender = new Button();
            btnDescartar = new Button();
            dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewCellStyle4 = new DataGridViewCellStyle();
            colColaOrden = new DataGridViewTextBoxColumn();
            colColaCodigo = new DataGridViewTextBoxColumn();
            colColaHora = new DataGridViewTextBoxColumn();
            colColaCajero = new DataGridViewTextBoxColumn();
            colColaItems = new DataGridViewTextBoxColumn();
            colColaTotal = new DataGridViewTextBoxColumn();
            dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridViewCellStyle7 = new DataGridViewCellStyle();
            dataGridViewCellStyle8 = new DataGridViewCellStyle();
            colDetalleProducto = new DataGridViewTextBoxColumn();
            colDetalleCantidad = new DataGridViewTextBoxColumn();
            colDetallePrecio = new DataGridViewTextBoxColumn();
            colDetalleImporte = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCola).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            grpDetalle.SuspendLayout();
            grpCobro.SuspendLayout();
            SuspendLayout();
            // 
            // lblEnEspera
            // 
            lblEnEspera.AutoSize = true;
            lblEnEspera.BackColor = Color.Transparent;
            lblEnEspera.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblEnEspera.Text = "Transacciones en espera";
            lblEnEspera.Location = new Point(13, 17);
            lblEnEspera.Name = "lblEnEspera";
            lblEnEspera.Size = new Size(351, 37);
            lblEnEspera.TabIndex = 0;
            // 
            // lblSiguiente
            // 
            lblSiguiente.AutoSize = true;
            lblSiguiente.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSiguiente.ForeColor = Color.DarkOliveGreen;
            lblSiguiente.Text = "Siguiente en atender: -";
            lblSiguiente.Location = new Point(20, 70);
            lblSiguiente.Name = "lblSiguiente";
            lblSiguiente.Size = new Size(220, 20);
            lblSiguiente.TabIndex = 1;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = Color.DarkSlateGray;
            lblCantidad.Text = "En cola: 0";
            lblCantidad.Location = new Point(20, 96);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(70, 17);
            lblCantidad.TabIndex = 2;
            // 
            // dgvCola
            // 
            dgvCola.AllowUserToAddRows = false;
            dgvCola.AllowUserToDeleteRows = false;
            dgvCola.AllowUserToResizeRows = false;
            dgvCola.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvCola.BackgroundColor = Color.White;
            dgvCola.BorderStyle = BorderStyle.None;
            dgvCola.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCola.ColumnHeadersHeight = 30;
            dgvCola.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCola.Columns.AddRange(new DataGridViewColumn[] { colColaOrden, colColaCodigo, colColaHora, colColaCajero, colColaItems, colColaTotal });
            dgvCola.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCola.EnableHeadersVisualStyles = false;
            dgvCola.GridColor = Color.Gainsboro;
            dgvCola.Location = new Point(20, 125);
            dgvCola.MultiSelect = false;
            dgvCola.Name = "dgvCola";
            dgvCola.ReadOnly = true;
            dgvCola.RowHeadersVisible = false;
            dgvCola.RowTemplate.Height = 25;
            dgvCola.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCola.Size = new Size(540, 380);
            dgvCola.TabIndex = 3;
            dgvCola.SelectionChanged += dgvCola_SelectionChanged;
            // 
            // colColaOrden
            // 
            colColaOrden.HeaderText = "N.º";
            colColaOrden.Name = "colColaOrden";
            colColaOrden.ReadOnly = true;
            colColaOrden.Width = 45;
            // 
            // colColaCodigo
            // 
            colColaCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colColaCodigo.MinimumWidth = 130;
            colColaCodigo.HeaderText = "Código";
            colColaCodigo.Name = "colColaCodigo";
            colColaCodigo.ReadOnly = true;
            // 
            // colColaHora
            // 
            colColaHora.HeaderText = "Hora";
            colColaHora.Name = "colColaHora";
            colColaHora.ReadOnly = true;
            colColaHora.Width = 65;
            // 
            // colColaCajero
            // 
            colColaCajero.HeaderText = "Cajero";
            colColaCajero.Name = "colColaCajero";
            colColaCajero.ReadOnly = true;
            colColaCajero.Width = 140;
            // 
            // colColaItems
            // 
            colColaItems.DefaultCellStyle = dataGridViewCellStyle4;
            colColaItems.HeaderText = "Ítems";
            colColaItems.Name = "colColaItems";
            colColaItems.ReadOnly = true;
            colColaItems.Width = 55;
            // 
            // colColaTotal
            // 
            colColaTotal.DefaultCellStyle = dataGridViewCellStyle4;
            colColaTotal.HeaderText = "Total S/";
            colColaTotal.Name = "colColaTotal";
            colColaTotal.ReadOnly = true;
            colColaTotal.Width = 75;
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
            grpDetalle.Text = "Detalle de la transacción";
            grpDetalle.Location = new Point(580, 125);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(360, 275);
            grpDetalle.TabIndex = 4;
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
            dgvDetalle.Location = new Point(10, 25);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.RowTemplate.Height = 25;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(340, 200);
            dgvDetalle.TabIndex = 5;
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
            lblTotalDetalle.Location = new Point(10, 235);
            lblTotalDetalle.Name = "lblTotalDetalle";
            lblTotalDetalle.Size = new Size(190, 30);
            lblTotalDetalle.TabIndex = 6;
            // 
            // grpCobro
            // 
            grpCobro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCobro.ForeColor = Color.DarkOliveGreen;
            grpCobro.Text = "Cobro del siguiente";
            grpCobro.Location = new Point(580, 410);
            grpCobro.Name = "grpCobro";
            grpCobro.Size = new Size(360, 95);
            grpCobro.TabIndex = 7;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMetodoPago.ForeColor = Color.DarkSlateGray;
            lblMetodoPago.Text = "Método de pago";
            lblMetodoPago.Location = new Point(10, 24);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(100, 17);
            lblMetodoPago.TabIndex = 8;
            // 
            // cboMetodoPago
            // 
            cboMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMetodoPago.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMetodoPago.FormattingEnabled = true;
            cboMetodoPago.ForeColor = Color.Black;
            cboMetodoPago.Location = new Point(10, 44);
            cboMetodoPago.Name = "cboMetodoPago";
            cboMetodoPago.Size = new Size(165, 25);
            cboMetodoPago.TabIndex = 9;
            cboMetodoPago.SelectedIndexChanged += cboMetodoPago_SelectedIndexChanged;
            // 
            // lblReferencia
            // 
            lblReferencia.AutoSize = true;
            lblReferencia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReferencia.ForeColor = Color.DarkSlateGray;
            lblReferencia.Text = "N.º de operación";
            lblReferencia.Location = new Point(185, 24);
            lblReferencia.Name = "lblReferencia";
            lblReferencia.Size = new Size(105, 17);
            lblReferencia.TabIndex = 10;
            // 
            // txtReferencia
            // 
            txtReferencia.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReferencia.Enabled = false;
            txtReferencia.ForeColor = Color.Black;
            txtReferencia.Location = new Point(185, 44);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(165, 25);
            txtReferencia.TabIndex = 11;
            // 
            // btnAtender
            // 
            btnAtender.BackColor = Color.DarkOliveGreen;
            btnAtender.Cursor = Cursors.Hand;
            btnAtender.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtender.ForeColor = Color.White;
            btnAtender.Text = "💵 Cobrar siguiente";
            btnAtender.UseVisualStyleBackColor = false;
            btnAtender.Enabled = false;
            btnAtender.Location = new Point(20, 520);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(265, 42);
            btnAtender.TabIndex = 12;
            btnAtender.Click += btnAtender_Click;
            // 
            // btnDescartar
            // 
            btnDescartar.BackColor = Color.Brown;
            btnDescartar.Cursor = Cursors.Hand;
            btnDescartar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDescartar.ForeColor = Color.White;
            btnDescartar.Text = "🗑 Descartar siguiente";
            btnDescartar.UseVisualStyleBackColor = false;
            btnDescartar.Enabled = false;
            btnDescartar.Location = new Point(295, 520);
            btnDescartar.Name = "btnDescartar";
            btnDescartar.Size = new Size(265, 42);
            btnDescartar.TabIndex = 13;
            btnDescartar.Click += btnDescartar_Click;
            grpDetalle.Controls.Add(dgvDetalle);
            grpDetalle.Controls.Add(lblTotalDetalle);
            grpCobro.Controls.Add(lblMetodoPago);
            grpCobro.Controls.Add(cboMetodoPago);
            grpCobro.Controls.Add(lblReferencia);
            grpCobro.Controls.Add(txtReferencia);
            // 
            // UC_TransaccionesEspera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblEnEspera);
            Controls.Add(lblSiguiente);
            Controls.Add(lblCantidad);
            Controls.Add(dgvCola);
            Controls.Add(grpDetalle);
            Controls.Add(grpCobro);
            Controls.Add(btnAtender);
            Controls.Add(btnDescartar);
            Name = "UC_TransaccionesEspera";
            Size = new Size(960, 610);
            Load += UC_TransaccionesEspera_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCola).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            grpDetalle.ResumeLayout(false);
            grpDetalle.PerformLayout();
            grpCobro.ResumeLayout(false);
            grpCobro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnEspera;
        private Label lblSiguiente;
        private Label lblCantidad;
        private DataGridView dgvCola;
        private GroupBox grpDetalle;
        private DataGridView dgvDetalle;
        private Label lblTotalDetalle;
        private GroupBox grpCobro;
        private Label lblMetodoPago;
        private ComboBox cboMetodoPago;
        private Label lblReferencia;
        private TextBox txtReferencia;
        private Button btnAtender;
        private Button btnDescartar;
        private DataGridViewTextBoxColumn colColaOrden;
        private DataGridViewTextBoxColumn colColaCodigo;
        private DataGridViewTextBoxColumn colColaHora;
        private DataGridViewTextBoxColumn colColaCajero;
        private DataGridViewTextBoxColumn colColaItems;
        private DataGridViewTextBoxColumn colColaTotal;
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
