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
    public partial class FormClientes : Form
    {
        ClientesBL bl = new ClientesBL();
        Clientes clienteSeleccionado = new Clientes();



        public FormClientes()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            ListarClientes();

            dgvClientes.Columns["Estado"].Visible = false;

            lblUsuario.Text = Sesion.Nombre;

            lblRol.Text = Sesion.Rol;
        }

        private void ListarClientes()
        {
            dgvClientes.DataSource = bl.Listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();

            c.Nombre = txtNombre.Text;
            c.Apellido = txtApellido.Text;
            c.Cedula = txtCedula.Text;
            c.Telefono = txtTelefono.Text;
            c.Licencia = txtLicencia.Text;
            c.Nombre_Garante = txtNombreGarante.Text;
            c.Telefono_Garante = txtTelefonoGarante.Text;

            bl.Insertar(c);

            MessageBox.Show("Cliente guardado correctamente");

            Nuevo();
            ListarClientes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado.Id_Cliente == 0)
            {
                MessageBox.Show("Seleccione un cliente");
                return;
            }

            clienteSeleccionado.Nombre = txtNombre.Text;
            clienteSeleccionado.Apellido = txtApellido.Text;
            clienteSeleccionado.Cedula = txtCedula.Text;
            clienteSeleccionado.Telefono = txtTelefono.Text;
            clienteSeleccionado.Licencia = txtLicencia.Text;
            clienteSeleccionado.Nombre_Garante = txtNombreGarante.Text;
            clienteSeleccionado.Telefono_Garante = txtTelefonoGarante.Text;

            bl.Actualizar(clienteSeleccionado);

            MessageBox.Show("Cliente actualizado correctamente");

            Nuevo();
            ListarClientes();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                clienteSeleccionado.Id_Cliente = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["Id_Cliente"].Value);

                txtNombre.Text = dgvClientes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvClientes.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                txtCedula.Text = dgvClientes.Rows[e.RowIndex].Cells["Cedula"].Value.ToString();
                txtTelefono.Text = dgvClientes.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                txtLicencia.Text = dgvClientes.Rows[e.RowIndex].Cells["Licencia"].Value.ToString();
                txtNombreGarante.Text = dgvClientes.Rows[e.RowIndex].Cells["Nombre_Garante"].Value.ToString();
                txtTelefonoGarante.Text = dgvClientes.Rows[e.RowIndex].Cells["Telefono_Garante"].Value.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        private void Nuevo()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            txtLicencia.Clear();
            txtNombreGarante.Clear();
            txtTelefonoGarante.Clear();

            clienteSeleccionado = new Clientes();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefonoGarante_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvClientes.DataSource = bl.Buscar(txtBuscar.Text);
        }

        private void AbrirFormulario(Form formulario)
        {
            formulario.Show();
            this.Hide();
        }


        private void lblClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormClientes());
        }

        private void lblVehiculos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormVehiculos());

        }

        private void lblBackups_Click(object sender, EventArgs e)
        {
            FormBackup frm = new FormBackup();

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();

        }

        private void label23_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmMenuPrincipal());
        }

        private void label17_Click(object sender, EventArgs e)
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
    }
}

