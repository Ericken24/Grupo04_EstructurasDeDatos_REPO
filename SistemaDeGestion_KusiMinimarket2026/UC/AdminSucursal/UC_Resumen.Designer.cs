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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            colUltCodigo = new DataGridViewTextBoxColumn();
            colUltFecha = new DataGridViewTextBoxColumn();
            colUltCajero = new DataGridViewTextBoxColumn();
            colUltEstado = new DataGridViewTextBoxColumn();
            colUltTotal = new DataGridViewTextBoxColumn();
            pnlCritico = new Panel();
            lblCriticoTitulo = new Label();
            dgvCritico = new DataGridView();
            colCritProducto = new DataGridViewTextBoxColumn();
            colCritStock = new DataGridViewTextBoxColumn();
            colCritMin = new DataGridViewTextBoxColumn();
            colCritEstado = new DataGridViewTextBoxColumn();
            pnlDestacado = new Panel();
            lblDestacadoTitulo = new Label();
            lblDestacadoTexto = new Label();
            lblDestacadoPos = new Label();
            btnSiguiente = new Button();
            timerDestacado = new System.Windows.Forms.Timer(components);
            pnlKpi1.SuspendLayout();
            pnlKpi2.SuspendLayout();
            pnlKpi3.SuspendLayout();
            pnlKpi4.SuspendLayout();
            pnlUltimas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUltimas).BeginInit();
            pnlCritico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCritico).BeginInit();
            pnlDestacado.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(15, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(365, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Resumen de sucursal";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.DimGray;
            lblSubtitulo.Location = new Point(377, 37);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(537, 27);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkOliveGreen;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI Semibold", 9.75F);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(939, 29);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(143, 43);
            btnActualizar.TabIndex = 0;
            btnActualizar.Text = "⟳ Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // pnlKpi1
            // 
            pnlKpi1.BackColor = Color.White;
            pnlKpi1.Controls.Add(lblKpi1Titulo);
            pnlKpi1.Controls.Add(lblKpi1Valor);
            pnlKpi1.Controls.Add(lblKpi1Sub);
            pnlKpi1.Location = new Point(15, 88);
            pnlKpi1.Margin = new Padding(3, 4, 3, 4);
            pnlKpi1.Name = "pnlKpi1";
            pnlKpi1.Size = new Size(255, 104);
            pnlKpi1.TabIndex = 2;
            // 
            // lblKpi1Titulo
            // 
            lblKpi1Titulo.AutoSize = true;
            lblKpi1Titulo.Font = new Font("Segoe UI Semibold", 9F);
            lblKpi1Titulo.ForeColor = Color.DimGray;
            lblKpi1Titulo.Location = new Point(14, 13);
            lblKpi1Titulo.Name = "lblKpi1Titulo";
            lblKpi1Titulo.Size = new Size(105, 20);
            lblKpi1Titulo.TabIndex = 0;
            lblKpi1Titulo.Text = "Ventas de hoy";
            // 
            // lblKpi1Valor
            // 
            lblKpi1Valor.AutoSize = true;
            lblKpi1Valor.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold);
            lblKpi1Valor.ForeColor = Color.DarkOliveGreen;
            lblKpi1Valor.Location = new Point(14, 39);
            lblKpi1Valor.Name = "lblKpi1Valor";
            lblKpi1Valor.Size = new Size(110, 37);
            lblKpi1Valor.TabIndex = 1;
            lblKpi1Valor.Text = "S/ 0.00";
            // 
            // lblKpi1Sub
            // 
            lblKpi1Sub.AutoSize = true;
            lblKpi1Sub.Font = new Font("Segoe UI", 9F);
            lblKpi1Sub.ForeColor = Color.DimGray;
            lblKpi1Sub.Location = new Point(14, 76);
            lblKpi1Sub.Name = "lblKpi1Sub";
            lblKpi1Sub.Size = new Size(0, 20);
            lblKpi1Sub.TabIndex = 2;
            // 
            // pnlKpi2
            // 
            pnlKpi2.BackColor = Color.White;
            pnlKpi2.Controls.Add(lblKpi2Titulo);
            pnlKpi2.Controls.Add(lblKpi2Valor);
            pnlKpi2.Controls.Add(lblKpi2Sub);
            pnlKpi2.Location = new Point(286, 88);
            pnlKpi2.Margin = new Padding(3, 4, 3, 4);
            pnlKpi2.Name = "pnlKpi2";
            pnlKpi2.Size = new Size(255, 104);
            pnlKpi2.TabIndex = 3;
            // 
            // lblKpi2Titulo
            // 
            lblKpi2Titulo.AutoSize = true;
            lblKpi2Titulo.Font = new Font("Segoe UI Semibold", 9F);
            lblKpi2Titulo.ForeColor = Color.DimGray;
            lblKpi2Titulo.Location = new Point(14, 13);
            lblKpi2Titulo.Name = "lblKpi2Titulo";
            lblKpi2Titulo.Size = new Size(110, 20);
            lblKpi2Titulo.TabIndex = 0;
            lblKpi2Titulo.Text = "Ventas del mes";
            // 
            // lblKpi2Valor
            // 
            lblKpi2Valor.AutoSize = true;
            lblKpi2Valor.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold);
            lblKpi2Valor.ForeColor = Color.DarkOliveGreen;
            lblKpi2Valor.Location = new Point(14, 39);
            lblKpi2Valor.Name = "lblKpi2Valor";
            lblKpi2Valor.Size = new Size(110, 37);
            lblKpi2Valor.TabIndex = 1;
            lblKpi2Valor.Text = "S/ 0.00";
            // 
            // lblKpi2Sub
            // 
            lblKpi2Sub.AutoSize = true;
            lblKpi2Sub.Font = new Font("Segoe UI", 9F);
            lblKpi2Sub.ForeColor = Color.DimGray;
            lblKpi2Sub.Location = new Point(14, 76);
            lblKpi2Sub.Name = "lblKpi2Sub";
            lblKpi2Sub.Size = new Size(0, 20);
            lblKpi2Sub.TabIndex = 2;
            // 
            // pnlKpi3
            // 
            pnlKpi3.BackColor = Color.White;
            pnlKpi3.Controls.Add(lblKpi3Titulo);
            pnlKpi3.Controls.Add(lblKpi3Valor);
            pnlKpi3.Controls.Add(lblKpi3Sub);
            pnlKpi3.Location = new Point(557, 88);
            pnlKpi3.Margin = new Padding(3, 4, 3, 4);
            pnlKpi3.Name = "pnlKpi3";
            pnlKpi3.Size = new Size(255, 104);
            pnlKpi3.TabIndex = 4;
            // 
            // lblKpi3Titulo
            // 
            lblKpi3Titulo.AutoSize = true;
            lblKpi3Titulo.Font = new Font("Segoe UI Semibold", 9F);
            lblKpi3Titulo.ForeColor = Color.DimGray;
            lblKpi3Titulo.Location = new Point(14, 13);
            lblKpi3Titulo.Name = "lblKpi3Titulo";
            lblKpi3Titulo.Size = new Size(125, 20);
            lblKpi3Titulo.TabIndex = 0;
            lblKpi3Titulo.Text = "Compras del mes";
            // 
            // lblKpi3Valor
            // 
            lblKpi3Valor.AutoSize = true;
            lblKpi3Valor.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold);
            lblKpi3Valor.ForeColor = Color.DarkOliveGreen;
            lblKpi3Valor.Location = new Point(14, 39);
            lblKpi3Valor.Name = "lblKpi3Valor";
            lblKpi3Valor.Size = new Size(110, 37);
            lblKpi3Valor.TabIndex = 1;
            lblKpi3Valor.Text = "S/ 0.00";
            // 
            // lblKpi3Sub
            // 
            lblKpi3Sub.AutoSize = true;
            lblKpi3Sub.Font = new Font("Segoe UI", 9F);
            lblKpi3Sub.ForeColor = Color.DimGray;
            lblKpi3Sub.Location = new Point(14, 76);
            lblKpi3Sub.Name = "lblKpi3Sub";
            lblKpi3Sub.Size = new Size(0, 20);
            lblKpi3Sub.TabIndex = 2;
            // 
            // pnlKpi4
            // 
            pnlKpi4.BackColor = Color.White;
            pnlKpi4.Controls.Add(lblKpi4Titulo);
            pnlKpi4.Controls.Add(lblKpi4Valor);
            pnlKpi4.Controls.Add(lblKpi4Sub);
            pnlKpi4.Location = new Point(827, 88);
            pnlKpi4.Margin = new Padding(3, 4, 3, 4);
            pnlKpi4.Name = "pnlKpi4";
            pnlKpi4.Size = new Size(255, 104);
            pnlKpi4.TabIndex = 5;
            // 
            // lblKpi4Titulo
            // 
            lblKpi4Titulo.AutoSize = true;
            lblKpi4Titulo.Font = new Font("Segoe UI Semibold", 9F);
            lblKpi4Titulo.ForeColor = Color.DimGray;
            lblKpi4Titulo.Location = new Point(14, 13);
            lblKpi4Titulo.Name = "lblKpi4Titulo";
            lblKpi4Titulo.Size = new Size(109, 20);
            lblKpi4Titulo.TabIndex = 0;
            lblKpi4Titulo.Text = "Gastos del mes";
            // 
            // lblKpi4Valor
            // 
            lblKpi4Valor.AutoSize = true;
            lblKpi4Valor.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold);
            lblKpi4Valor.ForeColor = Color.DarkOliveGreen;
            lblKpi4Valor.Location = new Point(14, 39);
            lblKpi4Valor.Name = "lblKpi4Valor";
            lblKpi4Valor.Size = new Size(110, 37);
            lblKpi4Valor.TabIndex = 1;
            lblKpi4Valor.Text = "S/ 0.00";
            // 
            // lblKpi4Sub
            // 
            lblKpi4Sub.AutoSize = true;
            lblKpi4Sub.Font = new Font("Segoe UI", 9F);
            lblKpi4Sub.ForeColor = Color.DimGray;
            lblKpi4Sub.Location = new Point(14, 76);
            lblKpi4Sub.Name = "lblKpi4Sub";
            lblKpi4Sub.Size = new Size(0, 20);
            lblKpi4Sub.TabIndex = 2;
            // 
            // pnlUltimas
            // 
            pnlUltimas.BackColor = Color.White;
            pnlUltimas.Controls.Add(lblUltimasTitulo);
            pnlUltimas.Controls.Add(dgvUltimas);
            pnlUltimas.Location = new Point(15, 208);
            pnlUltimas.Margin = new Padding(3, 4, 3, 4);
            pnlUltimas.Name = "pnlUltimas";
            pnlUltimas.Size = new Size(617, 401);
            pnlUltimas.TabIndex = 6;
            // 
            // lblUltimasTitulo
            // 
            lblUltimasTitulo.AutoSize = true;
            lblUltimasTitulo.Font = new Font("Segoe UI Semibold", 11.25F);
            lblUltimasTitulo.ForeColor = Color.DarkSlateGray;
            lblUltimasTitulo.Location = new Point(14, 11);
            lblUltimasTitulo.Name = "lblUltimasTitulo";
            lblUltimasTitulo.Size = new Size(138, 25);
            lblUltimasTitulo.TabIndex = 0;
            lblUltimasTitulo.Text = "Últimas ventas";
            // 
            // dgvUltimas
            // 
            dgvUltimas.AllowUserToAddRows = false;
            dgvUltimas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgvUltimas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUltimas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUltimas.BackgroundColor = Color.White;
            dgvUltimas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvUltimas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUltimas.ColumnHeadersHeight = 32;
            dgvUltimas.Columns.AddRange(new DataGridViewColumn[] { colUltCodigo, colUltFecha, colUltCajero, colUltEstado, colUltTotal });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvUltimas.DefaultCellStyle = dataGridViewCellStyle4;
            dgvUltimas.EnableHeadersVisualStyles = false;
            dgvUltimas.Location = new Point(0, 48);
            dgvUltimas.Margin = new Padding(3, 4, 3, 4);
            dgvUltimas.MultiSelect = false;
            dgvUltimas.Name = "dgvUltimas";
            dgvUltimas.ReadOnly = true;
            dgvUltimas.RowHeadersVisible = false;
            dgvUltimas.RowHeadersWidth = 51;
            dgvUltimas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUltimas.Size = new Size(617, 353);
            dgvUltimas.TabIndex = 1;
            // 
            // colUltCodigo
            // 
            colUltCodigo.FillWeight = 30F;
            colUltCodigo.HeaderText = "Código";
            colUltCodigo.MinimumWidth = 6;
            colUltCodigo.Name = "colUltCodigo";
            colUltCodigo.ReadOnly = true;
            // 
            // colUltFecha
            // 
            colUltFecha.FillWeight = 28F;
            colUltFecha.HeaderText = "Fecha";
            colUltFecha.MinimumWidth = 6;
            colUltFecha.Name = "colUltFecha";
            colUltFecha.ReadOnly = true;
            // 
            // colUltCajero
            // 
            colUltCajero.FillWeight = 30F;
            colUltCajero.HeaderText = "Cajero";
            colUltCajero.MinimumWidth = 6;
            colUltCajero.Name = "colUltCajero";
            colUltCajero.ReadOnly = true;
            // 
            // colUltEstado
            // 
            colUltEstado.FillWeight = 20F;
            colUltEstado.HeaderText = "Estado";
            colUltEstado.MinimumWidth = 6;
            colUltEstado.Name = "colUltEstado";
            colUltEstado.ReadOnly = true;
            // 
            // colUltTotal
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            colUltTotal.DefaultCellStyle = dataGridViewCellStyle3;
            colUltTotal.FillWeight = 22F;
            colUltTotal.HeaderText = "Total";
            colUltTotal.MinimumWidth = 6;
            colUltTotal.Name = "colUltTotal";
            colUltTotal.ReadOnly = true;
            // 
            // pnlCritico
            // 
            pnlCritico.BackColor = Color.White;
            pnlCritico.Controls.Add(lblCriticoTitulo);
            pnlCritico.Controls.Add(dgvCritico);
            pnlCritico.Location = new Point(648, 208);
            pnlCritico.Margin = new Padding(3, 4, 3, 4);
            pnlCritico.Name = "pnlCritico";
            pnlCritico.Size = new Size(434, 401);
            pnlCritico.TabIndex = 7;
            // 
            // lblCriticoTitulo
            // 
            lblCriticoTitulo.AutoSize = true;
            lblCriticoTitulo.Font = new Font("Segoe UI Semibold", 11.25F);
            lblCriticoTitulo.ForeColor = Color.DarkSlateGray;
            lblCriticoTitulo.Location = new Point(14, 11);
            lblCriticoTitulo.Name = "lblCriticoTitulo";
            lblCriticoTitulo.Size = new Size(116, 25);
            lblCriticoTitulo.TabIndex = 0;
            lblCriticoTitulo.Text = "Stock crítico";
            // 
            // dgvCritico
            // 
            dgvCritico.AllowUserToAddRows = false;
            dgvCritico.AllowUserToDeleteRows = false;
            dgvCritico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCritico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCritico.BackgroundColor = Color.White;
            dgvCritico.BorderStyle = BorderStyle.None;
            dgvCritico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCritico.ColumnHeadersHeight = 32;
            dgvCritico.Columns.AddRange(new DataGridViewColumn[] { colCritProducto, colCritStock, colCritMin, colCritEstado });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvCritico.DefaultCellStyle = dataGridViewCellStyle6;
            dgvCritico.EnableHeadersVisualStyles = false;
            dgvCritico.Location = new Point(0, 48);
            dgvCritico.Margin = new Padding(3, 4, 3, 4);
            dgvCritico.MultiSelect = false;
            dgvCritico.Name = "dgvCritico";
            dgvCritico.ReadOnly = true;
            dgvCritico.RowHeadersVisible = false;
            dgvCritico.RowHeadersWidth = 51;
            dgvCritico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCritico.Size = new Size(434, 353);
            dgvCritico.TabIndex = 2;
            // 
            // colCritProducto
            // 
            colCritProducto.FillWeight = 50F;
            colCritProducto.HeaderText = "Producto";
            colCritProducto.MinimumWidth = 6;
            colCritProducto.Name = "colCritProducto";
            colCritProducto.ReadOnly = true;
            // 
            // colCritStock
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "0.##";
            colCritStock.DefaultCellStyle = dataGridViewCellStyle5;
            colCritStock.FillWeight = 16F;
            colCritStock.HeaderText = "Stock";
            colCritStock.MinimumWidth = 6;
            colCritStock.Name = "colCritStock";
            colCritStock.ReadOnly = true;
            // 
            // colCritMin
            // 
            colCritMin.DefaultCellStyle = dataGridViewCellStyle5;
            colCritMin.FillWeight = 16F;
            colCritMin.HeaderText = "Mín.";
            colCritMin.MinimumWidth = 6;
            colCritMin.Name = "colCritMin";
            colCritMin.ReadOnly = true;
            // 
            // colCritEstado
            // 
            colCritEstado.FillWeight = 22F;
            colCritEstado.HeaderText = "Estado";
            colCritEstado.MinimumWidth = 6;
            colCritEstado.Name = "colCritEstado";
            colCritEstado.ReadOnly = true;
            // 
            // pnlDestacado
            // 
            pnlDestacado.BackColor = Color.White;
            pnlDestacado.Controls.Add(lblDestacadoTitulo);
            pnlDestacado.Controls.Add(lblDestacadoTexto);
            pnlDestacado.Controls.Add(lblDestacadoPos);
            pnlDestacado.Controls.Add(btnSiguiente);
            pnlDestacado.Location = new Point(15, 628);
            pnlDestacado.Margin = new Padding(3, 4, 3, 4);
            pnlDestacado.Name = "pnlDestacado";
            pnlDestacado.Size = new Size(1067, 107);
            pnlDestacado.TabIndex = 8;
            // 
            // lblDestacadoTitulo
            // 
            lblDestacadoTitulo.AutoSize = true;
            lblDestacadoTitulo.Font = new Font("Segoe UI", 9F);
            lblDestacadoTitulo.ForeColor = Color.DarkOliveGreen;
            lblDestacadoTitulo.Location = new Point(18, 16);
            lblDestacadoTitulo.Name = "lblDestacadoTitulo";
            lblDestacadoTitulo.Size = new Size(136, 20);
            lblDestacadoTitulo.TabIndex = 0;
            lblDestacadoTitulo.Text = "DATO DESTACADO";
            // 
            // lblDestacadoTexto
            // 
            lblDestacadoTexto.Font = new Font("Segoe UI Semibold", 11.25F);
            lblDestacadoTexto.ForeColor = Color.DarkSlateGray;
            lblDestacadoTexto.Location = new Point(18, 48);
            lblDestacadoTexto.Name = "lblDestacadoTexto";
            lblDestacadoTexto.Size = new Size(869, 45);
            lblDestacadoTexto.TabIndex = 1;
            lblDestacadoTexto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDestacadoPos
            // 
            lblDestacadoPos.AutoSize = true;
            lblDestacadoPos.Font = new Font("Segoe UI", 9F);
            lblDestacadoPos.ForeColor = Color.DimGray;
            lblDestacadoPos.Location = new Point(18, 99);
            lblDestacadoPos.Name = "lblDestacadoPos";
            lblDestacadoPos.Size = new Size(0, 20);
            lblDestacadoPos.TabIndex = 2;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.DarkOliveGreen;
            btnSiguiente.Cursor = Cursors.Hand;
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Segoe UI Semibold", 9.75F);
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Location = new Point(903, 40);
            btnSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(143, 45);
            btnSiguiente.TabIndex = 3;
            btnSiguiente.Text = "Siguiente ▶";
            btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // timerDestacado
            // 
            timerDestacado.Interval = 5000;
            // 
            // UC_Resumen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(btnActualizar);
            Controls.Add(pnlKpi1);
            Controls.Add(pnlKpi2);
            Controls.Add(pnlKpi3);
            Controls.Add(pnlKpi4);
            Controls.Add(pnlUltimas);
            Controls.Add(pnlCritico);
            Controls.Add(pnlDestacado);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Resumen";
            Size = new Size(1097, 813);
            pnlKpi1.ResumeLayout(false);
            pnlKpi1.PerformLayout();
            pnlKpi2.ResumeLayout(false);
            pnlKpi2.PerformLayout();
            pnlKpi3.ResumeLayout(false);
            pnlKpi3.PerformLayout();
            pnlKpi4.ResumeLayout(false);
            pnlKpi4.PerformLayout();
            pnlUltimas.ResumeLayout(false);
            pnlUltimas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUltimas).EndInit();
            pnlCritico.ResumeLayout(false);
            pnlCritico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCritico).EndInit();
            pnlDestacado.ResumeLayout(false);
            pnlDestacado.PerformLayout();
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
