namespace SistemaDeGestion_KusiMinimarket2026.UC.Cajero
{
    partial class UC_NuevaVenta
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
            lblPuntoVenta = new Label();
            SuspendLayout();
            // 
            // lblPuntoVenta
            // 
            lblPuntoVenta.AutoSize = true;
            lblPuntoVenta.BackColor = Color.Transparent;
            lblPuntoVenta.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold);
            lblPuntoVenta.Location = new Point(13, 17);
            lblPuntoVenta.Name = "lblPuntoVenta";
            lblPuntoVenta.Size = new Size(219, 37);
            lblPuntoVenta.TabIndex = 0;
            lblPuntoVenta.Text = "Punto de venta";
            // 
            // UC_NuevaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblPuntoVenta);
            Name = "UC_NuevaVenta";
            Size = new Size(960, 610);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPuntoVenta;
    }
}
