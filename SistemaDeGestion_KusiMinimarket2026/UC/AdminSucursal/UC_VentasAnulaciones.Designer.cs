namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminSucursal
{
    partial class UC_VentasAnulaciones
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            pnlFiltros = new Panel();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            cmbEstado = new ComboBox();
            txtBuscar = new TextBox();
            lblConteo = new Label();
            dgvVentas = new DataGridView();
            colVenCodigo = new DataGridViewTextBoxColumn();
            colVenFecha = new DataGridViewTextBoxColumn();
            colVenCajero = new DataGridViewTextBoxColumn();
            colVenMetodo = new DataGridViewTextBoxColumn();
            colVenTotal = new DataGridViewTextBoxColumn();
            colVenEstado = new DataGridViewTextBoxColumn();
            pnlDetalle = new Panel();
            lblDetalleTitulo = new Label();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            dgvDetalle = new DataGridView();
            colDetProducto = new DataGridViewTextBoxColumn();
            colDetCantidad = new DataGridViewTextBoxColumn();
            colDetPrecio = new DataGridViewTextBoxColumn();
            colDetDescuento = new DataGridViewTextBoxColumn();
            colDetImporte = new DataGridViewTextBoxColumn();
            pnlAccion = new Panel();
            lblAccionTitulo = new Label();
            lblVentaSel = new Label();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            btnAnular = new Button();
            btnRevertir = new Button();
            lblEspera = new Label();
            pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            pnlAccion.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(15, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(366, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ventas y anulaciones";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.DimGray;
            lblSubtitulo.Location = new Point(549, 17);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(534, 27);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlFiltros
            // 
            pnlFiltros.BackColor = Color.White;
            pnlFiltros.Controls.Add(lblDesde);
            pnlFiltros.Controls.Add(dtpDesde);
            pnlFiltros.Controls.Add(lblHasta);
            pnlFiltros.Controls.Add(dtpHasta);
            pnlFiltros.Controls.Add(cmbEstado);
            pnlFiltros.Controls.Add(txtBuscar);
            pnlFiltros.Controls.Add(lblConteo);
            pnlFiltros.Location = new Point(15, 68);
            pnlFiltros.Margin = new Padding(3, 4, 3, 4);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Size = new Size(1067, 75);
            pnlFiltros.TabIndex = 2;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 9F);
            lblDesde.ForeColor = Color.DimGray;
            lblDesde.Location = new Point(14, 27);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(51, 20);
            lblDesde.TabIndex = 0;
            lblDesde.Text = "Desde";
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(64, 21);
            dtpDesde.Margin = new Padding(3, 4, 3, 4);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(134, 27);
            dtpDesde.TabIndex = 0;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 9F);
            lblHasta.ForeColor = Color.DimGray;
            lblHasta.Location = new Point(213, 27);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(47, 20);
            lblHasta.TabIndex = 1;
            lblHasta.Text = "Hasta";
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(261, 21);
            dtpHasta.Margin = new Padding(3, 4, 3, 4);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(134, 27);
            dtpHasta.TabIndex = 1;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Location = new Point(411, 21);
            cmbEstado.Margin = new Padding(3, 4, 3, 4);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(148, 28);
            cmbEstado.TabIndex = 2;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(576, 21);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Código o cajero...";
            txtBuscar.Size = new Size(251, 27);
            txtBuscar.TabIndex = 3;
            // 
            // lblConteo
            // 
            lblConteo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblConteo.ForeColor = Color.DarkSlateGray;
            lblConteo.Location = new Point(834, 24);
            lblConteo.Name = "lblConteo";
            lblConteo.Size = new Size(219, 29);
            lblConteo.TabIndex = 4;
            lblConteo.Text = "0 ventas";
            lblConteo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVentas.ColumnHeadersHeight = 32;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { colVenCodigo, colVenFecha, colVenCajero, colVenMetodo, colVenTotal, colVenEstado });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle5.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvVentas.DefaultCellStyle = dataGridViewCellStyle5;
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.Location = new Point(15, 156);
            dgvVentas.Margin = new Padding(3, 4, 3, 4);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(1067, 214);
            dgvVentas.TabIndex = 4;
            // 
            // colVenCodigo
            // 
            colVenCodigo.FillWeight = 20F;
            colVenCodigo.HeaderText = "Código";
            colVenCodigo.MinimumWidth = 6;
            colVenCodigo.Name = "colVenCodigo";
            colVenCodigo.ReadOnly = true;
            // 
            // colVenFecha
            // 
            colVenFecha.FillWeight = 18F;
            colVenFecha.HeaderText = "Fecha";
            colVenFecha.MinimumWidth = 6;
            colVenFecha.Name = "colVenFecha";
            colVenFecha.ReadOnly = true;
            // 
            // colVenCajero
            // 
            colVenCajero.FillWeight = 22F;
            colVenCajero.HeaderText = "Cajero";
            colVenCajero.MinimumWidth = 6;
            colVenCajero.Name = "colVenCajero";
            colVenCajero.ReadOnly = true;
            // 
            // colVenMetodo
            // 
            colVenMetodo.FillWeight = 18F;
            colVenMetodo.HeaderText = "Método de pago";
            colVenMetodo.MinimumWidth = 6;
            colVenMetodo.Name = "colVenMetodo";
            colVenMetodo.ReadOnly = true;
            // 
            // colVenTotal
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            colVenTotal.DefaultCellStyle = dataGridViewCellStyle3;
            colVenTotal.FillWeight = 12F;
            colVenTotal.HeaderText = "Total";
            colVenTotal.MinimumWidth = 6;
            colVenTotal.Name = "colVenTotal";
            colVenTotal.ReadOnly = true;
            // 
            // colVenEstado
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colVenEstado.DefaultCellStyle = dataGridViewCellStyle4;
            colVenEstado.FillWeight = 10F;
            colVenEstado.HeaderText = "Estado";
            colVenEstado.MinimumWidth = 6;
            colVenEstado.Name = "colVenEstado";
            colVenEstado.ReadOnly = true;
            // 
            // pnlDetalle
            // 
            pnlDetalle.BackColor = Color.White;
            pnlDetalle.Controls.Add(lblDetalleTitulo);
            pnlDetalle.Controls.Add(btnAnterior);
            pnlDetalle.Controls.Add(btnSiguiente);
            pnlDetalle.Controls.Add(dgvDetalle);
            pnlDetalle.Location = new Point(15, 384);
            pnlDetalle.Margin = new Padding(3, 4, 3, 4);
            pnlDetalle.Name = "pnlDetalle";
            pnlDetalle.Size = new Size(640, 360);
            pnlDetalle.TabIndex = 5;
            // 
            // lblDetalleTitulo
            // 
            lblDetalleTitulo.AutoSize = true;
            lblDetalleTitulo.Font = new Font("Segoe UI Semibold", 11.25F);
            lblDetalleTitulo.ForeColor = Color.DarkSlateGray;
            lblDetalleTitulo.Location = new Point(14, 11);
            lblDetalleTitulo.Name = "lblDetalleTitulo";
            lblDetalleTitulo.Size = new Size(172, 25);
            lblDetalleTitulo.TabIndex = 0;
            lblDetalleTitulo.Text = "Detalle de la venta";
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.DarkOliveGreen;
            btnAnterior.Cursor = Cursors.Hand;
            btnAnterior.FlatAppearance.BorderSize = 0;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Font = new Font("Segoe UI Semibold", 9.75F);
            btnAnterior.ForeColor = Color.White;
            btnAnterior.Location = new Point(441, 5);
            btnAnterior.Margin = new Padding(3, 4, 3, 4);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(91, 37);
            btnAnterior.TabIndex = 5;
            btnAnterior.Text = "◀ Ant.";
            btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.DarkOliveGreen;
            btnSiguiente.Cursor = Cursors.Hand;
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Segoe UI Semibold", 9.75F);
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Location = new Point(539, 5);
            btnSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(91, 37);
            btnSiguiente.TabIndex = 6;
            btnSiguiente.Text = "Sig. ▶";
            btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            dgvDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.BackgroundColor = Color.White;
            dgvDetalle.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 9.5F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvDetalle.ColumnHeadersHeight = 32;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { colDetProducto, colDetCantidad, colDetPrecio, colDetDescuento, colDetImporte });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle9.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle9.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvDetalle.DefaultCellStyle = dataGridViewCellStyle9;
            dgvDetalle.EnableHeadersVisualStyles = false;
            dgvDetalle.Location = new Point(0, 48);
            dgvDetalle.Margin = new Padding(3, 4, 3, 4);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(640, 312);
            dgvDetalle.TabIndex = 7;
            // 
            // colDetProducto
            // 
            colDetProducto.FillWeight = 42F;
            colDetProducto.HeaderText = "Producto";
            colDetProducto.MinimumWidth = 6;
            colDetProducto.Name = "colDetProducto";
            colDetProducto.ReadOnly = true;
            // 
            // colDetCantidad
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "0.##";
            colDetCantidad.DefaultCellStyle = dataGridViewCellStyle8;
            colDetCantidad.FillWeight = 12F;
            colDetCantidad.HeaderText = "Cant.";
            colDetCantidad.MinimumWidth = 6;
            colDetCantidad.Name = "colDetCantidad";
            colDetCantidad.ReadOnly = true;
            // 
            // colDetPrecio
            // 
            colDetPrecio.DefaultCellStyle = dataGridViewCellStyle3;
            colDetPrecio.FillWeight = 16F;
            colDetPrecio.HeaderText = "P. unit.";
            colDetPrecio.MinimumWidth = 6;
            colDetPrecio.Name = "colDetPrecio";
            colDetPrecio.ReadOnly = true;
            // 
            // colDetDescuento
            // 
            colDetDescuento.DefaultCellStyle = dataGridViewCellStyle3;
            colDetDescuento.FillWeight = 14F;
            colDetDescuento.HeaderText = "Desc.";
            colDetDescuento.MinimumWidth = 6;
            colDetDescuento.Name = "colDetDescuento";
            colDetDescuento.ReadOnly = true;
            // 
            // colDetImporte
            // 
            colDetImporte.DefaultCellStyle = dataGridViewCellStyle3;
            colDetImporte.FillWeight = 16F;
            colDetImporte.HeaderText = "Importe";
            colDetImporte.MinimumWidth = 6;
            colDetImporte.Name = "colDetImporte";
            colDetImporte.ReadOnly = true;
            // 
            // pnlAccion
            // 
            pnlAccion.BackColor = Color.White;
            pnlAccion.Controls.Add(lblAccionTitulo);
            pnlAccion.Controls.Add(lblVentaSel);
            pnlAccion.Controls.Add(lblMotivo);
            pnlAccion.Controls.Add(txtMotivo);
            pnlAccion.Controls.Add(btnAnular);
            pnlAccion.Controls.Add(btnRevertir);
            pnlAccion.Controls.Add(lblEspera);
            pnlAccion.Location = new Point(671, 384);
            pnlAccion.Margin = new Padding(3, 4, 3, 4);
            pnlAccion.Name = "pnlAccion";
            pnlAccion.Size = new Size(411, 360);
            pnlAccion.TabIndex = 6;
            // 
            // lblAccionTitulo
            // 
            lblAccionTitulo.AutoSize = true;
            lblAccionTitulo.Font = new Font("Segoe UI Semibold", 11.25F);
            lblAccionTitulo.ForeColor = Color.DarkSlateGray;
            lblAccionTitulo.Location = new Point(14, 11);
            lblAccionTitulo.Name = "lblAccionTitulo";
            lblAccionTitulo.Size = new Size(98, 25);
            lblAccionTitulo.TabIndex = 0;
            lblAccionTitulo.Text = "Anulación";
            // 
            // lblVentaSel
            // 
            lblVentaSel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVentaSel.ForeColor = Color.DarkSlateGray;
            lblVentaSel.Location = new Point(14, 45);
            lblVentaSel.Name = "lblVentaSel";
            lblVentaSel.Size = new Size(384, 56);
            lblVentaSel.TabIndex = 1;
            lblVentaSel.Text = "Seleccione una venta de la tabla";
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Segoe UI", 9F);
            lblMotivo.ForeColor = Color.DimGray;
            lblMotivo.Location = new Point(14, 104);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(145, 20);
            lblMotivo.TabIndex = 2;
            lblMotivo.Text = "Motivo de anulación";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(14, 128);
            txtMotivo.Margin = new Padding(3, 4, 3, 4);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.PlaceholderText = "Obligatorio para anular";
            txtMotivo.Size = new Size(383, 73);
            txtMotivo.TabIndex = 8;
            // 
            // btnAnular
            // 
            btnAnular.BackColor = Color.Brown;
            btnAnular.Cursor = Cursors.Hand;
            btnAnular.FlatAppearance.BorderSize = 0;
            btnAnular.FlatStyle = FlatStyle.Flat;
            btnAnular.Font = new Font("Segoe UI Semibold", 9.75F);
            btnAnular.ForeColor = Color.White;
            btnAnular.Location = new Point(14, 213);
            btnAnular.Margin = new Padding(3, 4, 3, 4);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(384, 45);
            btnAnular.TabIndex = 9;
            btnAnular.Text = "Anular venta";
            btnAnular.UseVisualStyleBackColor = false;
            // 
            // btnRevertir
            // 
            btnRevertir.BackColor = Color.DarkSlateGray;
            btnRevertir.Cursor = Cursors.Hand;
            btnRevertir.FlatAppearance.BorderSize = 0;
            btnRevertir.FlatStyle = FlatStyle.Flat;
            btnRevertir.Font = new Font("Segoe UI Semibold", 9.75F);
            btnRevertir.ForeColor = Color.White;
            btnRevertir.Location = new Point(14, 264);
            btnRevertir.Margin = new Padding(3, 4, 3, 4);
            btnRevertir.Name = "btnRevertir";
            btnRevertir.Size = new Size(384, 45);
            btnRevertir.TabIndex = 10;
            btnRevertir.Text = "⬅️ Revertir última anulación";
            btnRevertir.UseVisualStyleBackColor = false;
            // 
            // lblEspera
            // 
            lblEspera.Font = new Font("Segoe UI", 9F);
            lblEspera.ForeColor = Color.DimGray;
            lblEspera.Location = new Point(14, 317);
            lblEspera.Name = "lblEspera";
            lblEspera.Size = new Size(384, 40);
            lblEspera.TabIndex = 11;
            // 
            // UC_VentasAnulaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(pnlFiltros);
            Controls.Add(dgvVentas);
            Controls.Add(pnlDetalle);
            Controls.Add(pnlAccion);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_VentasAnulaciones";
            Size = new Size(1097, 813);
            pnlFiltros.ResumeLayout(false);
            pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            pnlDetalle.ResumeLayout(false);
            pnlDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            pnlAccion.ResumeLayout(false);
            pnlAccion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel pnlFiltros;
        private Label lblDesde;
        private DateTimePicker dtpDesde;
        private Label lblHasta;
        private DateTimePicker dtpHasta;
        private ComboBox cmbEstado;
        private TextBox txtBuscar;
        private Label lblConteo;
        private DataGridView dgvVentas;
        private Panel pnlDetalle;
        private Label lblDetalleTitulo;
        private Button btnAnterior;
        private Button btnSiguiente;
        private DataGridView dgvDetalle;
        private Panel pnlAccion;
        private Label lblAccionTitulo;
        private Label lblVentaSel;
        private Label lblMotivo;
        private TextBox txtMotivo;
        private Button btnAnular;
        private Button btnRevertir;
        private Label lblEspera;
        private DataGridViewTextBoxColumn colVenCodigo;
        private DataGridViewTextBoxColumn colVenFecha;
        private DataGridViewTextBoxColumn colVenCajero;
        private DataGridViewTextBoxColumn colVenMetodo;
        private DataGridViewTextBoxColumn colVenTotal;
        private DataGridViewTextBoxColumn colVenEstado;
        private DataGridViewTextBoxColumn colDetProducto;
        private DataGridViewTextBoxColumn colDetCantidad;
        private DataGridViewTextBoxColumn colDetPrecio;
        private DataGridViewTextBoxColumn colDetDescuento;
        private DataGridViewTextBoxColumn colDetImporte;
    }
}
