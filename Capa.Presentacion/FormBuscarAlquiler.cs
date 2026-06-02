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
    public partial class FormBuscarAlquiler : Form
    {
        AlquileresBL bl = new AlquileresBL();

        public int IdAlquilerSeleccionado { get; set; }

        public FormBuscarAlquiler()
        {
            InitializeComponent();
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

        private void FormBuscarAlquiler_Load(object sender, EventArgs e)
        {
            EstiloGridAlquileres();

            dgvAlquileres.DataSource = bl.Listar();

            dgvAlquileres.Columns["Id_Cliente"].Visible = false;
            dgvAlquileres.Columns["Id_Usuario"].Visible = false;
        }

        private void dgvAlquileres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvAlquileres.CurrentRow != null)
            {
                IdAlquilerSeleccionado =
                    Convert.ToInt32(
                    dgvAlquileres.CurrentRow
                    .Cells["Id_Alquiler"].Value);

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
    }
    }
}
