using System;
using Capa.Entidades;
using Capa.Negocios;
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
    public partial class FormCargosAdicionales : Form
    {
        CargosAdicionalesBL bl = new CargosAdicionalesBL();

        private int idCargoSeleccionado = 0;

        private int idDetalleSeleccionado = 0;
        public FormCargosAdicionales()
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

        private void EstiloGridCargos()
        {
            dgvCargos.BorderStyle = BorderStyle.None;
            dgvCargos.BackgroundColor = Color.White;

            dgvCargos.EnableHeadersVisualStyles = false;

            dgvCargos.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgvCargos.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 0, 102);

            dgvCargos.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvCargos.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI Semibold", 12, FontStyle.Bold);

            dgvCargos.ColumnHeadersHeight = 45;

            dgvCargos.DefaultCellStyle.BackColor =
                Color.White;

            dgvCargos.DefaultCellStyle.ForeColor =
                Color.Black;

            dgvCargos.DefaultCellStyle.Font =
                new Font("Segoe UI", 11);

            dgvCargos.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(65, 105, 225);

            dgvCargos.DefaultCellStyle.SelectionForeColor =
                Color.White;

            dgvCargos.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            dgvCargos.GridColor =
                Color.LightGray;

            dgvCargos.RowTemplate.Height = 35;

            dgvCargos.RowHeadersVisible = false;

            dgvCargos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvCargos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvCargos.MultiSelect = false;

            dgvCargos.AllowUserToAddRows = false;

            dgvCargos.AllowUserToDeleteRows = false;

            dgvCargos.AllowUserToResizeRows = false;

            dgvCargos.ReadOnly = true;
        }

        public void CargarDetalle(int idDetalle,
                           string cliente,
                           string vehiculo,
                           string estado)
        {
            idDetalleSeleccionado = idDetalle;

            txtCliente.Text = cliente;
            txtVehiculo.Text = vehiculo;
            txtEstadoAlquiler.Text = estado;
        }
        private void FormCargosAdicionales_Load(object sender, EventArgs e)
        {
            EstiloGridCargos();

            lblUsuario.Text = Sesion.Nombre;

            lblRol.Text = Sesion.Rol;

            cbTipoCargo.Items.Clear();

            cbTipoCargo.Items.Add("Daño");
            cbTipoCargo.Items.Add("Limpieza");
            cbTipoCargo.Items.Add("Combustible");
            cbTipoCargo.Items.Add("Multa");
            cbTipoCargo.Items.Add("Retraso");
            cbTipoCargo.Items.Add("Otro");

            CargarCargos();

            if (dgvCargos.Columns.Contains("Id_Cargo"))
            {
                dgvCargos.Columns["Id_Cargo"].Visible = false;
            }

            if (dgvCargos.Columns.Contains("Id_Detalle"))
            {
                dgvCargos.Columns["Id_Detalle"].Visible = false;
            }

            txtCliente.ReadOnly = true;
            txtVehiculo.ReadOnly = true;
            txtEstadoAlquiler.ReadOnly = true;

            AplicarPermisos();

        }

        private void AbrirFormulario(Form formulario)
        {
            formulario.Show();
            this.Hide();
        }


        private void CargarCargos()
        {
            dgvCargos.DataSource = null;
            dgvCargos.DataSource =
                bl.ListarCargosAdicionales();

        }

        private void btnBuscarDetalle_Click(object sender, EventArgs e)
        {
            FormBuscarDetalless frm = new FormBuscarDetalless();

            frm.Owner = this;

            frm.ShowDialog();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                CargosAdicionales cargo = new CargosAdicionales();

                cargo.Id_Detalle = idDetalleSeleccionado;
                cargo.Fecha = dtpFecha.Value;
                cargo.Descripcion = cbTipoCargo.Text + " - " +
                                    txtDescripcion.Text.Trim();
                cargo.Monto = Convert.ToDecimal(txtMonto.Text);

                bl.InsertarCargoAdicional(cargo);

                CargarCargos();

                MessageBox.Show("Cargo agregado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                btnNuevo.PerformClick();
            }
            catch (FormatException)
            {
                MessageBox.Show("El monto tiene un formato incorrecto.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cargo.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idDetalleSeleccionado = 0;
            txtCliente.Clear();
            txtVehiculo.Clear();
            txtEstadoAlquiler.Clear();

            txtDescripcion.Clear();
            txtMonto.Clear();

            cbTipoCargo.SelectedIndex = -1;

            dtpFecha.Value = DateTime.Now;
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            /*holi*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPagos());
        }

        private void lblEntrega_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEntregaVehiculo());

        }

        private void lblAlquileres_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormAlquileres());

        }

        private void lblVehiculos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormVehiculos());
        }

        private void lblUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormUsuarios());

        }

        private void lblRoles_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormRoles());

        }

        private void lblReportes_Click(object sender, EventArgs e)
        {
            FormReportes frm = new FormReportes();

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }

        private void lblBackups_Click(object sender, EventArgs e)
        {
            FormBackup frm = new FormBackup();

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }

        private void dgvCargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void lblClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormClientes());

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idCargoSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione un cargo para actualizar.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidarCampos())
                    return;

                CargosAdicionales cargo = new CargosAdicionales();

                cargo.Id_Cargo = idCargoSeleccionado;
                cargo.Id_Detalle = idDetalleSeleccionado;
                cargo.Fecha = dtpFecha.Value;
                cargo.Descripcion = cbTipoCargo.Text + " - " +
                                    txtDescripcion.Text.Trim();
                cargo.Monto = Convert.ToDecimal(txtMonto.Text);

                bl.ActualizarCargoAdicional(cargo);

                CargarCargos();

                if (dgvCargos.Columns.Contains("Id_Cargo"))
                    dgvCargos.Columns["Id_Cargo"].Visible = false;

                if (dgvCargos.Columns.Contains("Id_Detalle"))
                    dgvCargos.Columns["Id_Detalle"].Visible = false;

                btnNuevo.PerformClick();

                dgvCargos.ClearSelection();

                MessageBox.Show("Cargo actualizado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("El monto tiene un formato incorrecto.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cargo.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvCargos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dgvCargos_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCargos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCargos_CellDoubleClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCargos.CurrentRow == null)
                return;

            idCargoSeleccionado = Convert.ToInt32(
                dgvCargos.CurrentRow.Cells["Id_Cargo"].Value);

            idDetalleSeleccionado = Convert.ToInt32(
                dgvCargos.CurrentRow.Cells["Id_Detalle"].Value);

            dtpFecha.Value = Convert.ToDateTime(
                dgvCargos.CurrentRow.Cells["Fecha"].Value);

            txtVehiculo.Text =
                dgvCargos.CurrentRow.Cells["Vehiculo"].Value.ToString();

            txtMonto.Text =
                dgvCargos.CurrentRow.Cells["Monto"].Value.ToString();

            txtDescripcion.Text =
                dgvCargos.CurrentRow.Cells["Descripcion"].Value.ToString();
        }

        private bool ValidarCampos()
        {
            if (idDetalleSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un detalle de alquiler.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (cbTipoCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de cargo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cbTipoCargo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Ingrese una descripción.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                MessageBox.Show("Ingrese un monto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtMonto.Focus();
                return false;
            }

            decimal monto;
            if (!decimal.TryParse(txtMonto.Text, out monto))
            {
                MessageBox.Show("El monto ingresado no es válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtMonto.Focus();
                return false;
            }

            if (monto <= 0)
            {
                MessageBox.Show("El monto debe ser mayor que cero.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtMonto.Focus();
                return false;
            }

            return true;
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' &&
                ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
