namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminSucursal
{
    partial class UC_Compras
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
            pnlNueva = new Panel();
            lblNuevaTitulo = new Label();
            lblProveedor = new Label();
            cmbProveedor = new ComboBox();
            lblProducto = new Label();
            cmbProducto = new ComboBox();
            lblCantidad = new Label();
            nudCantidad = new NumericUpDown();
            lblCosto = new Label();
            nudCosto = new NumericUpDown();
            lblStockActual = new Label();
            btnAgregar = new Button();
            btnDeshacerItem = new Button();
            lblDetalleTitulo = new Label();
            dgvDetalle = new DataGridView();
            lblTotal = new Label();
            btnVaciar = new Button();
            btnRegistrar = new Button();
            pnlHistorial = new Panel();
            lblHistTitulo = new Label();
            dgvCompras = new DataGridView();
            lblColaTitulo = new Label();
            lblCola = new Label();
            btnRecibir = new Button();
            btnAnular = new Button();
            colDetProducto = new DataGridViewTextBoxColumn();
            colDetCantidad = new DataGridViewTextBoxColumn();
            colDetCosto = new DataGridViewTextBoxColumn();
            colDetImporte = new DataGridViewTextBoxColumn();
            colCompCodigo = new DataGridViewTextBoxColumn();
            colCompFecha = new DataGridViewTextBoxColumn();
            colCompProveedor = new DataGridViewTextBoxColumn();
            colCompItems = new DataGridViewTextBoxColumn();
            colCompTotal = new DataGridViewTextBoxColumn();
            colCompEstado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
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
            lblTitulo.Text = "Compras";
            // lblSubtitulo
            lblSubtitulo.AutoSize = false;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.DimGray;
            lblSubtitulo.Location = new Point(480, 28);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(467, 20);
            lblSubtitulo.TextAlign = ContentAlignment.MiddleRight;
            lblSubtitulo.Text = "";
            // pnlNueva
            pnlNueva.Controls.AddRange(new Control[] { lblNuevaTitulo, lblProveedor, cmbProveedor, lblProducto, cmbProducto, lblCantidad, nudCantidad, lblCosto, nudCosto, lblStockActual, btnAgregar, btnDeshacerItem, lblDetalleTitulo, dgvDetalle, lblTotal, btnVaciar, btnRegistrar });
            pnlNueva.BackColor = Color.White;
            pnlNueva.Location = new Point(13, 66);
            pnlNueva.Name = "pnlNueva";
            pnlNueva.Size = new Size(934, 262);
            // lblNuevaTitulo
            lblNuevaTitulo.AutoSize = true;
            lblNuevaTitulo.Font = new Font("Segoe UI Semibold", 11.25F);
            lblNuevaTitulo.ForeColor = Color.DarkSlateGray;
            lblNuevaTitulo.Location = new Point(12, 8);
            lblNuevaTitulo.Name = "lblNuevaTitulo";
            lblNuevaTitulo.Text = "Nueva compra";
            // lblProveedor
            lblProveedor.AutoSize = true;
            lblProveedor.Font = new Font("Segoe UI", 9F);
            lblProveedor.ForeColor = Color.DimGray;
            lblProveedor.Location = new Point(12, 40);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Text = "Proveedor";
            // cmbProveedor
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.Location = new Point(12, 58);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(290, 23);
            cmbProveedor.TabIndex = 0;
            // lblProducto
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 9F);
            lblProducto.ForeColor = Color.DimGray;
            lblProducto.Location = new Point(12, 90);
            lblProducto.Name = "lblProducto";
            lblProducto.Text = "Producto";
            // cmbProducto
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.Location = new Point(12, 108);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(290, 23);
            cmbProducto.TabIndex = 1;
            // lblCantidad
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9F);
            lblCantidad.ForeColor = Color.DimGray;
            lblCantidad.Location = new Point(12, 140);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Text = "Cantidad";
            // nudCantidad
            nudCantidad.DecimalPlaces = 2;
            nudCantidad.Location = new Point(12, 158);
            nudCantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(100, 23);
            nudCantidad.TabIndex = 2;
            nudCantidad.TextAlign = HorizontalAlignment.Right;
            // lblCosto
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Segoe UI", 9F);
            lblCosto.ForeColor = Color.DimGray;
            lblCosto.Location = new Point(126, 140);
            lblCosto.Name = "lblCosto";
            lblCosto.Text = "Costo unit. (S/)";
            // nudCosto
            nudCosto.DecimalPlaces = 2;
            nudCosto.Location = new Point(126, 158);
            nudCosto.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudCosto.Name = "nudCosto";
            nudCosto.Size = new Size(110, 23);
            nudCosto.TabIndex = 3;
            nudCosto.TextAlign = HorizontalAlignment.Right;
            // lblStockActual
            lblStockActual.AutoSize = true;
            lblStockActual.Font = new Font("Segoe UI", 9F);
            lblStockActual.ForeColor = Color.DimGray;
            lblStockActual.Location = new Point(12, 190);
            lblStockActual.Name = "lblStockActual";
            lblStockActual.Text = "Stock actual: -";
            // btnAgregar
            btnAgregar.BackColor = Color.DarkOliveGreen;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI Semibold", 9.75F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(12, 214);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 34);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "＋ Agregar";
            // btnDeshacerItem
            btnDeshacerItem.BackColor = Color.DarkSlateGray;
            btnDeshacerItem.Cursor = Cursors.Hand;
            btnDeshacerItem.FlatAppearance.BorderSize = 0;
            btnDeshacerItem.FlatStyle = FlatStyle.Flat;
            btnDeshacerItem.Font = new Font("Segoe UI Semibold", 9.75F);
            btnDeshacerItem.ForeColor = Color.White;
            btnDeshacerItem.Location = new Point(162, 214);
            btnDeshacerItem.Name = "btnDeshacerItem";
            btnDeshacerItem.Size = new Size(140, 34);
            btnDeshacerItem.TabIndex = 5;
            btnDeshacerItem.Text = "↶ Deshacer último";
            // lblDetalleTitulo
            lblDetalleTitulo.AutoSize = true;
            lblDetalleTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDetalleTitulo.ForeColor = Color.DarkSlateGray;
            lblDetalleTitulo.Location = new Point(330, 12);
            lblDetalleTitulo.Name = "lblDetalleTitulo";
            lblDetalleTitulo.Text = "Detalle de la compra";
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
            dgvDetalle.Location = new Point(330, 36);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(592, 166);
            dgvDetalle.TabIndex = 6;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { colDetProducto, colDetCantidad, colDetCosto, colDetImporte });
            colDetProducto.FillWeight = 46F;
            colDetProducto.HeaderText = "Producto";
            colDetProducto.Name = "colDetProducto";
            colDetCantidad.FillWeight = 16F;
            colDetCantidad.HeaderText = "Cantidad";
            colDetCantidad.Name = "colDetCantidad";
            colDetCantidad.DefaultCellStyle = estQty;
            colDetCosto.FillWeight = 19F;
            colDetCosto.HeaderText = "Costo unit.";
            colDetCosto.Name = "colDetCosto";
            colDetCosto.DefaultCellStyle = estMoney;
            colDetImporte.FillWeight = 19F;
            colDetImporte.HeaderText = "Importe";
            colDetImporte.Name = "colDetImporte";
            colDetImporte.DefaultCellStyle = estMoney;
            // lblTotal
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.DarkOliveGreen;
            lblTotal.Location = new Point(330, 218);
            lblTotal.Name = "lblTotal";
            lblTotal.Text = "Total: S/ 0.00";
            // btnVaciar
            btnVaciar.BackColor = Color.DarkSlateGray;
            btnVaciar.Cursor = Cursors.Hand;
            btnVaciar.FlatAppearance.BorderSize = 0;
            btnVaciar.FlatStyle = FlatStyle.Flat;
            btnVaciar.Font = new Font("Segoe UI Semibold", 9.75F);
            btnVaciar.ForeColor = Color.White;
            btnVaciar.Location = new Point(590, 214);
            btnVaciar.Name = "btnVaciar";
            btnVaciar.Size = new Size(160, 34);
            btnVaciar.TabIndex = 7;
            btnVaciar.Text = "Vaciar detalle";
            // btnRegistrar
            btnRegistrar.BackColor = Color.DarkOliveGreen;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 9.75F);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(760, 214);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(162, 34);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "✔ Registrar compra";
            // pnlHistorial
            pnlHistorial.Controls.AddRange(new Control[] { lblHistTitulo, dgvCompras, lblColaTitulo, lblCola, btnRecibir, btnAnular });
            pnlHistorial.BackColor = Color.White;
            pnlHistorial.Location = new Point(13, 338);
            pnlHistorial.Name = "pnlHistorial";
            pnlHistorial.Size = new Size(934, 258);
            // lblHistTitulo
            lblHistTitulo.AutoSize = true;
            lblHistTitulo.Font = new Font("Segoe UI Semibold", 11.25F);
            lblHistTitulo.ForeColor = Color.DarkSlateGray;
            lblHistTitulo.Location = new Point(12, 8);
            lblHistTitulo.Name = "lblHistTitulo";
            lblHistTitulo.Text = "Compras registradas";
            // dgvCompras
            dgvCompras.AllowUserToAddRows = false;
            dgvCompras.AllowUserToDeleteRows = false;
            dgvCompras.AlternatingRowsDefaultCellStyle = estAlt;
            dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompras.BackgroundColor = Color.White;
            dgvCompras.BorderStyle = BorderStyle.None;
            dgvCompras.ColumnHeadersDefaultCellStyle = estCab;
            dgvCompras.ColumnHeadersHeight = 32;
            dgvCompras.DefaultCellStyle = estDef;
            dgvCompras.EnableHeadersVisualStyles = false;
            dgvCompras.Location = new Point(12, 36);
            dgvCompras.MultiSelect = false;
            dgvCompras.Name = "dgvCompras";
            dgvCompras.ReadOnly = true;
            dgvCompras.RowHeadersVisible = false;
            dgvCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompras.Size = new Size(700, 210);
            dgvCompras.TabIndex = 9;
            dgvCompras.Columns.AddRange(new DataGridViewColumn[] { colCompCodigo, colCompFecha, colCompProveedor, colCompItems, colCompTotal, colCompEstado });
            colCompCodigo.FillWeight = 24F;
            colCompCodigo.HeaderText = "Código";
            colCompCodigo.Name = "colCompCodigo";
            colCompFecha.FillWeight = 20F;
            colCompFecha.HeaderText = "Fecha";
            colCompFecha.Name = "colCompFecha";
            colCompProveedor.FillWeight = 32F;
            colCompProveedor.HeaderText = "Proveedor";
            colCompProveedor.Name = "colCompProveedor";
            colCompItems.FillWeight = 9F;
            colCompItems.HeaderText = "Ítems";
            colCompItems.Name = "colCompItems";
            colCompItems.DefaultCellStyle = estCentro;
            colCompTotal.FillWeight = 17F;
            colCompTotal.HeaderText = "Total";
            colCompTotal.Name = "colCompTotal";
            colCompTotal.DefaultCellStyle = estMoney;
            colCompEstado.FillWeight = 18F;
            colCompEstado.HeaderText = "Estado";
            colCompEstado.Name = "colCompEstado";
            colCompEstado.DefaultCellStyle = estCentro;
            // lblColaTitulo
            lblColaTitulo.AutoSize = true;
            lblColaTitulo.Font = new Font("Segoe UI", 9F);
            lblColaTitulo.ForeColor = Color.DarkOliveGreen;
            lblColaTitulo.Location = new Point(726, 38);
            lblColaTitulo.Name = "lblColaTitulo";
            lblColaTitulo.Text = "COLA DE RECEPCIÓN";
            // lblCola
            lblCola.AutoSize = false;
            lblCola.Font = new Font("Segoe UI", 10F);
            lblCola.ForeColor = Color.DarkSlateGray;
            lblCola.Location = new Point(726, 58);
            lblCola.Name = "lblCola";
            lblCola.Size = new Size(196, 54);
            lblCola.Text = "";
            // btnRecibir
            btnRecibir.BackColor = Color.DarkOliveGreen;
            btnRecibir.Cursor = Cursors.Hand;
            btnRecibir.FlatAppearance.BorderSize = 0;
            btnRecibir.FlatStyle = FlatStyle.Flat;
            btnRecibir.Font = new Font("Segoe UI Semibold", 9.75F);
            btnRecibir.ForeColor = Color.White;
            btnRecibir.Location = new Point(726, 118);
            btnRecibir.Name = "btnRecibir";
            btnRecibir.Size = new Size(196, 38);
            btnRecibir.TabIndex = 10;
            btnRecibir.Text = "📥 Recibir siguiente";
            // btnAnular
            btnAnular.BackColor = Color.Brown;
            btnAnular.Cursor = Cursors.Hand;
            btnAnular.FlatAppearance.BorderSize = 0;
            btnAnular.FlatStyle = FlatStyle.Flat;
            btnAnular.Font = new Font("Segoe UI Semibold", 9.75F);
            btnAnular.ForeColor = Color.White;
            btnAnular.Location = new Point(726, 166);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(196, 38);
            btnAnular.TabIndex = 11;
            btnAnular.Text = "Anular compra";
            // UC_Compras
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.AddRange(new Control[] { lblTitulo, lblSubtitulo, pnlNueva, pnlHistorial });
            Name = "UC_Compras";
            Size = new Size(960, 610);
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel pnlNueva;
        private Label lblNuevaTitulo;
        private Label lblProveedor;
        private ComboBox cmbProveedor;
        private Label lblProducto;
        private ComboBox cmbProducto;
        private Label lblCantidad;
        private NumericUpDown nudCantidad;
        private Label lblCosto;
        private NumericUpDown nudCosto;
        private Label lblStockActual;
        private Button btnAgregar;
        private Button btnDeshacerItem;
        private Label lblDetalleTitulo;
        private DataGridView dgvDetalle;
        private Label lblTotal;
        private Button btnVaciar;
        private Button btnRegistrar;
        private Panel pnlHistorial;
        private Label lblHistTitulo;
        private DataGridView dgvCompras;
        private Label lblColaTitulo;
        private Label lblCola;
        private Button btnRecibir;
        private Button btnAnular;
        private DataGridViewTextBoxColumn colDetProducto;
        private DataGridViewTextBoxColumn colDetCantidad;
        private DataGridViewTextBoxColumn colDetCosto;
        private DataGridViewTextBoxColumn colDetImporte;
        private DataGridViewTextBoxColumn colCompCodigo;
        private DataGridViewTextBoxColumn colCompFecha;
        private DataGridViewTextBoxColumn colCompProveedor;
        private DataGridViewTextBoxColumn colCompItems;
        private DataGridViewTextBoxColumn colCompTotal;
        private DataGridViewTextBoxColumn colCompEstado;
    }
}
