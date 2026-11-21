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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            pnlFiltros = new Panel();
            txtBuscar = new TextBox();
            cmbCategoria = new ComboBox();
            chkSoloBajo = new CheckBox();
            btnLimpiar = new Button();
            lblConteo = new Label();
            dgvInventario = new DataGridView();
            colInvSku = new DataGridViewTextBoxColumn();
            colInvProducto = new DataGridViewTextBoxColumn();
            colInvCategoria = new DataGridViewTextBoxColumn();
            colInvProveedor = new DataGridViewTextBoxColumn();
            colInvUnidad = new DataGridViewTextBoxColumn();
            colInvStock = new DataGridViewTextBoxColumn();
            colInvMinimo = new DataGridViewTextBoxColumn();
            colInvPrecio = new DataGridViewTextBoxColumn();
            colInvEstado = new DataGridViewTextBoxColumn();
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
            pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            pnlAjuste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNuevoStock).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(15, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(387, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Inventario de sucursal";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.DimGray;
            lblSubtitulo.Location = new Point(549, 34);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(534, 27);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlFiltros
            // 
            pnlFiltros.BackColor = Color.White;
            pnlFiltros.Controls.Add(txtBuscar);
            pnlFiltros.Controls.Add(cmbCategoria);
            pnlFiltros.Controls.Add(chkSoloBajo);
            pnlFiltros.Controls.Add(btnLimpiar);
            pnlFiltros.Controls.Add(lblConteo);
            pnlFiltros.Location = new Point(15, 85);
            pnlFiltros.Margin = new Padding(3, 4, 3, 4);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Size = new Size(1169, 75);
            pnlFiltros.TabIndex = 2;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(14, 20);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por nombre o SKU...";
            txtBuscar.Size = new Size(285, 27);
            txtBuscar.TabIndex = 0;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Location = new Point(315, 20);
            cmbCategoria.Margin = new Padding(3, 4, 3, 4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(228, 28);
            cmbCategoria.TabIndex = 1;
            // 
            // chkSoloBajo
            // 
            chkSoloBajo.AutoSize = true;
            chkSoloBajo.ForeColor = Color.DarkSlateGray;
            chkSoloBajo.Location = new Point(560, 23);
            chkSoloBajo.Margin = new Padding(3, 4, 3, 4);
            chkSoloBajo.Name = "chkSoloBajo";
            chkSoloBajo.Size = new Size(207, 24);
            chkSoloBajo.TabIndex = 2;
            chkSoloBajo.Text = "Solo stock bajo o agotado";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Brown;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9.75F);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(800, 16);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(114, 43);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // lblConteo
            // 
            lblConteo.AutoSize = true;
            lblConteo.Font = new Font("Segoe UI", 9F);
            lblConteo.ForeColor = Color.DimGray;
            lblConteo.Location = new Point(931, 27);
            lblConteo.Name = "lblConteo";
            lblConteo.Size = new Size(88, 20);
            lblConteo.TabIndex = 4;
            lblConteo.Text = "0 productos";
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgvInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.BackgroundColor = Color.White;
            dgvInventario.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInventario.ColumnHeadersHeight = 32;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { colInvSku, colInvProducto, colInvCategoria, colInvProveedor, colInvUnidad, colInvStock, colInvMinimo, colInvPrecio, colInvEstado });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvInventario.DefaultCellStyle = dataGridViewCellStyle6;
            dgvInventario.EnableHeadersVisualStyles = false;
            dgvInventario.Location = new Point(15, 173);
            dgvInventario.Margin = new Padding(3, 4, 3, 4);
            dgvInventario.MultiSelect = false;
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowHeadersVisible = false;
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(1169, 386);
            dgvInventario.TabIndex = 4;
            // 
            // colInvSku
            // 
            colInvSku.FillWeight = 12F;
            colInvSku.HeaderText = "SKU";
            colInvSku.MinimumWidth = 6;
            colInvSku.Name = "colInvSku";
            colInvSku.ReadOnly = true;
            // 
            // colInvProducto
            // 
            colInvProducto.FillWeight = 34F;
            colInvProducto.HeaderText = "Producto";
            colInvProducto.MinimumWidth = 6;
            colInvProducto.Name = "colInvProducto";
            colInvProducto.ReadOnly = true;
            // 
            // colInvCategoria
            // 
            colInvCategoria.FillWeight = 18F;
            colInvCategoria.HeaderText = "Categoría";
            colInvCategoria.MinimumWidth = 6;
            colInvCategoria.Name = "colInvCategoria";
            colInvCategoria.ReadOnly = true;
            // 
            // colInvProveedor
            // 
            colInvProveedor.FillWeight = 22F;
            colInvProveedor.HeaderText = "Proveedor";
            colInvProveedor.MinimumWidth = 6;
            colInvProveedor.Name = "colInvProveedor";
            colInvProveedor.ReadOnly = true;
            // 
            // colInvUnidad
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colInvUnidad.DefaultCellStyle = dataGridViewCellStyle3;
            colInvUnidad.FillWeight = 7F;
            colInvUnidad.HeaderText = "Unid.";
            colInvUnidad.MinimumWidth = 6;
            colInvUnidad.Name = "colInvUnidad";
            colInvUnidad.ReadOnly = true;
            // 
            // colInvStock
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "0.##";
            colInvStock.DefaultCellStyle = dataGridViewCellStyle4;
            colInvStock.FillWeight = 9F;
            colInvStock.HeaderText = "Stock";
            colInvStock.MinimumWidth = 6;
            colInvStock.Name = "colInvStock";
            colInvStock.ReadOnly = true;
            // 
            // colInvMinimo
            // 
            colInvMinimo.DefaultCellStyle = dataGridViewCellStyle4;
            colInvMinimo.FillWeight = 9F;
            colInvMinimo.HeaderText = "Mínimo";
            colInvMinimo.MinimumWidth = 6;
            colInvMinimo.Name = "colInvMinimo";
            colInvMinimo.ReadOnly = true;
            // 
            // colInvPrecio
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            colInvPrecio.DefaultCellStyle = dataGridViewCellStyle5;
            colInvPrecio.FillWeight = 10F;
            colInvPrecio.HeaderText = "P. venta";
            colInvPrecio.MinimumWidth = 6;
            colInvPrecio.Name = "colInvPrecio";
            colInvPrecio.ReadOnly = true;
            // 
            // colInvEstado
            // 
            colInvEstado.DefaultCellStyle = dataGridViewCellStyle3;
            colInvEstado.FillWeight = 11F;
            colInvEstado.HeaderText = "Estado";
            colInvEstado.MinimumWidth = 6;
            colInvEstado.Name = "colInvEstado";
            colInvEstado.ReadOnly = true;
            // 
            // pnlAjuste
            // 
            pnlAjuste.BackColor = Color.White;
            pnlAjuste.Controls.Add(lblAjusteTitulo);
            pnlAjuste.Controls.Add(lblProductoSel);
            pnlAjuste.Controls.Add(lblNuevoStock);
            pnlAjuste.Controls.Add(nudNuevoStock);
            pnlAjuste.Controls.Add(lblMotivo);
            pnlAjuste.Controls.Add(txtMotivo);
            pnlAjuste.Controls.Add(btnAplicar);
            pnlAjuste.Controls.Add(btnDeshacer);
            pnlAjuste.Controls.Add(lblPila);
            pnlAjuste.Location = new Point(15, 576);
            pnlAjuste.Margin = new Padding(3, 4, 3, 4);
            pnlAjuste.Name = "pnlAjuste";
            pnlAjuste.Size = new Size(1169, 165);
            pnlAjuste.TabIndex = 5;
            // 
            // lblAjusteTitulo
            // 
            lblAjusteTitulo.AutoSize = true;
            lblAjusteTitulo.Font = new Font("Segoe UI Semibold", 11.25F);
            lblAjusteTitulo.ForeColor = Color.DarkSlateGray;
            lblAjusteTitulo.Location = new Point(14, 11);
            lblAjusteTitulo.Name = "lblAjusteTitulo";
            lblAjusteTitulo.Size = new Size(142, 25);
            lblAjusteTitulo.TabIndex = 0;
            lblAjusteTitulo.Text = "Ajuste de stock";
            // 
            // lblProductoSel
            // 
            lblProductoSel.AutoSize = true;
            lblProductoSel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProductoSel.ForeColor = Color.DarkSlateGray;
            lblProductoSel.Location = new Point(14, 51);
            lblProductoSel.Name = "lblProductoSel";
            lblProductoSel.Size = new Size(287, 23);
            lblProductoSel.TabIndex = 1;
            lblProductoSel.Text = "Seleccione un producto de la tabla";
            // 
            // lblNuevoStock
            // 
            lblNuevoStock.AutoSize = true;
            lblNuevoStock.Font = new Font("Segoe UI", 9F);
            lblNuevoStock.ForeColor = Color.DimGray;
            lblNuevoStock.Location = new Point(14, 101);
            lblNuevoStock.Name = "lblNuevoStock";
            lblNuevoStock.Size = new Size(90, 20);
            lblNuevoStock.TabIndex = 2;
            lblNuevoStock.Text = "Nuevo stock";
            // 
            // nudNuevoStock
            // 
            nudNuevoStock.DecimalPlaces = 2;
            nudNuevoStock.Location = new Point(103, 96);
            nudNuevoStock.Margin = new Padding(3, 4, 3, 4);
            nudNuevoStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudNuevoStock.Name = "nudNuevoStock";
            nudNuevoStock.Size = new Size(114, 27);
            nudNuevoStock.TabIndex = 5;
            nudNuevoStock.TextAlign = HorizontalAlignment.Right;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Segoe UI", 9F);
            lblMotivo.ForeColor = Color.DimGray;
            lblMotivo.Location = new Point(240, 101);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(56, 20);
            lblMotivo.TabIndex = 6;
            lblMotivo.Text = "Motivo";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(299, 96);
            txtMotivo.Margin = new Padding(3, 4, 3, 4);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.PlaceholderText = "Ej. conteo físico, merma, vencimiento...";
            txtMotivo.Size = new Size(319, 27);
            txtMotivo.TabIndex = 6;
            // 
            // btnAplicar
            // 
            btnAplicar.BackColor = Color.DarkOliveGreen;
            btnAplicar.Cursor = Cursors.Hand;
            btnAplicar.FlatAppearance.BorderSize = 0;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI Semibold", 9.75F);
            btnAplicar.ForeColor = Color.White;
            btnAplicar.Location = new Point(687, 86);
            btnAplicar.Margin = new Padding(3, 4, 3, 4);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(171, 48);
            btnAplicar.TabIndex = 7;
            btnAplicar.Text = "Aplicar ajuste";
            btnAplicar.UseVisualStyleBackColor = false;
            // 
            // btnDeshacer
            // 
            btnDeshacer.BackColor = Color.Brown;
            btnDeshacer.Cursor = Cursors.Hand;
            btnDeshacer.FlatAppearance.BorderSize = 0;
            btnDeshacer.FlatStyle = FlatStyle.Flat;
            btnDeshacer.Font = new Font("Segoe UI Semibold", 9.75F);
            btnDeshacer.ForeColor = Color.White;
            btnDeshacer.Location = new Point(909, 86);
            btnDeshacer.Margin = new Padding(3, 4, 3, 4);
            btnDeshacer.Name = "btnDeshacer";
            btnDeshacer.Size = new Size(231, 48);
            btnDeshacer.TabIndex = 8;
            btnDeshacer.Text = "⬅️ Deshacer último ajuste";
            btnDeshacer.UseVisualStyleBackColor = false;
            // 
            // lblPila
            // 
            lblPila.AutoSize = true;
            lblPila.Font = new Font("Segoe UI", 9F);
            lblPila.ForeColor = Color.DimGray;
            lblPila.Location = new Point(14, 136);
            lblPila.Name = "lblPila";
            lblPila.Size = new Size(120, 20);
            lblPila.TabIndex = 9;
            lblPila.Text = "Ajustes en pila: 0";
            // 
            // UC_Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(pnlFiltros);
            Controls.Add(dgvInventario);
            Controls.Add(pnlAjuste);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Inventario";
            Size = new Size(1200, 813);
            pnlFiltros.ResumeLayout(false);
            pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            pnlAjuste.ResumeLayout(false);
            pnlAjuste.PerformLayout();
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
