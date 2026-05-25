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
            cbEstado.SelectedIndex = -1;

            dtFechaPago.Value = DateTime.Now;

            pagoSeleccionado = new Pagos();
        }

        private void btnBuscarAlquiler_Click(object sender, EventArgs e)
        {

            FormBuscarAlquiler frm =
                new FormBuscarAlquiler();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtIdAlquiler.Text =
                    frm.IdAlquilerSeleccionado.ToString();
            }
        }
    }
}
