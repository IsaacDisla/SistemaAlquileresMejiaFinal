using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa.Entidades;
using Capa.Negocios;

namespace Capa.Presentacion
{
    public partial class FormAlquileres : Form
    {
        private AlquileresBL alquilerBL = new AlquileresBL();
        private DetalleAlquileresBL detalleBL = new DetalleAlquileresBL();

        private DataTable detalles = new DataTable();
        private VehiculosBL vehiculoBL = new VehiculosBL();

        private ClientesBL clienteBL = new ClientesBL();
        public FormAlquileres()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

        }

        private void btnGuardarAlquiler_Click(object sender, EventArgs e)
        {

        }

        private void EstiloGridPrincipal()
        {
            dgvAlquileres.BorderStyle = BorderStyle.None;
            dgvAlquileres.BackgroundColor = Color.White;

            dgvAlquileres.EnableHeadersVisualStyles = false;

            dgvAlquileres.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgvAlquileres.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 0, 102);

            dgvAlquileres.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvAlquileres.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI Semibold", 12, FontStyle.Bold);

            dgvAlquileres.ColumnHeadersHeight = 45;

            dgvAlquileres.DefaultCellStyle.BackColor =
                Color.White;

            dgvAlquileres.DefaultCellStyle.ForeColor =
                Color.Black;

            dgvAlquileres.DefaultCellStyle.Font =
                new Font("Segoe UI", 11);

            dgvAlquileres.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(65, 105, 225);

            dgvAlquileres.DefaultCellStyle.SelectionForeColor =
                Color.White;

            dgvAlquileres.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            dgvAlquileres.GridColor =
                Color.LightGray;

            dgvAlquileres.RowTemplate.Height = 35;

            dgvAlquileres.RowHeadersVisible = false;

            dgvAlquileres.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvAlquileres.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvAlquileres.MultiSelect = false;

            dgvAlquileres.AllowUserToAddRows = false;

            dgvAlquileres.AllowUserToDeleteRows = false;

