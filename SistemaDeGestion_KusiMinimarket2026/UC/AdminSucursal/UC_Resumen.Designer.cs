namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminSucursal
{
    partial class UC_Resumen
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
            btnActualizar = new Button();
            pnlKpi1 = new Panel();
            lblKpi1Titulo = new Label();
            lblKpi1Valor = new Label();
            lblKpi1Sub = new Label();
            pnlKpi2 = new Panel();
            lblKpi2Titulo = new Label();
            lblKpi2Valor = new Label();
            lblKpi2Sub = new Label();
            pnlKpi3 = new Panel();
            lblKpi3Titulo = new Label();
            lblKpi3Valor = new Label();
            lblKpi3Sub = new Label();
            pnlKpi4 = new Panel();
            lblKpi4Titulo = new Label();
            lblKpi4Valor = new Label();
            lblKpi4Sub = new Label();
            pnlUltimas = new Panel();
            lblUltimasTitulo = new Label();
            dgvUltimas = new DataGridView();
            pnlCritico = new Panel();
            lblCriticoTitulo = new Label();
            dgvCritico = new DataGridView();
            pnlDestacado = new Panel();
            lblDestacadoTitulo = new Label();
            lblDestacadoTexto = new Label();
            lblDestacadoPos = new Label();
            btnSiguiente = new Button();
            colUltCodigo = new DataGridViewTextBoxColumn();
            colUltFecha = new DataGridViewTextBoxColumn();
            colUltCajero = new DataGridViewTextBoxColumn();
            colUltEstado = new DataGridViewTextBoxColumn();
            colUltTotal = new DataGridViewTextBoxColumn();
            colCritProducto = new DataGridViewTextBoxColumn();
            colCritStock = new DataGridViewTextBoxColumn();
            colCritMin = new DataGridViewTextBoxColumn();
            colCritEstado = new DataGridViewTextBoxColumn();
            timerDestacado = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvUltimas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCritico).BeginInit();
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
            lblTitulo.Text = "Resumen de sucursal";
            // lblSubtitulo
            lblSubtitulo.AutoSize = false;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.DimGray;
            lblSubtitulo.Location = new Point(330, 28);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(470, 20);
            lblSubtitulo.TextAlign = ContentAlignment.MiddleRight;
            lblSubtitulo.Text = "";
            // btnActualizar
            btnActualizar.BackColor = Color.DarkOliveGreen;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI Semibold", 9.75F);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(822, 22);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(125, 32);
            btnActualizar.TabIndex = 0;
            btnActualizar.Text = "⟳ Actualizar";
            // pnlKpi1
            pnlKpi1.Controls.AddRange(new Control[] { lblKpi1Titulo, lblKpi1Valor, lblKpi1Sub });
            pnlKpi1.BackColor = Color.White;
            pnlKpi1.Location = new Point(13, 66);
            pnlKpi1.Name = "pnlKpi1";
            pnlKpi1.Size = new Size(223, 78);
            // lblKpi1Titulo
            lblKpi1Titulo.AutoSize = true;
            lblKpi1Titulo.Font = new Font("Segoe UI Semibold", 9F);
            lblKpi1Titulo.ForeColor = Color.DimGray;
            lblKpi1Titulo.Location = new Point(12, 10);
            lblKpi1Titulo.Name = "lblKpi1Titulo";
            lblKpi1Titulo.Text = "Ventas de hoy";
            // lblKpi1Valor
            lblKpi1Valor.AutoSize = true;
            lblKpi1Valor.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold);
            lblKpi1Valor.ForeColor = Color.DarkOliveGreen;
            lblKpi1Valor.Location = new Point(12, 29);
            lblKpi1Valor.Name = "lblKpi1Valor";
            lblKpi1Valor.Text = "S/ 0.00";
            // lblKpi1Sub
            lblKpi1Sub.AutoSize = true;
            lblKpi1Sub.Font = new Font("Segoe UI", 9F);
            lblKpi1Sub.ForeColor = Color.DimGray;
            lblKpi1Sub.Location = new Point(12, 57);
            lblKpi1Sub.Name = "lblKpi1Sub";
            lblKpi1Sub.Text = "";
            // pnlKpi2
            pnlKpi2.Controls.AddRange(new Control[] { lblKpi2Titulo, lblKpi2Valor, lblKpi2Sub });
            pnlKpi2.BackColor = Color.White;
            pnlKpi2.Location = new Point(250, 66);
            pnlKpi2.Name = "pnlKpi2";
            pnlKpi2.Size = new Size(223, 78);
            // lblKpi2Titulo
            lblKpi2Titulo.AutoSize = true;
            lblKpi2Titulo.Font = new Font("Segoe UI Semibold", 9F);
            lblKpi2Titulo.ForeColor = Color.DimGray;
            lblKpi2Titulo.Location = new Point(12, 10);
            lblKpi2Titulo.Name = "lblKpi2Titulo";
            lblKpi2Titulo.Text = "Ventas del mes";
            // lblKpi2Valor
            lblKpi2Valor.AutoSize = true;
            lblKpi2Valor.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold);
            lblKpi2Valor.ForeColor = Color.DarkOliveGreen;
            lblKpi2Valor.Location = new Point(12, 29);
            lblKpi2Valor.Name = "lblKpi2Valor";
            lblKpi2Valor.Text = "S/ 0.00";
            // lblKpi2Sub
            lblKpi2Sub.AutoSize = true;
            lblKpi2Sub.Font = new Font("Segoe UI", 9F);
            lblKpi2Sub.ForeColor = Color.DimGray;
            lblKpi2Sub.Location = new Point(12, 57);
            lblKpi2Sub.Name = "lblKpi2Sub";
            lblKpi2Sub.Text = "";
            // pnlKpi3
            pnlKpi3.Controls.AddRange(new Control[] { lblKpi3Titulo, lblKpi3Valor, lblKpi3Sub });
            pnlKpi3.BackColor = Color.White;
            pnlKpi3.Location = new Point(487, 66);
            pnlKpi3.Name = "pnlKpi3";
            pnlKpi3.Size = new Size(223, 78);
            // lblKpi3Titulo
            lblKpi3Titulo.AutoSize = true;
            lblKpi3Titulo.Font = new Font("Segoe UI Semibold", 9F);
            lblKpi3Titulo.ForeColor = Color.DimGray;
            lblKpi3Titulo.Location = new Point(12, 10);
            lblKpi3Titulo.Name = "lblKpi3Titulo";
            lblKpi3Titulo.Text = "Compras del mes";
            // lblKpi3Valor
            lblKpi3Valor.AutoSize = true;
            lblKpi3Valor.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold);
            lblKpi3Valor.ForeColor = Color.DarkOliveGreen;
            lblKpi3Valor.Location = new Point(12, 29);
            lblKpi3Valor.Name = "lblKpi3Valor";
            lblKpi3Valor.Text = "S/ 0.00";
            // lblKpi3Sub
            lblKpi3Sub.AutoSize = true;
            lblKpi3Sub.Font = new Font("Segoe UI", 9F);
            lblKpi3Sub.ForeColor = Color.DimGray;
            lblKpi3Sub.Location = new Point(12, 57);
            lblKpi3Sub.Name = "lblKpi3Sub";
            lblKpi3Sub.Text = "";
            // pnlKpi4
            pnlKpi4.Controls.AddRange(new Control[] { lblKpi4Titulo, lblKpi4Valor, lblKpi4Sub });
            pnlKpi4.BackColor = Color.White;
            pnlKpi4.Location = new Point(724, 66);
            pnlKpi4.Name = "pnlKpi4";
            pnlKpi4.Size = new Size(223, 78);
            // lblKpi4Titulo
            lblKpi4Titulo.AutoSize = true;
            lblKpi4Titulo.Font = new Font("Segoe UI Semibold", 9F);
            lblKpi4Titulo.ForeColor = Color.DimGray;
            lblKpi4Titulo.Location = new Point(12, 10);
            lblKpi4Titulo.Name = "lblKpi4Titulo";
            lblKpi4Titulo.Text = "Gastos del mes";
            // lblKpi4Valor
            lblKpi4Valor.AutoSize = true;
            lblKpi4Valor.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold);
            lblKpi4Valor.ForeColor = Color.DarkOliveGreen;
            lblKpi4Valor.Location = new Point(12, 29);
            lblKpi4Valor.Name = "lblKpi4Valor";
            lblKpi4Valor.Text = "S/ 0.00";
            // lblKpi4Sub
            lblKpi4Sub.AutoSize = true;
            lblKpi4Sub.Font = new Font("Segoe UI", 9F);
            lblKpi4Sub.ForeColor = Color.DimGray;
            lblKpi4Sub.Location = new Point(12, 57);
            lblKpi4Sub.Name = "lblKpi4Sub";
            lblKpi4Sub.Text = "";
            // pnlUltimas
            pnlUltimas.Controls.AddRange(new Control[] { lblUltimasTitulo, dgvUltimas });
            pnlUltimas.BackColor = Color.White;
            pnlUltimas.Location = new Point(13, 156);
            pnlUltimas.Name = "pnlUltimas";
            pnlUltimas.Size = new Size(540, 330);
            // lblUltimasTitulo
            lblUltimasTitulo.AutoSize = true;
            lblUltimasTitulo.Font = new Font("Segoe UI Semibold", 11.25F);
            lblUltimasTitulo.ForeColor = Color.DarkSlateGray;
            lblUltimasTitulo.Location = new Point(12, 8);
            lblUltimasTitulo.Name = "lblUltimasTitulo";
            lblUltimasTitulo.Text = "Últimas ventas";
            // dgvUltimas
            dgvUltimas.AllowUserToAddRows = false;
            dgvUltimas.AllowUserToDeleteRows = false;
            dgvUltimas.AlternatingRowsDefaultCellStyle = estAlt;
            dgvUltimas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUltimas.BackgroundColor = Color.White;
            dgvUltimas.BorderStyle = BorderStyle.None;
            dgvUltimas.ColumnHeadersDefaultCellStyle = estCab;
            dgvUltimas.ColumnHeadersHeight = 32;
            dgvUltimas.DefaultCellStyle = estDef;
            dgvUltimas.EnableHeadersVisualStyles = false;
            dgvUltimas.Location = new Point(0, 36);
            dgvUltimas.MultiSelect = false;
            dgvUltimas.Name = "dgvUltimas";
            dgvUltimas.ReadOnly = true;
            dgvUltimas.RowHeadersVisible = false;
            dgvUltimas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUltimas.Size = new Size(540, 294);
            dgvUltimas.TabIndex = 1;
            dgvUltimas.Columns.AddRange(new DataGridViewColumn[] { colUltCodigo, colUltFecha, colUltCajero, colUltEstado, colUltTotal });
            colUltCodigo.FillWeight = 30F;
            colUltCodigo.HeaderText = "Código";
            colUltCodigo.Name = "colUltCodigo";
            colUltFecha.FillWeight = 28F;
            colUltFecha.HeaderText = "Fecha";
            colUltFecha.Name = "colUltFecha";
            colUltCajero.FillWeight = 30F;
            colUltCajero.HeaderText = "Cajero";
            colUltCajero.Name = "colUltCajero";
            colUltEstado.FillWeight = 20F;
            colUltEstado.HeaderText = "Estado";
            colUltEstado.Name = "colUltEstado";
            colUltTotal.FillWeight = 22F;
            colUltTotal.HeaderText = "Total";
            colUltTotal.Name = "colUltTotal";
            colUltTotal.DefaultCellStyle = estMoney;
            // pnlCritico
            pnlCritico.Controls.AddRange(new Control[] { lblCriticoTitulo, dgvCritico });
            pnlCritico.BackColor = Color.White;
            pnlCritico.Location = new Point(567, 156);
            pnlCritico.Name = "pnlCritico";
            pnlCritico.Size = new Size(380, 330);
            // lblCriticoTitulo
            lblCriticoTitulo.AutoSize = true;
            lblCriticoTitulo.Font = new Font("Segoe UI Semibold", 11.25F);
            lblCriticoTitulo.ForeColor = Color.DarkSlateGray;
            lblCriticoTitulo.Location = new Point(12, 8);
            lblCriticoTitulo.Name = "lblCriticoTitulo";
            lblCriticoTitulo.Text = "Stock crítico";
            // dgvCritico
            dgvCritico.AllowUserToAddRows = false;
            dgvCritico.AllowUserToDeleteRows = false;
            dgvCritico.AlternatingRowsDefaultCellStyle = estAlt;
            dgvCritico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCritico.BackgroundColor = Color.White;
            dgvCritico.BorderStyle = BorderStyle.None;
            dgvCritico.ColumnHeadersDefaultCellStyle = estCab;
            dgvCritico.ColumnHeadersHeight = 32;
            dgvCritico.DefaultCellStyle = estDef;
            dgvCritico.EnableHeadersVisualStyles = false;
            dgvCritico.Location = new Point(0, 36);
            dgvCritico.MultiSelect = false;
            dgvCritico.Name = "dgvCritico";
            dgvCritico.ReadOnly = true;
            dgvCritico.RowHeadersVisible = false;
            dgvCritico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCritico.Size = new Size(380, 294);
            dgvCritico.TabIndex = 2;
            dgvCritico.Columns.AddRange(new DataGridViewColumn[] { colCritProducto, colCritStock, colCritMin, colCritEstado });
            colCritProducto.FillWeight = 50F;
            colCritProducto.HeaderText = "Producto";
            colCritProducto.Name = "colCritProducto";
            colCritStock.FillWeight = 16F;
            colCritStock.HeaderText = "Stock";
            colCritStock.Name = "colCritStock";
            colCritStock.DefaultCellStyle = estQty;
            colCritMin.FillWeight = 16F;
            colCritMin.HeaderText = "Mín.";
            colCritMin.Name = "colCritMin";
            colCritMin.DefaultCellStyle = estQty;
            colCritEstado.FillWeight = 22F;
            colCritEstado.HeaderText = "Estado";
            colCritEstado.Name = "colCritEstado";
            // pnlDestacado
            pnlDestacado.Controls.AddRange(new Control[] { lblDestacadoTitulo, lblDestacadoTexto, lblDestacadoPos, btnSiguiente });
            pnlDestacado.BackColor = Color.White;
            pnlDestacado.Location = new Point(13, 498);
            pnlDestacado.Name = "pnlDestacado";
            pnlDestacado.Size = new Size(934, 98);
            // lblDestacadoTitulo
            lblDestacadoTitulo.AutoSize = true;
            lblDestacadoTitulo.Font = new Font("Segoe UI", 9F);
            lblDestacadoTitulo.ForeColor = Color.DarkOliveGreen;
            lblDestacadoTitulo.Location = new Point(16, 12);
            lblDestacadoTitulo.Name = "lblDestacadoTitulo";
            lblDestacadoTitulo.Text = "DATO DESTACADO";
            // lblDestacadoTexto
            lblDestacadoTexto.AutoSize = false;
            lblDestacadoTexto.Font = new Font("Segoe UI Semibold", 11.25F);
            lblDestacadoTexto.ForeColor = Color.DarkSlateGray;
            lblDestacadoTexto.Location = new Point(16, 36);
            lblDestacadoTexto.Name = "lblDestacadoTexto";
            lblDestacadoTexto.Size = new Size(760, 34);
            lblDestacadoTexto.TextAlign = ContentAlignment.MiddleLeft;
            lblDestacadoTexto.Text = "";
            // lblDestacadoPos
            lblDestacadoPos.AutoSize = true;
            lblDestacadoPos.Font = new Font("Segoe UI", 9F);
            lblDestacadoPos.ForeColor = Color.DimGray;
            lblDestacadoPos.Location = new Point(16, 74);
            lblDestacadoPos.Name = "lblDestacadoPos";
            lblDestacadoPos.Text = "";
            // btnSiguiente
            btnSiguiente.BackColor = Color.DarkOliveGreen;
            btnSiguiente.Cursor = Cursors.Hand;
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Segoe UI Semibold", 9.75F);
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Location = new Point(790, 30);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(125, 34);
            btnSiguiente.TabIndex = 3;
            btnSiguiente.Text = "Siguiente ▶";
            // timerDestacado
            timerDestacado.Interval = 5000;
            // UC_Resumen
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.AddRange(new Control[] { lblTitulo, lblSubtitulo, btnActualizar, pnlKpi1, pnlKpi2, pnlKpi3, pnlKpi4, pnlUltimas, pnlCritico, pnlDestacado });
            Name = "UC_Resumen";
            Size = new Size(960, 610);
            ((System.ComponentModel.ISupportInitialize)dgvUltimas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCritico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnActualizar;
        private Panel pnlKpi1;
        private Label lblKpi1Titulo;
        private Label lblKpi1Valor;
        private Label lblKpi1Sub;
        private Panel pnlKpi2;
        private Label lblKpi2Titulo;
        private Label lblKpi2Valor;
        private Label lblKpi2Sub;
        private Panel pnlKpi3;
        private Label lblKpi3Titulo;
        private Label lblKpi3Valor;
        private Label lblKpi3Sub;
        private Panel pnlKpi4;
        private Label lblKpi4Titulo;
        private Label lblKpi4Valor;
        private Label lblKpi4Sub;
        private Panel pnlUltimas;
        private Label lblUltimasTitulo;
        private DataGridView dgvUltimas;
        private Panel pnlCritico;
        private Label lblCriticoTitulo;
        private DataGridView dgvCritico;
        private Panel pnlDestacado;
        private Label lblDestacadoTitulo;
        private Label lblDestacadoTexto;
        private Label lblDestacadoPos;
        private Button btnSiguiente;
        private DataGridViewTextBoxColumn colUltCodigo;
        private DataGridViewTextBoxColumn colUltFecha;
        private DataGridViewTextBoxColumn colUltCajero;
        private DataGridViewTextBoxColumn colUltEstado;
        private DataGridViewTextBoxColumn colUltTotal;
        private DataGridViewTextBoxColumn colCritProducto;
        private DataGridViewTextBoxColumn colCritStock;
        private DataGridViewTextBoxColumn colCritMin;
        private DataGridViewTextBoxColumn colCritEstado;
        private System.Windows.Forms.Timer timerDestacado;
    }
}
