namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminSucursal
{
    partial class UC_Gastos
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
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            pnlNuevo = new Panel();
            lblNuevoTitulo = new Label();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblMonto = new Label();
            nudMonto = new NumericUpDown();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            btnRegistrar = new Button();
            lblUltimo = new Label();
            btnDeshacer = new Button();
            pnlFiltros = new Panel();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            lblFiltroCat = new Label();
            cmbFiltroCategoria = new ComboBox();
            chkAnulados = new CheckBox();
            lblTotal = new Label();
            dgvGastos = new DataGridView();
            colGasFecha = new DataGridViewTextBoxColumn();
            colGasCategoria = new DataGridViewTextBoxColumn();
            colGasDescripcion = new DataGridViewTextBoxColumn();
            colGasMonto = new DataGridViewTextBoxColumn();
            colGasEstado = new DataGridViewTextBoxColumn();
            pnlPorCategoria = new Panel();
            lblPorCatTitulo = new Label();
            dgvPorCategoria = new DataGridView();
            colCatNombre = new DataGridViewTextBoxColumn();
            colCatMonto = new DataGridViewTextBoxColumn();
            btnAnular = new Button();
            pnlNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGastos).BeginInit();
            pnlPorCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPorCategoria).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(15, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(132, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gastos";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.DimGray;
            lblSubtitulo.Location = new Point(549, 18);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(534, 27);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlNuevo
            // 
            pnlNuevo.BackColor = Color.White;
            pnlNuevo.Controls.Add(lblNuevoTitulo);
            pnlNuevo.Controls.Add(lblCategoria);
            pnlNuevo.Controls.Add(cmbCategoria);
            pnlNuevo.Controls.Add(lblDescripcion);
            pnlNuevo.Controls.Add(txtDescripcion);
            pnlNuevo.Controls.Add(lblMonto);
            pnlNuevo.Controls.Add(nudMonto);
            pnlNuevo.Controls.Add(lblFecha);
            pnlNuevo.Controls.Add(dtpFecha);
            pnlNuevo.Controls.Add(btnRegistrar);
            pnlNuevo.Controls.Add(lblUltimo);
            pnlNuevo.Controls.Add(btnDeshacer);
            pnlNuevo.Location = new Point(15, 69);
            pnlNuevo.Margin = new Padding(3, 4, 3, 4);
            pnlNuevo.Name = "pnlNuevo";
            pnlNuevo.Size = new Size(1168, 157);
            pnlNuevo.TabIndex = 2;
            // 
            // lblNuevoTitulo
            // 
            lblNuevoTitulo.AutoSize = true;
            lblNuevoTitulo.Font = new Font("Segoe UI Semibold", 11.25F);
            lblNuevoTitulo.ForeColor = Color.DarkSlateGray;
            lblNuevoTitulo.Location = new Point(14, 11);
            lblNuevoTitulo.Name = "lblNuevoTitulo";
            lblNuevoTitulo.Size = new Size(140, 25);
            lblNuevoTitulo.TabIndex = 0;
            lblNuevoTitulo.Text = "Registrar gasto";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F);
            lblCategoria.ForeColor = Color.DimGray;
            lblCategoria.Location = new Point(14, 51);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(74, 20);
            lblCategoria.TabIndex = 1;
            lblCategoria.Text = "Categoría";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Location = new Point(14, 75);
            cmbCategoria.Margin = new Padding(3, 4, 3, 4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(228, 28);
            cmbCategoria.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F);
            lblDescripcion.ForeColor = Color.DimGray;
            lblDescripcion.Location = new Point(258, 51);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(258, 75);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Detalle del gasto";
            txtDescripcion.Size = new Size(354, 27);
            txtDescripcion.TabIndex = 1;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 9F);
            lblMonto.ForeColor = Color.DimGray;
            lblMonto.Location = new Point(629, 51);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(81, 20);
            lblMonto.TabIndex = 3;
            lblMonto.Text = "Monto (S/)";
            // 
            // nudMonto
            // 
            nudMonto.DecimalPlaces = 2;
            nudMonto.Location = new Point(629, 75);
            nudMonto.Margin = new Padding(3, 4, 3, 4);
            nudMonto.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(126, 27);
            nudMonto.TabIndex = 2;
            nudMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9F);
            lblFecha.ForeColor = Color.DimGray;
            lblFecha.Location = new Point(770, 51);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 20);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(770, 75);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(148, 27);
            dtpFecha.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.DarkOliveGreen;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 9.75F);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(1032, 69);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(119, 43);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "＋ Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // lblUltimo
            // 
            lblUltimo.AutoSize = true;
            lblUltimo.Font = new Font("Segoe UI", 9F);
            lblUltimo.ForeColor = Color.DimGray;
            lblUltimo.Location = new Point(14, 123);
            lblUltimo.Name = "lblUltimo";
            lblUltimo.Size = new Size(266, 20);
            lblUltimo.TabIndex = 5;
            lblUltimo.Text = "Ningún gasto registrado en esta sesión";
            // 
            // btnDeshacer
            // 
            btnDeshacer.BackColor = Color.Brown;
            btnDeshacer.Cursor = Cursors.Hand;
            btnDeshacer.FlatAppearance.BorderSize = 0;
            btnDeshacer.FlatStyle = FlatStyle.Flat;
            btnDeshacer.Font = new Font("Segoe UI Semibold", 9.75F);
            btnDeshacer.ForeColor = Color.White;
            btnDeshacer.Location = new Point(867, 115);
            btnDeshacer.Margin = new Padding(3, 4, 3, 4);
            btnDeshacer.Name = "btnDeshacer";
            btnDeshacer.Size = new Size(283, 37);
            btnDeshacer.TabIndex = 5;
            btnDeshacer.Text = "⬅️ Deshacer último gasto registrado";
            btnDeshacer.UseVisualStyleBackColor = false;
            // 
            // pnlFiltros
            // 
            pnlFiltros.BackColor = Color.White;
            pnlFiltros.Controls.Add(lblDesde);
            pnlFiltros.Controls.Add(dtpDesde);
            pnlFiltros.Controls.Add(lblHasta);
            pnlFiltros.Controls.Add(dtpHasta);
            pnlFiltros.Controls.Add(lblFiltroCat);
            pnlFiltros.Controls.Add(cmbFiltroCategoria);
            pnlFiltros.Controls.Add(chkAnulados);
            pnlFiltros.Controls.Add(lblTotal);
            pnlFiltros.Location = new Point(15, 240);
            pnlFiltros.Margin = new Padding(3, 4, 3, 4);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Size = new Size(1168, 69);
            pnlFiltros.TabIndex = 3;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 9F);
            lblDesde.ForeColor = Color.DimGray;
            lblDesde.Location = new Point(14, 24);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(51, 20);
            lblDesde.TabIndex = 0;
            lblDesde.Text = "Desde";
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(66, 19);
            dtpDesde.Margin = new Padding(3, 4, 3, 4);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(137, 27);
            dtpDesde.TabIndex = 6;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 9F);
            lblHasta.ForeColor = Color.DimGray;
            lblHasta.Location = new Point(219, 24);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(47, 20);
            lblHasta.TabIndex = 7;
            lblHasta.Text = "Hasta";
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(270, 19);
            dtpHasta.Margin = new Padding(3, 4, 3, 4);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(137, 27);
            dtpHasta.TabIndex = 7;
            // 
            // lblFiltroCat
            // 
            lblFiltroCat.AutoSize = true;
            lblFiltroCat.Font = new Font("Segoe UI", 9F);
            lblFiltroCat.ForeColor = Color.DimGray;
            lblFiltroCat.Location = new Point(425, 24);
            lblFiltroCat.Name = "lblFiltroCat";
            lblFiltroCat.Size = new Size(74, 20);
            lblFiltroCat.TabIndex = 8;
            lblFiltroCat.Text = "Categoría";
            // 
            // cmbFiltroCategoria
            // 
            cmbFiltroCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroCategoria.Location = new Point(503, 19);
            cmbFiltroCategoria.Margin = new Padding(3, 4, 3, 4);
            cmbFiltroCategoria.Name = "cmbFiltroCategoria";
            cmbFiltroCategoria.Size = new Size(194, 28);
            cmbFiltroCategoria.TabIndex = 8;
            // 
            // chkAnulados
            // 
            chkAnulados.AutoSize = true;
            chkAnulados.ForeColor = Color.DarkSlateGray;
            chkAnulados.Location = new Point(713, 21);
            chkAnulados.Margin = new Padding(3, 4, 3, 4);
            chkAnulados.Name = "chkAnulados";
            chkAnulados.Size = new Size(116, 24);
            chkAnulados.TabIndex = 9;
            chkAnulados.Text = "Ver anulados";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.DarkOliveGreen;
            lblTotal.Location = new Point(965, 19);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(185, 35);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Total: S/ 0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvGastos
            // 
            dgvGastos.AllowUserToAddRows = false;
            dgvGastos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgvGastos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGastos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGastos.BackgroundColor = Color.White;
            dgvGastos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGastos.ColumnHeadersHeight = 32;
            dgvGastos.Columns.AddRange(new DataGridViewColumn[] { colGasFecha, colGasCategoria, colGasDescripcion, colGasMonto, colGasEstado });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle5.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvGastos.DefaultCellStyle = dataGridViewCellStyle5;
            dgvGastos.EnableHeadersVisualStyles = false;
            dgvGastos.Location = new Point(15, 322);
            dgvGastos.Margin = new Padding(3, 4, 3, 4);
            dgvGastos.MultiSelect = false;
            dgvGastos.Name = "dgvGastos";
            dgvGastos.ReadOnly = true;
            dgvGastos.RowHeadersVisible = false;
            dgvGastos.RowHeadersWidth = 51;
            dgvGastos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGastos.Size = new Size(876, 416);
            dgvGastos.TabIndex = 10;
            // 
            // colGasFecha
            // 
            colGasFecha.FillWeight = 16F;
            colGasFecha.HeaderText = "Fecha";
            colGasFecha.MinimumWidth = 6;
            colGasFecha.Name = "colGasFecha";
            colGasFecha.ReadOnly = true;
            // 
            // colGasCategoria
            // 
            colGasCategoria.FillWeight = 26F;
            colGasCategoria.HeaderText = "Categoría";
            colGasCategoria.MinimumWidth = 6;
            colGasCategoria.Name = "colGasCategoria";
            colGasCategoria.ReadOnly = true;
            // 
            // colGasDescripcion
            // 
            colGasDescripcion.FillWeight = 34F;
            colGasDescripcion.HeaderText = "Descripción";
            colGasDescripcion.MinimumWidth = 6;
            colGasDescripcion.Name = "colGasDescripcion";
            colGasDescripcion.ReadOnly = true;
            // 
            // colGasMonto
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            colGasMonto.DefaultCellStyle = dataGridViewCellStyle3;
            colGasMonto.FillWeight = 14F;
            colGasMonto.HeaderText = "Monto";
            colGasMonto.MinimumWidth = 6;
            colGasMonto.Name = "colGasMonto";
            colGasMonto.ReadOnly = true;
            // 
            // colGasEstado
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colGasEstado.DefaultCellStyle = dataGridViewCellStyle4;
            colGasEstado.FillWeight = 14F;
            colGasEstado.HeaderText = "Estado";
            colGasEstado.MinimumWidth = 6;
            colGasEstado.Name = "colGasEstado";
            colGasEstado.ReadOnly = true;
            // 
            // pnlPorCategoria
            // 
            pnlPorCategoria.BackColor = Color.White;
            pnlPorCategoria.Controls.Add(lblPorCatTitulo);
            pnlPorCategoria.Controls.Add(dgvPorCategoria);
            pnlPorCategoria.Controls.Add(btnAnular);
            pnlPorCategoria.Location = new Point(897, 322);
            pnlPorCategoria.Margin = new Padding(3, 4, 3, 4);
            pnlPorCategoria.Name = "pnlPorCategoria";
            pnlPorCategoria.Size = new Size(286, 416);
            pnlPorCategoria.TabIndex = 11;
            // 
            // lblPorCatTitulo
            // 
            lblPorCatTitulo.AutoSize = true;
            lblPorCatTitulo.Font = new Font("Segoe UI Semibold", 11.25F);
            lblPorCatTitulo.ForeColor = Color.DarkSlateGray;
            lblPorCatTitulo.Location = new Point(11, 11);
            lblPorCatTitulo.Name = "lblPorCatTitulo";
            lblPorCatTitulo.Size = new Size(172, 25);
            lblPorCatTitulo.TabIndex = 0;
            lblPorCatTitulo.Text = "Total por categoría";
            // 
            // dgvPorCategoria
            // 
            dgvPorCategoria.AllowUserToAddRows = false;
            dgvPorCategoria.AllowUserToDeleteRows = false;
            dgvPorCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPorCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPorCategoria.BackgroundColor = Color.White;
            dgvPorCategoria.BorderStyle = BorderStyle.None;
            dgvPorCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPorCategoria.ColumnHeadersHeight = 32;
            dgvPorCategoria.Columns.AddRange(new DataGridViewColumn[] { colCatNombre, colCatMonto });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvPorCategoria.DefaultCellStyle = dataGridViewCellStyle6;
            dgvPorCategoria.EnableHeadersVisualStyles = false;
            dgvPorCategoria.Location = new Point(0, 48);
            dgvPorCategoria.Margin = new Padding(3, 4, 3, 4);
            dgvPorCategoria.MultiSelect = false;
            dgvPorCategoria.Name = "dgvPorCategoria";
            dgvPorCategoria.ReadOnly = true;
            dgvPorCategoria.RowHeadersVisible = false;
            dgvPorCategoria.RowHeadersWidth = 51;
            dgvPorCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPorCategoria.Size = new Size(286, 308);
            dgvPorCategoria.TabIndex = 11;
            // 
            // colCatNombre
            // 
            colCatNombre.FillWeight = 60F;
            colCatNombre.HeaderText = "Categoría";
            colCatNombre.MinimumWidth = 6;
            colCatNombre.Name = "colCatNombre";
            colCatNombre.ReadOnly = true;
            // 
            // colCatMonto
            // 
            colCatMonto.DefaultCellStyle = dataGridViewCellStyle3;
            colCatMonto.FillWeight = 40F;
            colCatMonto.HeaderText = "Monto";
            colCatMonto.MinimumWidth = 6;
            colCatMonto.Name = "colCatMonto";
            colCatMonto.ReadOnly = true;
            // 
            // btnAnular
            // 
            btnAnular.BackColor = Color.Brown;
            btnAnular.Cursor = Cursors.Hand;
            btnAnular.FlatAppearance.BorderSize = 0;
            btnAnular.FlatStyle = FlatStyle.Flat;
            btnAnular.Font = new Font("Segoe UI Semibold", 9.75F);
            btnAnular.ForeColor = Color.White;
            btnAnular.Location = new Point(11, 364);
            btnAnular.Margin = new Padding(3, 4, 3, 4);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(229, 48);
            btnAnular.TabIndex = 12;
            btnAnular.Text = "Anular gasto seleccionado";
            btnAnular.UseVisualStyleBackColor = false;
            // 
            // UC_Gastos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(pnlNuevo);
            Controls.Add(pnlFiltros);
            Controls.Add(dgvGastos);
            Controls.Add(pnlPorCategoria);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Gastos";
            Size = new Size(1200, 813);
            pnlNuevo.ResumeLayout(false);
            pnlNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            pnlFiltros.ResumeLayout(false);
            pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGastos).EndInit();
            pnlPorCategoria.ResumeLayout(false);
            pnlPorCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPorCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel pnlNuevo;
        private Label lblNuevoTitulo;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblMonto;
        private NumericUpDown nudMonto;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Button btnRegistrar;
        private Label lblUltimo;
        private Button btnDeshacer;
        private Panel pnlFiltros;
        private Label lblDesde;
        private DateTimePicker dtpDesde;
        private Label lblHasta;
        private DateTimePicker dtpHasta;
        private Label lblFiltroCat;
        private ComboBox cmbFiltroCategoria;
        private CheckBox chkAnulados;
        private Label lblTotal;
        private DataGridView dgvGastos;
        private Panel pnlPorCategoria;
        private Label lblPorCatTitulo;
        private DataGridView dgvPorCategoria;
        private Button btnAnular;
        private DataGridViewTextBoxColumn colGasFecha;
        private DataGridViewTextBoxColumn colGasCategoria;
        private DataGridViewTextBoxColumn colGasDescripcion;
        private DataGridViewTextBoxColumn colGasMonto;
        private DataGridViewTextBoxColumn colGasEstado;
        private DataGridViewTextBoxColumn colCatNombre;
        private DataGridViewTextBoxColumn colCatMonto;
    }
}
