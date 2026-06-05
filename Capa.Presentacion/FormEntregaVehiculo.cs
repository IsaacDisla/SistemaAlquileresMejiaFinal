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
    public partial class FormEntregaVehiculo : Form
    {
        EntregaVehiculoBLL bll = new EntregaVehiculoBLL();
        EntregaVehiculo entregaSeleccionada = new EntregaVehiculo();
        private int idDetalleSeleccionado;

        DateTime fechaEsperada;

        decimal precioDia;
        public FormEntregaVehiculo()
        {
            InitializeComponent();

            chkAplicaRetraso.CheckedChanged += chkAplicaRetraso_CheckedChanged_1;
            chkTieneDanos.CheckedChanged += chkTieneDanos_CheckedChanged_1;

            this.WindowState = FormWindowState.Maximized;

        }

        private void txtObservaciones_TextChanged(object sender, EventArgs e)
        {

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

        private void EstiloGridEntregas()
        {
            dgvEntregas.BorderStyle = BorderStyle.None;
            dgvEntregas.BackgroundColor = Color.White;

            dgvEntregas.EnableHeadersVisualStyles = false;

            dgvEntregas.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgvEntregas.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 0, 102);

            dgvEntregas.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvEntregas.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI Semibold", 12, FontStyle.Bold);

            dgvEntregas.ColumnHeadersHeight = 45;

            dgvEntregas.DefaultCellStyle.BackColor =
                Color.White;

            dgvEntregas.DefaultCellStyle.ForeColor =
                Color.Black;

            dgvEntregas.DefaultCellStyle.Font =
                new Font("Segoe UI", 11);

            dgvEntregas.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(65, 105, 225);

            dgvEntregas.DefaultCellStyle.SelectionForeColor =
                Color.White;

            dgvEntregas.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            dgvEntregas.GridColor =
                Color.LightGray;

            dgvEntregas.RowTemplate.Height = 35;

            dgvEntregas.RowHeadersVisible = false;

            dgvEntregas.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvEntregas.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvEntregas.MultiSelect = false;

            dgvEntregas.AllowUserToAddRows = false;

            dgvEntregas.AllowUserToDeleteRows = false;

            dgvEntregas.AllowUserToResizeRows = false;

            dgvEntregas.ReadOnly = true;
        }

        private void FormEntregaVehiculo_Load(object sender, EventArgs e)
        {
            EstiloGridEntregas();

            numDiasRetraso.Enabled = false;
            numDiasRetraso.Value = 0;

            txtObservaciones.Enabled = false;
            txtObservaciones.Clear();

            cbCombustibleEntrada.Items.Add("Lleno");
            cbCombustibleEntrada.Items.Add("3/4");
            cbCombustibleEntrada.Items.Add("1/2");
            cbCombustibleEntrada.Items.Add("1/4");
            cbCombustibleEntrada.Items.Add("Vacío");

            cbEstadoEntrada.Items.Add("Bueno");
            cbEstadoEntrada.Items.Add("Regular");
            cbEstadoEntrada.Items.Add("Dañado");

            ListarEntregas();

            dgvEntregas.Columns["Id_Entrega"].Visible = false;
            dgvEntregas.Columns["Id_Detalle"].Visible = false;

            lblUsuario.Text = Sesion.Nombre;
            lblRol.Text = Sesion.Rol;

            AplicarPermisos();
        }

        private void ListarEntregas()
        {
            dgvEntregas.DataSource = bll.Listar();
        }




        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDACIONES

                if (txtIdDetalle.Text.Trim() == "")
                {
                    MessageBox.Show("Seleccione un detalle.");
                    return;
                }

                if (txtKilometrajeEntrada.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el kilometraje de entrada.");
                    return;
                }

                if (cbCombustibleEntrada.Text == "")
                {
                    MessageBox.Show("Seleccione el combustible de entrada.");
                    return;
                }

                if (cbEstadoEntrada.Text == "")
                {
                    MessageBox.Show("Seleccione el estado del vehículo.");
                    return;
                }

                if (chkTieneDanos.Checked &&
                    txtObservaciones.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese las observaciones.");
                    return;
                }

                // CREAR OBJETO

                EntregaVehiculo entrega = new EntregaVehiculo();

                entrega.Id_Detalle = idDetalleSeleccionado;

                entrega.Fecha_Entrega_Real =
                    dtFechaEntrega.Value;

                entrega.Kilometraje_Entrada =
                    Convert.ToInt32(txtKilometrajeEntrada.Text);

                entrega.Combustible_Entrada =
                    cbCombustibleEntrada.Text;

                entrega.Estado_Entrada =
                    cbEstadoEntrada.Text;

                // OBSERVACIONES

                if (chkTieneDanos.Checked)
                {
                    entrega.Observaciones =
                        txtObservaciones.Text;
                }
                else
                {
                    entrega.Observaciones =
                        "Sin daños";
                }

                // RETRASO

                if (chkAplicaRetraso.Checked)
                {
                    entrega.Dias_Retraso =
                        Convert.ToInt32(numDiasRetraso.Value);
                }
                else
                {
                    entrega.Dias_Retraso = 0;
                }

                bll.Insertar(entrega);

                MessageBox.Show("Entrega guardada correctamente");

                // LIMPIAR FORM
                Nuevo();

                // REFRESCAR DATAGRID
                // Esto es lo importante para que el entregado desaparezca
                ListarEntregas();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (entregaSeleccionada.Id_Entrega == 0)
                {
                    MessageBox.Show("Seleccione una entrega");
                    return;
                }

                entregaSeleccionada.Id_Detalle = Convert.ToInt32(txtIdDetalle.Text);
                entregaSeleccionada.Fecha_Entrega_Real = dtFechaEntrega.Value;
                entregaSeleccionada.Kilometraje_Entrada = Convert.ToInt32(txtKilometrajeEntrada.Text);
                entregaSeleccionada.Combustible_Entrada = cbCombustibleEntrada.Text;
                entregaSeleccionada.Estado_Entrada = cbEstadoEntrada.Text;

                if (chkTieneDanos.Checked)
                {
                    entregaSeleccionada.Observaciones = txtObservaciones.Text;
                }
                else
                {
                    entregaSeleccionada.Observaciones = "Sin daños";
                }

                if (chkAplicaRetraso.Checked)
                {
                    entregaSeleccionada.Dias_Retraso = Convert.ToInt32(numDiasRetraso.Value);
                }
                else
                {
                    entregaSeleccionada.Dias_Retraso = 0;
                }

                bll.Actualizar(entregaSeleccionada);

                MessageBox.Show("Entrega actualizada correctamente");

                Nuevo();
                ListarEntregas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void chkAplicaRetraso_CheckedChanged(object sender, EventArgs e)
        {
            numDiasRetraso.Enabled = chkAplicaRetraso.Checked;

            if (!chkAplicaRetraso.Checked)
            {
                numDiasRetraso.Value = 0;
            }
        }

        private void chkTieneDanos_CheckedChanged(object sender, EventArgs e)
        {
            txtObservaciones.Enabled = chkTieneDanos.Checked;

            if (!chkTieneDanos.Checked)
            {
                txtObservaciones.Clear();
            }
        }


        private void BtnBuscarDetalle_Click(object sender, EventArgs e)
        {
            FormBuscarDetalle frm = new FormBuscarDetalle();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtIdDetalle.Text =
                    frm.IdDetalleSeleccionado.ToString();

                fechaEsperada =
                    frm.FechaEntregaEsperada;

                precioDia =
                    frm.PrecioDia;

                lblVehiculo.Text =
                    frm.Vehiculo;

                lblFechaEsperada.Text =
                    fechaEsperada.ToShortDateString();

                CalcularRetraso();
            }
        }

        private void dgvEntregas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                entregaSeleccionada.Id_Entrega =
                    Convert.ToInt32(dgvEntregas.Rows[e.RowIndex].Cells["Id_Entrega"].Value);

                txtIdDetalle.Text =
                    dgvEntregas.Rows[e.RowIndex].Cells["Id_Detalle"].Value.ToString();

                dtFechaEntrega.Value =
                    Convert.ToDateTime(dgvEntregas.Rows[e.RowIndex].Cells["Fecha_Entrega_Real"].Value);

                txtKilometrajeEntrada.Text =
                    dgvEntregas.Rows[e.RowIndex].Cells["Kilometraje_Entrada"].Value.ToString();

                cbCombustibleEntrada.Text =
                    dgvEntregas.Rows[e.RowIndex].Cells["Combustible_Entrada"].Value.ToString();

                cbEstadoEntrada.Text =
                    dgvEntregas.Rows[e.RowIndex].Cells["Estado_Entrada"].Value.ToString();

                txtObservaciones.Text =
                    dgvEntregas.Rows[e.RowIndex].Cells["Observaciones"].Value.ToString();

                numDiasRetraso.Value =
                    Convert.ToDecimal(dgvEntregas.Rows[e.RowIndex].Cells["Dias_Retraso"].Value);

                chkAplicaRetraso.Checked = numDiasRetraso.Value > 0;

                if (txtObservaciones.Text == "Sin daños")
                {
                    chkTieneDanos.Checked = false;
                }
                else
                {
                    chkTieneDanos.Checked = true;
                }
            }
        }

        private void CalcularRetraso()
        {
            if (fechaEsperada == DateTime.MinValue)
            {
                return;
            }

            int dias =
                (dtFechaEntrega.Value.Date - fechaEsperada.Date).Days;

            if (dias > 0)
            {
                chkAplicaRetraso.Checked = true;

                numDiasRetraso.Value =
                    Math.Min(dias, numDiasRetraso.Maximum);
            }
            else
            {
                chkAplicaRetraso.Checked = false;

                numDiasRetraso.Value = 0;
            }
        }


        private void Nuevo()
        {
            txtIdDetalle.Clear();
            txtKilometrajeEntrada.Clear();
            txtObservaciones.Clear();

            cbCombustibleEntrada.SelectedIndex = -1;
            cbEstadoEntrada.SelectedIndex = -1;

            chkAplicaRetraso.Checked = false;
            chkTieneDanos.Checked = false;

            numDiasRetraso.Value = 0;
            numDiasRetraso.Enabled = false;

            txtObservaciones.Enabled = false;

            dtFechaEntrega.Value = DateTime.Now;

            entregaSeleccionada = new EntregaVehiculo();
        }

        private void chkAplicaRetraso_CheckedChanged_1(object sender, EventArgs e)
        {
            numDiasRetraso.Enabled = chkAplicaRetraso.Checked;

            if (!chkAplicaRetraso.Checked)
            {
                numDiasRetraso.Value = 0;
            }
        }

        private void chkTieneDanos_CheckedChanged_1(object sender, EventArgs e)
        {
            txtObservaciones.Enabled = chkTieneDanos.Checked;

            if (!chkTieneDanos.Checked)
            {
                txtObservaciones.Clear();
            }
        }
        

        private void txtIdDetalle_TextChanged(object sender, EventArgs e)
        {
        }
        private void btnBuscarDetalle_Click(object sender, EventArgs e)
        {
            FormBuscarDetalle frm = new FormBuscarDetalle();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtIdDetalle.Text = frm.IdDetalleSeleccionado.ToString();

                idDetalleSeleccionado = frm.IdDetalleSeleccionado;

                fechaEsperada = frm.FechaEntregaEsperada;

                lblVehiculo.Text = frm.Vehiculo;

                lblFechaEsperada.Text = fechaEsperada.ToShortDateString();

                CalcularRetraso();
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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

        private void lblBackups_Click(object sender, EventArgs e)
        {
            FormBackup frm = new FormBackup();

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }

        private void dtFechaEntrega_ValueChanged(object sender, EventArgs e)
        {
            CalcularRetraso();

        }

        private void txtIdDetalle_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblPagos_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPagos());

        }

        private void lblAdicionales_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormCargosAdicionales());

        }

        private void lblAlquileres_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormAlquileres());

        }

        private void label9_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Menu_FacturaAlquiler());

        }

        private void label23_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmMenuPrincipal());
        }

        private void lblClientes_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormClientes());

        }

        private void lblBackups_Click_1(object sender, EventArgs e)
        {
            FormBackup frm = new FormBackup();

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }

        private void lblUsuarios_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormUsuarios());

        }

        private void lblReportes_Click(object sender, EventArgs e)
        {
            FormReportes frm = new FormReportes();

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblVehiculo_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaEsperada_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblRoles_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormRoles());

        }

        private void lblVehiculos_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormVehiculos());

        }
    }
}


