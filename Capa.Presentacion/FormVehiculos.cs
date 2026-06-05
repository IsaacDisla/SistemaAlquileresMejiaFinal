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
        private void EstiloGridVehiculos()
        {
            dgvVehiculos.BorderStyle = BorderStyle.None;
            dgvVehiculos.BackgroundColor = Color.White;

            dgvVehiculos.EnableHeadersVisualStyles = false;

            dgvVehiculos.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgvVehiculos.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 0, 102);

            dgvVehiculos.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvVehiculos.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI Semibold", 12, FontStyle.Bold);

            dgvVehiculos.ColumnHeadersHeight = 45;

            dgvVehiculos.DefaultCellStyle.BackColor =
                Color.White;

            dgvVehiculos.DefaultCellStyle.ForeColor =
                Color.Black;

            dgvVehiculos.DefaultCellStyle.Font =
                new Font("Segoe UI", 11);

            dgvVehiculos.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(65, 105, 225);

            dgvVehiculos.DefaultCellStyle.SelectionForeColor =
                Color.White;

            dgvVehiculos.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            dgvVehiculos.GridColor =
                Color.LightGray;

            dgvVehiculos.RowTemplate.Height = 35;

            dgvVehiculos.RowHeadersVisible = false;

            dgvVehiculos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvVehiculos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvVehiculos.MultiSelect = false;

            dgvVehiculos.AllowUserToAddRows = false;

            dgvVehiculos.AllowUserToDeleteRows = false;

            dgvVehiculos.AllowUserToResizeRows = false;

            dgvVehiculos.ReadOnly = true;
        }

        private void FormVehiculos_Load(object sender, EventArgs e)
        {
            EstiloGridVehiculos();

            cbEstado.Items.Add("Disponible");
            cbEstado.Items.Add("Alquilado");
            cbEstado.Items.Add("Mantenimiento");

            ListarVehiculos();

            dgvVehiculos.Columns["Id_Vehiculo"].Visible = false;

            lblUsuario.Text = Sesion.Nombre;
            lblRol.Text = Sesion.Rol;

            AplicarPermisos();

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

        private void dgvVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            vehiculoSeleccionado.Id_Vehiculo =
                Convert.ToInt32(
                dgvVehiculos.Rows[e.RowIndex]
                .Cells["Id_Vehiculo"].Value);

            txtMarca.Text =
                dgvVehiculos.Rows[e.RowIndex]
                .Cells["Marca"].Value.ToString();

            txtModelo.Text =
                dgvVehiculos.Rows[e.RowIndex]
                .Cells["Modelo"].Value.ToString();

            txtAño.Text =
                dgvVehiculos.Rows[e.RowIndex]
                .Cells["Año"].Value.ToString();

            txtPlaca.Text =
                dgvVehiculos.Rows[e.RowIndex]
                .Cells["Placa"].Value.ToString();

            txtColor.Text =
                dgvVehiculos.Rows[e.RowIndex]
                .Cells["Color"].Value.ToString();

            txtKilometraje.Text =
                dgvVehiculos.Rows[e.RowIndex]
                .Cells["Kilometraje"].Value.ToString();

            txtPrecioDia.Text =
                dgvVehiculos.Rows[e.RowIndex]
                .Cells["Precio_Dia"].Value.ToString();

            cbEstado.Text =
                dgvVehiculos.Rows[e.RowIndex]
                .Cells["Estado_Vehiculo"].Value.ToString();
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

        private void lblAlquileres_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormAlquileres());

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (vehiculoSeleccionado.Id_Vehiculo == 0)
                {
                    MessageBox.Show("Seleccione un vehículo.");
                    return;
                }

                DialogResult r = MessageBox.Show(
                    "¿Desea eliminar este vehículo?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    bl.Eliminar(vehiculoSeleccionado.Id_Vehiculo);

                    MessageBox.Show(
                        "Vehículo eliminado correctamente.");

                    Nuevo();
                    ListarVehiculos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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

        private void lblClientes_Click_2(object sender, EventArgs e)
        {
            AbrirFormulario(new FormClientes());

        }

        private void lblEntrega_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEntregaVehiculo());

        }

        private void lblAdicionales_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormCargosAdicionales());

        }

        private void lblPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPagos());

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new Menu_FacturaAlquiler());

        }
    }
    }

