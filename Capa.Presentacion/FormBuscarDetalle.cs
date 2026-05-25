using Capa.Negocios;
using System;
using System.Windows.Forms;

namespace Capa.Presentacion
{
    public partial class FormBuscarDetalle : Form
    {
        DetalleAlquileresBL bl = new DetalleAlquileresBL();

        public int IdDetalleSeleccionado { get; set; }


        public FormBuscarDetalle()
        {
            InitializeComponent();
            dgvDetalles.CellClick += dgvDetalles_CellClick;

        }

        private void FormBuscarDetalle_Load(object sender, EventArgs e)
        {
            dgvDetalles.DataSource = bl.Listar();

            dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalles.MultiSelect = false;
            dgvDetalles.ReadOnly = true;
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.RowHeadersVisible = false;
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvDetalles.Columns.Contains("Seleccionar"))
            {
                dgvDetalles.Columns.Remove("Seleccionar");
            }

            DataGridViewButtonColumn btnSeleccionar = new DataGridViewButtonColumn();
            btnSeleccionar.Name = "Seleccionar";
            btnSeleccionar.HeaderText = "ACCIÓN";
            btnSeleccionar.Text = "Elegir";
            btnSeleccionar.UseColumnTextForButtonValue = true;

            dgvDetalles.Columns.Add(btnSeleccionar);

        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDetalles.Columns[e.ColumnIndex].Name == "Seleccionar")
            {
                IdDetalleSeleccionado = Convert.ToInt32(
                    dgvDetalles.Rows[e.RowIndex].Cells["Id_Detalle"].Value
                );

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dgvDetalles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDetalles.Columns[e.ColumnIndex].Name == "Seleccionar")
            {
                IdDetalleSeleccionado = Convert.ToInt32(
                    dgvDetalles.Rows[e.RowIndex].Cells["Id_Detalle"].Value
                );

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
    }
    }
}

