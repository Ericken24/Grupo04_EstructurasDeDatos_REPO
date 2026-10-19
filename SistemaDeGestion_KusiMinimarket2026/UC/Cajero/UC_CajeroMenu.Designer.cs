namespace SistemaDeGestion_KusiMinimarket2026.CajeroRol_UC
{
    partial class UC_CajeroMenu
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
            lblModulosMenu = new Label();
            btnPuntoVenta = new Button();
            btnHisotrialVentas = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnTransEspera = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblModulosMenu
            // 
            lblModulosMenu.AutoSize = true;
            lblModulosMenu.Font = new Font("Heavitas", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModulosMenu.ForeColor = Color.DarkSeaGreen;
            lblModulosMenu.Location = new Point(20, 30);
            lblModulosMenu.Name = "lblModulosMenu";
            lblModulosMenu.Size = new Size(98, 21);
            lblModulosMenu.TabIndex = 0;
            lblModulosMenu.Text = "MÓDULOS";
            // 
            // btnPuntoVenta
            // 
            btnPuntoVenta.Anchor = AnchorStyles.None;
            btnPuntoVenta.BackColor = Color.DarkOliveGreen;
            btnPuntoVenta.BackgroundImageLayout = ImageLayout.Zoom;
            btnPuntoVenta.Cursor = Cursors.Hand;
            btnPuntoVenta.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPuntoVenta.ForeColor = Color.White;
            btnPuntoVenta.Location = new Point(16, 27);
            btnPuntoVenta.Name = "btnPuntoVenta";
            btnPuntoVenta.Size = new Size(187, 35);
            btnPuntoVenta.TabIndex = 1;
            btnPuntoVenta.Text = "➕ Nueva venta";
            btnPuntoVenta.UseVisualStyleBackColor = false;
            // 
            // btnHisotrialVentas
            // 
            btnHisotrialVentas.Anchor = AnchorStyles.None;
            btnHisotrialVentas.BackColor = Color.DarkOliveGreen;
            btnHisotrialVentas.BackgroundImageLayout = ImageLayout.Zoom;
            btnHisotrialVentas.Cursor = Cursors.Hand;
            btnHisotrialVentas.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHisotrialVentas.ForeColor = Color.White;
            btnHisotrialVentas.Location = new Point(16, 116);
            btnHisotrialVentas.Name = "btnHisotrialVentas";
            btnHisotrialVentas.Size = new Size(187, 35);
            btnHisotrialVentas.TabIndex = 2;
            btnHisotrialVentas.Text = "🔎 Historial de ventas";
            btnHisotrialVentas.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnTransEspera, 0, 2);
            tableLayoutPanel1.Controls.Add(btnPuntoVenta, 0, 0);
            tableLayoutPanel1.Controls.Add(btnHisotrialVentas, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 65);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(219, 268);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // btnTransEspera
            // 
            btnTransEspera.Anchor = AnchorStyles.None;
            btnTransEspera.BackColor = Color.DarkOliveGreen;
            btnTransEspera.BackgroundImageLayout = ImageLayout.Zoom;
            btnTransEspera.Cursor = Cursors.Hand;
            btnTransEspera.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransEspera.ForeColor = Color.White;
            btnTransEspera.Location = new Point(16, 197);
            btnTransEspera.Name = "btnTransEspera";
            btnTransEspera.Size = new Size(187, 51);
            btnTransEspera.TabIndex = 3;
            btnTransEspera.Text = "⌚ Transacciones en espera";
            btnTransEspera.UseVisualStyleBackColor = false;
            // 
            // UC_CajeroMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblModulosMenu);
            Name = "UC_CajeroMenu";
            Size = new Size(225, 610);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblModulosMenu;
        private Button btnPuntoVenta;
        private Button btnHisotrialVentas;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnTransEspera;
    }
}
