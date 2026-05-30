using Capa.Negocios;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capa.Presentacion
{
    public partial class FormBuscarDetalle : Form
    {
        DetalleAlquileresBL bl = new DetalleAlquileresBL();

        public int IdDetalleSeleccionado { get; set; }

        public DateTime FechaEntregaEsperada { get; set; }

        public decimal PrecioDia { get; set; }

        public int DiasAlquilados { get; set; }

        public string Vehiculo { get; set; }


        public FormBuscarDetalle()
        {
            InitializeComponent();
            dgvDetalles.CellClick += dgvDetalles_CellClick;

        }

        private void FormBuscarDetalle_Load(object sender, EventArgs e)
        {
            DataTable dt = bl.Listar();
            DataView dv = new DataView(dt);

            // FILTRAR SOLO ACTIVOS
            dv.RowFilter = "Estado = 'Alquilado'";
            dgvDetalles.DataSource = dv;

            dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalles.MultiSelect = false;
            dgvDetalles.ReadOnly = true;
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.RowHeadersVisible = false;
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvDetalles.Columns.Contains("Seleccionar"))
                dgvDetalles.Columns.Remove("Seleccionar");

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

                FechaEntregaEsperada =
                          Convert.ToDateTime(
                             dgvDetalles.Rows[e.RowIndex]
                                    .Cells["Fecha_Entrega_Esperada"].Value
                                  );

                             PrecioDia =
                                Convert.ToDecimal(
                                dgvDetalles.Rows[e.RowIndex]
                        .Cells["Precio_Por_Dia"].Value
                    );

                DiasAlquilados =
                    Convert.ToInt32(
                        dgvDetalles.Rows[e.RowIndex]
                        .Cells["Dias_Alquilados"].Value
                    );

                Vehiculo =
                    dgvDetalles.Rows[e.RowIndex]
                    .Cells["Vehiculo"].Value.ToString();

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

                FechaEntregaEsperada =
    Convert.ToDateTime(
        dgvDetalles.Rows[e.RowIndex]
        .Cells["Fecha_Entrega_Esperada"].Value
    );

                PrecioDia =
                    Convert.ToDecimal(
                        dgvDetalles.Rows[e.RowIndex]
                        .Cells["Precio_Por_Dia"].Value
                    );

                DiasAlquilados =
                    Convert.ToInt32(
                        dgvDetalles.Rows[e.RowIndex]
                        .Cells["Dias_Alquilados"].Value
                    );

                Vehiculo =
                    dgvDetalles.Rows[e.RowIndex]
                    .Cells["Vehiculo"].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
    }
    }
}

