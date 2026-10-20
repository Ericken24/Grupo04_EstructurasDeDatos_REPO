namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminSucursal
{
    partial class UC_Reportes
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle estMoney = new DataGridViewCellStyle();
            DataGridViewCellStyle estQty = new DataGridViewCellStyle();
            DataGridViewCellStyle estCab = new DataGridViewCellStyle();
            DataGridViewCellStyle estAlt = new DataGridViewCellStyle();
            DataGridViewCellStyle estDef = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            pnlParametros = new Panel();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            btnGenerar = new Button();
            btnVolver = new Button();
            btnExportar = new Button();
            pnlResumen = new Panel();
            lblReporteTitulo = new Label();
            lblReporteDetalle = new Label();
            lblReporteTotal = new Label();
            dgvReporte = new DataGridView();
            lblPie = new Label();
            colRepConcepto = new DataGridViewTextBoxColumn();
            colRepCantidad = new DataGridViewTextBoxColumn();
            colRepMonto = new DataGridViewTextBoxColumn();
            colRepPorcentaje = new DataGridViewTextBoxColumn();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // estilos compartidos
            estMoney.Alignment = DataGridViewContentAlignment.MiddleRight;
            estMoney.Format = "N2";
            estQty.Alignment = DataGridViewContentAlignment.MiddleRight;
            estQty.Format = "0.##";
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
            lblTitulo.Text = "Reportes";
            // lblSubtitulo
            lblSubtitulo.AutoSize = false;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.DimGray;
            lblSubtitulo.Location = new Point(480, 28);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(467, 20);
            lblSubtitulo.TextAlign = ContentAlignment.MiddleRight;
            lblSubtitulo.Text = "";
            // pnlParametros
            pnlParametros.Controls.AddRange(new Control[] { lblTipo, cmbTipo, lblDesde, dtpDesde, lblHasta, dtpHasta, btnGenerar, btnVolver, btnExportar });
            pnlParametros.BackColor = Color.White;
            pnlParametros.Location = new Point(13, 66);
            pnlParametros.Name = "pnlParametros";
            pnlParametros.Size = new Size(934, 70);
            // lblTipo
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 9F);
            lblTipo.ForeColor = Color.DimGray;
            lblTipo.Location = new Point(12, 10);
            lblTipo.Name = "lblTipo";
            lblTipo.Text = "Tipo de reporte";
            // cmbTipo
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Location = new Point(12, 30);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(280, 23);
            cmbTipo.TabIndex = 0;
            // lblDesde
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 9F);
            lblDesde.ForeColor = Color.DimGray;
            lblDesde.Location = new Point(306, 10);
            lblDesde.Name = "lblDesde";
            lblDesde.Text = "Desde";
            // dtpDesde
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(306, 30);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(120, 23);
            dtpDesde.TabIndex = 1;
            // lblHasta
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 9F);
            lblHasta.ForeColor = Color.DimGray;
            lblHasta.Location = new Point(440, 10);
            lblHasta.Name = "lblHasta";
            lblHasta.Text = "Hasta";
            // dtpHasta
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(440, 30);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(120, 23);
            dtpHasta.TabIndex = 2;
            // btnGenerar
            btnGenerar.BackColor = Color.DarkOliveGreen;
            btnGenerar.Cursor = Cursors.Hand;
            btnGenerar.FlatAppearance.BorderSize = 0;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI Semibold", 9.75F);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(574, 26);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(120, 34);
            btnGenerar.TabIndex = 3;
            btnGenerar.Text = "Generar";
            // btnVolver
            btnVolver.BackColor = Color.DarkSlateGray;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI Semibold", 9.75F);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(702, 26);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(110, 34);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "↶ Anterior";
            // btnExportar
            btnExportar.BackColor = Color.DarkSlateGray;
            btnExportar.Cursor = Cursors.Hand;
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI Semibold", 9.75F);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(820, 26);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(102, 34);
            btnExportar.TabIndex = 5;
            btnExportar.Text = "Exportar";
            // pnlResumen
            pnlResumen.Controls.AddRange(new Control[] { lblReporteTitulo, lblReporteDetalle, lblReporteTotal });
            pnlResumen.BackColor = Color.White;
            pnlResumen.Location = new Point(13, 146);
            pnlResumen.Name = "pnlResumen";
            pnlResumen.Size = new Size(934, 52);
            // lblReporteTitulo
            lblReporteTitulo.AutoSize = true;
            lblReporteTitulo.Font = new Font("Segoe UI Semibold", 11.25F);
            lblReporteTitulo.ForeColor = Color.DarkSlateGray;
            lblReporteTitulo.Location = new Point(12, 6);
            lblReporteTitulo.Name = "lblReporteTitulo";
            lblReporteTitulo.Text = "Seleccione un reporte";
            // lblReporteDetalle
            lblReporteDetalle.AutoSize = true;
            lblReporteDetalle.Font = new Font("Segoe UI", 9F);
            lblReporteDetalle.ForeColor = Color.DimGray;
            lblReporteDetalle.Location = new Point(12, 30);
            lblReporteDetalle.Name = "lblReporteDetalle";
            lblReporteDetalle.Text = "";
            // lblReporteTotal
            lblReporteTotal.AutoSize = false;
            lblReporteTotal.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold);
            lblReporteTotal.ForeColor = Color.DarkOliveGreen;
            lblReporteTotal.Location = new Point(622, 10);
            lblReporteTotal.Name = "lblReporteTotal";
            lblReporteTotal.Size = new Size(300, 30);
            lblReporteTotal.TextAlign = ContentAlignment.MiddleRight;
            lblReporteTotal.Text = "";
            // dgvReporte
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.AllowUserToDeleteRows = false;
            dgvReporte.AlternatingRowsDefaultCellStyle = estAlt;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporte.BackgroundColor = Color.White;
            dgvReporte.BorderStyle = BorderStyle.None;
            dgvReporte.ColumnHeadersDefaultCellStyle = estCab;
            dgvReporte.ColumnHeadersHeight = 32;
            dgvReporte.DefaultCellStyle = estDef;
            dgvReporte.EnableHeadersVisualStyles = false;
            dgvReporte.Location = new Point(13, 208);
            dgvReporte.MultiSelect = false;
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dgvReporte.RowHeadersVisible = false;
            dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporte.Size = new Size(934, 342);
            dgvReporte.TabIndex = 6;
            dgvReporte.Columns.AddRange(new DataGridViewColumn[] { colRepConcepto, colRepCantidad, colRepMonto, colRepPorcentaje });
            colRepConcepto.FillWeight = 46F;
            colRepConcepto.HeaderText = "Concepto";
            colRepConcepto.Name = "colRepConcepto";
            colRepCantidad.FillWeight = 16F;
            colRepCantidad.HeaderText = "Cantidad";
            colRepCantidad.Name = "colRepCantidad";
            colRepCantidad.DefaultCellStyle = estQty;
            colRepMonto.FillWeight = 20F;
            colRepMonto.HeaderText = "Monto (S/)";
            colRepMonto.Name = "colRepMonto";
            colRepMonto.DefaultCellStyle = estMoney;
            colRepPorcentaje.FillWeight = 18F;
            colRepPorcentaje.HeaderText = "% del total";
            colRepPorcentaje.Name = "colRepPorcentaje";
            colRepPorcentaje.DefaultCellStyle = estMoney;
            // lblPie
            lblPie.AutoSize = true;
            lblPie.Font = new Font("Segoe UI", 9F);
            lblPie.ForeColor = Color.DimGray;
            lblPie.Location = new Point(13, 562);
            lblPie.Name = "lblPie";
            lblPie.Text = "Reportes en la pila: 0";
            // saveFileDialog1
            saveFileDialog1.Filter = "Archivo CSV (*.csv)|*.csv";
            saveFileDialog1.Title = "Exportar reporte";
            // UC_Reportes
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.AddRange(new Control[] { lblTitulo, lblSubtitulo, pnlParametros, pnlResumen, dgvReporte, lblPie });
            Name = "UC_Reportes";
            Size = new Size(960, 610);
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel pnlParametros;
        private Label lblTipo;
        private ComboBox cmbTipo;
        private Label lblDesde;
        private DateTimePicker dtpDesde;
        private Label lblHasta;
        private DateTimePicker dtpHasta;
        private Button btnGenerar;
        private Button btnVolver;
        private Button btnExportar;
        private Panel pnlResumen;
        private Label lblReporteTitulo;
        private Label lblReporteDetalle;
        private Label lblReporteTotal;
        private DataGridView dgvReporte;
        private Label lblPie;
        private DataGridViewTextBoxColumn colRepConcepto;
        private DataGridViewTextBoxColumn colRepCantidad;
        private DataGridViewTextBoxColumn colRepMonto;
        private DataGridViewTextBoxColumn colRepPorcentaje;
        private SaveFileDialog saveFileDialog1;
    }
}
