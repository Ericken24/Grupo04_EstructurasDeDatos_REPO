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
            dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewCellStyle4 = new DataGridViewCellStyle();
            grpPermisos = new GroupBox();
            lblUsuarioSel = new Label();
            lblRolSel = new Label();
            dgvPermisos = new DataGridView();
            colPermModulo = new DataGridViewTextBoxColumn();
            colPermMenu = new DataGridViewTextBoxColumn();
            colPermAcceso = new DataGridViewTextBoxColumn();
            dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridViewCellStyle7 = new DataGridViewCellStyle();
            dataGridViewCellStyle8 = new DataGridViewCellStyle();
            lblResumenPermisos = new Label();
            lblNota = new Label();
            btnRegistrarRevision = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPermisos).BeginInit();
            grpPermisos.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuariosPermisos
            // 
            lblUsuariosPermisos.AutoSize = true;
            lblUsuariosPermisos.BackColor = Color.Transparent;
            lblUsuariosPermisos.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblUsuariosPermisos.Location = new Point(13, 17);
            lblUsuariosPermisos.Name = "lblUsuariosPermisos";
            lblUsuariosPermisos.Size = new Size(281, 37);
            lblUsuariosPermisos.TabIndex = 0;
            lblUsuariosPermisos.Text = "Usuarios y permisos";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRol.ForeColor = Color.DarkSlateGray;
            lblRol.Location = new Point(20, 78);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(33, 17);
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
            cboRol.Location = new Point(58, 74);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(220, 25);
            cboRol.TabIndex = 2;
            cboRol.SelectedIndexChanged += FiltroCambiado;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.ForeColor = Color.DarkSlateGray;
            lblBuscar.Location = new Point(298, 78);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(55, 17);
            lblBuscar.TabIndex = 3;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.Black;
            txtBuscar.Location = new Point(360, 74);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(180, 25);
            txtBuscar.TabIndex = 4;
            txtBuscar.TextChanged += FiltroCambiado;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.ColumnHeadersHeight = 30;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { colUsuUsuario, colUsuNombre, colUsuRol, colUsuSucursal });
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = Color.Gainsboro;
            dgvUsuarios.Location = new Point(20, 110);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(520, 395);
            dgvUsuarios.TabIndex = 5;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            // 
            // colUsuUsuario
            // 
            colUsuUsuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUsuUsuario.MinimumWidth = 110;
            colUsuUsuario.HeaderText = "Usuario";
            colUsuUsuario.Name = "colUsuUsuario";
            colUsuUsuario.ReadOnly = true;
            // 
            // colUsuNombre
            // 
            colUsuNombre.HeaderText = "Nombre";
            colUsuNombre.Name = "colUsuNombre";
            colUsuNombre.ReadOnly = true;
            colUsuNombre.Width = 140;
            // 
            // colUsuRol
            // 
            colUsuRol.HeaderText = "Rol";
            colUsuRol.Name = "colUsuRol";
            colUsuRol.ReadOnly = true;
            colUsuRol.Width = 150;
            // 
            // colUsuSucursal
            // 
            colUsuSucursal.HeaderText = "Sucursal";
            colUsuSucursal.Name = "colUsuSucursal";
            colUsuSucursal.ReadOnly = true;
            colUsuSucursal.Width = 100;
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
            // grpPermisos
            // 
            grpPermisos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpPermisos.ForeColor = Color.DarkOliveGreen;
            grpPermisos.Location = new Point(560, 110);
            grpPermisos.Name = "grpPermisos";
            grpPermisos.Size = new Size(380, 395);
            grpPermisos.TabIndex = 6;
            grpPermisos.TabStop = false;
            grpPermisos.Text = "Permisos del usuario";
            // 
            // lblUsuarioSel
            // 
            lblUsuarioSel.AutoSize = true;
            lblUsuarioSel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioSel.ForeColor = Color.DarkOliveGreen;
            lblUsuarioSel.Location = new Point(10, 28);
            lblUsuarioSel.Name = "lblUsuarioSel";
            lblUsuarioSel.Size = new Size(159, 17);
            lblUsuarioSel.TabIndex = 7;
            lblUsuarioSel.Text = "Seleccione un usuario";
            // 
            // lblRolSel
            // 
            lblRolSel.AutoSize = true;
            lblRolSel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRolSel.ForeColor = Color.Black;
            lblRolSel.Location = new Point(10, 52);
            lblRolSel.Name = "lblRolSel";
            lblRolSel.Size = new Size(45, 17);
            lblRolSel.TabIndex = 8;
            lblRolSel.Text = "Rol: -";
            // 
            // dgvPermisos
            // 
            dgvPermisos.AllowUserToAddRows = false;
            dgvPermisos.AllowUserToDeleteRows = false;
            dgvPermisos.AllowUserToResizeRows = false;
            dgvPermisos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvPermisos.BackgroundColor = Color.White;
            dgvPermisos.BorderStyle = BorderStyle.None;
            dgvPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvPermisos.ColumnHeadersHeight = 30;
            dgvPermisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPermisos.Columns.AddRange(new DataGridViewColumn[] { colPermModulo, colPermMenu, colPermAcceso });
            dgvPermisos.DefaultCellStyle = dataGridViewCellStyle6;
            dgvPermisos.EnableHeadersVisualStyles = false;
            dgvPermisos.GridColor = Color.Gainsboro;
            dgvPermisos.Location = new Point(10, 82);
            dgvPermisos.MultiSelect = false;
            dgvPermisos.Name = "dgvPermisos";
            dgvPermisos.ReadOnly = true;
            dgvPermisos.RowHeadersVisible = false;
            dgvPermisos.RowTemplate.Height = 25;
            dgvPermisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPermisos.Size = new Size(360, 265);
            dgvPermisos.TabIndex = 9;
            // 
            // colPermModulo
            // 
            colPermModulo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPermModulo.MinimumWidth = 130;
            colPermModulo.HeaderText = "Módulo";
            colPermModulo.Name = "colPermModulo";
            colPermModulo.ReadOnly = true;
            // 
            // colPermMenu
            // 
            colPermMenu.HeaderText = "Menú";
            colPermMenu.Name = "colPermMenu";
            colPermMenu.ReadOnly = true;
            colPermMenu.Width = 120;
            // 
            // colPermAcceso
            // 
            colPermAcceso.HeaderText = "Acceso";
            colPermAcceso.Name = "colPermAcceso";
            colPermAcceso.ReadOnly = true;
            colPermAcceso.Width = 70;
            // 
            // dataGridViewCellStyle5
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            // 
            // dataGridViewCellStyle6
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            // 
            // dataGridViewCellStyle7
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.Honeydew;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            // 
            // dataGridViewCellStyle8
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            // 
            // lblResumenPermisos
            // 
            lblResumenPermisos.AutoSize = true;
            lblResumenPermisos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResumenPermisos.ForeColor = Color.DarkSlateGray;
            lblResumenPermisos.Location = new Point(10, 358);
            lblResumenPermisos.Name = "lblResumenPermisos";
            lblResumenPermisos.Size = new Size(174, 17);
            lblResumenPermisos.TabIndex = 10;
            lblResumenPermisos.Text = "Acceso a 0 de 0 módulos";
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNota.ForeColor = Color.Black;
            lblNota.Location = new Point(20, 531);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(369, 17);
            lblNota.TabIndex = 11;
            lblNota.Text = "Los permisos dependen del rol asignado a cada cuenta.";
            // 
            // btnRegistrarRevision
            // 
            btnRegistrarRevision.BackColor = Color.DarkOliveGreen;
            btnRegistrarRevision.Cursor = Cursors.Hand;
            btnRegistrarRevision.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarRevision.ForeColor = Color.White;
            btnRegistrarRevision.Location = new Point(725, 520);
            btnRegistrarRevision.Name = "btnRegistrarRevision";
            btnRegistrarRevision.Size = new Size(215, 38);
            btnRegistrarRevision.TabIndex = 12;
            btnRegistrarRevision.Text = "📝 Registrar revisión";
            btnRegistrarRevision.UseVisualStyleBackColor = false;
            btnRegistrarRevision.Click += btnRegistrarRevision_Click;
            grpPermisos.Controls.Add(lblUsuarioSel);
            grpPermisos.Controls.Add(lblRolSel);
            grpPermisos.Controls.Add(dgvPermisos);
            grpPermisos.Controls.Add(lblResumenPermisos);
            // 
            // UC_UsuariosPermisos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Name = "UC_UsuariosPermisos";
            Size = new Size(960, 610);
            Load += UC_UsuariosPermisos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPermisos).EndInit();
            grpPermisos.ResumeLayout(false);
            grpPermisos.PerformLayout();
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
