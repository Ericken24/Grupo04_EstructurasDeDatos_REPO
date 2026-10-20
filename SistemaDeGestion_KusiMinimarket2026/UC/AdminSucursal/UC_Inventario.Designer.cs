namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminSucursal
{
    partial class UC_Inventario
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
            txtBuscar = new TextBox();
            cmbCategoria = new ComboBox();
            chkSoloBajo = new CheckBox();
            btnLimpiar = new Button();
            lblConteo = new Label();
            dgvInventario = new DataGridView();
            pnlAjuste = new Panel();
            lblAjusteTitulo = new Label();
            lblProductoSel = new Label();
            lblNuevoStock = new Label();
            nudNuevoStock = new NumericUpDown();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            btnAplicar = new Button();
            btnDeshacer = new Button();
            lblPila = new Label();
            colInvSku = new DataGridViewTextBoxColumn();
            colInvProducto = new DataGridViewTextBoxColumn();
            colInvCategoria = new DataGridViewTextBoxColumn();
            colInvProveedor = new DataGridViewTextBoxColumn();
            colInvUnidad = new DataGridViewTextBoxColumn();
            colInvStock = new DataGridViewTextBoxColumn();
            colInvMinimo = new DataGridViewTextBoxColumn();
            colInvPrecio = new DataGridViewTextBoxColumn();
            colInvEstado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNuevoStock).BeginInit();
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
            lblTitulo.Text = "Inventario de sucursal";
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
            pnlFiltros.Controls.AddRange(new Control[] { txtBuscar, cmbCategoria, chkSoloBajo, btnLimpiar, lblConteo });
            pnlFiltros.BackColor = Color.White;
            pnlFiltros.Location = new Point(13, 66);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Size = new Size(934, 56);
            // txtBuscar
            txtBuscar.Location = new Point(12, 15);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por nombre o SKU...";
            txtBuscar.Size = new Size(250, 23);
            txtBuscar.TabIndex = 0;
            // cmbCategoria
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Location = new Point(276, 15);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(200, 23);
            cmbCategoria.TabIndex = 1;
            // chkSoloBajo
            chkSoloBajo.AutoSize = true;
            chkSoloBajo.ForeColor = Color.DarkSlateGray;
            chkSoloBajo.Location = new Point(490, 17);
            chkSoloBajo.Name = "chkSoloBajo";
            chkSoloBajo.TabIndex = 2;
            chkSoloBajo.Text = "Solo stock bajo o agotado";
            // btnLimpiar
            btnLimpiar.BackColor = Color.DarkSlateGray;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9.75F);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(700, 12);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 32);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            // lblConteo
            lblConteo.AutoSize = true;
            lblConteo.Font = new Font("Segoe UI", 9F);
            lblConteo.ForeColor = Color.DimGray;
            lblConteo.Location = new Point(815, 20);
            lblConteo.Name = "lblConteo";
            lblConteo.Text = "0 productos";
            // dgvInventario
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dgvInventario.AlternatingRowsDefaultCellStyle = estAlt;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.BackgroundColor = Color.White;
            dgvInventario.BorderStyle = BorderStyle.None;
            dgvInventario.ColumnHeadersDefaultCellStyle = estCab;
            dgvInventario.ColumnHeadersHeight = 32;
            dgvInventario.DefaultCellStyle = estDef;
            dgvInventario.EnableHeadersVisualStyles = false;
            dgvInventario.Location = new Point(13, 132);
            dgvInventario.MultiSelect = false;
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowHeadersVisible = false;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(934, 328);
            dgvInventario.TabIndex = 4;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { colInvSku, colInvProducto, colInvCategoria, colInvProveedor, colInvUnidad, colInvStock, colInvMinimo, colInvPrecio, colInvEstado });
            colInvSku.FillWeight = 12F;
            colInvSku.HeaderText = "SKU";
            colInvSku.Name = "colInvSku";
            colInvProducto.FillWeight = 34F;
            colInvProducto.HeaderText = "Producto";
            colInvProducto.Name = "colInvProducto";
            colInvCategoria.FillWeight = 18F;
            colInvCategoria.HeaderText = "Categoría";
            colInvCategoria.Name = "colInvCategoria";
            colInvProveedor.FillWeight = 22F;
            colInvProveedor.HeaderText = "Proveedor";
            colInvProveedor.Name = "colInvProveedor";
            colInvUnidad.FillWeight = 7F;
            colInvUnidad.HeaderText = "Unid.";
            colInvUnidad.Name = "colInvUnidad";
            colInvUnidad.DefaultCellStyle = estCentro;
            colInvStock.FillWeight = 9F;
            colInvStock.HeaderText = "Stock";
            colInvStock.Name = "colInvStock";
            colInvStock.DefaultCellStyle = estQty;
            colInvMinimo.FillWeight = 9F;
            colInvMinimo.HeaderText = "Mínimo";
            colInvMinimo.Name = "colInvMinimo";
            colInvMinimo.DefaultCellStyle = estQty;
            colInvPrecio.FillWeight = 10F;
            colInvPrecio.HeaderText = "P. venta";
            colInvPrecio.Name = "colInvPrecio";
            colInvPrecio.DefaultCellStyle = estMoney;
            colInvEstado.FillWeight = 11F;
            colInvEstado.HeaderText = "Estado";
            colInvEstado.Name = "colInvEstado";
            colInvEstado.DefaultCellStyle = estCentro;
            // pnlAjuste
            pnlAjuste.Controls.AddRange(new Control[] { lblAjusteTitulo, lblProductoSel, lblNuevoStock, nudNuevoStock, lblMotivo, txtMotivo, btnAplicar, btnDeshacer, lblPila });
            pnlAjuste.BackColor = Color.White;
            pnlAjuste.Location = new Point(13, 470);
            pnlAjuste.Name = "pnlAjuste";
            pnlAjuste.Size = new Size(934, 124);
            // lblAjusteTitulo
            lblAjusteTitulo.AutoSize = true;
            lblAjusteTitulo.Font = new Font("Segoe UI Semibold", 11.25F);
            lblAjusteTitulo.ForeColor = Color.DarkSlateGray;
            lblAjusteTitulo.Location = new Point(12, 8);
            lblAjusteTitulo.Name = "lblAjusteTitulo";
            lblAjusteTitulo.Text = "Ajuste de stock";
            // lblProductoSel
            lblProductoSel.AutoSize = true;
            lblProductoSel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProductoSel.ForeColor = Color.DarkSlateGray;
            lblProductoSel.Location = new Point(12, 38);
            lblProductoSel.Name = "lblProductoSel";
            lblProductoSel.Text = "Seleccione un producto de la tabla";
            // lblNuevoStock
            lblNuevoStock.AutoSize = true;
            lblNuevoStock.Font = new Font("Segoe UI", 9F);
            lblNuevoStock.ForeColor = Color.DimGray;
            lblNuevoStock.Location = new Point(12, 76);
            lblNuevoStock.Name = "lblNuevoStock";
            lblNuevoStock.Text = "Nuevo stock";
            // nudNuevoStock
            nudNuevoStock.DecimalPlaces = 2;
            nudNuevoStock.Location = new Point(90, 72);
            nudNuevoStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudNuevoStock.Name = "nudNuevoStock";
            nudNuevoStock.Size = new Size(100, 23);
            nudNuevoStock.TabIndex = 5;
            nudNuevoStock.TextAlign = HorizontalAlignment.Right;
            // lblMotivo
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Segoe UI", 9F);
            lblMotivo.ForeColor = Color.DimGray;
            lblMotivo.Location = new Point(210, 76);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Text = "Motivo";
            // txtMotivo
            txtMotivo.Location = new Point(262, 72);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.PlaceholderText = "Ej. conteo físico, merma, vencimiento...";
            txtMotivo.Size = new Size(280, 23);
            txtMotivo.TabIndex = 6;
            // btnAplicar
            btnAplicar.BackColor = Color.DarkOliveGreen;
            btnAplicar.Cursor = Cursors.Hand;
            btnAplicar.FlatAppearance.BorderSize = 0;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI Semibold", 9.75F);
            btnAplicar.ForeColor = Color.White;
            btnAplicar.Location = new Point(560, 66);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(150, 36);
            btnAplicar.TabIndex = 7;
            btnAplicar.Text = "Aplicar ajuste";
            // btnDeshacer
            btnDeshacer.BackColor = Color.DarkSlateGray;
            btnDeshacer.Cursor = Cursors.Hand;
            btnDeshacer.FlatAppearance.BorderSize = 0;
            btnDeshacer.FlatStyle = FlatStyle.Flat;
            btnDeshacer.Font = new Font("Segoe UI Semibold", 9.75F);
            btnDeshacer.ForeColor = Color.White;
            btnDeshacer.Location = new Point(720, 66);
            btnDeshacer.Name = "btnDeshacer";
            btnDeshacer.Size = new Size(202, 36);
            btnDeshacer.TabIndex = 8;
            btnDeshacer.Text = "↶ Deshacer último ajuste";
            // lblPila
            lblPila.AutoSize = true;
            lblPila.Font = new Font("Segoe UI", 9F);
            lblPila.ForeColor = Color.DimGray;
            lblPila.Location = new Point(12, 102);
            lblPila.Name = "lblPila";
            lblPila.Text = "Ajustes en pila: 0";
            // UC_Inventario
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.AddRange(new Control[] { lblTitulo, lblSubtitulo, pnlFiltros, dgvInventario, pnlAjuste });
            Name = "UC_Inventario";
            Size = new Size(960, 610);
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNuevoStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel pnlFiltros;
        private TextBox txtBuscar;
        private ComboBox cmbCategoria;
        private CheckBox chkSoloBajo;
        private Button btnLimpiar;
        private Label lblConteo;
        private DataGridView dgvInventario;
        private Panel pnlAjuste;
        private Label lblAjusteTitulo;
        private Label lblProductoSel;
        private Label lblNuevoStock;
        private NumericUpDown nudNuevoStock;
        private Label lblMotivo;
        private TextBox txtMotivo;
        private Button btnAplicar;
        private Button btnDeshacer;
        private Label lblPila;
        private DataGridViewTextBoxColumn colInvSku;
        private DataGridViewTextBoxColumn colInvProducto;
        private DataGridViewTextBoxColumn colInvCategoria;
        private DataGridViewTextBoxColumn colInvProveedor;
        private DataGridViewTextBoxColumn colInvUnidad;
        private DataGridViewTextBoxColumn colInvStock;
        private DataGridViewTextBoxColumn colInvMinimo;
        private DataGridViewTextBoxColumn colInvPrecio;
        private DataGridViewTextBoxColumn colInvEstado;
    }
}
