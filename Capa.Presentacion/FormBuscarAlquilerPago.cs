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

        }

        private void dgvAlquileres_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EstiloGridAlquileres()
        {
            dgvAlquileres.BorderStyle = BorderStyle.None;
            dgvAlquileres.BackgroundColor = Color.White;

            dgvAlquileres.EnableHeadersVisualStyles = false;

            dgvAlquileres.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgvAlquileres.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 0, 102);

            dgvAlquileres.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvAlquileres.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI Semibold", 12, FontStyle.Bold);

            dgvAlquileres.ColumnHeadersHeight = 45;

            dgvAlquileres.DefaultCellStyle.BackColor =
                Color.White;

            dgvAlquileres.DefaultCellStyle.ForeColor =
                Color.Black;

            dgvAlquileres.DefaultCellStyle.Font =
                new Font("Segoe UI", 11);

            dgvAlquileres.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(65, 105, 225);

            dgvAlquileres.DefaultCellStyle.SelectionForeColor =
                Color.White;

            dgvAlquileres.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            dgvAlquileres.GridColor =
                Color.LightGray;

            dgvAlquileres.RowTemplate.Height = 35;

            dgvAlquileres.RowHeadersVisible = false;

            dgvAlquileres.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvAlquileres.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvAlquileres.MultiSelect = false;

            dgvAlquileres.AllowUserToAddRows = false;

            dgvAlquileres.AllowUserToDeleteRows = false;

            dgvAlquileres.AllowUserToResizeRows = false;

            dgvAlquileres.ReadOnly = true;
        }

        private void FormBuscarAlquilerPago_Load(object sender, EventArgs e)
        {

            dgvAlquileres.DataSource =
      bl.ListarAlquileresPendientesPago();

            EstiloGridAlquileres();

            dgvAlquileres.Columns["Id_Alquiler"].Width = 90;
            dgvAlquileres.Columns["Cliente"].Width = 220;
            dgvAlquileres.Columns["Total_Alquiler"].Width = 120;
            dgvAlquileres.Columns["Total_Pagado"].Width = 120;
            dgvAlquileres.Columns["Balance_Pendiente"].Width = 140;
            dgvAlquileres.Columns["Estado_Alquiler"].Width = 120;

        }

        private void dgvAlquileres_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvAlquileres.Rows[e.RowIndex].Cells["Id_Alquiler"].Value == null)
                return;

            IdAlquilerSeleccionado =
                Convert.ToInt32(
                dgvAlquileres.Rows[e.RowIndex].Cells["Id_Alquiler"].Value);
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
