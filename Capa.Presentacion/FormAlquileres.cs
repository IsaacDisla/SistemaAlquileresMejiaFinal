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

        private void CargarAlquileres()
        {
            dgvAlquileres.DataSource = alquilerBL.Listar();

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

            CargarAlquileres();

 

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
            foreach (DataRow fila in detalles.Rows)
            {
                if (fila["Id_Vehiculo"].ToString() == txtIdVehiculo.Text)
                {
                    MessageBox.Show("Este vehículo ya fue agregado.");
                    return;
                }
            }

            decimal precio = Convert.ToDecimal(txtPrecioDia.Text);
            int dias = Convert.ToInt32(txtDias.Text);

            decimal subtotal = precio * dias;

            txtSubtotal.Text = subtotal.ToString();

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

        private void CargarClientes()
        {
            cbCliente.DataSource = clienteBL.Listar();

            cbCliente.DisplayMember = "Nombre";

            cbCliente.ValueMember = "Id_Cliente";

            cbCliente.SelectedIndex = -1;

            if (cbCliente.Items.Count > 0)
            {
                cbCliente.SelectedIndex =
                    cbCliente.Items.Count - 1;
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
            int idAlquiler = Convert.ToInt32(
      dgvAlquileres.CurrentRow.Cells["Id_Alquiler"].Value);

            FrmFacturaAlquiler frm =
                new FrmFacturaAlquiler(idAlquiler);

            frm.ShowDialog();
        }

        private void btnFactura_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
