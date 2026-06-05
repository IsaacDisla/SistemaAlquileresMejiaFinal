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
    public partial class FormSeleccionarVehiculo : Form
    {

        VehiculosBL vehiculosBL = new VehiculosBL();

        public int IdVehiculo { get; set; }
        public string Vehiculo { get; set; }
        public decimal PrecioDia { get; set; }
        public int Kilometraje { get; set; }
        public FormSeleccionarVehiculo()
        {
            InitializeComponent();
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

        private void FormSeleccionarVehiculo_Load(object sender, EventArgs e)
        {
            EstiloGridVehiculos();

            DataTable dt = vehiculosBL.Listar();

            DataView dv = dt.DefaultView;

            dv.RowFilter = "Estado_Vehiculo = 'Disponible'";

            dgvVehiculos.DataSource = dv;

            AgregarBotonSeleccionar();

            dgvVehiculos.Columns["Id_Vehiculo"].Visible = false;

            dgvVehiculos.Columns["Seleccionar"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            this.WindowState = FormWindowState.Maximized;
        }
        private void AgregarBotonSeleccionar()
        {
            if (dgvVehiculos.Columns["Seleccionar"] == null)
            {
                DataGridViewButtonColumn btn =
                    new DataGridViewButtonColumn();

                btn.Name = "Seleccionar";
                btn.HeaderText = "ACCIÓN";
                btn.Text = "Seleccionar";
                btn.UseColumnTextForButtonValue = true;

                dgvVehiculos.Columns.Add(btn);
            }
        }

        private void dgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                            dgvVehiculos.Columns[e.ColumnIndex].Name == "Seleccionar")
            {
                IdVehiculo = Convert.ToInt32(
                    dgvVehiculos.Rows[e.RowIndex].Cells["Id_Vehiculo"].Value);

                Vehiculo =
                    dgvVehiculos.Rows[e.RowIndex].Cells["Marca"].Value.ToString()
                    + " " +
                    dgvVehiculos.Rows[e.RowIndex].Cells["Modelo"].Value.ToString();

                PrecioDia = Convert.ToDecimal(
                    dgvVehiculos.Rows[e.RowIndex].Cells["Precio_Dia"].Value);

                Kilometraje = Convert.ToInt32(
                    dgvVehiculos.Rows[e.RowIndex].Cells["Kilometraje"].Value);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

    }
}

