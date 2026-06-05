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

        private void EstiloGridClientes()
        {
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.BackgroundColor = Color.White;

            dgvClientes.EnableHeadersVisualStyles = false;

            dgvClientes.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgvClientes.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 0, 102);

            dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvClientes.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI Semibold", 12, FontStyle.Bold);

            dgvClientes.ColumnHeadersHeight = 45;

            dgvClientes.DefaultCellStyle.BackColor =
                Color.White;

            dgvClientes.DefaultCellStyle.ForeColor =
                Color.Black;

            dgvClientes.DefaultCellStyle.Font =
                new Font("Segoe UI", 11);

            dgvClientes.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(65, 105, 225);

            dgvClientes.DefaultCellStyle.SelectionForeColor =
                Color.White;

            dgvClientes.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            dgvClientes.GridColor =
                Color.LightGray;

            dgvClientes.RowTemplate.Height = 35;

            dgvClientes.RowHeadersVisible = false;

            dgvClientes.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvClientes.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvClientes.MultiSelect = false;

            dgvClientes.AllowUserToAddRows = false;

            dgvClientes.AllowUserToDeleteRows = false;

            dgvClientes.AllowUserToResizeRows = false;

            dgvClientes.ReadOnly = true;
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            try
            {
                EstiloGridClientes();
                ListarClientes();

                dgvClientes.Columns["Estado"].Visible = false;
                dgvClientes.Columns["Id_Cliente"].Visible = false;

                lblUsuario.Text = Sesion.Nombre;
                lblRol.Text = Sesion.Rol;

                AplicarPermisos();

                txtBuscar.Text = "Buscar";
                txtBuscar.ForeColor = Color.Gray;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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
            try
            {
                Clientes c = new Clientes
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Cedula = txtCedula.Text,
                    Telefono = txtTelefono.Text,
                    Licencia = txtLicencia.Text,
                    Nombre_Garante = txtNombreGarante.Text,
                    Telefono_Garante = txtTelefonoGarante.Text
                };

                bl.Insertar(c);

                MessageBox.Show("Cliente guardado correctamente");

                Nuevo();
                ListarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cliente\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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
            try
            {
                if (txtBuscar.Text == "Buscar" || string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    ListarClientes();
                    return;
                }

                dgvClientes.DataSource = bl.Buscar(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar clientes\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

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

        private void label2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Menu_FacturaAlquiler());

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

        private void lblReportes_Click(object sender, EventArgs e)
        {
            FormReportes frm = new FormReportes();

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteSeleccionado.Id_Cliente == 0)
                {
                    MessageBox.Show("Seleccione un cliente.");
                    return;
                }

                DialogResult r = MessageBox.Show(
                    "¿Desea eliminar este cliente?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    bl.Eliminar(clienteSeleccionado.Id_Cliente);

                    clienteSeleccionado = new Clientes();

                    txtBuscar.Text = "Buscar";
                    txtBuscar.ForeColor = Color.Gray;

                    ListarClientes();

                    MessageBox.Show("Cliente eliminado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cliente\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lblUsuarios_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormUsuarios());

        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Buscar";
                txtBuscar.ForeColor = Color.Gray;

                ListarClientes();
            }
        }
    }
    }

