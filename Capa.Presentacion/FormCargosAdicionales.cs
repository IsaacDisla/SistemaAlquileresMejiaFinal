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



        public FormCargosAdicionales()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;



        }

        private void FormCargosAdicionales_Load(object sender, EventArgs e)
        {
            cbTipoCargo.Items.Clear();

            cbTipoCargo.Items.Add("Daño");
            cbTipoCargo.Items.Add("Limpieza");
            cbTipoCargo.Items.Add("Combustible");
            cbTipoCargo.Items.Add("Multa");
            cbTipoCargo.Items.Add("Retraso");
            cbTipoCargo.Items.Add("Otro");

            CargarCargos();

            txtIdDetalle.ReadOnly = true;
            txtCliente.ReadOnly = true;
            txtVehiculo.ReadOnly = true;
            txtEstadoAlquiler.ReadOnly = true;


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
                CargosAdicionales cargo =
                    new CargosAdicionales();

                cargo.Id_Detalle =
                    Convert.ToInt32(txtIdDetalle.Text);

                cargo.Fecha =
                    dtpFecha.Value;

                cargo.Descripcion =
                    cbTipoCargo.Text + " - " +
                    txtDescripcion.Text;

                cargo.Monto =
                    Convert.ToDecimal(txtMonto.Text);

                bl.InsertarCargoAdicional(cargo);

                CargarCargos(); // <-- refresca el grid

                MessageBox.Show("Cargo agregado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIdDetalle.Clear();
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
    }
}
