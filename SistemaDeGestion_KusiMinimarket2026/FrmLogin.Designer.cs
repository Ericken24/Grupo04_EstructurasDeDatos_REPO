 namespace SistemaDeGestion_KusiMinimarket2026
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pnlBienvenida = new Panel();
            tlpBienvenida = new TableLayoutPanel();
            lblDescripcion = new Label();
            pctLogoKusi = new PictureBox();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            pnlLogin = new Panel();
            btnIniciarSesion = new Button();
            lblTexto2 = new Label();
            lblTexto1 = new Label();
            pctMascota = new PictureBox();
            tlpLoginDatos = new TableLayoutPanel();
            lblInstruccion = new Label();
            lblBienvenidaLogin = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblContraseña = new Label();
            txtContraseña = new TextBox();
            pnlBienvenida.SuspendLayout();
            tlpBienvenida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctLogoKusi).BeginInit();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctMascota).BeginInit();
            tlpLoginDatos.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBienvenida
            // 
            pnlBienvenida.BackColor = Color.DarkOliveGreen;
            pnlBienvenida.Controls.Add(tlpBienvenida);
            pnlBienvenida.Location = new Point(0, 1);
            pnlBienvenida.Name = "pnlBienvenida";
            pnlBienvenida.Size = new Size(640, 680);
            pnlBienvenida.TabIndex = 0;
            // 
            // tlpBienvenida
            // 
            tlpBienvenida.ColumnCount = 1;
            tlpBienvenida.ColumnStyles.Add(new ColumnStyle());
            tlpBienvenida.Controls.Add(lblDescripcion, 0, 3);
            tlpBienvenida.Controls.Add(pctLogoKusi, 0, 0);
            tlpBienvenida.Controls.Add(lblTitulo, 0, 1);
            tlpBienvenida.Controls.Add(lblSubtitulo, 0, 2);
            tlpBienvenida.ForeColor = Color.Transparent;
            tlpBienvenida.Location = new Point(36, 24);
            tlpBienvenida.Name = "tlpBienvenida";
            tlpBienvenida.RowCount = 4;
            tlpBienvenida.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpBienvenida.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpBienvenida.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpBienvenida.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpBienvenida.Size = new Size(559, 631);
            tlpBienvenida.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Dock = DockStyle.Top;
            lblDescripcion.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = Color.DarkGray;
            lblDescripcion.Location = new Point(3, 535);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(553, 52);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Ventas, inventario y operación de tus \r\n7 sucursales en un solo lugar.";
            lblDescripcion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pctLogoKusi
            // 
            pctLogoKusi.Dock = DockStyle.Fill;
            pctLogoKusi.Image = (Image)resources.GetObject("pctLogoKusi.Image");
            pctLogoKusi.Location = new Point(3, 3);
            pctLogoKusi.Name = "pctLogoKusi";
            pctLogoKusi.Size = new Size(553, 246);
            pctLogoKusi.SizeMode = PictureBoxSizeMode.Zoom;
            pctLogoKusi.TabIndex = 0;
            pctLogoKusi.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(25, 275);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(508, 142);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Sistema de Gestión\r\nKusi Minimarket";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Dock = DockStyle.Top;
            lblSubtitulo.Font = new Font("Segoe UI Emoji", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.Gainsboro;
            lblSubtitulo.Location = new Point(3, 441);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(553, 85);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Control simple.\r\nDesiciones claras.";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(btnIniciarSesion);
            pnlLogin.Controls.Add(lblTexto2);
            pnlLogin.Controls.Add(lblTexto1);
            pnlLogin.Controls.Add(pctMascota);
            pnlLogin.Controls.Add(tlpLoginDatos);
            pnlLogin.Location = new Point(646, 1);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(538, 680);
            pnlLogin.TabIndex = 0;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.Goldenrod;
            btnIniciarSesion.Cursor = Cursors.Hand;
            btnIniciarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesion.ForeColor = Color.Black;
            btnIniciarSesion.Location = new Point(191, 497);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(167, 32);
            btnIniciarSesion.TabIndex = 4;
            btnIniciarSesion.Text = "Ingresar al Sistema";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // lblTexto2
            // 
            lblTexto2.AutoSize = true;
            lblTexto2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTexto2.ForeColor = SystemColors.ControlDarkDark;
            lblTexto2.Location = new Point(205, 120);
            lblTexto2.Name = "lblTexto2";
            lblTexto2.Size = new Size(90, 21);
            lblTexto2.TabIndex = 3;
            lblTexto2.Text = "MiniMarket";
            // 
            // lblTexto1
            // 
            lblTexto1.AutoSize = true;
            lblTexto1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTexto1.Location = new Point(201, 84);
            lblTexto1.Name = "lblTexto1";
            lblTexto1.Size = new Size(116, 32);
            lblTexto1.TabIndex = 2;
            lblTexto1.Text = "Kusi POS";
            // 
            // pctMascota
            // 
            pctMascota.BackColor = Color.Transparent;
            pctMascota.Image = (Image)resources.GetObject("pctMascota.Image");
            pctMascota.Location = new Point(16, 24);
            pctMascota.Name = "pctMascota";
            pctMascota.Size = new Size(215, 168);
            pctMascota.SizeMode = PictureBoxSizeMode.Zoom;
            pctMascota.TabIndex = 1;
            pctMascota.TabStop = false;
            // 
            // tlpLoginDatos
            // 
            tlpLoginDatos.ColumnCount = 1;
            tlpLoginDatos.ColumnStyles.Add(new ColumnStyle());
            tlpLoginDatos.Controls.Add(lblInstruccion, 0, 1);
            tlpLoginDatos.Controls.Add(lblBienvenidaLogin, 0, 0);
            tlpLoginDatos.Controls.Add(lblUsuario, 0, 2);
            tlpLoginDatos.Controls.Add(txtUsuario, 0, 3);
            tlpLoginDatos.Controls.Add(lblContraseña, 0, 4);
            tlpLoginDatos.Controls.Add(txtContraseña, 0, 5);
            tlpLoginDatos.Location = new Point(73, 232);
            tlpLoginDatos.Name = "tlpLoginDatos";
            tlpLoginDatos.RowCount = 6;
            tlpLoginDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpLoginDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpLoginDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tlpLoginDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tlpLoginDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tlpLoginDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tlpLoginDatos.Size = new Size(394, 259);
            tlpLoginDatos.TabIndex = 0;
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.BackColor = Color.Transparent;
            lblInstruccion.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblInstruccion.ForeColor = SystemColors.ControlDarkDark;
            lblInstruccion.Location = new Point(3, 52);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(282, 21);
            lblInstruccion.TabIndex = 5;
            lblInstruccion.Text = "Ingresa tus credenciales para continuar";
            // 
            // lblBienvenidaLogin
            // 
            lblBienvenidaLogin.Anchor = AnchorStyles.Left;
            lblBienvenidaLogin.AutoSize = true;
            lblBienvenidaLogin.BackColor = Color.Transparent;
            lblBienvenidaLogin.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenidaLogin.Location = new Point(3, 3);
            lblBienvenidaLogin.Name = "lblBienvenidaLogin";
            lblBienvenidaLogin.Size = new Size(229, 45);
            lblBienvenidaLogin.TabIndex = 4;
            lblBienvenidaLogin.Text = "Bienvenido(a)";
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblUsuario.Location = new Point(3, 107);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(219, 21);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario o correo electrónico";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Left;
            txtUsuario.Location = new Point(3, 133);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(304, 23);
            txtUsuario.TabIndex = 1;
            // 
            // lblContraseña
            // 
            lblContraseña.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblContraseña.AutoSize = true;
            lblContraseña.BackColor = Color.Transparent;
            lblContraseña.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblContraseña.Location = new Point(3, 204);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(92, 21);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Anchor = AnchorStyles.Left;
            txtContraseña.Location = new Point(3, 234);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(304, 23);
            txtContraseña.TabIndex = 3;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1184, 681);
            Controls.Add(pnlLogin);
            Controls.Add(pnlBienvenida);
            MaximizeBox = false;
            MinimumSize = new Size(800, 500);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kusi Minimarket || Acceso";
            Load += FrmLogin_Load;
            pnlBienvenida.ResumeLayout(false);
            tlpBienvenida.ResumeLayout(false);
            tlpBienvenida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctLogoKusi).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctMascota).EndInit();
            tlpLoginDatos.ResumeLayout(false);
            tlpLoginDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBienvenida;
        private Panel pnlLogin;
        private TableLayoutPanel tlpBienvenida;
        private TableLayoutPanel tlpLoginDatos;
        private PictureBox pctLogoKusi;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblDescripcion;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private Label lblInstruccion;
        private Label lblBienvenidaLogin;
        private Label lblContraseña;
        private TextBox txtContraseña;
        private Label lblTexto1;
        private PictureBox pctMascota;
        private Label lblTexto2;
        private Button btnIniciarSesion;
    }
}
