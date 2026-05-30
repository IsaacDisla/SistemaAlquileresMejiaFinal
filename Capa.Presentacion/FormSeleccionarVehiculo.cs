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

        private void FormSeleccionarVehiculo_Load(object sender, EventArgs e)
        {
            DataTable dt = vehiculosBL.Listar();

            DataView dv = dt.DefaultView;

            dv.RowFilter = "Estado_Vehiculo = 'Disponible'";

            dgvVehiculos.DataSource = dv;

            AgregarBotonSeleccionar();

            dgvVehiculos.Columns["Id_Vehiculo"].Visible = false;


        }

        private void AgregarBotonSeleccionar()
        {
            if (dgvVehiculos.Columns["Seleccionar"] == null)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "Seleccionar";
                btn.HeaderText = "Seleccionar";
                btn.Text = "✓";
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

