namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminGeneral
{
    partial class UC_InventarioGlobal
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
            lblInventarioGlobal = new Label();
            lblSucursal = new Label();
            cboSucursal = new ComboBox();
            lblCategoria = new Label();
            cboCategoria = new ComboBox();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            chkSoloCriticos = new CheckBox();
            dgvInventario = new DataGridView();
            colInvSucursal = new DataGridViewTextBoxColumn();
            colInvSku = new DataGridViewTextBoxColumn();
            colInvProducto = new DataGridViewTextBoxColumn();
            colInvCategoria = new DataGridViewTextBoxColumn();
            colInvStock = new DataGridViewTextBoxColumn();
            colInvMinimo = new DataGridViewTextBoxColumn();
            colInvEstado = new DataGridViewTextBoxColumn();
            colInvValor = new DataGridViewTextBoxColumn();
            dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblResumen = new Label();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // lblInventarioGlobal
            // 
            lblInventarioGlobal.AutoSize = true;
            lblInventarioGlobal.BackColor = Color.Transparent;
            lblInventarioGlobal.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblInventarioGlobal.Location = new Point(13, 17);
            lblInventarioGlobal.Name = "lblInventarioGlobal";
            lblInventarioGlobal.Size = new Size(252, 37);
            lblInventarioGlobal.TabIndex = 0;
            lblInventarioGlobal.Text = "Inventario global";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucursal.ForeColor = Color.DarkSlateGray;
            lblSucursal.Location = new Point(20, 78);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(70, 17);
            lblSucursal.TabIndex = 1;
            lblSucursal.Text = "Sucursal:";
            // 
            // cboSucursal
            // 
            cboSucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSucursal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSucursal.ForeColor = Color.Black;
            cboSucursal.FormattingEnabled = true;
            cboSucursal.Location = new Point(95, 74);
            cboSucursal.Name = "cboSucursal";
            cboSucursal.Size = new Size(170, 25);
            cboSucursal.TabIndex = 2;
            cboSucursal.SelectedIndexChanged += FiltroCambiado;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.ForeColor = Color.DarkSlateGray;
            lblCategoria.Location = new Point(285, 78);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(78, 17);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Categoría:";
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCategoria.ForeColor = Color.Black;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(365, 74);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(170, 25);
            cboCategoria.TabIndex = 4;
            cboCategoria.SelectedIndexChanged += FiltroCambiado;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.ForeColor = Color.DarkSlateGray;
            lblBuscar.Location = new Point(555, 78);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(70, 17);
            lblBuscar.TabIndex = 5;
            lblBuscar.Text = "Producto:";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.Black;
            txtBuscar.Location = new Point(630, 74);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(170, 25);
            txtBuscar.TabIndex = 6;
            txtBuscar.TextChanged += FiltroCambiado;
            // 
            // chkSoloCriticos
            // 
            chkSoloCriticos.AutoSize = true;
            chkSoloCriticos.Cursor = Cursors.Hand;
            chkSoloCriticos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkSoloCriticos.ForeColor = Color.DarkSlateGray;
            chkSoloCriticos.Location = new Point(815, 76);
            chkSoloCriticos.Name = "chkSoloCriticos";
            chkSoloCriticos.Size = new Size(119, 21);
            chkSoloCriticos.TabIndex = 7;
            chkSoloCriticos.Text = "Solo críticos";
            chkSoloCriticos.UseVisualStyleBackColor = true;
            chkSoloCriticos.CheckedChanged += FiltroCambiado;
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dgvInventario.AllowUserToResizeRows = false;
            dgvInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvInventario.BackgroundColor = Color.White;
            dgvInventario.BorderStyle = BorderStyle.None;
            dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventario.ColumnHeadersHeight = 30;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { colInvSucursal, colInvSku, colInvProducto, colInvCategoria, colInvStock, colInvMinimo, colInvEstado, colInvValor });
            dgvInventario.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInventario.EnableHeadersVisualStyles = false;
            dgvInventario.GridColor = Color.Gainsboro;
            dgvInventario.Location = new Point(20, 110);
            dgvInventario.MultiSelect = false;
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowHeadersVisible = false;
            dgvInventario.RowTemplate.Height = 25;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(920, 395);
            dgvInventario.TabIndex = 8;
            // 
            // colInvSucursal
            // 
            colInvSucursal.HeaderText = "Sucursal";
            colInvSucursal.Name = "colInvSucursal";
            colInvSucursal.ReadOnly = true;
            colInvSucursal.Width = 110;
            // 
            // colInvSku
            // 
            colInvSku.HeaderText = "SKU";
            colInvSku.Name = "colInvSku";
            colInvSku.ReadOnly = true;
            colInvSku.Width = 80;
            // 
            // colInvProducto
            // 
            colInvProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colInvProducto.MinimumWidth = 200;
            colInvProducto.HeaderText = "Producto";
            colInvProducto.Name = "colInvProducto";
            colInvProducto.ReadOnly = true;
            // 
            // colInvCategoria
            // 
            colInvCategoria.HeaderText = "Categoría";
            colInvCategoria.Name = "colInvCategoria";
            colInvCategoria.ReadOnly = true;
            colInvCategoria.Width = 140;
            // 
            // colInvStock
            // 
            colInvStock.DefaultCellStyle = dataGridViewCellStyle4;
            colInvStock.HeaderText = "Stock";
            colInvStock.Name = "colInvStock";
            colInvStock.ReadOnly = true;
            colInvStock.Width = 75;
            // 
            // colInvMinimo
            // 
            colInvMinimo.DefaultCellStyle = dataGridViewCellStyle4;
            colInvMinimo.HeaderText = "Mínimo";
            colInvMinimo.Name = "colInvMinimo";
            colInvMinimo.ReadOnly = true;
            colInvMinimo.Width = 75;
            // 
            // colInvEstado
            // 
            colInvEstado.HeaderText = "Estado";
            colInvEstado.Name = "colInvEstado";
            colInvEstado.ReadOnly = true;
            colInvEstado.Width = 105;
            // 
            // colInvValor
            // 
            colInvValor.DefaultCellStyle = dataGridViewCellStyle4;
            colInvValor.HeaderText = "Valor S/";
            colInvValor.Name = "colInvValor";
            colInvValor.ReadOnly = true;
            colInvValor.Width = 95;
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
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResumen.ForeColor = Color.DarkSlateGray;
            lblResumen.Location = new Point(20, 531);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(492, 17);
            lblResumen.TabIndex = 9;
            lblResumen.Text = "Registros: 0   ·   Críticos: 0   ·   Valor del inventario: S/ 0.00";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkOliveGreen;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(800, 520);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(140, 38);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "🔄 Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // UC_InventarioGlobal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblInventarioGlobal);
            Controls.Add(lblSucursal);
            Controls.Add(cboSucursal);
            Controls.Add(lblCategoria);
            Controls.Add(cboCategoria);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(chkSoloCriticos);
            Controls.Add(dgvInventario);
            Controls.Add(lblResumen);
            Controls.Add(btnActualizar);
            Name = "UC_InventarioGlobal";
            Size = new Size(960, 610);
            Load += UC_InventarioGlobal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInventarioGlobal;
        private Label lblSucursal;
        private ComboBox cboSucursal;
        private Label lblCategoria;
        private ComboBox cboCategoria;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private CheckBox chkSoloCriticos;
        private DataGridView dgvInventario;
        private DataGridViewTextBoxColumn colInvSucursal;
        private DataGridViewTextBoxColumn colInvSku;
        private DataGridViewTextBoxColumn colInvProducto;
        private DataGridViewTextBoxColumn colInvCategoria;
        private DataGridViewTextBoxColumn colInvStock;
        private DataGridViewTextBoxColumn colInvMinimo;
        private DataGridViewTextBoxColumn colInvEstado;
        private DataGridViewTextBoxColumn colInvValor;
        private DataGridViewCellStyle dataGridViewCellStyle1;
        private DataGridViewCellStyle dataGridViewCellStyle2;
        private DataGridViewCellStyle dataGridViewCellStyle3;
        private DataGridViewCellStyle dataGridViewCellStyle4;
        private Label lblResumen;
        private Button btnActualizar;
    }
}
