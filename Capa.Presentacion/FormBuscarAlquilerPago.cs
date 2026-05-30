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
    public partial class FormBuscarAlquilerPago : Form
    {

        public int IdAlquilerSeleccionado { get; set; }

        public string ClienteSeleccionado { get; set; }

        public decimal TotalAlquiler { get; set; }

        public decimal TotalPagado { get; set; }

        public decimal BalancePendiente { get; set; }

        public string EstadoSeleccionado { get; set; }

        private PagosBL bl = new PagosBL();


        public FormBuscarAlquilerPago()
        {


            InitializeComponent();
        }

        private void dgvAlquileres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvAlquileres.DataSource =
  bl.ListarAlquileresPendientesPago();
        }

        private void dgvAlquileres_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormBuscarAlquilerPago_Load(object sender, EventArgs e)
        {

            dgvAlquileres.DataSource =
      bl.ListarAlquileresPendientesPago();

        
        }

        private void dgvAlquileres_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdAlquilerSeleccionado =
                    Convert.ToInt32(
                    dgvAlquileres.Rows[e.RowIndex].Cells["Id_Alquiler"].Value);

                ClienteSeleccionado =
                    dgvAlquileres.Rows[e.RowIndex].Cells["Cliente"].Value.ToString();

                TotalAlquiler =
                    Convert.ToDecimal(
                    dgvAlquileres.Rows[e.RowIndex].Cells["Total_Alquiler"].Value);

                TotalPagado =
                    Convert.ToDecimal(
                    dgvAlquileres.Rows[e.RowIndex].Cells["Total_Pagado"].Value);

                BalancePendiente =
                    Convert.ToDecimal(
                    dgvAlquileres.Rows[e.RowIndex].Cells["Balance_Pendiente"].Value);

                EstadoSeleccionado =
                    dgvAlquileres.Rows[e.RowIndex].Cells["Estado_Alquiler"].Value.ToString();

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
