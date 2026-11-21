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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            colRepConcepto = new DataGridViewTextBoxColumn();
            colRepCantidad = new DataGridViewTextBoxColumn();
            colRepMonto = new DataGridViewTextBoxColumn();
            colRepPorcentaje = new DataGridViewTextBoxColumn();
            lblPie = new Label();
            saveFileDialog1 = new SaveFileDialog();
            pnlParametros.SuspendLayout();
            pnlResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(15, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(170, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Reportes";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.DimGray;
            lblSubtitulo.Location = new Point(549, 37);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(534, 27);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlParametros
            // 
            pnlParametros.BackColor = Color.White;
            pnlParametros.Controls.Add(lblTipo);
            pnlParametros.Controls.Add(cmbTipo);
            pnlParametros.Controls.Add(lblDesde);
            pnlParametros.Controls.Add(dtpDesde);
            pnlParametros.Controls.Add(lblHasta);
            pnlParametros.Controls.Add(dtpHasta);
            pnlParametros.Controls.Add(btnGenerar);
            pnlParametros.Controls.Add(btnVolver);
            pnlParametros.Controls.Add(btnExportar);
            pnlParametros.Location = new Point(15, 88);
            pnlParametros.Margin = new Padding(3, 4, 3, 4);
            pnlParametros.Name = "pnlParametros";
            pnlParametros.Size = new Size(1171, 93);
            pnlParametros.TabIndex = 2;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 9F);
            lblTipo.ForeColor = Color.DimGray;
            lblTipo.Location = new Point(14, 13);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(113, 20);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo de reporte";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Location = new Point(14, 40);
            cmbTipo.Margin = new Padding(3, 4, 3, 4);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(319, 28);
            cmbTipo.TabIndex = 0;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 9F);
            lblDesde.ForeColor = Color.DimGray;
            lblDesde.Location = new Point(350, 13);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(51, 20);
            lblDesde.TabIndex = 1;
            lblDesde.Text = "Desde";
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(350, 40);
            dtpDesde.Margin = new Padding(3, 4, 3, 4);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(137, 27);
            dtpDesde.TabIndex = 1;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 9F);
            lblHasta.ForeColor = Color.DimGray;
            lblHasta.Location = new Point(503, 13);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(47, 20);
            lblHasta.TabIndex = 2;
            lblHasta.Text = "Hasta";
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(503, 40);
            dtpHasta.Margin = new Padding(3, 4, 3, 4);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(137, 27);
            dtpHasta.TabIndex = 2;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.DarkOliveGreen;
            btnGenerar.Cursor = Cursors.Hand;
            btnGenerar.FlatAppearance.BorderSize = 0;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI Semibold", 9.75F);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(656, 35);
            btnGenerar.Margin = new Padding(3, 4, 3, 4);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(137, 45);
            btnGenerar.TabIndex = 3;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.DarkSlateGray;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI Semibold", 9.75F);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(802, 35);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(126, 45);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "⬅️ Anterior";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.Brown;
            btnExportar.Cursor = Cursors.Hand;
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI Semibold", 9.75F);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(937, 35);
            btnExportar.Margin = new Padding(3, 4, 3, 4);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(117, 45);
            btnExportar.TabIndex = 5;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = false;
            // 
            // pnlResumen
            // 
            pnlResumen.BackColor = Color.White;
            pnlResumen.Controls.Add(lblReporteTitulo);
            pnlResumen.Controls.Add(lblReporteDetalle);
            pnlResumen.Controls.Add(lblReporteTotal);
            pnlResumen.Location = new Point(15, 195);
            pnlResumen.Margin = new Padding(3, 4, 3, 4);
            pnlResumen.Name = "pnlResumen";
            pnlResumen.Size = new Size(1171, 69);
            pnlResumen.TabIndex = 3;
            // 
            // lblReporteTitulo
            // 
            lblReporteTitulo.AutoSize = true;
            lblReporteTitulo.Font = new Font("Segoe UI Semibold", 11.25F);
            lblReporteTitulo.ForeColor = Color.DarkSlateGray;
            lblReporteTitulo.Location = new Point(14, 8);
            lblReporteTitulo.Name = "lblReporteTitulo";
            lblReporteTitulo.Size = new Size(198, 25);
            lblReporteTitulo.TabIndex = 0;
            lblReporteTitulo.Text = "Seleccione un reporte";
            // 
            // lblReporteDetalle
            // 
            lblReporteDetalle.AutoSize = true;
            lblReporteDetalle.Font = new Font("Segoe UI", 9F);
            lblReporteDetalle.ForeColor = Color.DimGray;
            lblReporteDetalle.Location = new Point(14, 40);
            lblReporteDetalle.Name = "lblReporteDetalle";
            lblReporteDetalle.Size = new Size(0, 20);
            lblReporteDetalle.TabIndex = 1;
            // 
            // lblReporteTotal
            // 
            lblReporteTotal.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold);
            lblReporteTotal.ForeColor = Color.DarkOliveGreen;
            lblReporteTotal.Location = new Point(711, 13);
            lblReporteTotal.Name = "lblReporteTotal";
            lblReporteTotal.Size = new Size(343, 40);
            lblReporteTotal.TabIndex = 2;
            lblReporteTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvReporte
            // 
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            dgvReporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporte.BackgroundColor = Color.White;
            dgvReporte.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 9.5F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvReporte.ColumnHeadersHeight = 32;
            dgvReporte.Columns.AddRange(new DataGridViewColumn[] { colRepConcepto, colRepCantidad, colRepMonto, colRepPorcentaje });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle10.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle10.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvReporte.DefaultCellStyle = dataGridViewCellStyle10;
            dgvReporte.EnableHeadersVisualStyles = false;
            dgvReporte.Location = new Point(15, 277);
            dgvReporte.Margin = new Padding(3, 4, 3, 4);
            dgvReporte.MultiSelect = false;
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dgvReporte.RowHeadersVisible = false;
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporte.Size = new Size(1171, 399);
            dgvReporte.TabIndex = 6;
            // 
            // colRepConcepto
            // 
            colRepConcepto.FillWeight = 46F;
            colRepConcepto.HeaderText = "Concepto";
            colRepConcepto.MinimumWidth = 6;
            colRepConcepto.Name = "colRepConcepto";
            colRepConcepto.ReadOnly = true;
            // 
            // colRepCantidad
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "0.##";
            colRepCantidad.DefaultCellStyle = dataGridViewCellStyle8;
            colRepCantidad.FillWeight = 16F;
            colRepCantidad.HeaderText = "Cantidad";
            colRepCantidad.MinimumWidth = 6;
            colRepCantidad.Name = "colRepCantidad";
            colRepCantidad.ReadOnly = true;
            // 
            // colRepMonto
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            colRepMonto.DefaultCellStyle = dataGridViewCellStyle9;
            colRepMonto.FillWeight = 20F;
            colRepMonto.HeaderText = "Monto (S/)";
            colRepMonto.MinimumWidth = 6;
            colRepMonto.Name = "colRepMonto";
            colRepMonto.ReadOnly = true;
            // 
            // colRepPorcentaje
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "0.##";
            colRepPorcentaje.DefaultCellStyle = dataGridViewCellStyle4;
            colRepPorcentaje.FillWeight = 18F;
            colRepPorcentaje.HeaderText = "% del total";
            colRepPorcentaje.MinimumWidth = 6;
            colRepPorcentaje.Name = "colRepPorcentaje";
            colRepPorcentaje.ReadOnly = true;
            // 
            // lblPie
            // 
            lblPie.AutoSize = true;
            lblPie.Font = new Font("Segoe UI", 9F);
            lblPie.ForeColor = Color.DimGray;
            lblPie.Location = new Point(15, 706);
            lblPie.Name = "lblPie";
            lblPie.Size = new Size(148, 20);
            lblPie.TabIndex = 7;
            lblPie.Text = "Reportes en la pila: 0";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Archivo CSV (*.csv)|*.csv";
            saveFileDialog1.Title = "Exportar reporte";
            // 
            // UC_Reportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(pnlParametros);
            Controls.Add(pnlResumen);
            Controls.Add(dgvReporte);
            Controls.Add(lblPie);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Reportes";
            Size = new Size(1200, 813);
            pnlParametros.ResumeLayout(false);
            pnlParametros.PerformLayout();
            pnlResumen.ResumeLayout(false);
            pnlResumen.PerformLayout();
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
