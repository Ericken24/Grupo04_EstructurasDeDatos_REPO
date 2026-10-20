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
            DataGridViewCellStyle estMoney = new DataGridViewCellStyle();
            DataGridViewCellStyle estQty = new DataGridViewCellStyle();
            DataGridViewCellStyle estCentro = new DataGridViewCellStyle();
            DataGridViewCellStyle estCab = new DataGridViewCellStyle();
            DataGridViewCellStyle estAlt = new DataGridViewCellStyle();
            DataGridViewCellStyle estDef = new DataGridViewCellStyle();
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
            pnlDetalle = new Panel();
            lblDetalleTitulo = new Label();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            dgvDetalle = new DataGridView();
            pnlAccion = new Panel();
            lblAccionTitulo = new Label();
            lblVentaSel = new Label();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            btnAnular = new Button();
            btnRevertir = new Button();
            lblEspera = new Label();
            colVenCodigo = new DataGridViewTextBoxColumn();
            colVenFecha = new DataGridViewTextBoxColumn();
            colVenCajero = new DataGridViewTextBoxColumn();
            colVenMetodo = new DataGridViewTextBoxColumn();
            colVenTotal = new DataGridViewTextBoxColumn();
            colVenEstado = new DataGridViewTextBoxColumn();
            colDetProducto = new DataGridViewTextBoxColumn();
            colDetCantidad = new DataGridViewTextBoxColumn();
            colDetPrecio = new DataGridViewTextBoxColumn();
            colDetDescuento = new DataGridViewTextBoxColumn();
            colDetImporte = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // estilos compartidos
            estMoney.Alignment = DataGridViewContentAlignment.MiddleRight;
            estMoney.Format = "N2";
            estQty.Alignment = DataGridViewContentAlignment.MiddleRight;
            estQty.Format = "0.##";
            estCentro.Alignment = DataGridViewContentAlignment.MiddleCenter;
            estCab.BackColor = Color.DarkOliveGreen;
            estCab.Font = new Font("Segoe UI Semibold", 9.5F);
            estCab.ForeColor = Color.White;
            estCab.SelectionBackColor = Color.DarkOliveGreen;
            estCab.SelectionForeColor = Color.White;
            estAlt.BackColor = Color.WhiteSmoke;
            estDef.Font = new Font("Segoe UI", 9.5F);
            estDef.ForeColor = Color.DarkSlateGray;
            estDef.SelectionBackColor = Color.DarkSeaGreen;
            estDef.SelectionForeColor = Color.Black;
            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(13, 17);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Text = "Ventas y anulaciones";
            // lblSubtitulo
            lblSubtitulo.AutoSize = false;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.DimGray;
            lblSubtitulo.Location = new Point(480, 28);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(467, 20);
            lblSubtitulo.TextAlign = ContentAlignment.MiddleRight;
            lblSubtitulo.Text = "";
            // pnlFiltros
            pnlFiltros.Controls.AddRange(new Control[] { lblDesde, dtpDesde, lblHasta, dtpHasta, cmbEstado, txtBuscar, lblConteo });
            pnlFiltros.BackColor = Color.White;
            pnlFiltros.Location = new Point(13, 66);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Size = new Size(934, 56);
            // lblDesde
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 9F);
            lblDesde.ForeColor = Color.DimGray;
            lblDesde.Location = new Point(12, 20);
            lblDesde.Name = "lblDesde";
            lblDesde.Text = "Desde";
            // dtpDesde
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(56, 16);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(118, 23);
            dtpDesde.TabIndex = 0;
            // lblHasta
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 9F);
            lblHasta.ForeColor = Color.DimGray;
            lblHasta.Location = new Point(186, 20);
            lblHasta.Name = "lblHasta";
            lblHasta.Text = "Hasta";
            // dtpHasta
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(228, 16);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(118, 23);
            dtpHasta.TabIndex = 1;
            // cmbEstado
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Location = new Point(360, 16);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(130, 23);
            cmbEstado.TabIndex = 2;
            // txtBuscar
            txtBuscar.Location = new Point(504, 16);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Código o cajero...";
            txtBuscar.Size = new Size(220, 23);
            txtBuscar.TabIndex = 3;
            // lblConteo
            lblConteo.AutoSize = false;
            lblConteo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblConteo.ForeColor = Color.DarkSlateGray;
            lblConteo.Location = new Point(730, 18);
            lblConteo.Name = "lblConteo";
            lblConteo.Size = new Size(192, 22);
            lblConteo.TextAlign = ContentAlignment.MiddleRight;
            lblConteo.Text = "0 ventas";
            // dgvVentas
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AlternatingRowsDefaultCellStyle = estAlt;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.BorderStyle = BorderStyle.None;
            dgvVentas.ColumnHeadersDefaultCellStyle = estCab;
            dgvVentas.ColumnHeadersHeight = 32;
            dgvVentas.DefaultCellStyle = estDef;
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.Location = new Point(13, 132);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(934, 184);
            dgvVentas.TabIndex = 4;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { colVenCodigo, colVenFecha, colVenCajero, colVenMetodo, colVenTotal, colVenEstado });
            colVenCodigo.FillWeight = 20F;
            colVenCodigo.HeaderText = "Código";
            colVenCodigo.Name = "colVenCodigo";
            colVenFecha.FillWeight = 18F;
            colVenFecha.HeaderText = "Fecha";
            colVenFecha.Name = "colVenFecha";
            colVenCajero.FillWeight = 22F;
            colVenCajero.HeaderText = "Cajero";
            colVenCajero.Name = "colVenCajero";
            colVenMetodo.FillWeight = 18F;
            colVenMetodo.HeaderText = "Método de pago";
            colVenMetodo.Name = "colVenMetodo";
            colVenTotal.FillWeight = 12F;
            colVenTotal.HeaderText = "Total";
            colVenTotal.Name = "colVenTotal";
            colVenTotal.DefaultCellStyle = estMoney;
            colVenEstado.FillWeight = 10F;
            colVenEstado.HeaderText = "Estado";
            colVenEstado.Name = "colVenEstado";
            colVenEstado.DefaultCellStyle = estCentro;
            // pnlDetalle
            pnlDetalle.Controls.AddRange(new Control[] { lblDetalleTitulo, btnAnterior, btnSiguiente, dgvDetalle });
            pnlDetalle.BackColor = Color.White;
            pnlDetalle.Location = new Point(13, 326);
            pnlDetalle.Name = "pnlDetalle";
            pnlDetalle.Size = new Size(560, 270);
            // lblDetalleTitulo
            lblDetalleTitulo.AutoSize = true;
            lblDetalleTitulo.Font = new Font("Segoe UI Semibold", 11.25F);
            lblDetalleTitulo.ForeColor = Color.DarkSlateGray;
            lblDetalleTitulo.Location = new Point(12, 8);
            lblDetalleTitulo.Name = "lblDetalleTitulo";
            lblDetalleTitulo.Text = "Detalle de la venta";
            // btnAnterior
            btnAnterior.BackColor = Color.DarkSlateGray;
            btnAnterior.Cursor = Cursors.Hand;
            btnAnterior.FlatAppearance.BorderSize = 0;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Font = new Font("Segoe UI Semibold", 9.75F);
            btnAnterior.ForeColor = Color.White;
            btnAnterior.Location = new Point(386, 4);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(80, 28);
            btnAnterior.TabIndex = 5;
            btnAnterior.Text = "◀ Ant.";
            // btnSiguiente
            btnSiguiente.BackColor = Color.DarkSlateGray;
            btnSiguiente.Cursor = Cursors.Hand;
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Segoe UI Semibold", 9.75F);
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Location = new Point(472, 4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(80, 28);
            btnSiguiente.TabIndex = 6;
            btnSiguiente.Text = "Sig. ▶";
            // dgvDetalle
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.AlternatingRowsDefaultCellStyle = estAlt;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.BackgroundColor = Color.White;
            dgvDetalle.BorderStyle = BorderStyle.None;
            dgvDetalle.ColumnHeadersDefaultCellStyle = estCab;
            dgvDetalle.ColumnHeadersHeight = 32;
            dgvDetalle.DefaultCellStyle = estDef;
            dgvDetalle.EnableHeadersVisualStyles = false;
            dgvDetalle.Location = new Point(0, 36);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(560, 234);
            dgvDetalle.TabIndex = 7;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { colDetProducto, colDetCantidad, colDetPrecio, colDetDescuento, colDetImporte });
            colDetProducto.FillWeight = 42F;
            colDetProducto.HeaderText = "Producto";
            colDetProducto.Name = "colDetProducto";
            colDetCantidad.FillWeight = 12F;
            colDetCantidad.HeaderText = "Cant.";
            colDetCantidad.Name = "colDetCantidad";
            colDetCantidad.DefaultCellStyle = estQty;
            colDetPrecio.FillWeight = 16F;
            colDetPrecio.HeaderText = "P. unit.";
            colDetPrecio.Name = "colDetPrecio";
            colDetPrecio.DefaultCellStyle = estMoney;
            colDetDescuento.FillWeight = 14F;
            colDetDescuento.HeaderText = "Desc.";
            colDetDescuento.Name = "colDetDescuento";
            colDetDescuento.DefaultCellStyle = estMoney;
            colDetImporte.FillWeight = 16F;
            colDetImporte.HeaderText = "Importe";
            colDetImporte.Name = "colDetImporte";
            colDetImporte.DefaultCellStyle = estMoney;
            // pnlAccion
            pnlAccion.Controls.AddRange(new Control[] { lblAccionTitulo, lblVentaSel, lblMotivo, txtMotivo, btnAnular, btnRevertir, lblEspera });
            pnlAccion.BackColor = Color.White;
            pnlAccion.Location = new Point(587, 326);
            pnlAccion.Name = "pnlAccion";
            pnlAccion.Size = new Size(360, 270);
            // lblAccionTitulo
            lblAccionTitulo.AutoSize = true;
            lblAccionTitulo.Font = new Font("Segoe UI Semibold", 11.25F);
            lblAccionTitulo.ForeColor = Color.DarkSlateGray;
            lblAccionTitulo.Location = new Point(12, 8);
            lblAccionTitulo.Name = "lblAccionTitulo";
            lblAccionTitulo.Text = "Anulación";
            // lblVentaSel
            lblVentaSel.AutoSize = false;
            lblVentaSel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVentaSel.ForeColor = Color.DarkSlateGray;
            lblVentaSel.Location = new Point(12, 34);
            lblVentaSel.Name = "lblVentaSel";
            lblVentaSel.Size = new Size(336, 42);
            lblVentaSel.Text = "Seleccione una venta de la tabla";
            // lblMotivo
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Segoe UI", 9F);
            lblMotivo.ForeColor = Color.DimGray;
            lblMotivo.Location = new Point(12, 78);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Text = "Motivo de anulación";
            // txtMotivo
            txtMotivo.Location = new Point(12, 96);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.PlaceholderText = "Obligatorio para anular";
            txtMotivo.Size = new Size(336, 56);
            txtMotivo.TabIndex = 8;
            // btnAnular
            btnAnular.BackColor = Color.Brown;
            btnAnular.Cursor = Cursors.Hand;
            btnAnular.FlatAppearance.BorderSize = 0;
            btnAnular.FlatStyle = FlatStyle.Flat;
            btnAnular.Font = new Font("Segoe UI Semibold", 9.75F);
            btnAnular.ForeColor = Color.White;
            btnAnular.Location = new Point(12, 160);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(336, 34);
            btnAnular.TabIndex = 9;
            btnAnular.Text = "Anular venta";
            // btnRevertir
            btnRevertir.BackColor = Color.DarkSlateGray;
            btnRevertir.Cursor = Cursors.Hand;
            btnRevertir.FlatAppearance.BorderSize = 0;
            btnRevertir.FlatStyle = FlatStyle.Flat;
            btnRevertir.Font = new Font("Segoe UI Semibold", 9.75F);
            btnRevertir.ForeColor = Color.White;
            btnRevertir.Location = new Point(12, 198);
            btnRevertir.Name = "btnRevertir";
            btnRevertir.Size = new Size(336, 34);
            btnRevertir.TabIndex = 10;
            btnRevertir.Text = "↶ Revertir última anulación";
            // lblEspera
            lblEspera.AutoSize = false;
            lblEspera.Font = new Font("Segoe UI", 9F);
            lblEspera.ForeColor = Color.DimGray;
            lblEspera.Location = new Point(12, 238);
            lblEspera.Name = "lblEspera";
            lblEspera.Size = new Size(336, 30);
            lblEspera.Text = "";
            // UC_VentasAnulaciones
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.AddRange(new Control[] { lblTitulo, lblSubtitulo, pnlFiltros, dgvVentas, pnlDetalle, pnlAccion });
            Name = "UC_VentasAnulaciones";
            Size = new Size(960, 610);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
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
