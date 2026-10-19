namespace SistemaDeGestion_KusiMinimarket2026.AdmiGenRol_UC
{
    partial class UC_AdminGenMenu
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
            tableLayoutPanel2 = new TableLayoutPanel();
            this.btnAudSincr = new Button();
            btnUserPermisos = new Button();
            btnProdCategorias = new Button();
            btnInventarioGlob = new Button();
            btnVistaCons = new Button();
            btnDetalleSuc = new Button();
            tableLayoutPanel2.SuspendLayout();
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
            lblModulosMenu.TabIndex = 6;
            lblModulosMenu.Text = "MÓDULOS";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(this.btnAudSincr, 0, 5);
            tableLayoutPanel2.Controls.Add(btnUserPermisos, 0, 4);
            tableLayoutPanel2.Controls.Add(btnProdCategorias, 0, 3);
            tableLayoutPanel2.Controls.Add(btnInventarioGlob, 0, 2);
            tableLayoutPanel2.Controls.Add(btnVistaCons, 0, 0);
            tableLayoutPanel2.Controls.Add(btnDetalleSuc, 0, 1);
            tableLayoutPanel2.Location = new Point(3, 65);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Size = new Size(219, 431);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // btnAudSincr
            // 
            this.btnAudSincr.Anchor = AnchorStyles.None;
            this.btnAudSincr.BackColor = Color.DarkOliveGreen;
            this.btnAudSincr.BackgroundImageLayout = ImageLayout.Zoom;
            this.btnAudSincr.Cursor = Cursors.Hand;
            this.btnAudSincr.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnAudSincr.ForeColor = Color.White;
            this.btnAudSincr.Location = new Point(16, 365);
            this.btnAudSincr.Name = "btnAudSincr";
            this.btnAudSincr.Size = new Size(187, 56);
            this.btnAudSincr.TabIndex = 6;
            this.btnAudSincr.Text = "👨🏻‍💻 Auditoría y sincornización";
            this.btnAudSincr.UseVisualStyleBackColor = false;
            // 
            // btnUserPermisos
            // 
            btnUserPermisos.Anchor = AnchorStyles.None;
            btnUserPermisos.BackColor = Color.DarkOliveGreen;
            btnUserPermisos.BackgroundImageLayout = ImageLayout.Zoom;
            btnUserPermisos.Cursor = Cursors.Hand;
            btnUserPermisos.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUserPermisos.ForeColor = Color.White;
            btnUserPermisos.Location = new Point(16, 302);
            btnUserPermisos.Name = "btnUserPermisos";
            btnUserPermisos.Size = new Size(187, 35);
            btnUserPermisos.TabIndex = 5;
            btnUserPermisos.Text = "\U0001f9cd🏻Usuarios y permisos";
            btnUserPermisos.UseVisualStyleBackColor = false;
            // 
            // btnProdCategorias
            // 
            btnProdCategorias.Anchor = AnchorStyles.None;
            btnProdCategorias.BackColor = Color.DarkOliveGreen;
            btnProdCategorias.BackgroundImageLayout = ImageLayout.Zoom;
            btnProdCategorias.Cursor = Cursors.Hand;
            btnProdCategorias.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProdCategorias.ForeColor = Color.White;
            btnProdCategorias.Location = new Point(16, 222);
            btnProdCategorias.Name = "btnProdCategorias";
            btnProdCategorias.Size = new Size(187, 52);
            btnProdCategorias.TabIndex = 4;
            btnProdCategorias.Text = "🍪 Productos y categorías";
            btnProdCategorias.UseVisualStyleBackColor = false;
            // 
            // btnInventarioGlob
            // 
            btnInventarioGlob.Anchor = AnchorStyles.None;
            btnInventarioGlob.BackColor = Color.DarkOliveGreen;
            btnInventarioGlob.BackgroundImageLayout = ImageLayout.Zoom;
            btnInventarioGlob.Cursor = Cursors.Hand;
            btnInventarioGlob.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventarioGlob.ForeColor = Color.White;
            btnInventarioGlob.Location = new Point(16, 160);
            btnInventarioGlob.Name = "btnInventarioGlob";
            btnInventarioGlob.Size = new Size(187, 35);
            btnInventarioGlob.TabIndex = 3;
            btnInventarioGlob.Text = "🍶 Inventario global";
            btnInventarioGlob.UseVisualStyleBackColor = false;
            // 
            // btnVistaCons
            // 
            btnVistaCons.Anchor = AnchorStyles.None;
            btnVistaCons.BackColor = Color.DarkOliveGreen;
            btnVistaCons.BackgroundImageLayout = ImageLayout.Zoom;
            btnVistaCons.Cursor = Cursors.Hand;
            btnVistaCons.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVistaCons.ForeColor = Color.White;
            btnVistaCons.Location = new Point(16, 18);
            btnVistaCons.Name = "btnVistaCons";
            btnVistaCons.Size = new Size(187, 35);
            btnVistaCons.TabIndex = 1;
            btnVistaCons.Text = "📈 Vista consolidada";
            btnVistaCons.UseVisualStyleBackColor = false;
            // 
            // btnDetalleSuc
            // 
            btnDetalleSuc.Anchor = AnchorStyles.None;
            btnDetalleSuc.BackColor = Color.DarkOliveGreen;
            btnDetalleSuc.BackgroundImageLayout = ImageLayout.Zoom;
            btnDetalleSuc.Cursor = Cursors.Hand;
            btnDetalleSuc.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDetalleSuc.ForeColor = Color.White;
            btnDetalleSuc.Location = new Point(16, 89);
            btnDetalleSuc.Name = "btnDetalleSuc";
            btnDetalleSuc.Size = new Size(187, 35);
            btnDetalleSuc.TabIndex = 2;
            btnDetalleSuc.Text = "🏪 Detalle por sucursal";
            btnDetalleSuc.UseVisualStyleBackColor = false;
            // 
            // UC_AdminGenMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(lblModulosMenu);
            Name = "UC_AdminGenMenu";
            Size = new Size(225, 610);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button btnPuntoVenta;
        private Button btnHisotrialVentas;
        private Label lblModulosMenu;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnReportes;
        private Button btnAudSincr;
        private Button btnUserPermisos;
        private Button btnProdCategorias;
        private Button btnInventarioGlob;
        private Button btnResumen;
        private Button btnVistaCons;
        private Button btnDetalleSuc;
    }
}
