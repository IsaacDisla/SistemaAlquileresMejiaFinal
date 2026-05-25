using Capa.Entidades;
using Capa.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.Presentacion
{
    public partial class FormAlquileres : Form
    {
        AlquileresBL alquilerBLL = new AlquileresBL();
        ClientesBL clientesBL = new ClientesBL();
        DetalleAlquileresBL detalleBLL = new DetalleAlquileresBL();


        int idAlquiler = 0;
        int idVehiculo = 0;

        public FormAlquileres()
        {
            InitializeComponent();
        }

        private void FormAlquileres_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarEstados();
            CargarAlquileres();

            dtpFechaInicio.Value = DateTime.Now;
            lblUsuario.Text = "Usuario:";

            txtSubtotal.ReadOnly = true;
            txtVehiculo.ReadOnly = true;
            txtPrecioDia.ReadOnly = true;
            txtKilometrajeSalida.ReadOnly = true;

            CargarDetalleAlquileres();

            lblUsuario.Text = Sesion.Nombre;
            lblRol.Text = Sesion.Rol;
        }

        private void AbrirFormulario(Form formulario)
        {
            formulario.Show();
            this.Hide();
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.Yellow;
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.White;
        }


        private void CargarDetalleAlquileres()
        {
            dgvDetalleAlquiler.DataSource = detalleBLL.Listar();
        }

        private void CargarClientes()
        {
            cbCliente.DataSource = clientesBL.Listar();
            cbCliente.DisplayMember = "Cliente";
            cbCliente.ValueMember = "Id_Cliente";

            if (cbCliente.Items.Count > 0)
            {
                cbCliente.SelectedIndex = cbCliente.Items.Count - 1;
            }
        }

        private void CargarEstados()
        {
            cbEstadoAlquiler.Items.Clear();
            cbEstadoAlquiler.Items.Add("Activo");
            cbEstadoAlquiler.Items.Add("Finalizado");
            cbEstadoAlquiler.Items.Add("Cancelado");
            cbEstadoAlquiler.SelectedIndex = 0;

            cbCombustibleSalida.Items.Clear();
            cbCombustibleSalida.Items.Add("Lleno");
            cbCombustibleSalida.Items.Add("Medio");
            cbCombustibleSalida.Items.Add("Bajo");
            cbCombustibleSalida.Items.Add("Vacío");
            cbCombustibleSalida.SelectedIndex = 0;

            cbEstadoSalida.Items.Clear();
            cbEstadoSalida.Items.Add("Bueno");
            cbEstadoSalida.Items.Add("Regular");
            cbEstadoSalida.Items.Add("Dañado");
            cbEstadoSalida.SelectedIndex = 0;

            cbEstadoDetalle.Items.Clear();
            cbEstadoDetalle.Items.Add("Activo");
            cbEstadoDetalle.Items.Add("Finalizado");
            cbEstadoDetalle.Items.Add("Cancelado");
            cbEstadoDetalle.SelectedIndex = 0;
        }

        private void CargarAlquileres()
        {
            dgvAlquileres.DataSource = alquilerBLL.Listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Alquileres a = new Alquileres();

            a.Id_Cliente = Convert.ToInt32(cbCliente.SelectedValue);
            a.Id_Usuario = 1;
            a.Fecha_Inicio = dtpFechaInicio.Value;
            a.Estado_Alquiler = cbEstadoAlquiler.Text;

            alquilerBLL.Insertar(a);

            MessageBox.Show("Alquiler registrado correctamente");

            CargarAlquileres();
            Limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idAlquiler == 0)
            {
                MessageBox.Show("Seleccione un alquiler del listado");
                return;
            }
            Alquileres a = new Alquileres();

            a.Id_Alquiler = idAlquiler;
            a.Id_Cliente = Convert.ToInt32(cbCliente.SelectedValue);
            a.Id_Usuario = 1; // Temporal
            a.Fecha_Inicio = dtpFechaInicio.Value;
            a.Estado_Alquiler = cbEstadoAlquiler.Text;

            alquilerBLL.Actualizar(a);

            MessageBox.Show("Alquiler actualizado correctamente");

            CargarAlquileres();
            Limpiar();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void dgvAlquileres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idAlquiler = Convert.ToInt32(
                    dgvAlquileres.Rows[e.RowIndex].Cells["Id_Alquiler"].Value
                );

                cbCliente.SelectedValue = Convert.ToInt32(
                    dgvAlquileres.Rows[e.RowIndex].Cells["Id_Cliente"].Value
                );

                dtpFechaInicio.Value = Convert.ToDateTime(
                    dgvAlquileres.Rows[e.RowIndex].Cells["Fecha_Inicio"].Value
                );

                cbEstadoAlquiler.Text =
                    dgvAlquileres.Rows[e.RowIndex].Cells["Estado_Alquiler"].Value.ToString();
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSeleccionarVehiculo_Click(object sender, EventArgs e)
        {
            FormSeleccionarVehiculo frm = new FormSeleccionarVehiculo();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                idVehiculo = frm.IdVehiculo;

                txtVehiculo.Text = frm.Vehiculo;
                txtPrecioDia.Text = frm.PrecioDia.ToString();
                txtKilometrajeSalida.Text = frm.Kilometraje.ToString();

                CalcularSubtotal();
            }
        }

        private void txtDiasAlquilados_TextChanged(object sender, EventArgs e)
        {
            CalcularSubtotal();
        }

        private void CalcularSubtotal()
        {
            if (decimal.TryParse(txtPrecioDia.Text, out decimal precio) &&
                int.TryParse(txtDiasAlquilados.Text, out int dias))
            {
                txtSubtotal.Text = (precio * dias).ToString("0.00");
            }
            else
            {
                txtSubtotal.Text = "0.00";
            }
        }

        private int ObtenerUltimoAlquiler()
        {
            DataTable dt = alquilerBLL.Listar();

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[dt.Rows.Count - 1]["Id_Alquiler"]);
            }

            return 0;
        }

        private void btnGuardarAlquiler_Click(object sender, EventArgs e)
        {
            if (idVehiculo == 0)
            {
                MessageBox.Show("Debe seleccionar un vehículo");
                return;
            }

            if (txtDiasAlquilados.Text == "")
            {
                MessageBox.Show("Debe colocar los días alquilados");
                return;
            }

            Alquileres alquiler = new Alquileres();

            alquiler.Id_Cliente = Convert.ToInt32(cbCliente.SelectedValue);
            alquiler.Id_Usuario = Sesion.IdUsuario;
            alquiler.Fecha_Inicio = dtpFechaInicio.Value;
            alquiler.Estado_Alquiler = cbEstadoAlquiler.Text;

            alquilerBLL.Insertar(alquiler);
            idAlquiler = ObtenerUltimoAlquiler();

            DetalleAlquileres detalle = new DetalleAlquileres();

            detalle.Id_Alquiler = idAlquiler;
            detalle.Id_Vehiculo = idVehiculo;
            detalle.Fecha_Entrega_Esperada = dtpFechaEntregaEsperada.Value;
            detalle.Precio_Dia = Convert.ToDecimal(txtPrecioDia.Text);
            detalle.Dias_Alquilados = Convert.ToInt32(txtDiasAlquilados.Text);
            detalle.Subtotal = Convert.ToDecimal(txtSubtotal.Text);
            detalle.Kilometraje_Salida = Convert.ToInt32(txtKilometrajeSalida.Text);
            detalle.Combustible_Salida = cbCombustibleSalida.Text;
            detalle.Estado_Salida = cbEstadoSalida.Text;
            detalle.Estado = cbEstadoDetalle.Text;


            detalleBLL.Insertar(detalle);

            detalleBLL.Insertar(detalle);

            MessageBox.Show("Alquiler registrado correctamente");

            Limpiar();
        }

        private void Limpiar()
        {
            idAlquiler = 0;
            idVehiculo = 0;

            if (cbCliente.Items.Count > 0)
                cbCliente.SelectedIndex = cbCliente.Items.Count - 1;

            cbEstadoAlquiler.SelectedIndex = 0;
            cbCombustibleSalida.SelectedIndex = 0;
            cbEstadoSalida.SelectedIndex = 0;
            cbEstadoDetalle.SelectedIndex = 0;

            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaEntregaEsperada.Value = DateTime.Now;

            txtVehiculo.Clear();
            txtPrecioDia.Clear();
            txtDiasAlquilados.Clear();
            txtSubtotal.Clear();
            txtKilometrajeSalida.Clear();
        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRol_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cbEstadoSalida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbEstadoDetalle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCombustibleSalida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaEntregaEsperada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtKilometrajeSalida_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioDia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVehiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbEstadoAlquiler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblVehiculos_Click(object sender, EventArgs e)
        {

        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmMenuPrincipal());

        }
    }
}
