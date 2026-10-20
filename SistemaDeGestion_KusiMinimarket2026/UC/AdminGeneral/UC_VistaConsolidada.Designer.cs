namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminGeneral
{
    partial class UC_VistaConsolidada
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblVistaConsolidada = new Label();
            lblSubtitulo = new Label();
            btnActualizar = new Button();
            pnlKpiVentas = new Panel();
            lblKpiVentasTitulo = new Label();
            lblKpiVentas = new Label();
            pnlKpiCompras = new Panel();
            lblKpiComprasTitulo = new Label();
            lblKpiCompras = new Label();
            pnlKpiGastos = new Panel();
            lblKpiGastosTitulo = new Label();
            lblKpiGastos = new Label();
            pnlKpiUtilidad = new Panel();
            lblKpiUtilidadTitulo = new Label();
            lblKpiUtilidad = new Label();
            dgvSucursales = new DataGridView();
            colSucSucursal = new DataGridViewTextBoxColumn();
            colSucNumVentas = new DataGridViewTextBoxColumn();
            colSucVentas = new DataGridViewTextBoxColumn();
            colSucCompras = new DataGridViewTextBoxColumn();
            colSucGastos = new DataGridViewTextBoxColumn();
            colSucUtilidad = new DataGridViewTextBoxColumn();
            dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewCellStyle4 = new DataGridViewCellStyle();
            grpDestacado = new GroupBox();
            lblDestacado = new Label();
            lblPosicionDestacado = new Label();
            btnSiguienteDestacado = new Button();
            lblNota = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).BeginInit();
            pnlKpiVentas.SuspendLayout();
            pnlKpiCompras.SuspendLayout();
            pnlKpiGastos.SuspendLayout();
            pnlKpiUtilidad.SuspendLayout();
            grpDestacado.SuspendLayout();
            SuspendLayout();
            // 
            // lblVistaConsolidada
            // 
            lblVistaConsolidada.AutoSize = true;
            lblVistaConsolidada.BackColor = Color.Transparent;
            lblVistaConsolidada.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblVistaConsolidada.Location = new Point(13, 17);
            lblVistaConsolidada.Name = "lblVistaConsolidada";
            lblVistaConsolidada.Size = new Size(252, 37);
            lblVistaConsolidada.TabIndex = 0;
            lblVistaConsolidada.Text = "Vista consolidada";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.DarkSlateGray;
            lblSubtitulo.Location = new Point(20, 66);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(152, 17);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Todas las sucursales";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkOliveGreen;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(800, 20);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(140, 38);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "🔄 Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // pnlKpiVentas
            // 
            pnlKpiVentas.BackColor = Color.White;
            pnlKpiVentas.Location = new Point(20, 95);
            pnlKpiVentas.Name = "pnlKpiVentas";
            pnlKpiVentas.Size = new Size(215, 80);
            pnlKpiVentas.TabIndex = 3;
            // 
            // lblKpiVentasTitulo
            // 
            lblKpiVentasTitulo.AutoSize = true;
            lblKpiVentasTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiVentasTitulo.ForeColor = Color.DarkSlateGray;
            lblKpiVentasTitulo.Location = new Point(10, 10);
            lblKpiVentasTitulo.Name = "lblKpiVentasTitulo";
            lblKpiVentasTitulo.Size = new Size(107, 17);
            lblKpiVentasTitulo.TabIndex = 4;
            lblKpiVentasTitulo.Text = "Ventas pagadas";
            // 
            // lblKpiVentas
            // 
            lblKpiVentas.AutoSize = true;
            lblKpiVentas.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiVentas.ForeColor = Color.DarkOliveGreen;
            lblKpiVentas.Location = new Point(10, 34);
            lblKpiVentas.Name = "lblKpiVentas";
            lblKpiVentas.Size = new Size(123, 30);
            lblKpiVentas.TabIndex = 5;
            lblKpiVentas.Text = "S/ 0.00";
            // 
            // pnlKpiCompras
            // 
            pnlKpiCompras.BackColor = Color.White;
            pnlKpiCompras.Location = new Point(255, 95);
            pnlKpiCompras.Name = "pnlKpiCompras";
            pnlKpiCompras.Size = new Size(215, 80);
            pnlKpiCompras.TabIndex = 6;
            // 
            // lblKpiComprasTitulo
            // 
            lblKpiComprasTitulo.AutoSize = true;
            lblKpiComprasTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiComprasTitulo.ForeColor = Color.DarkSlateGray;
            lblKpiComprasTitulo.Location = new Point(10, 10);
            lblKpiComprasTitulo.Name = "lblKpiComprasTitulo";
            lblKpiComprasTitulo.Size = new Size(55, 17);
            lblKpiComprasTitulo.TabIndex = 7;
            lblKpiComprasTitulo.Text = "Compras";
            // 
            // lblKpiCompras
            // 
            lblKpiCompras.AutoSize = true;
            lblKpiCompras.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiCompras.ForeColor = Color.DarkOliveGreen;
            lblKpiCompras.Location = new Point(10, 34);
            lblKpiCompras.Name = "lblKpiCompras";
            lblKpiCompras.Size = new Size(123, 30);
            lblKpiCompras.TabIndex = 8;
            lblKpiCompras.Text = "S/ 0.00";
            // 
            // pnlKpiGastos
            // 
            pnlKpiGastos.BackColor = Color.White;
            pnlKpiGastos.Location = new Point(490, 95);
            pnlKpiGastos.Name = "pnlKpiGastos";
            pnlKpiGastos.Size = new Size(215, 80);
            pnlKpiGastos.TabIndex = 9;
            // 
            // lblKpiGastosTitulo
            // 
            lblKpiGastosTitulo.AutoSize = true;
            lblKpiGastosTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiGastosTitulo.ForeColor = Color.DarkSlateGray;
            lblKpiGastosTitulo.Location = new Point(10, 10);
            lblKpiGastosTitulo.Name = "lblKpiGastosTitulo";
            lblKpiGastosTitulo.Size = new Size(48, 17);
            lblKpiGastosTitulo.TabIndex = 10;
            lblKpiGastosTitulo.Text = "Gastos";
            // 
            // lblKpiGastos
            // 
            lblKpiGastos.AutoSize = true;
            lblKpiGastos.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiGastos.ForeColor = Color.DarkOliveGreen;
            lblKpiGastos.Location = new Point(10, 34);
            lblKpiGastos.Name = "lblKpiGastos";
            lblKpiGastos.Size = new Size(123, 30);
            lblKpiGastos.TabIndex = 11;
            lblKpiGastos.Text = "S/ 0.00";
            // 
            // pnlKpiUtilidad
            // 
            pnlKpiUtilidad.BackColor = Color.White;
            pnlKpiUtilidad.Location = new Point(725, 95);
            pnlKpiUtilidad.Name = "pnlKpiUtilidad";
            pnlKpiUtilidad.Size = new Size(215, 80);
            pnlKpiUtilidad.TabIndex = 12;
            // 
            // lblKpiUtilidadTitulo
            // 
            lblKpiUtilidadTitulo.AutoSize = true;
            lblKpiUtilidadTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiUtilidadTitulo.ForeColor = Color.DarkSlateGray;
            lblKpiUtilidadTitulo.Location = new Point(10, 10);
            lblKpiUtilidadTitulo.Name = "lblKpiUtilidadTitulo";
            lblKpiUtilidadTitulo.Size = new Size(129, 17);
            lblKpiUtilidadTitulo.TabIndex = 13;
            lblKpiUtilidadTitulo.Text = "Utilidad estimada";
            // 
            // lblKpiUtilidad
            // 
            lblKpiUtilidad.AutoSize = true;
            lblKpiUtilidad.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiUtilidad.ForeColor = Color.DarkOliveGreen;
            lblKpiUtilidad.Location = new Point(10, 34);
            lblKpiUtilidad.Name = "lblKpiUtilidad";
            lblKpiUtilidad.Size = new Size(123, 30);
            lblKpiUtilidad.TabIndex = 14;
            lblKpiUtilidad.Text = "S/ 0.00";
            // 
            // dgvSucursales
            // 
            dgvSucursales.AllowUserToAddRows = false;
            dgvSucursales.AllowUserToDeleteRows = false;
            dgvSucursales.AllowUserToResizeRows = false;
            dgvSucursales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvSucursales.BackgroundColor = Color.White;
            dgvSucursales.BorderStyle = BorderStyle.None;
            dgvSucursales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSucursales.ColumnHeadersHeight = 30;
            dgvSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSucursales.Columns.AddRange(new DataGridViewColumn[] { colSucSucursal, colSucNumVentas, colSucVentas, colSucCompras, colSucGastos, colSucUtilidad });
            dgvSucursales.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSucursales.EnableHeadersVisualStyles = false;
            dgvSucursales.GridColor = Color.Gainsboro;
            dgvSucursales.Location = new Point(20, 195);
            dgvSucursales.MultiSelect = false;
            dgvSucursales.Name = "dgvSucursales";
            dgvSucursales.ReadOnly = true;
            dgvSucursales.RowHeadersVisible = false;
            dgvSucursales.RowTemplate.Height = 25;
            dgvSucursales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSucursales.Size = new Size(640, 310);
            dgvSucursales.TabIndex = 15;
            // 
            // colSucSucursal
            // 
            colSucSucursal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSucSucursal.MinimumWidth = 120;
            colSucSucursal.HeaderText = "Sucursal";
            colSucSucursal.Name = "colSucSucursal";
            colSucSucursal.ReadOnly = true;
            // 
            // colSucNumVentas
            // 
            colSucNumVentas.DefaultCellStyle = dataGridViewCellStyle4;
            colSucNumVentas.HeaderText = "N.º ventas";
            colSucNumVentas.Name = "colSucNumVentas";
            colSucNumVentas.ReadOnly = true;
            colSucNumVentas.Width = 75;
            // 
            // colSucVentas
            // 
            colSucVentas.DefaultCellStyle = dataGridViewCellStyle4;
            colSucVentas.HeaderText = "Ventas S/";
            colSucVentas.Name = "colSucVentas";
            colSucVentas.ReadOnly = true;
            colSucVentas.Width = 95;
            // 
            // colSucCompras
            // 
            colSucCompras.DefaultCellStyle = dataGridViewCellStyle4;
            colSucCompras.HeaderText = "Compras S/";
            colSucCompras.Name = "colSucCompras";
            colSucCompras.ReadOnly = true;
            colSucCompras.Width = 95;
            // 
            // colSucGastos
            // 
            colSucGastos.DefaultCellStyle = dataGridViewCellStyle4;
            colSucGastos.HeaderText = "Gastos S/";
            colSucGastos.Name = "colSucGastos";
            colSucGastos.ReadOnly = true;
            colSucGastos.Width = 95;
            // 
            // colSucUtilidad
            // 
            colSucUtilidad.DefaultCellStyle = dataGridViewCellStyle4;
            colSucUtilidad.HeaderText = "Utilidad S/";
            colSucUtilidad.Name = "colSucUtilidad";
            colSucUtilidad.ReadOnly = true;
            colSucUtilidad.Width = 95;
            // 
            // dataGridViewCellStyle1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            // 
            // dataGridViewCellStyle2
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            // 
            // dataGridViewCellStyle3
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Honeydew;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            // 
            // dataGridViewCellStyle4
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            // 
            // grpDestacado
            // 
            grpDestacado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDestacado.ForeColor = Color.DarkOliveGreen;
            grpDestacado.Location = new Point(680, 195);
            grpDestacado.Name = "grpDestacado";
            grpDestacado.Size = new Size(260, 310);
            grpDestacado.TabIndex = 16;
            grpDestacado.TabStop = false;
            grpDestacado.Text = "Datos destacados";
            // 
            // lblDestacado
            // 
            lblDestacado.AutoSize = false;
            lblDestacado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDestacado.ForeColor = Color.Black;
            lblDestacado.Location = new Point(12, 32);
            lblDestacado.Name = "lblDestacado";
            lblDestacado.Size = new Size(236, 170);
            lblDestacado.TabIndex = 17;
            lblDestacado.Text = "Sin datos para mostrar.";
            // 
            // lblPosicionDestacado
            // 
            lblPosicionDestacado.AutoSize = true;
            lblPosicionDestacado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPosicionDestacado.ForeColor = Color.DarkSlateGray;
            lblPosicionDestacado.Location = new Point(12, 215);
            lblPosicionDestacado.Name = "lblPosicionDestacado";
            lblPosicionDestacado.Size = new Size(4, 17);
            lblPosicionDestacado.TabIndex = 18;
            lblPosicionDestacado.Text = "";
            // 
            // btnSiguienteDestacado
            // 
            btnSiguienteDestacado.BackColor = Color.DarkOliveGreen;
            btnSiguienteDestacado.Cursor = Cursors.Hand;
            btnSiguienteDestacado.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguienteDestacado.ForeColor = Color.White;
            btnSiguienteDestacado.Location = new Point(12, 255);
            btnSiguienteDestacado.Name = "btnSiguienteDestacado";
            btnSiguienteDestacado.Size = new Size(236, 38);
            btnSiguienteDestacado.TabIndex = 19;
            btnSiguienteDestacado.Text = "Siguiente ▶";
            btnSiguienteDestacado.UseVisualStyleBackColor = false;
            btnSiguienteDestacado.Click += btnSiguienteDestacado_Click;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNota.ForeColor = Color.Black;
            lblNota.Location = new Point(20, 521);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(535, 17);
            lblNota.TabIndex = 20;
            lblNota.Text = "Utilidad estimada = ventas pagadas − compras − gastos (solo tiendas activas).";
            pnlKpiVentas.Controls.Add(lblKpiVentasTitulo);
            pnlKpiVentas.Controls.Add(lblKpiVentas);
            pnlKpiCompras.Controls.Add(lblKpiComprasTitulo);
            pnlKpiCompras.Controls.Add(lblKpiCompras);
            pnlKpiGastos.Controls.Add(lblKpiGastosTitulo);
            pnlKpiGastos.Controls.Add(lblKpiGastos);
            pnlKpiUtilidad.Controls.Add(lblKpiUtilidadTitulo);
            pnlKpiUtilidad.Controls.Add(lblKpiUtilidad);
            grpDestacado.Controls.Add(lblDestacado);
            grpDestacado.Controls.Add(lblPosicionDestacado);
            grpDestacado.Controls.Add(btnSiguienteDestacado);
            // 
            // UC_VistaConsolidada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblVistaConsolidada);
            Controls.Add(lblSubtitulo);
            Controls.Add(btnActualizar);
            Controls.Add(pnlKpiVentas);
            Controls.Add(pnlKpiCompras);
            Controls.Add(pnlKpiGastos);
            Controls.Add(pnlKpiUtilidad);
            Controls.Add(dgvSucursales);
            Controls.Add(grpDestacado);
            Controls.Add(lblNota);
            Name = "UC_VistaConsolidada";
            Size = new Size(960, 610);
            Load += UC_VistaConsolidada_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).EndInit();
            pnlKpiVentas.ResumeLayout(false);
            pnlKpiVentas.PerformLayout();
            pnlKpiCompras.ResumeLayout(false);
            pnlKpiCompras.PerformLayout();
            pnlKpiGastos.ResumeLayout(false);
            pnlKpiGastos.PerformLayout();
            pnlKpiUtilidad.ResumeLayout(false);
            pnlKpiUtilidad.PerformLayout();
            grpDestacado.ResumeLayout(false);
            grpDestacado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVistaConsolidada;
        private Label lblSubtitulo;
        private Button btnActualizar;
        private Panel pnlKpiVentas;
        private Label lblKpiVentasTitulo;
        private Label lblKpiVentas;
        private Panel pnlKpiCompras;
        private Label lblKpiComprasTitulo;
        private Label lblKpiCompras;
        private Panel pnlKpiGastos;
        private Label lblKpiGastosTitulo;
        private Label lblKpiGastos;
        private Panel pnlKpiUtilidad;
        private Label lblKpiUtilidadTitulo;
        private Label lblKpiUtilidad;
        private DataGridView dgvSucursales;
        private DataGridViewTextBoxColumn colSucSucursal;
        private DataGridViewTextBoxColumn colSucNumVentas;
        private DataGridViewTextBoxColumn colSucVentas;
        private DataGridViewTextBoxColumn colSucCompras;
        private DataGridViewTextBoxColumn colSucGastos;
        private DataGridViewTextBoxColumn colSucUtilidad;
        private DataGridViewCellStyle dataGridViewCellStyle1;
        private DataGridViewCellStyle dataGridViewCellStyle2;
        private DataGridViewCellStyle dataGridViewCellStyle3;
        private DataGridViewCellStyle dataGridViewCellStyle4;
        private GroupBox grpDestacado;
        private Label lblDestacado;
        private Label lblPosicionDestacado;
        private Button btnSiguienteDestacado;
        private Label lblNota;
    }
}
