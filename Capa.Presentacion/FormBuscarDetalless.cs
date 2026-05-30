using System;
using Capa.Negocios;
using Capa.Entidades;
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
    public partial class FormBuscarDetalless : Form
    {
        CargosAdicionalesBL bl = new CargosAdicionalesBL();

        public System.Windows.Forms.TextBox txtIdDetalle;
        public System.Windows.Forms.TextBox txtCliente;
        public System.Windows.Forms.TextBox txtVehiculo;
        public System.Windows.Forms.TextBox txtEstadoAlquiler;


        public FormBuscarDetalless()
        {
            InitializeComponent();
        }

        private void FormBuscarDetalless_Load(object sender, EventArgs e)
        {


            CargarDetalles();

        }

        private void CargarDetalles()
        {
            dgvDetalles.DataSource =
                bl.ListarDetallesEntregados();
        }

        private void dgvDetalles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentRow == null)
                return;

            FormCargosAdicionales frm =
                this.Owner as FormCargosAdicionales;

            if (frm != null)
            {
                frm.txtIdDetalle.Text =
                    dgvDetalles.CurrentRow.Cells["Id_Detalle"]
                    .Value.ToString();

                frm.txtCliente.Text =
                    dgvDetalles.CurrentRow.Cells["Cliente"]
                    .Value.ToString();

                frm.txtVehiculo.Text =
                    dgvDetalles.CurrentRow.Cells["Vehiculo"]
                    .Value.ToString();

                frm.txtEstadoAlquiler.Text =
                    dgvDetalles.CurrentRow.Cells["Estado_Alquiler"]
                    .Value.ToString();
            }
            this.Close();
        }
    }
}
