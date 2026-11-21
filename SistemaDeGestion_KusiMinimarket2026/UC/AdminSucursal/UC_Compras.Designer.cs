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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
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
            colDetProducto = new DataGridViewTextBoxColumn();
            colDetCantidad = new DataGridViewTextBoxColumn();
            colDetCosto = new DataGridViewTextBoxColumn();
            colDetImporte = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            btnVaciar = new Button();
            btnRegistrar = new Button();
            pnlHistorial = new Panel();
            lblHistTitulo = new Label();
            dgvCompras = new DataGridView();
            colCompCodigo = new DataGridViewTextBoxColumn();
            colCompFecha = new DataGridViewTextBoxColumn();
            colCompProveedor = new DataGridViewTextBoxColumn();
            colCompItems = new DataGridViewTextBoxColumn();
            colCompTotal = new DataGridViewTextBoxColumn();
            colCompEstado = new DataGridViewTextBoxColumn();
            lblColaTitulo = new Label();
            lblCola = new Label();
            btnRecibir = new Button();
            btnAnular = new Button();
            pnlNueva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            pnlHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(15, 2);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(167, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Compras";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.DimGray;
            lblSubtitulo.Location = new Point(549, 16);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(534, 27);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlNueva
            // 
            pnlNueva.BackColor = Color.White;
            pnlNueva.Controls.Add(lblNuevaTitulo);
            pnlNueva.Controls.Add(lblProveedor);
            pnlNueva.Controls.Add(cmbProveedor);
            pnlNueva.Controls.Add(lblProducto);
            pnlNueva.Controls.Add(cmbProducto);
            pnlNueva.Controls.Add(lblCantidad);
            pnlNueva.Controls.Add(nudCantidad);
            pnlNueva.Controls.Add(lblCosto);
            pnlNueva.Controls.Add(nudCosto);
            pnlNueva.Controls.Add(lblStockActual);
            pnlNueva.Controls.Add(btnAgregar);
            pnlNueva.Controls.Add(btnDeshacerItem);
            pnlNueva.Controls.Add(lblDetalleTitulo);
            pnlNueva.Controls.Add(dgvDetalle);
            pnlNueva.Controls.Add(lblTotal);
            pnlNueva.Controls.Add(btnVaciar);
            pnlNueva.Controls.Add(btnRegistrar);
            pnlNueva.Location = new Point(15, 67);
            pnlNueva.Margin = new Padding(3, 4, 3, 4);
            pnlNueva.Name = "pnlNueva";
            pnlNueva.Size = new Size(1067, 349);
            pnlNueva.TabIndex = 2;
            // 
            // lblNuevaTitulo
            // 
            lblNuevaTitulo.AutoSize = true;
            lblNuevaTitulo.Font = new Font("Segoe UI Semibold", 11.25F);
            lblNuevaTitulo.ForeColor = Color.DarkSlateGray;
            lblNuevaTitulo.Location = new Point(14, 11);
            lblNuevaTitulo.Name = "lblNuevaTitulo";
            lblNuevaTitulo.Size = new Size(138, 25);
            lblNuevaTitulo.TabIndex = 0;
            lblNuevaTitulo.Text = "Nueva compra";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Font = new Font("Segoe UI", 9F);
            lblProveedor.ForeColor = Color.DimGray;
            lblProveedor.Location = new Point(14, 53);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(77, 20);
            lblProveedor.TabIndex = 1;
            lblProveedor.Text = "Proveedor";
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.Location = new Point(14, 77);
            cmbProveedor.Margin = new Padding(3, 4, 3, 4);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(331, 28);
            cmbProveedor.TabIndex = 0;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 9F);
            lblProducto.ForeColor = Color.DimGray;
            lblProducto.Location = new Point(14, 120);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(69, 20);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto";
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.Location = new Point(14, 144);
            cmbProducto.Margin = new Padding(3, 4, 3, 4);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(331, 28);
            cmbProducto.TabIndex = 1;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9F);
            lblCantidad.ForeColor = Color.DimGray;
            lblCantidad.Location = new Point(14, 187);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            nudCantidad.DecimalPlaces = 2;
            nudCantidad.Location = new Point(14, 211);
            nudCantidad.Margin = new Padding(3, 4, 3, 4);
            nudCantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(114, 27);
            nudCantidad.TabIndex = 2;
            nudCantidad.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Segoe UI", 9F);
            lblCosto.ForeColor = Color.DimGray;
            lblCosto.Location = new Point(144, 187);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(107, 20);
            lblCosto.TabIndex = 4;
            lblCosto.Text = "Costo unit. (S/)";
            // 
            // nudCosto
            // 
            nudCosto.DecimalPlaces = 2;
            nudCosto.Location = new Point(144, 211);
            nudCosto.Margin = new Padding(3, 4, 3, 4);
            nudCosto.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudCosto.Name = "nudCosto";
            nudCosto.Size = new Size(126, 27);
            nudCosto.TabIndex = 3;
            nudCosto.TextAlign = HorizontalAlignment.Right;
            // 
            // lblStockActual
            // 
            lblStockActual.AutoSize = true;
            lblStockActual.Font = new Font("Segoe UI", 9F);
            lblStockActual.ForeColor = Color.DimGray;
            lblStockActual.Location = new Point(14, 253);
            lblStockActual.Name = "lblStockActual";
            lblStockActual.Size = new Size(102, 20);
            lblStockActual.TabIndex = 5;
            lblStockActual.Text = "Stock actual: -";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkOliveGreen;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI Semibold", 9.75F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(14, 285);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(160, 45);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "＋ Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnDeshacerItem
            // 
            btnDeshacerItem.BackColor = Color.DarkSlateGray;
            btnDeshacerItem.Cursor = Cursors.Hand;
            btnDeshacerItem.FlatAppearance.BorderSize = 0;
            btnDeshacerItem.FlatStyle = FlatStyle.Flat;
            btnDeshacerItem.Font = new Font("Segoe UI Semibold", 9.75F);
            btnDeshacerItem.ForeColor = Color.White;
            btnDeshacerItem.Location = new Point(185, 277);
            btnDeshacerItem.Margin = new Padding(3, 4, 3, 4);
            btnDeshacerItem.Name = "btnDeshacerItem";
            btnDeshacerItem.Size = new Size(160, 60);
            btnDeshacerItem.TabIndex = 5;
            btnDeshacerItem.Text = "⬅️ Deshacer último";
            btnDeshacerItem.UseVisualStyleBackColor = false;
            // 
            // lblDetalleTitulo
            // 
            lblDetalleTitulo.AutoSize = true;
            lblDetalleTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDetalleTitulo.ForeColor = Color.DarkSlateGray;
            lblDetalleTitulo.Location = new Point(377, 16);
            lblDetalleTitulo.Name = "lblDetalleTitulo";
            lblDetalleTitulo.Size = new Size(177, 23);
            lblDetalleTitulo.TabIndex = 6;
            lblDetalleTitulo.Text = "Detalle de la compra";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgvDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.BackgroundColor = Color.White;
            dgvDetalle.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDetalle.ColumnHeadersHeight = 32;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { colDetProducto, colDetCantidad, colDetCosto, colDetImporte });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvDetalle.DefaultCellStyle = dataGridViewCellStyle6;
            dgvDetalle.EnableHeadersVisualStyles = false;
            dgvDetalle.Location = new Point(377, 48);
            dgvDetalle.Margin = new Padding(3, 4, 3, 4);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(677, 221);
            dgvDetalle.TabIndex = 6;
            // 
            // colDetProducto
            // 
            colDetProducto.FillWeight = 46F;
            colDetProducto.HeaderText = "Producto";
            colDetProducto.MinimumWidth = 6;
            colDetProducto.Name = "colDetProducto";
            colDetProducto.ReadOnly = true;
            // 
            // colDetCantidad
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "0.##";
            colDetCantidad.DefaultCellStyle = dataGridViewCellStyle3;
            colDetCantidad.FillWeight = 16F;
            colDetCantidad.HeaderText = "Cantidad";
            colDetCantidad.MinimumWidth = 6;
            colDetCantidad.Name = "colDetCantidad";
            colDetCantidad.ReadOnly = true;
            // 
            // colDetCosto
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            colDetCosto.DefaultCellStyle = dataGridViewCellStyle4;
            colDetCosto.FillWeight = 19F;
            colDetCosto.HeaderText = "Costo unit.";
            colDetCosto.MinimumWidth = 6;
            colDetCosto.Name = "colDetCosto";
            colDetCosto.ReadOnly = true;
            // 
            // colDetImporte
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            colDetImporte.DefaultCellStyle = dataGridViewCellStyle5;
            colDetImporte.FillWeight = 19F;
            colDetImporte.HeaderText = "Importe";
            colDetImporte.MinimumWidth = 6;
            colDetImporte.Name = "colDetImporte";
            colDetImporte.ReadOnly = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.DarkOliveGreen;
            lblTotal.Location = new Point(377, 291);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(144, 28);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total: S/ 0.00";
            // 
            // btnVaciar
            // 
            btnVaciar.BackColor = Color.Brown;
            btnVaciar.Cursor = Cursors.Hand;
            btnVaciar.FlatAppearance.BorderSize = 0;
            btnVaciar.FlatStyle = FlatStyle.Flat;
            btnVaciar.Font = new Font("Segoe UI Semibold", 9.75F);
            btnVaciar.ForeColor = Color.White;
            btnVaciar.Location = new Point(674, 285);
            btnVaciar.Margin = new Padding(3, 4, 3, 4);
            btnVaciar.Name = "btnVaciar";
            btnVaciar.Size = new Size(183, 45);
            btnVaciar.TabIndex = 7;
            btnVaciar.Text = "🗑️ Vaciar detalle";
            btnVaciar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.DarkOliveGreen;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 9.75F);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(869, 285);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(185, 45);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "✔ Registrar compra";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // pnlHistorial
            // 
            pnlHistorial.BackColor = Color.White;
            pnlHistorial.Controls.Add(lblHistTitulo);
            pnlHistorial.Controls.Add(dgvCompras);
            pnlHistorial.Controls.Add(lblColaTitulo);
            pnlHistorial.Controls.Add(lblCola);
            pnlHistorial.Controls.Add(btnRecibir);
            pnlHistorial.Controls.Add(btnAnular);
            pnlHistorial.Location = new Point(15, 430);
            pnlHistorial.Margin = new Padding(3, 4, 3, 4);
            pnlHistorial.Name = "pnlHistorial";
            pnlHistorial.Size = new Size(1067, 311);
            pnlHistorial.TabIndex = 3;
            // 
            // lblHistTitulo
            // 
            lblHistTitulo.AutoSize = true;
            lblHistTitulo.Font = new Font("Segoe UI Semibold", 11.25F);
            lblHistTitulo.ForeColor = Color.DarkSlateGray;
            lblHistTitulo.Location = new Point(14, 11);
            lblHistTitulo.Name = "lblHistTitulo";
            lblHistTitulo.Size = new Size(187, 25);
            lblHistTitulo.TabIndex = 0;
            lblHistTitulo.Text = "Compras registradas";
            // 
            // dgvCompras
            // 
            dgvCompras.AllowUserToAddRows = false;
            dgvCompras.AllowUserToDeleteRows = false;
            dgvCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompras.BackgroundColor = Color.White;
            dgvCompras.BorderStyle = BorderStyle.None;
            dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCompras.ColumnHeadersHeight = 32;
            dgvCompras.Columns.AddRange(new DataGridViewColumn[] { colCompCodigo, colCompFecha, colCompProveedor, colCompItems, colCompTotal, colCompEstado });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle9.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle9.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvCompras.DefaultCellStyle = dataGridViewCellStyle9;
            dgvCompras.EnableHeadersVisualStyles = false;
            dgvCompras.Location = new Point(14, 48);
            dgvCompras.Margin = new Padding(3, 4, 3, 4);
            dgvCompras.MultiSelect = false;
            dgvCompras.Name = "dgvCompras";
            dgvCompras.ReadOnly = true;
            dgvCompras.RowHeadersVisible = false;
            dgvCompras.RowHeadersWidth = 51;
            dgvCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompras.Size = new Size(800, 251);
            dgvCompras.TabIndex = 9;
            // 
            // colCompCodigo
            // 
            colCompCodigo.FillWeight = 24F;
            colCompCodigo.HeaderText = "Código";
            colCompCodigo.MinimumWidth = 6;
            colCompCodigo.Name = "colCompCodigo";
            colCompCodigo.ReadOnly = true;
            // 
            // colCompFecha
            // 
            colCompFecha.FillWeight = 20F;
            colCompFecha.HeaderText = "Fecha";
            colCompFecha.MinimumWidth = 6;
            colCompFecha.Name = "colCompFecha";
            colCompFecha.ReadOnly = true;
            // 
            // colCompProveedor
            // 
            colCompProveedor.FillWeight = 32F;
            colCompProveedor.HeaderText = "Proveedor";
            colCompProveedor.MinimumWidth = 6;
            colCompProveedor.Name = "colCompProveedor";
            colCompProveedor.ReadOnly = true;
            // 
            // colCompItems
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCompItems.DefaultCellStyle = dataGridViewCellStyle7;
            colCompItems.FillWeight = 9F;
            colCompItems.HeaderText = "Ítems";
            colCompItems.MinimumWidth = 6;
            colCompItems.Name = "colCompItems";
            colCompItems.ReadOnly = true;
            // 
            // colCompTotal
            // 
            colCompTotal.DefaultCellStyle = dataGridViewCellStyle5;
            colCompTotal.FillWeight = 17F;
            colCompTotal.HeaderText = "Total";
            colCompTotal.MinimumWidth = 6;
            colCompTotal.Name = "colCompTotal";
            colCompTotal.ReadOnly = true;
            // 
            // colCompEstado
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCompEstado.DefaultCellStyle = dataGridViewCellStyle8;
            colCompEstado.FillWeight = 18F;
            colCompEstado.HeaderText = "Estado";
            colCompEstado.MinimumWidth = 6;
            colCompEstado.Name = "colCompEstado";
            colCompEstado.ReadOnly = true;
            // 
            // lblColaTitulo
            // 
            lblColaTitulo.AutoSize = true;
            lblColaTitulo.Font = new Font("Segoe UI", 9F);
            lblColaTitulo.ForeColor = Color.DarkOliveGreen;
            lblColaTitulo.Location = new Point(830, 51);
            lblColaTitulo.Name = "lblColaTitulo";
            lblColaTitulo.Size = new Size(150, 20);
            lblColaTitulo.TabIndex = 10;
            lblColaTitulo.Text = "COLA DE RECEPCIÓN";
            // 
            // lblCola
            // 
            lblCola.Font = new Font("Segoe UI", 10F);
            lblCola.ForeColor = Color.DarkSlateGray;
            lblCola.Location = new Point(830, 77);
            lblCola.Name = "lblCola";
            lblCola.Size = new Size(224, 72);
            lblCola.TabIndex = 11;
            // 
            // btnRecibir
            // 
            btnRecibir.BackColor = Color.DarkOliveGreen;
            btnRecibir.Cursor = Cursors.Hand;
            btnRecibir.FlatAppearance.BorderSize = 0;
            btnRecibir.FlatStyle = FlatStyle.Flat;
            btnRecibir.Font = new Font("Segoe UI Semibold", 9.75F);
            btnRecibir.ForeColor = Color.White;
            btnRecibir.Location = new Point(830, 157);
            btnRecibir.Margin = new Padding(3, 4, 3, 4);
            btnRecibir.Name = "btnRecibir";
            btnRecibir.Size = new Size(224, 51);
            btnRecibir.TabIndex = 10;
            btnRecibir.Text = "📥 Recibir siguiente";
            btnRecibir.UseVisualStyleBackColor = false;
            // 
            // btnAnular
            // 
            btnAnular.BackColor = Color.Brown;
            btnAnular.Cursor = Cursors.Hand;
            btnAnular.FlatAppearance.BorderSize = 0;
            btnAnular.FlatStyle = FlatStyle.Flat;
            btnAnular.Font = new Font("Segoe UI Semibold", 9.75F);
            btnAnular.ForeColor = Color.White;
            btnAnular.Location = new Point(830, 221);
            btnAnular.Margin = new Padding(3, 4, 3, 4);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(224, 51);
            btnAnular.TabIndex = 11;
            btnAnular.Text = "Anular compra";
            btnAnular.UseVisualStyleBackColor = false;
            // 
            // UC_Compras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(pnlNueva);
            Controls.Add(pnlHistorial);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Compras";
            Size = new Size(1097, 813);
            pnlNueva.ResumeLayout(false);
            pnlNueva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            pnlHistorial.ResumeLayout(false);
            pnlHistorial.PerformLayout();
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
