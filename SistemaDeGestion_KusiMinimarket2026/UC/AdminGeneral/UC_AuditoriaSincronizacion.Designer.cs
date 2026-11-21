namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminGeneral
{
    partial class UC_AuditoriaSincronizacion
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblAuditoriaSincronizacion = new Label();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            dgvAuditoria = new DataGridView();
            colAudFecha = new DataGridViewTextBoxColumn();
            colAudUsuario = new DataGridViewTextBoxColumn();
            colAudSucursal = new DataGridViewTextBoxColumn();
            colAudAccion = new DataGridViewTextBoxColumn();
            colAudDetalle = new DataGridViewTextBoxColumn();
            grpSync = new GroupBox();
            lblEstadoSync = new Label();
            dgvEnlaces = new DataGridView();
            colEnlOrigen = new DataGridViewTextBoxColumn();
            colEnlDestino = new DataGridViewTextBoxColumn();
            colEnlCosto = new DataGridViewTextBoxColumn();
            colEnlEstado = new DataGridViewTextBoxColumn();
            btnAlternarEnlace = new Button();
            btnSincronizar = new Button();
            lblTurno = new Label();
            lblPendientes = new Label();
            lblSiguientePendiente = new Label();
            btnReintentar = new Button();
            lblTotalAuditoria = new Label();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).BeginInit();
            grpSync.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnlaces).BeginInit();
            SuspendLayout();
            // 
            // lblAuditoriaSincronizacion
            // 
            lblAuditoriaSincronizacion.AutoSize = true;
            lblAuditoriaSincronizacion.BackColor = Color.Transparent;
            lblAuditoriaSincronizacion.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblAuditoriaSincronizacion.Location = new Point(15, 23);
            lblAuditoriaSincronizacion.Name = "lblAuditoriaSincronizacion";
            lblAuditoriaSincronizacion.Size = new Size(455, 46);
            lblAuditoriaSincronizacion.TabIndex = 0;
            lblAuditoriaSincronizacion.Text = "Auditoría y sincronización";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.ForeColor = Color.DarkSlateGray;
            lblBuscar.Location = new Point(23, 104);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(68, 23);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.Black;
            txtBuscar.Location = new Point(97, 99);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(519, 29);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvAuditoria
            // 
            dgvAuditoria.AllowUserToAddRows = false;
            dgvAuditoria.AllowUserToDeleteRows = false;
            dgvAuditoria.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Honeydew;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvAuditoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAuditoria.BackgroundColor = Color.White;
            dgvAuditoria.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAuditoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAuditoria.ColumnHeadersHeight = 30;
            dgvAuditoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAuditoria.Columns.AddRange(new DataGridViewColumn[] { colAudFecha, colAudUsuario, colAudSucursal, colAudAccion, colAudDetalle });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAuditoria.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAuditoria.EnableHeadersVisualStyles = false;
            dgvAuditoria.GridColor = Color.Gainsboro;
            dgvAuditoria.Location = new Point(23, 147);
            dgvAuditoria.Margin = new Padding(3, 4, 3, 4);
            dgvAuditoria.MultiSelect = false;
            dgvAuditoria.Name = "dgvAuditoria";
            dgvAuditoria.ReadOnly = true;
            dgvAuditoria.RowHeadersVisible = false;
            dgvAuditoria.RowHeadersWidth = 51;
            dgvAuditoria.RowTemplate.Height = 25;
            dgvAuditoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuditoria.Size = new Size(673, 527);
            dgvAuditoria.TabIndex = 3;
            // 
            // colAudFecha
            // 
            colAudFecha.HeaderText = "Fecha";
            colAudFecha.MinimumWidth = 6;
            colAudFecha.Name = "colAudFecha";
            colAudFecha.ReadOnly = true;
            colAudFecha.Width = 115;
            // 
            // colAudUsuario
            // 
            colAudUsuario.HeaderText = "Usuario";
            colAudUsuario.MinimumWidth = 6;
            colAudUsuario.Name = "colAudUsuario";
            colAudUsuario.ReadOnly = true;
            colAudUsuario.Width = 70;
            // 
            // colAudSucursal
            // 
            colAudSucursal.HeaderText = "Sucursal";
            colAudSucursal.MinimumWidth = 6;
            colAudSucursal.Name = "colAudSucursal";
            colAudSucursal.ReadOnly = true;
            colAudSucursal.Width = 75;
            // 
            // colAudAccion
            // 
            colAudAccion.HeaderText = "Acción";
            colAudAccion.MinimumWidth = 6;
            colAudAccion.Name = "colAudAccion";
            colAudAccion.ReadOnly = true;
            colAudAccion.Width = 110;
            // 
            // colAudDetalle
            // 
            colAudDetalle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAudDetalle.HeaderText = "Detalle";
            colAudDetalle.MinimumWidth = 120;
            colAudDetalle.Name = "colAudDetalle";
            colAudDetalle.ReadOnly = true;
            // 
            // grpSync
            // 
            grpSync.Controls.Add(lblEstadoSync);
            grpSync.Controls.Add(dgvEnlaces);
            grpSync.Controls.Add(btnAlternarEnlace);
            grpSync.Controls.Add(btnSincronizar);
            grpSync.Controls.Add(lblTurno);
            grpSync.Controls.Add(lblPendientes);
            grpSync.Controls.Add(lblSiguientePendiente);
            grpSync.Controls.Add(btnReintentar);
            grpSync.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpSync.ForeColor = Color.DarkOliveGreen;
            grpSync.Location = new Point(702, 93);
            grpSync.Margin = new Padding(3, 4, 3, 4);
            grpSync.Name = "grpSync";
            grpSync.Padding = new Padding(3, 4, 3, 4);
            grpSync.Size = new Size(479, 580);
            grpSync.TabIndex = 4;
            grpSync.TabStop = false;
            grpSync.Text = "Sincronización entre sucursales";
            // 
            // lblEstadoSync
            // 
            lblEstadoSync.AutoSize = true;
            lblEstadoSync.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstadoSync.ForeColor = Color.DarkOliveGreen;
            lblEstadoSync.Location = new Point(11, 37);
            lblEstadoSync.Name = "lblEstadoSync";
            lblEstadoSync.Size = new Size(223, 23);
            lblEstadoSync.TabIndex = 5;
            lblEstadoSync.Text = "Enlaces disponibles: 0 de 0";
            // 
            // dgvEnlaces
            // 
            dgvEnlaces.AllowUserToAddRows = false;
            dgvEnlaces.AllowUserToDeleteRows = false;
            dgvEnlaces.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Honeydew;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvEnlaces.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvEnlaces.BackgroundColor = Color.White;
            dgvEnlaces.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvEnlaces.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvEnlaces.ColumnHeadersHeight = 30;
            dgvEnlaces.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEnlaces.Columns.AddRange(new DataGridViewColumn[] { colEnlOrigen, colEnlDestino, colEnlCosto, colEnlEstado });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.DarkOliveGreen;
            dataGridViewCellStyle7.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvEnlaces.DefaultCellStyle = dataGridViewCellStyle7;
            dgvEnlaces.EnableHeadersVisualStyles = false;
            dgvEnlaces.GridColor = Color.Gainsboro;
            dgvEnlaces.Location = new Point(11, 73);
            dgvEnlaces.Margin = new Padding(3, 4, 3, 4);
            dgvEnlaces.MultiSelect = false;
            dgvEnlaces.Name = "dgvEnlaces";
            dgvEnlaces.ReadOnly = true;
            dgvEnlaces.RowHeadersVisible = false;
            dgvEnlaces.RowHeadersWidth = 51;
            dgvEnlaces.RowTemplate.Height = 25;
            dgvEnlaces.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEnlaces.Size = new Size(411, 267);
            dgvEnlaces.TabIndex = 6;
            // 
            // colEnlOrigen
            // 
            colEnlOrigen.HeaderText = "Origen";
            colEnlOrigen.MinimumWidth = 6;
            colEnlOrigen.Name = "colEnlOrigen";
            colEnlOrigen.ReadOnly = true;
            colEnlOrigen.Width = 80;
            // 
            // colEnlDestino
            // 
            colEnlDestino.HeaderText = "Destino";
            colEnlDestino.MinimumWidth = 6;
            colEnlDestino.Name = "colEnlDestino";
            colEnlDestino.ReadOnly = true;
            colEnlDestino.Width = 80;
            // 
            // colEnlCosto
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            colEnlCosto.DefaultCellStyle = dataGridViewCellStyle6;
            colEnlCosto.HeaderText = "Costo";
            colEnlCosto.MinimumWidth = 6;
            colEnlCosto.Name = "colEnlCosto";
            colEnlCosto.ReadOnly = true;
            colEnlCosto.Width = 60;
            // 
            // colEnlEstado
            // 
            colEnlEstado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEnlEstado.HeaderText = "Estado";
            colEnlEstado.MinimumWidth = 80;
            colEnlEstado.Name = "colEnlEstado";
            colEnlEstado.ReadOnly = true;
            // 
            // btnAlternarEnlace
            // 
            btnAlternarEnlace.BackColor = Color.DarkOliveGreen;
            btnAlternarEnlace.Cursor = Cursors.Hand;
            btnAlternarEnlace.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlternarEnlace.ForeColor = Color.White;
            btnAlternarEnlace.Location = new Point(11, 353);
            btnAlternarEnlace.Margin = new Padding(3, 4, 3, 4);
            btnAlternarEnlace.Name = "btnAlternarEnlace";
            btnAlternarEnlace.Size = new Size(194, 48);
            btnAlternarEnlace.TabIndex = 7;
            btnAlternarEnlace.Text = "🔌 Alternar enlace";
            btnAlternarEnlace.UseVisualStyleBackColor = false;
            btnAlternarEnlace.Click += btnAlternarEnlace_Click;
            // 
            // btnSincronizar
            // 
            btnSincronizar.BackColor = Color.DarkOliveGreen;
            btnSincronizar.Cursor = Cursors.Hand;
            btnSincronizar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSincronizar.ForeColor = Color.White;
            btnSincronizar.Location = new Point(217, 353);
            btnSincronizar.Margin = new Padding(3, 4, 3, 4);
            btnSincronizar.Name = "btnSincronizar";
            btnSincronizar.Size = new Size(194, 48);
            btnSincronizar.TabIndex = 8;
            btnSincronizar.Text = "🔄 Sincronizar";
            btnSincronizar.UseVisualStyleBackColor = false;
            btnSincronizar.Click += btnSincronizar_Click;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTurno.ForeColor = Color.Black;
            lblTurno.Location = new Point(11, 421);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(124, 23);
            lblTurno.TabIndex = 9;
            lblTurno.Text = "Último turno: -";
            // 
            // lblPendientes
            // 
            lblPendientes.AutoSize = true;
            lblPendientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendientes.ForeColor = Color.DarkSlateGray;
            lblPendientes.Location = new Point(11, 453);
            lblPendientes.Name = "lblPendientes";
            lblPendientes.Size = new Size(190, 23);
            lblPendientes.TabIndex = 10;
            lblPendientes.Text = "En cola de reintento: 0";
            // 
            // lblSiguientePendiente
            // 
            lblSiguientePendiente.AutoSize = true;
            lblSiguientePendiente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSiguientePendiente.ForeColor = Color.Black;
            lblSiguientePendiente.Location = new Point(11, 485);
            lblSiguientePendiente.Name = "lblSiguientePendiente";
            lblSiguientePendiente.Size = new Size(172, 23);
            lblSiguientePendiente.TabIndex = 11;
            lblSiguientePendiente.Text = "Siguiente reintento: -";
            // 
            // btnReintentar
            // 
            btnReintentar.BackColor = Color.Brown;
            btnReintentar.Cursor = Cursors.Hand;
            btnReintentar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReintentar.ForeColor = Color.White;
            btnReintentar.Location = new Point(11, 523);
            btnReintentar.Margin = new Padding(3, 4, 3, 4);
            btnReintentar.Name = "btnReintentar";
            btnReintentar.Size = new Size(400, 48);
            btnReintentar.TabIndex = 12;
            btnReintentar.Text = "🔁 Reintentar pendiente";
            btnReintentar.UseVisualStyleBackColor = false;
            btnReintentar.Click += btnReintentar_Click;
            // 
            // lblTotalAuditoria
            // 
            lblTotalAuditoria.AutoSize = true;
            lblTotalAuditoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAuditoria.ForeColor = Color.DarkSlateGray;
            lblTotalAuditoria.Location = new Point(23, 708);
            lblTotalAuditoria.Name = "lblTotalAuditoria";
            lblTotalAuditoria.Size = new Size(91, 23);
            lblTotalAuditoria.TabIndex = 13;
            lblTotalAuditoria.Text = "Eventos: 0";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkOliveGreen;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(914, 693);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(160, 51);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "🔄 Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // UC_AuditoriaSincronizacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblAuditoriaSincronizacion);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(dgvAuditoria);
            Controls.Add(grpSync);
            Controls.Add(lblTotalAuditoria);
            Controls.Add(btnActualizar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_AuditoriaSincronizacion";
            Size = new Size(1200, 813);
            Load += UC_AuditoriaSincronizacion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).EndInit();
            grpSync.ResumeLayout(false);
            grpSync.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnlaces).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAuditoriaSincronizacion;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private DataGridView dgvAuditoria;
        private DataGridViewTextBoxColumn colAudFecha;
        private DataGridViewTextBoxColumn colAudUsuario;
        private DataGridViewTextBoxColumn colAudSucursal;
        private DataGridViewTextBoxColumn colAudAccion;
        private DataGridViewTextBoxColumn colAudDetalle;
        private DataGridViewCellStyle dataGridViewCellStyle1;
        private DataGridViewCellStyle dataGridViewCellStyle2;
        private DataGridViewCellStyle dataGridViewCellStyle3;
        private DataGridViewCellStyle dataGridViewCellStyle4;
        private GroupBox grpSync;
        private Label lblEstadoSync;
        private DataGridView dgvEnlaces;
        private DataGridViewTextBoxColumn colEnlOrigen;
        private DataGridViewTextBoxColumn colEnlDestino;
        private DataGridViewTextBoxColumn colEnlCosto;
        private DataGridViewTextBoxColumn colEnlEstado;
        private DataGridViewCellStyle dataGridViewCellStyle5;
        private DataGridViewCellStyle dataGridViewCellStyle6;
        private DataGridViewCellStyle dataGridViewCellStyle7;
        private DataGridViewCellStyle dataGridViewCellStyle8;
        private Button btnAlternarEnlace;
        private Button btnSincronizar;
        private Label lblTurno;
        private Label lblPendientes;
        private Label lblSiguientePendiente;
        private Button btnReintentar;
        private Label lblTotalAuditoria;
        private Button btnActualizar;
    }
}
