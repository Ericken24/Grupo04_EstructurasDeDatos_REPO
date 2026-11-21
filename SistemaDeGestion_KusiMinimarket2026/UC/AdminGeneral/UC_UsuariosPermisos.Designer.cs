namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminGeneral
{
    partial class UC_UsuariosPermisos
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblUsuariosPermisos = new Label();
            lblRol = new Label();
            cboRol = new ComboBox();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            dgvUsuarios = new DataGridView();
            colUsuUsuario = new DataGridViewTextBoxColumn();
            colUsuNombre = new DataGridViewTextBoxColumn();
            colUsuRol = new DataGridViewTextBoxColumn();
            colUsuSucursal = new DataGridViewTextBoxColumn();
            grpPermisos = new GroupBox();
            lblUsuarioSel = new Label();
            lblRolSel = new Label();
            dgvPermisos = new DataGridView();
            colPermModulo = new DataGridViewTextBoxColumn();
            colPermMenu = new DataGridViewTextBoxColumn();
            colPermAcceso = new DataGridViewTextBoxColumn();
            lblResumenPermisos = new Label();
            lblNota = new Label();
            btnRegistrarRevision = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            grpPermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPermisos).BeginInit();
            SuspendLayout();
            // 
            // lblUsuariosPermisos
            // 
            lblUsuariosPermisos.AutoSize = true;
            lblUsuariosPermisos.BackColor = Color.Transparent;
            lblUsuariosPermisos.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblUsuariosPermisos.Location = new Point(15, 23);
            lblUsuariosPermisos.Name = "lblUsuariosPermisos";
            lblUsuariosPermisos.Size = new Size(354, 46);
            lblUsuariosPermisos.TabIndex = 0;
            lblUsuariosPermisos.Text = "Usuarios y permisos";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRol.ForeColor = Color.DarkSlateGray;
            lblRol.Location = new Point(23, 104);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(41, 23);
            lblRol.TabIndex = 1;
            lblRol.Text = "Rol:";
            // 
            // cboRol
            // 
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRol.ForeColor = Color.Black;
            cboRol.FormattingEnabled = true;
            cboRol.Items.AddRange(new object[] { "Todos los roles", "Cajero", "Administrador de sucursal", "Administrador general" });
            cboRol.Location = new Point(66, 99);
            cboRol.Margin = new Padding(3, 4, 3, 4);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(251, 29);
            cboRol.TabIndex = 2;
            cboRol.SelectedIndexChanged += FiltroCambiado;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.ForeColor = Color.DarkSlateGray;
            lblBuscar.Location = new Point(341, 104);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(68, 23);
            lblBuscar.TabIndex = 3;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.Black;
            txtBuscar.Location = new Point(411, 99);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(205, 29);
            txtBuscar.TabIndex = 4;
            txtBuscar.TextChanged += FiltroCambiado;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Honeydew;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.ColumnHeadersHeight = 30;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { colUsuUsuario, colUsuNombre, colUsuRol, colUsuSucursal });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = Color.Gainsboro;
            dgvUsuarios.Location = new Point(23, 147);
            dgvUsuarios.Margin = new Padding(3, 4, 3, 4);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(628, 527);
            dgvUsuarios.TabIndex = 5;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            // 
            // colUsuUsuario
            // 
            colUsuUsuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUsuUsuario.HeaderText = "Usuario";
            colUsuUsuario.MinimumWidth = 110;
            colUsuUsuario.Name = "colUsuUsuario";
            colUsuUsuario.ReadOnly = true;
            // 
            // colUsuNombre
            // 
            colUsuNombre.HeaderText = "Nombre";
            colUsuNombre.MinimumWidth = 6;
            colUsuNombre.Name = "colUsuNombre";
            colUsuNombre.ReadOnly = true;
            colUsuNombre.Width = 140;
            // 
            // colUsuRol
            // 
            colUsuRol.HeaderText = "Rol";
            colUsuRol.MinimumWidth = 6;
            colUsuRol.Name = "colUsuRol";
            colUsuRol.ReadOnly = true;
            colUsuRol.Width = 150;
            // 
            // colUsuSucursal
            // 
            colUsuSucursal.HeaderText = "Sucursal";
            colUsuSucursal.MinimumWidth = 6;
            colUsuSucursal.Name = "colUsuSucursal";
            colUsuSucursal.ReadOnly = true;
            // 
            // grpPermisos
            // 
            grpPermisos.Controls.Add(lblUsuarioSel);
            grpPermisos.Controls.Add(lblRolSel);
            grpPermisos.Controls.Add(dgvPermisos);
            grpPermisos.Controls.Add(lblResumenPermisos);
            grpPermisos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpPermisos.ForeColor = Color.DarkOliveGreen;
            grpPermisos.Location = new Point(657, 147);
            grpPermisos.Margin = new Padding(3, 4, 3, 4);
            grpPermisos.Name = "grpPermisos";
            grpPermisos.Padding = new Padding(3, 4, 3, 4);
            grpPermisos.Size = new Size(538, 527);
            grpPermisos.TabIndex = 6;
            grpPermisos.TabStop = false;
            grpPermisos.Text = "Permisos del usuario";
            // 
            // lblUsuarioSel
            // 
            lblUsuarioSel.AutoSize = true;
            lblUsuarioSel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioSel.ForeColor = Color.DarkOliveGreen;
            lblUsuarioSel.Location = new Point(11, 37);
            lblUsuarioSel.Name = "lblUsuarioSel";
            lblUsuarioSel.Size = new Size(181, 23);
            lblUsuarioSel.TabIndex = 7;
            lblUsuarioSel.Text = "Seleccione un usuario";
            // 
            // lblRolSel
            // 
            lblRolSel.AutoSize = true;
            lblRolSel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRolSel.ForeColor = Color.Black;
            lblRolSel.Location = new Point(11, 69);
            lblRolSel.Name = "lblRolSel";
            lblRolSel.Size = new Size(50, 23);
            lblRolSel.TabIndex = 8;
            lblRolSel.Text = "Rol: -";
            // 
            // dgvPermisos
            // 
            dgvPermisos.AllowUserToAddRows = false;
            dgvPermisos.AllowUserToDeleteRows = false;
            dgvPermisos.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Honeydew;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvPermisos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvPermisos.BackgroundColor = Color.White;
            dgvPermisos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvPermisos.ColumnHeadersHeight = 30;
            dgvPermisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPermisos.Columns.AddRange(new DataGridViewColumn[] { colPermModulo, colPermMenu, colPermAcceso });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.DarkOliveGreen;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvPermisos.DefaultCellStyle = dataGridViewCellStyle6;
            dgvPermisos.EnableHeadersVisualStyles = false;
            dgvPermisos.GridColor = Color.Gainsboro;
            dgvPermisos.Location = new Point(11, 109);
            dgvPermisos.Margin = new Padding(3, 4, 3, 4);
            dgvPermisos.MultiSelect = false;
            dgvPermisos.Name = "dgvPermisos";
            dgvPermisos.ReadOnly = true;
            dgvPermisos.RowHeadersVisible = false;
            dgvPermisos.RowHeadersWidth = 51;
            dgvPermisos.RowTemplate.Height = 25;
            dgvPermisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPermisos.Size = new Size(483, 353);
            dgvPermisos.TabIndex = 9;
            // 
            // colPermModulo
            // 
            colPermModulo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPermModulo.HeaderText = "Módulo";
            colPermModulo.MinimumWidth = 130;
            colPermModulo.Name = "colPermModulo";
            colPermModulo.ReadOnly = true;
            // 
            // colPermMenu
            // 
            colPermMenu.HeaderText = "Menú";
            colPermMenu.MinimumWidth = 6;
            colPermMenu.Name = "colPermMenu";
            colPermMenu.ReadOnly = true;
            colPermMenu.Width = 120;
            // 
            // colPermAcceso
            // 
            colPermAcceso.HeaderText = "Acceso";
            colPermAcceso.MinimumWidth = 6;
            colPermAcceso.Name = "colPermAcceso";
            colPermAcceso.ReadOnly = true;
            colPermAcceso.Width = 70;
            // 
            // lblResumenPermisos
            // 
            lblResumenPermisos.AutoSize = true;
            lblResumenPermisos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResumenPermisos.ForeColor = Color.DarkSlateGray;
            lblResumenPermisos.Location = new Point(11, 477);
            lblResumenPermisos.Name = "lblResumenPermisos";
            lblResumenPermisos.Size = new Size(207, 23);
            lblResumenPermisos.TabIndex = 10;
            lblResumenPermisos.Text = "Acceso a 0 de 0 módulos";
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNota.ForeColor = Color.Black;
            lblNota.Location = new Point(23, 708);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(433, 23);
            lblNota.TabIndex = 11;
            lblNota.Text = "Los permisos dependen del rol asignado a cada cuenta.";
            // 
            // btnRegistrarRevision
            // 
            btnRegistrarRevision.BackColor = Color.DarkOliveGreen;
            btnRegistrarRevision.Cursor = Cursors.Hand;
            btnRegistrarRevision.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarRevision.ForeColor = Color.White;
            btnRegistrarRevision.Location = new Point(829, 693);
            btnRegistrarRevision.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarRevision.Name = "btnRegistrarRevision";
            btnRegistrarRevision.Size = new Size(246, 51);
            btnRegistrarRevision.TabIndex = 12;
            btnRegistrarRevision.Text = "📝 Registrar revisión";
            btnRegistrarRevision.UseVisualStyleBackColor = false;
            btnRegistrarRevision.Click += btnRegistrarRevision_Click;
            // 
            // UC_UsuariosPermisos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblUsuariosPermisos);
            Controls.Add(lblRol);
            Controls.Add(cboRol);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(dgvUsuarios);
            Controls.Add(grpPermisos);
            Controls.Add(lblNota);
            Controls.Add(btnRegistrarRevision);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_UsuariosPermisos";
            Size = new Size(1200, 813);
            Load += UC_UsuariosPermisos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            grpPermisos.ResumeLayout(false);
            grpPermisos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPermisos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuariosPermisos;
        private Label lblRol;
        private ComboBox cboRol;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn colUsuUsuario;
        private DataGridViewTextBoxColumn colUsuNombre;
        private DataGridViewTextBoxColumn colUsuRol;
        private DataGridViewTextBoxColumn colUsuSucursal;
        private DataGridViewCellStyle dataGridViewCellStyle1;
        private DataGridViewCellStyle dataGridViewCellStyle2;
        private DataGridViewCellStyle dataGridViewCellStyle3;
        private DataGridViewCellStyle dataGridViewCellStyle4;
        private GroupBox grpPermisos;
        private Label lblUsuarioSel;
        private Label lblRolSel;
        private DataGridView dgvPermisos;
        private DataGridViewTextBoxColumn colPermModulo;
        private DataGridViewTextBoxColumn colPermMenu;
        private DataGridViewTextBoxColumn colPermAcceso;
        private DataGridViewCellStyle dataGridViewCellStyle5;
        private DataGridViewCellStyle dataGridViewCellStyle6;
        private DataGridViewCellStyle dataGridViewCellStyle7;
        private DataGridViewCellStyle dataGridViewCellStyle8;
        private Label lblResumenPermisos;
        private Label lblNota;
        private Button btnRegistrarRevision;
    }
}