            dgvAlquileres.AllowUserToResizeRows = false;
        }


        private void EstiloGridDetalles()
        {
            dgvDetalles.BorderStyle = BorderStyle.None;
            dgvDetalles.BackgroundColor = Color.White;

            dgvDetalles.EnableHeadersVisualStyles = false;

            dgvDetalles.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgvDetalles.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 0, 102);

            dgvDetalles.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvDetalles.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI Semibold", 12, FontStyle.Bold);

            dgvDetalles.ColumnHeadersHeight = 45;

            dgvDetalles.DefaultCellStyle.BackColor =
                Color.White;

            dgvDetalles.DefaultCellStyle.ForeColor =
                Color.Black;

            dgvDetalles.DefaultCellStyle.Font =
                new Font("Segoe UI", 11);

            dgvDetalles.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(65, 105, 225);

            dgvDetalles.DefaultCellStyle.SelectionForeColor =
                Color.White;

            dgvDetalles.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            dgvDetalles.GridColor =
                Color.LightGray;

            dgvDetalles.RowTemplate.Height = 35;

            dgvDetalles.RowHeadersVisible = false;

            dgvDetalles.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.None;

            dgvDetalles.ScrollBars =
                ScrollBars.Both;

            dgvDetalles.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvDetalles.MultiSelect = false;

            dgvDetalles.AllowUserToAddRows = false;

            dgvDetalles.AllowUserToDeleteRows = false;

            dgvDetalles.AllowUserToResizeRows = false;
        }
        private void CargarDetalleAlquiler(int idAlquiler)
        {
            try
            {
                dgvDetalles.DataSource =
                    detalleBL.ObtenerDetallePorAlquiler(idAlquiler);

                dgvDetalles.Columns["Id_Vehiculo"].Visible = false;

                dgvDetalles.Columns["Vehiculo"].Width = 250;
                dgvDetalles.Columns["Fecha_Entrega"].Width = 120;
                dgvDetalles.Columns["Precio_Dia"].Width = 100;
                dgvDetalles.Columns["Dias"].Width = 70;
                dgvDetalles.Columns["Subtotal"].Width = 100;
                dgvDetalles.Columns["Kilometraje"].Width = 120;
                dgvDetalles.Columns["Combustible"].Width = 120;
                dgvDetalles.Columns["Estado_Salida"].Width = 180;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar detalle: " + ex.Message);
            }
        }

        private void AplicarPermisos()
        {
            if (Sesion.Rol == "Administrador")
            {
                return;
            }

            if (Sesion.Rol == "Gerente")
            {
                lblUsuarios.Visible = false;
                lblRoles.Visible = false;
                lblBackups.Visible = false;
            }

            if (Sesion.Rol == "Empleado")
            {
                lblUsuarios.Visible = false;
                lblRoles.Visible = false;
                lblBackups.Visible = false;
                lblReportes.Visible = false;
            }
        }

        private void FormAlquileres_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Sesion.Nombre;
            lblRol.Text = Sesion.Rol;

            cbCombustible.Items.Add("Lleno");
            cbCombustible.Items.Add("Medio");
            cbCombustible.Items.Add("Reserva");

            cbEstadoSalida.Items.Add("Buenas Condiciones");
            cbEstadoSalida.Items.Add("Regular");
            cbEstadoSalida.Items.Add("Mal Estado");

            CrearTablaDetalles();
            CargarClientes();

            cbCliente.AutoCompleteMode =
                AutoCompleteMode.SuggestAppend;

            cbCliente.AutoCompleteSource =
                AutoCompleteSource.ListItems;

            cbCliente.DropDownStyle =
                ComboBoxStyle.DropDown;

            EstiloGridPrincipal();

            EstiloGridDetalles();

            CargarAlquileres();

            AplicarPermisos();


        }



        private void CrearTablaDetalles()
        {
            detalles.Columns.Add("Id_Vehiculo");
            detalles.Columns.Add("Vehiculo");
            detalles.Columns.Add("Fecha_Entrega");
            detalles.Columns.Add("Precio_Dia");
            detalles.Columns.Add("Dias");
            detalles.Columns.Add("Subtotal");
            detalles.Columns.Add("Kilometraje");
            detalles.Columns.Add("Combustible");
            detalles.Columns.Add("Estado_Salida");

            dgvDetalles.DataSource = detalles;
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow fila in detalles.Rows)
                {
                    if (fila["Id_Vehiculo"].ToString() ==
                        txtIdVehiculo.Text)
                    {
                        MessageBox.Show(
                            "Este vehículo ya fue agregado.");
                        return;
                    }
                }

                decimal precio =
                    Convert.ToDecimal(txtPrecioDia.Text);

                int dias =
                    Convert.ToInt32(txtDias.Text);

                decimal subtotal =
                    precio * dias;

                txtSubtotal.Text =
                    subtotal.ToString();

                detalles.Rows.Add(
                    txtIdVehiculo.Text,
                    txtVehiculo.Text,
                    dtpFechaEntrega.Value.ToShortDateString(),
                    txtPrecioDia.Text,
                    txtDias.Text,
                    subtotal,
                    txtKilometrajeSalida.Text,
                    cbCombustible.Text,
                    cbEstadoSalida.Text
                );

                LimpiarDetalle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al agregar vehículo: " +
                    ex.Message);
            }

        }


        private void LimpiarDetalle()
        {
            txtIdVehiculo.Clear();
            txtVehiculo.Clear();
            txtPrecioDia.Clear();
            txtDias.Value = 0;
            txtSubtotal.Clear();
            txtKilometrajeSalida.Clear();

            cbCombustible.SelectedIndex = -1;
            cbEstadoSalida.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (detalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar vehículos.");
                return;
            }

            Alquileres alquiler = new Alquileres();

            alquiler.Id_Cliente = Convert.ToInt32(cbCliente.SelectedValue);

            alquiler.Id_Usuario = Sesion.IdUsuario;

            alquiler.Fecha_Inicio = dtpFechaInicio.Value;

            alquiler.Estado_Alquiler = "Activo";

            int idAlquiler = alquilerBL.InsertarAlquiler(alquiler);

            foreach (DataRow fila in detalles.Rows)
            {
                DetalleAlquileres detalle = new DetalleAlquileres();

                detalle.Id_Alquiler = idAlquiler;

                detalle.Id_Vehiculo =
                    Convert.ToInt32(fila["Id_Vehiculo"]);

                detalle.Fecha_Entrega_Esperada =
                    Convert.ToDateTime(fila["Fecha_Entrega"]);

                detalle.Precio_Dia =
                    Convert.ToDecimal(fila["Precio_Dia"]);

                detalle.Dias_Alquilados =
                    Convert.ToInt32(fila["Dias"]);

                detalle.Subtotal =
                    Convert.ToDecimal(fila["Subtotal"]);

                detalle.Kilometraje_Salida =
                    Convert.ToInt32(fila["Kilometraje"]);

                detalle.Combustible_Salida =
                    fila["Combustible"].ToString();

                detalle.Estado_Salida =
                    fila["Estado_Salida"].ToString();

                detalle.Estado = "Alquilado";

                detalleBL.Insertar(detalle);

                vehiculoBL.ActualizarEstadoVehiculo(
                    detalle.Id_Vehiculo,
                    "Alquilado"
                );
            }

            MessageBox.Show("Alquiler guardado correctamente.");

            CargarAlquileres();

            btnNuevoAlquiler.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar alquiler: " +
                    ex.Message);

            }
        }

        private void btnQuitarVehiculo_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.CurrentRow != null)
            {
                dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);
            }
        }

        private void btnNuevoAlquiler_Click(object sender, EventArgs e)
        {
            cbCliente.SelectedIndex = -1;

            detalles.Rows.Clear();

            LimpiarDetalle();

            dtpFechaInicio.Value = DateTime.Now;

            dtpFechaEntrega.Value = DateTime.Now;

            txtSubtotal.Clear();
        }


        private void CalcularFechaEntrega()
        {
            int dias = Convert.ToInt32(txtDias.Value);

            dtpFechaEntrega.Value =
                dtpFechaInicio.Value.AddDays(dias);
        }

        private void CalcularSubtotal()
        {
            decimal precio = 0;

            decimal.TryParse(txtPrecioDia.Text, out precio);

            int dias = Convert.ToInt32(txtDias.Value);

            decimal subtotal = precio * dias;

            txtSubtotal.Text = subtotal.ToString("N2");
        }

        private void btnSeleccionarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                FormSeleccionarVehiculo frm =
                    new FormSeleccionarVehiculo();

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txtIdVehiculo.Text =
                        frm.IdVehiculo.ToString();

                    txtVehiculo.Text =
                        frm.Vehiculo;

                    txtPrecioDia.Text =
                        frm.PrecioDia.ToString();

                    CalcularSubtotal();
                    CalcularFechaEntrega();

                    txtKilometrajeSalida.Text =
                        frm.Kilometraje.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al seleccionar vehículo: " +
                    ex.Message);
            }
        }

        private void txtIdVehiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDias_ValueChanged(object sender, EventArgs e)
        {
            CalcularFechaEntrega();

            CalcularSubtotal();
        }


        private void CargarAlquileres()
        {
            try
            {
                dgvAlquileres.DataSource = alquilerBL.Listar();

                // Ocultar IDs
                dgvAlquileres.Columns["Id_Alquiler"].Visible = false;
                dgvAlquileres.Columns["Id_Cliente"].Visible = false;

                // Tamaños de columnas
                dgvAlquileres.Columns["Cliente"].FillWeight = 180;
                dgvAlquileres.Columns["Usuario"].FillWeight = 120;
                dgvAlquileres.Columns["Estado_Alquiler"].FillWeight = 90;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar alquileres: " + ex.Message);
            }
        }

        private void AbrirFormulario(Form formulario)
        {
            formulario.Show();
            this.Hide();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmMenuPrincipal());
        }

        private void lblClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormClientes());
        }

        private void lblVehiculos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormVehiculos());
        }

        private void lblAlquileres_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormAlquileres());
        }

        private void label11_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Menu_FacturaAlquiler());

        }

        private void lblPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPagos());
        }

        private void lblEntrega_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEntregaVehiculo());
        }

        private void lblAdicionales_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormCargosAdicionales());
        }

        private void lblUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormUsuarios());
        }

        private void lblRoles_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormRoles());
        }

        private void lblBackups_Click(object sender, EventArgs e)
        {
            FormBackup frm = new FormBackup();

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();

        }



        
        private void dgvAlquileres_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvAlquileres.CurrentRow == null)
                    return;

                int idAlquiler = Convert.ToInt32(
                    dgvAlquileres.CurrentRow.Cells["Id_Alquiler"].Value);

                CargarDetalleAlquiler(idAlquiler);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalle: " + ex.Message);
            }
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlquileres.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un alquiler.");
                    return;
                }

                int idAlquiler = Convert.ToInt32(
                    dgvAlquileres.CurrentRow.Cells["Id_Alquiler"].Value);

                FrmFacturaAlquiler frm =
                    new FrmFacturaAlquiler(idAlquiler);

                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar reporte: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvAlquileres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label23_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmMenuPrincipal());

        }

        private void lblEntrega_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEntregaVehiculo());

        }

        private void lblAdicionales_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormCargosAdicionales());

        }

        private void lblPagos_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPagos());
        }

        private void label7_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Menu_FacturaAlquiler());
        }

        private void lblReportes_Click(object sender, EventArgs e)
        {
            FormReportes frm = new FormReportes();

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }

        private void lblUsuarios_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormUsuarios());
        }

        private void lblRoles_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormRoles());
        }

        private void lblBackups_Click_1(object sender, EventArgs e)
        {
            FormBackup frm = new FormBackup();

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }

        private void lblClientes_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormClientes());

        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Deseas cerrar sesión?",
                 "Cerrar Sesión",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Sesion.IdUsuario = 0;
                Sesion.Nombre = "";
                Sesion.Rol = "";

                FormLogin login = new FormLogin();
                login.Show();

                this.Close();
            }
        }

        private void CargarClientes()
        {
            try
            {
                cbCliente.DataSource = clienteBL.Listar();

                cbCliente.DisplayMember = "Cliente"; // o "Nombre" si aún no has creado Cliente
                cbCliente.ValueMember = "Id_Cliente";

                if (cbCliente.Items.Count > 0)
                {
                    cbCliente.SelectedIndex =
                        cbCliente.Items.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar clientes: " +
                    ex.Message);
            }
        }

        private void lblCerrarSesion_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
      "¿Deseas cerrar sesión?",
      "Cerrar Sesión",
      MessageBoxButtons.YesNo,
      MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Sesion.IdUsuario = 0;
                Sesion.Nombre = "";
                Sesion.Rol = "";

                FormLogin login = new FormLogin();
                login.Show();

                this.Close();
            }
        }
    }
}
