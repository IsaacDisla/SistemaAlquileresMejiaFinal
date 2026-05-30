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
    public partial class FormVehiculos : Form
    {
        VehiculosBL bl = new VehiculosBL();
        Vehiculos vehiculoSeleccionado = new Vehiculos();
        public FormVehiculos()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

        }

        private void FormVehiculos_Load(object sender, EventArgs e)
        {
            cbEstado.Items.Add("Disponible");
            cbEstado.Items.Add("Alquilado");
            cbEstado.Items.Add("Mantenimiento");

            ListarVehiculos();

            lblUsuario.Text = Sesion.Nombre;

            lblRol.Text = Sesion.Rol;

        }



        private void lblClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Menu_FacturaAlquiler());
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

        private void ListarVehiculos()
        {
            dgvVehiculos.DataSource = bl.Listar();
        }

        private void lblVehiculos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEntregaVehiculo());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Vehiculos v = new Vehiculos();

            v.Marca = txtMarca.Text;
            v.Modelo = txtModelo.Text;
            v.Año = Convert.ToInt32(txtAño.Text);
            v.Placa = txtPlaca.Text;
            v.Color = txtColor.Text;
            v.Kilometraje = Convert.ToInt32(txtKilometraje.Text);
            v.Precio_Dia = Convert.ToDecimal(txtPrecioDia.Text);
            v.Estado_Vehiculo = cbEstado.Text;

            bl.Insertar(v);

            MessageBox.Show("Vehículo guardado correctamente");

            Nuevo();
            ListarVehiculos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (vehiculoSeleccionado.Id_Vehiculo == 0)
            {
                MessageBox.Show("Seleccione un vehículo");
                return;
            }

            vehiculoSeleccionado.Marca = txtMarca.Text;
            vehiculoSeleccionado.Modelo = txtModelo.Text;
            vehiculoSeleccionado.Año = Convert.ToInt32(txtAño.Text);
            vehiculoSeleccionado.Placa = txtPlaca.Text;
            vehiculoSeleccionado.Color = txtColor.Text;
            vehiculoSeleccionado.Kilometraje = Convert.ToInt32(txtKilometraje.Text);
            vehiculoSeleccionado.Precio_Dia = Convert.ToDecimal(txtPrecioDia.Text);
            vehiculoSeleccionado.Estado_Vehiculo = cbEstado.Text;

            bl.Actualizar(vehiculoSeleccionado);

            MessageBox.Show("Vehículo actualizado correctamente");

            Nuevo();
            ListarVehiculos();
        }

        private void dgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                vehiculoSeleccionado.Id_Vehiculo = Convert.ToInt32(dgvVehiculos.Rows[e.RowIndex].Cells["Id_Vehiculo"].Value);

                txtMarca.Text = dgvVehiculos.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
                txtModelo.Text = dgvVehiculos.Rows[e.RowIndex].Cells["Modelo"].Value.ToString();
                txtAño.Text = dgvVehiculos.Rows[e.RowIndex].Cells["Año"].Value.ToString();
                txtPlaca.Text = dgvVehiculos.Rows[e.RowIndex].Cells["Placa"].Value.ToString();
                txtColor.Text = dgvVehiculos.Rows[e.RowIndex].Cells["Color"].Value.ToString();
                txtKilometraje.Text = dgvVehiculos.Rows[e.RowIndex].Cells["Kilometraje"].Value.ToString();
                txtPrecioDia.Text = dgvVehiculos.Rows[e.RowIndex].Cells["Precio_Dia"].Value.ToString();
                cbEstado.Text = dgvVehiculos.Rows[e.RowIndex].Cells["Estado_Vehiculo"].Value.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();

        }

        private void Nuevo()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtAño.Clear();
            txtPlaca.Clear();
            txtColor.Clear();
            txtKilometraje.Clear();
            txtPrecioDia.Clear();

            cbEstado.SelectedIndex = -1;

            vehiculoSeleccionado = new Vehiculos();
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvVehiculos.DataSource = bl.Buscar(txtBuscar.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Menu_FacturaAlquiler());

        }

        private void lblPagos_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPagos());
        }

        private void label23_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmMenuPrincipal());

        }

        private void lblClientes_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormClientes());
        }

        private void lblVehiculos_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormVehiculos());
        }

        private void lblAlquileres_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormAlquileres());

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
    }
}
