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
            this.WindowState = FormWindowState.Maximized;

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

        private void EstiloGridDetalles()
        {
            dgvDetalles.BorderStyle = BorderStyle.None;
            dgvDetalles.BackgroundColor = Color.White;

            dgvDetalles.EnableHeadersVisualStyles = false;

            dgvDetalles.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgvDetalles.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 0, 102);

            dgvDetalles.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvDetalles.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI Semibold", 12, FontStyle.Bold);

            dgvDetalles.ColumnHeadersHeight = 45;

            dgvDetalles.DefaultCellStyle.BackColor =
                Color.White;

            dgvDetalles.DefaultCellStyle.ForeColor =
                Color.Black;

            dgvDetalles.DefaultCellStyle.Font =
                new Font("Segoe UI", 11);

            dgvDetalles.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(65, 105, 225);

            dgvDetalles.DefaultCellStyle.SelectionForeColor =
                Color.White;

            dgvDetalles.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            dgvDetalles.GridColor =
                Color.LightGray;

            dgvDetalles.RowTemplate.Height = 35;

            dgvDetalles.RowHeadersVisible = false;

            dgvDetalles.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvDetalles.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvDetalles.MultiSelect = false;

            dgvDetalles.AllowUserToAddRows = false;

            dgvDetalles.AllowUserToDeleteRows = false;

            dgvDetalles.AllowUserToResizeRows = false;

            dgvDetalles.ReadOnly = true;
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EstiloGridDetalles();
            CargarDetalles();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
