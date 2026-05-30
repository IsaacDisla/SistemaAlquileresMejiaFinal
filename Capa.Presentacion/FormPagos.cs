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
    public partial class FormPagos : Form
    {
        PagosBL bl = new PagosBL();
        Pagos pagoSeleccionado = new Pagos();
        public FormPagos()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

        }

        private void FormPagos_Load(object sender, EventArgs e)
        {
            cbMetodoPago.Items.Add("Efectivo");
            cbMetodoPago.Items.Add("Transferencia");
            cbMetodoPago.Items.Add("Tarjeta");

            ListarPagos();



            lblUsuario.Text = Sesion.Nombre;

            lblRol.Text = Sesion.Rol;
        }

        private void ListarPagos()
        {
            dgvPagos.DataSource = bl.Listar();
        }

        private void AbrirFormulario(Form formulario)
        {
            formulario.Show();
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Pagos p = new Pagos();

                p.Id_Alquiler =
                    Convert.ToInt32(txtIdAlquiler.Text);

                p.Fecha_Pago =
                    dtFechaPago.Value;

                p.Metodo_Pago =
                    cbMetodoPago.Text;

                p.Monto_Pagado =
                    Convert.ToDecimal(txtMontoPagado.Text);

                bl.Insertar(p);
                ActualizarBalance();

                MessageBox.Show("Pago guardado correctamente");

                Nuevo();
                ListarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (pagoSeleccionado.Id_Pago == 0)
                {
                    MessageBox.Show("Seleccione un pago");
                    return;
                }

                pagoSeleccionado.Id_Alquiler =
                    Convert.ToInt32(txtIdAlquiler.Text);

                pagoSeleccionado.Fecha_Pago =
                    dtFechaPago.Value;

                pagoSeleccionado.Metodo_Pago =
                    cbMetodoPago.Text;

                pagoSeleccionado.Monto_Pagado =
                    Convert.ToDecimal(txtMontoPagado.Text);

                bl.Actualizar(pagoSeleccionado);

                MessageBox.Show("Pago actualizado correctamente");

                Nuevo();
                ListarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                pagoSeleccionado.Id_Pago =
                    Convert.ToInt32(
                    dgvPagos.Rows[e.RowIndex].Cells["Id_Pago"].Value);

                txtIdAlquiler.Text =
                    dgvPagos.Rows[e.RowIndex].Cells["Id_Alquiler"].Value.ToString();

                dtFechaPago.Value =
                    Convert.ToDateTime(
                    dgvPagos.Rows[e.RowIndex].Cells["Fecha_Pago"].Value);

                cbMetodoPago.Text =
                    dgvPagos.Rows[e.RowIndex].Cells["Metodo_Pago"].Value.ToString();

                txtMontoPagado.Text =
                    dgvPagos.Rows[e.RowIndex].Cells["Monto_Pagado"].Value.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo()
        {
            txtIdAlquiler.Clear();
            txtMontoPagado.Clear();

            cbMetodoPago.SelectedIndex = -1;

            dtFechaPago.Value = DateTime.Now;

            pagoSeleccionado = new Pagos();
        }

        private void btnBuscarAlquiler_Click(object sender, EventArgs e)
        {

            FormBuscarAlquilerPago frm =
         new FormBuscarAlquilerPago();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtIdAlquiler.Text =
                    frm.IdAlquilerSeleccionado.ToString();

                txtCliente.Text =
                    frm.ClienteSeleccionado;

                lblTotalAlquiler.Text =
                    frm.TotalAlquiler.ToString("N2");

                lblTotalPagado.Text =
                    frm.TotalPagado.ToString("N2");

                lblBalancePendiente.Text =
                    frm.BalancePendiente.ToString("N2");

                txtEstado.Text =
                    frm.EstadoSeleccionado;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm =
                                  new FrmMenuPrincipal();

            frm.Show();

            this.Hide();
        }

        private void lblRol_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

        private void label9_Click(object sender, EventArgs e)
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

        private void ActualizarBalance()
        {
            if (txtIdAlquiler.Text == "")
                return;

            DataTable dt =
                bl.ObtenerBalanceAlquiler(
                Convert.ToInt32(txtIdAlquiler.Text));

            if (dt.Rows.Count > 0)
            {
                lblTotalAlquiler.Text =
                    Convert.ToDecimal(
                    dt.Rows[0]["Total_Alquiler"]).ToString("N2");

                lblTotalPagado.Text =
                    Convert.ToDecimal(
                    dt.Rows[0]["Total_Pagado"]).ToString("N2");

                lblBalancePendiente.Text =
                    Convert.ToDecimal(
                    dt.Rows[0]["Balance_Pendiente"]).ToString("N2");
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotalAlquiler_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPagado_Click(object sender, EventArgs e)
        {

        }

        private void lblBalancePendiente_Click(object sender, EventArgs e)
        {

        }
    }
}
