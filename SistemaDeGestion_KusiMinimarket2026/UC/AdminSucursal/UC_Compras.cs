using SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion;
using SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras;
using SistemaDeGestion_KusiMinimarket2026.Clases.Modelos;
using SistemaDeGestion_KusiMinimarket2026.Clases.Persistencia;

namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminSucursal
{
    /// <summary>
    /// Registro de compras a proveedores y recepción de mercadería.
    /// Estructuras: ListaSimple (detalle de la compra en curso), Pila (deshacer el último ítem agregado),
    /// Cola (compras REGISTRADAS que esperan ser recibidas, en orden de llegada: FIFO) y ListaDoble (historial, lo último primero).
    /// </summary>
    public partial class UC_Compras : UserControl
    {
        private readonly int sucursalId = Sesion.Actual?.SucursalId ?? 0;
        private ListaSimple<Producto> productos = new ListaSimple<Producto>();
        private ListaSimple<Proveedor> proveedores = new ListaSimple<Proveedor>();
        private readonly ListaSimple<DetalleCompra> detalle = new ListaSimple<DetalleCompra>();   // ítems de la compra en curso
        private readonly Pila<DetalleCompra> agregados = new Pila<DetalleCompra>();               // para "Deshacer último"
        private Cola<Compra> colaRecepcion = new Cola<Compra>();                                  // pendientes de recibir

        public UC_Compras()
        {
            InitializeComponent();
            nudCantidad.Value = 1;
            cmbProveedor.SelectedIndexChanged += (s, e) => CargarProductosDelProveedor();
            cmbProducto.SelectedIndexChanged += (s, e) => MostrarProducto();
            btnAgregar.Click += (s, e) => AgregarItem();
            btnDeshacerItem.Click += (s, e) => DeshacerItem();
            btnVaciar.Click += (s, e) => { detalle.Limpiar(); agregados.Limpiar(); RefrescarDetalle(); };
            btnRegistrar.Click += (s, e) => RegistrarCompra();
            btnRecibir.Click += (s, e) => RecibirSiguiente();
            btnAnular.Click += (s, e) => AnularSeleccionada();
            Load += (s, e) => { if (!DesignMode) Iniciar(); };
        }

        private static string Soles(decimal monto) => "S/ " + monto.ToString("N2");
        private static void Avisar(string mensaje, MessageBoxIcon icono = MessageBoxIcon.Information)
            => MessageBox.Show(mensaje, "Compras", MessageBoxButtons.OK, icono);

        private void Iniciar()
        {
            lblSubtitulo.Text = Sesion.Actual?.NombreSucursal ?? "";
            productos = ListaSimple<Producto>.Desde(Almacen.Productos.Cargar()).Filtrar(p => p.Activo);
            proveedores = ListaSimple<Proveedor>.Desde(Almacen.Proveedores.Cargar());
            foreach (Proveedor pr in proveedores) if (pr.Activo) cmbProveedor.Items.Add(pr);
            if (cmbProveedor.Items.Count > 0) cmbProveedor.SelectedIndex = 0;   // dispara la carga de productos
            RefrescarDetalle();
            CargarCompras();
        }

        // ---------- Nueva compra ----------
        private void CargarProductosDelProveedor()
        {
            cmbProducto.Items.Clear();
            if (cmbProveedor.SelectedItem is Proveedor pr)
                foreach (Producto p in productos.Filtrar(x => x.ProveedorId == pr.ProveedorId)) cmbProducto.Items.Add(p);
            if (cmbProducto.Items.Count > 0) cmbProducto.SelectedIndex = 0; else MostrarProducto();
        }

        private void MostrarProducto()
        {
            if (cmbProducto.SelectedItem is Producto p)
            {
                nudCosto.Value = Math.Clamp(p.PrecioCompra, nudCosto.Minimum, nudCosto.Maximum);
                decimal stock = Almacen.Inventario.Cargar()
                    .FirstOrDefault(i => i.SucursalId == sucursalId && i.ProductoId == p.ProductoId)?.StockActual ?? 0;
                lblStockActual.Text = $"Stock actual: {stock:0.##} {p.UnidadMedida}";
            }
            else lblStockActual.Text = "Stock actual: -";
        }

        private void AgregarItem()
        {
            if (cmbProducto.SelectedItem is not Producto p) { Avisar("Seleccione un producto.", MessageBoxIcon.Warning); return; }
            if (nudCantidad.Value <= 0 || nudCosto.Value <= 0) { Avisar("La cantidad y el costo deben ser mayores que 0.", MessageBoxIcon.Warning); return; }

            DetalleCompra item = new DetalleCompra { ProductoId = p.ProductoId, Nombre = p.Nombre, Cantidad = nudCantidad.Value, CostoUnitario = nudCosto.Value };
            detalle.AgregarFinal(item);
            agregados.Apilar(item);               // Pila: el último ítem queda en el tope
            nudCantidad.Value = 1;
            RefrescarDetalle();
        }

        private void DeshacerItem()
        {
            DetalleCompra? ultimo = agregados.Desapilar();      // LIFO: sale el último agregado
            if (ultimo == null) { Avisar("No hay ítems para deshacer."); return; }
            detalle.Eliminar(d => ReferenceEquals(d, ultimo));
            RefrescarDetalle();
        }

        private void RefrescarDetalle()
        {
            dgvDetalle.Rows.Clear();
            decimal total = 0;
            foreach (DetalleCompra d in detalle)
            {
                dgvDetalle.Rows.Add(d.Nombre, d.Cantidad, d.CostoUnitario, d.Importe);
                total += d.Importe;
            }
            lblTotal.Text = "Total: " + Soles(total);
            cmbProveedor.Enabled = detalle.EstaVacia;           // una compra = un solo proveedor
            btnDeshacerItem.Enabled = !agregados.EstaVacia;
            btnRegistrar.Enabled = btnVaciar.Enabled = !detalle.EstaVacia;
        }

        private void RegistrarCompra()
        {
            if (detalle.EstaVacia || cmbProveedor.SelectedItem is not Proveedor pr) { Avisar("Agregue al menos un producto.", MessageBoxIcon.Warning); return; }

            List<Compra> todas = Almacen.Compras.Cargar();
            int id = RepositorioJson<Compra>.SiguienteId(todas.Select(c => c.CompraId));
            string sucursal = (Sesion.Actual?.CodigoSucursal ?? "SUC").Replace("-", "");
            decimal total = 0;
            foreach (DetalleCompra d in detalle) total += d.Importe;

            Compra nueva = new Compra
            {
                CompraId = id,
                CodigoCompra = $"C-{sucursal}-{id:D6}",
                SucursalId = sucursalId,
                ProveedorId = pr.ProveedorId,
                UsuarioId = Sesion.Actual?.UsuarioId ?? 0,
                FechaCompra = DateTime.Now,
                Estado = "REGISTRADA",
                Total = total,
                Detalles = detalle.ToList()
            };
            todas.Add(nueva);
            Almacen.Compras.Guardar(todas);
            Auditar("REGISTRAR_COMPRA", $"{nueva.CodigoCompra} a {pr.RazonSocial} por {Soles(total)}");

            detalle.Limpiar();
            agregados.Limpiar();
            RefrescarDetalle();
            CargarCompras();
            Avisar($"Compra {nueva.CodigoCompra} registrada. Quedó en la cola de recepción.");
        }

        // ---------- Historial y cola de recepción ----------
        private void CargarCompras()
        {
            ListaSimple<Compra> compras = ListaSimple<Compra>.Desde(Almacen.Compras.Cargar()).Filtrar(c => c.SucursalId == sucursalId);

            // Cola: las compras REGISTRADAS entran en el orden en que fueron hechas
            colaRecepcion = Cola<Compra>.Desde(compras.Filtrar(c => c.Estado == "REGISTRADA"));

            dgvCompras.Rows.Clear();
            foreach (Compra c in ListaDoble<Compra>.Desde(compras).RecorrerAlReves())      // lo más reciente primero
            {
                int fila = dgvCompras.Rows.Add(c.CodigoCompra, c.FechaCompra.ToString("dd/MM/yyyy HH:mm"),
                    proveedores.Buscar(p => p.ProveedorId == c.ProveedorId)?.RazonSocial ?? "-", c.Detalles.Count, c.Total, c.Estado);
                dgvCompras.Rows[fila].Tag = c;
                if (c.Estado == "RECIBIDA") dgvCompras.Rows[fila].DefaultCellStyle.ForeColor = Color.DarkGreen;
                else if (c.Estado == "ANULADA") dgvCompras.Rows[fila].DefaultCellStyle.ForeColor = Color.Gray;
            }

            Compra? siguiente = colaRecepcion.Frente();
            lblCola.Text = siguiente == null
                ? "No hay compras pendientes de recibir."
                : $"Pendientes: {colaRecepcion.Cantidad}\nSiguiente: {siguiente.CodigoCompra}";
            btnRecibir.Enabled = siguiente != null;
        }

        private void RecibirSiguiente()
        {
            Compra? siguiente = colaRecepcion.Frente();           // quien sigue en la cola, sin sacarlo todavía
            if (siguiente == null) return;
            if (MessageBox.Show($"¿Recibir la compra {siguiente.CodigoCompra}?\nSu detalle se sumará al stock de la sucursal.",
                "Recibir compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            List<Compra> todas = Almacen.Compras.Cargar();
            Compra? real = todas.FirstOrDefault(c => c.CompraId == siguiente.CompraId);
            if (real == null || real.Estado != "REGISTRADA") { Avisar("La compra ya cambió de estado.", MessageBoxIcon.Warning); CargarCompras(); return; }

            List<Inventario> inventario = Almacen.Inventario.Cargar();
            foreach (DetalleCompra d in real.Detalles)
            {
                Inventario? registro = inventario.FirstOrDefault(i => i.SucursalId == sucursalId && i.ProductoId == d.ProductoId);
                if (registro == null) inventario.Add(new Inventario { SucursalId = sucursalId, ProductoId = d.ProductoId, StockActual = d.Cantidad });
                else registro.StockActual += d.Cantidad;
            }
            real.Estado = "RECIBIDA";
            Almacen.Inventario.Guardar(inventario);
            Almacen.Compras.Guardar(todas);

            colaRecepcion.Desencolar();                           // FIFO: sale el que llevaba más tiempo esperando
            Auditar("RECIBIR_COMPRA", $"{real.CodigoCompra} recibida; stock actualizado");
            CargarCompras();
            MostrarProducto();
        }

        private void AnularSeleccionada()
        {
            if (dgvCompras.CurrentRow?.Tag is not Compra sel) { Avisar("Seleccione una compra de la tabla.", MessageBoxIcon.Warning); return; }
            if (sel.Estado != "REGISTRADA") { Avisar("Solo se pueden anular compras REGISTRADAS (aún no recibidas).", MessageBoxIcon.Warning); return; }
            if (MessageBox.Show($"¿Anular la compra {sel.CodigoCompra}?", "Anular compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            List<Compra> todas = Almacen.Compras.Cargar();
            Compra? real = todas.FirstOrDefault(c => c.CompraId == sel.CompraId);
            if (real == null || real.Estado != "REGISTRADA") { CargarCompras(); return; }
            real.Estado = "ANULADA";
            Almacen.Compras.Guardar(todas);
            Auditar("ANULAR_COMPRA", real.CodigoCompra);
            CargarCompras();
        }

        private void Auditar(string accion, string detalleTexto)
        {
            List<Auditoria> log = Almacen.Auditoria.Cargar();
            log.Add(new Auditoria
            {
                AuditoriaId = RepositorioJson<Auditoria>.SiguienteId(log.Select(a => a.AuditoriaId)),
                UsuarioId = Sesion.Actual?.UsuarioId,
                SucursalId = sucursalId,
                Accion = accion,
                Detalle = detalleTexto
            });
            Almacen.Auditoria.Guardar(log);
        }
    }
}
