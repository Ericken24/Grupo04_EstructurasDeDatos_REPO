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
            DataGridViewCellStyle estMoney = new DataGridViewCellStyle();
            DataGridViewCellStyle estCentro = new DataGridViewCellStyle();
            DataGridViewCellStyle estCab = new DataGridViewCellStyle();
            DataGridViewCellStyle estAlt = new DataGridViewCellStyle();
            DataGridViewCellStyle estDef = new DataGridViewCellStyle();
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
            pnlPorCategoria = new Panel();
            lblPorCatTitulo = new Label();
            dgvPorCategoria = new DataGridView();
            btnAnular = new Button();
            colGasFecha = new DataGridViewTextBoxColumn();
            colGasCategoria = new DataGridViewTextBoxColumn();
            colGasDescripcion = new DataGridViewTextBoxColumn();
            colGasMonto = new DataGridViewTextBoxColumn();
            colGasEstado = new DataGridViewTextBoxColumn();
            colCatNombre = new DataGridViewTextBoxColumn();
            colCatMonto = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGastos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPorCategoria).BeginInit();
            SuspendLayout();
            // estilos compartidos
            estMoney.Alignment = DataGridViewContentAlignment.MiddleRight;
            estMoney.Format = "N2";
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
            lblTitulo.Text = "Gastos";
            // lblSubtitulo
            lblSubtitulo.AutoSize = false;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.DimGray;
            lblSubtitulo.Location = new Point(480, 28);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(467, 20);
            lblSubtitulo.TextAlign = ContentAlignment.MiddleRight;
            lblSubtitulo.Text = "";
            // pnlNuevo
            pnlNuevo.Controls.AddRange(new Control[] { lblNuevoTitulo, lblCategoria, cmbCategoria, lblDescripcion, txtDescripcion, lblMonto, nudMonto, lblFecha, dtpFecha, btnRegistrar, lblUltimo, btnDeshacer });
            pnlNuevo.BackColor = Color.White;
            pnlNuevo.Location = new Point(13, 66);
            pnlNuevo.Name = "pnlNuevo";
            pnlNuevo.Size = new Size(934, 118);
            // lblNuevoTitulo
            lblNuevoTitulo.AutoSize = true;
            lblNuevoTitulo.Font = new Font("Segoe UI Semibold", 11.25F);
            lblNuevoTitulo.ForeColor = Color.DarkSlateGray;
            lblNuevoTitulo.Location = new Point(12, 8);
            lblNuevoTitulo.Name = "lblNuevoTitulo";
            lblNuevoTitulo.Text = "Registrar gasto";
            // lblCategoria
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F);
            lblCategoria.ForeColor = Color.DimGray;
            lblCategoria.Location = new Point(12, 38);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Text = "Categoría";
            // cmbCategoria
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Location = new Point(12, 56);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(200, 23);
            cmbCategoria.TabIndex = 0;
            // lblDescripcion
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F);
            lblDescripcion.ForeColor = Color.DimGray;
            lblDescripcion.Location = new Point(226, 38);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Text = "Descripción";
            // txtDescripcion
            txtDescripcion.Location = new Point(226, 56);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Detalle del gasto";
            txtDescripcion.Size = new Size(310, 23);
            txtDescripcion.TabIndex = 1;
            // lblMonto
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 9F);
            lblMonto.ForeColor = Color.DimGray;
            lblMonto.Location = new Point(550, 38);
            lblMonto.Name = "lblMonto";
            lblMonto.Text = "Monto (S/)";
            // nudMonto
            nudMonto.DecimalPlaces = 2;
            nudMonto.Location = new Point(550, 56);
            nudMonto.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(110, 23);
            nudMonto.TabIndex = 2;
            nudMonto.TextAlign = HorizontalAlignment.Right;
            // lblFecha
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9F);
            lblFecha.ForeColor = Color.DimGray;
            lblFecha.Location = new Point(674, 38);
            lblFecha.Name = "lblFecha";
            lblFecha.Text = "Fecha";
            // dtpFecha
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(674, 56);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(130, 23);
            dtpFecha.TabIndex = 3;
            // btnRegistrar
            btnRegistrar.BackColor = Color.DarkOliveGreen;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 9.75F);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(818, 52);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(104, 32);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "＋ Registrar";
            // lblUltimo
            lblUltimo.AutoSize = true;
            lblUltimo.Font = new Font("Segoe UI", 9F);
            lblUltimo.ForeColor = Color.DimGray;
            lblUltimo.Location = new Point(12, 92);
            lblUltimo.Name = "lblUltimo";
            lblUltimo.Text = "Ningún gasto registrado en esta sesión";
            // btnDeshacer
            btnDeshacer.BackColor = Color.DarkSlateGray;
            btnDeshacer.Cursor = Cursors.Hand;
            btnDeshacer.FlatAppearance.BorderSize = 0;
            btnDeshacer.FlatStyle = FlatStyle.Flat;
            btnDeshacer.Font = new Font("Segoe UI Semibold", 9.75F);
            btnDeshacer.ForeColor = Color.White;
            btnDeshacer.Location = new Point(674, 86);
            btnDeshacer.Name = "btnDeshacer";
            btnDeshacer.Size = new Size(248, 28);
            btnDeshacer.TabIndex = 5;
            btnDeshacer.Text = "↶ Deshacer último gasto registrado";
            // pnlFiltros
            pnlFiltros.Controls.AddRange(new Control[] { lblDesde, dtpDesde, lblHasta, dtpHasta, lblFiltroCat, cmbFiltroCategoria, chkAnulados, lblTotal });
            pnlFiltros.BackColor = Color.White;
            pnlFiltros.Location = new Point(13, 194);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Size = new Size(934, 52);
            // lblDesde
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 9F);
            lblDesde.ForeColor = Color.DimGray;
            lblDesde.Location = new Point(12, 18);
            lblDesde.Name = "lblDesde";
            lblDesde.Text = "Desde";
            // dtpDesde
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(58, 14);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(120, 23);
            dtpDesde.TabIndex = 6;
            // lblHasta
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 9F);
            lblHasta.ForeColor = Color.DimGray;
            lblHasta.Location = new Point(192, 18);
            lblHasta.Name = "lblHasta";
            lblHasta.Text = "Hasta";
            // dtpHasta
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(236, 14);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(120, 23);
            dtpHasta.TabIndex = 7;
            // lblFiltroCat
            lblFiltroCat.AutoSize = true;
            lblFiltroCat.Font = new Font("Segoe UI", 9F);
            lblFiltroCat.ForeColor = Color.DimGray;
            lblFiltroCat.Location = new Point(372, 18);
            lblFiltroCat.Name = "lblFiltroCat";
            lblFiltroCat.Text = "Categoría";
            // cmbFiltroCategoria
            cmbFiltroCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroCategoria.Location = new Point(440, 14);
            cmbFiltroCategoria.Name = "cmbFiltroCategoria";
            cmbFiltroCategoria.Size = new Size(170, 23);
            cmbFiltroCategoria.TabIndex = 8;
            // chkAnulados
            chkAnulados.AutoSize = true;
            chkAnulados.ForeColor = Color.DarkSlateGray;
            chkAnulados.Location = new Point(624, 16);
            chkAnulados.Name = "chkAnulados";
            chkAnulados.TabIndex = 9;
            chkAnulados.Text = "Ver anulados";
            // lblTotal
            lblTotal.AutoSize = false;
            lblTotal.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.DarkOliveGreen;
            lblTotal.Location = new Point(760, 12);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(162, 26);
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            lblTotal.Text = "Total: S/ 0.00";
            // dgvGastos
            dgvGastos.AllowUserToAddRows = false;
            dgvGastos.AllowUserToDeleteRows = false;
            dgvGastos.AlternatingRowsDefaultCellStyle = estAlt;
            dgvGastos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGastos.BackgroundColor = Color.White;
            dgvGastos.BorderStyle = BorderStyle.None;
            dgvGastos.ColumnHeadersDefaultCellStyle = estCab;
            dgvGastos.ColumnHeadersHeight = 32;
            dgvGastos.DefaultCellStyle = estDef;
            dgvGastos.EnableHeadersVisualStyles = false;
            dgvGastos.Location = new Point(13, 256);
            dgvGastos.MultiSelect = false;
            dgvGastos.Name = "dgvGastos";
            dgvGastos.ReadOnly = true;
            dgvGastos.RowHeadersVisible = false;
            dgvGastos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGastos.Size = new Size(700, 340);
            dgvGastos.TabIndex = 10;
            dgvGastos.Columns.AddRange(new DataGridViewColumn[] { colGasFecha, colGasCategoria, colGasDescripcion, colGasMonto, colGasEstado });
            colGasFecha.FillWeight = 16F;
            colGasFecha.HeaderText = "Fecha";
            colGasFecha.Name = "colGasFecha";
            colGasCategoria.FillWeight = 26F;
            colGasCategoria.HeaderText = "Categoría";
            colGasCategoria.Name = "colGasCategoria";
            colGasDescripcion.FillWeight = 34F;
            colGasDescripcion.HeaderText = "Descripción";
            colGasDescripcion.Name = "colGasDescripcion";
            colGasMonto.FillWeight = 14F;
            colGasMonto.HeaderText = "Monto";
            colGasMonto.Name = "colGasMonto";
            colGasMonto.DefaultCellStyle = estMoney;
            colGasEstado.FillWeight = 14F;
            colGasEstado.HeaderText = "Estado";
            colGasEstado.Name = "colGasEstado";
            colGasEstado.DefaultCellStyle = estCentro;
            // pnlPorCategoria
            pnlPorCategoria.Controls.AddRange(new Control[] { lblPorCatTitulo, dgvPorCategoria, btnAnular });
            pnlPorCategoria.BackColor = Color.White;
            pnlPorCategoria.Location = new Point(727, 256);
            pnlPorCategoria.Name = "pnlPorCategoria";
            pnlPorCategoria.Size = new Size(220, 340);
            // lblPorCatTitulo
            lblPorCatTitulo.AutoSize = true;
            lblPorCatTitulo.Font = new Font("Segoe UI Semibold", 11.25F);
            lblPorCatTitulo.ForeColor = Color.DarkSlateGray;
            lblPorCatTitulo.Location = new Point(10, 8);
            lblPorCatTitulo.Name = "lblPorCatTitulo";
            lblPorCatTitulo.Text = "Total por categoría";
            // dgvPorCategoria
            dgvPorCategoria.AllowUserToAddRows = false;
            dgvPorCategoria.AllowUserToDeleteRows = false;
            dgvPorCategoria.AlternatingRowsDefaultCellStyle = estAlt;
            dgvPorCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPorCategoria.BackgroundColor = Color.White;
            dgvPorCategoria.BorderStyle = BorderStyle.None;
            dgvPorCategoria.ColumnHeadersDefaultCellStyle = estCab;
            dgvPorCategoria.ColumnHeadersHeight = 32;
            dgvPorCategoria.DefaultCellStyle = estDef;
            dgvPorCategoria.EnableHeadersVisualStyles = false;
            dgvPorCategoria.Location = new Point(0, 36);
            dgvPorCategoria.MultiSelect = false;
            dgvPorCategoria.Name = "dgvPorCategoria";
            dgvPorCategoria.ReadOnly = true;
            dgvPorCategoria.RowHeadersVisible = false;
            dgvPorCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPorCategoria.Size = new Size(220, 240);
            dgvPorCategoria.TabIndex = 11;
            dgvPorCategoria.Columns.AddRange(new DataGridViewColumn[] { colCatNombre, colCatMonto });
            colCatNombre.FillWeight = 60F;
            colCatNombre.HeaderText = "Categoría";
            colCatNombre.Name = "colCatNombre";
            colCatMonto.FillWeight = 40F;
            colCatMonto.HeaderText = "Monto";
            colCatMonto.Name = "colCatMonto";
            colCatMonto.DefaultCellStyle = estMoney;
            // btnAnular
            btnAnular.BackColor = Color.Brown;
            btnAnular.Cursor = Cursors.Hand;
            btnAnular.FlatAppearance.BorderSize = 0;
            btnAnular.FlatStyle = FlatStyle.Flat;
            btnAnular.Font = new Font("Segoe UI Semibold", 9.75F);
            btnAnular.ForeColor = Color.White;
            btnAnular.Location = new Point(10, 290);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(200, 36);
            btnAnular.TabIndex = 12;
            btnAnular.Text = "Anular gasto seleccionado";
            // UC_Gastos
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.AddRange(new Control[] { lblTitulo, lblSubtitulo, pnlNuevo, pnlFiltros, dgvGastos, pnlPorCategoria });
            Name = "UC_Gastos";
            Size = new Size(960, 610);
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGastos).EndInit();
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
