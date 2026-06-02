using Capa.Negocios;
using System;
using System.Data;
using System.Drawing;
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

            dgvDetalles.DefaultCellStyle.Font =
                new Font("Segoe UI", 11);

            dgvDetalles.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(65, 105, 225);

            dgvDetalles.DefaultCellStyle.SelectionForeColor =
                Color.White;

            dgvDetalles.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            dgvDetalles.RowTemplate.Height = 35;

            dgvDetalles.RowHeadersVisible = false;

            dgvDetalles.GridColor = Color.LightGray;
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
            btnSeleccionar.Text = "✅ Seleccionar";
            btnSeleccionar.UseColumnTextForButtonValue = true;
            dgvDetalles.Columns.Add(btnSeleccionar);

            btnSeleccionar.DefaultCellStyle.BackColor =
    Color.FromArgb(0, 0, 102);

            btnSeleccionar.DefaultCellStyle.ForeColor =
                Color.White;

            btnSeleccionar.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(65, 105, 225);

            btnSeleccionar.DefaultCellStyle.SelectionForeColor =
                Color.White;

            btnSeleccionar.FlatStyle = FlatStyle.Flat;

            EstiloGridDetalles();

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

