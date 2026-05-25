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

        private void FormBuscarAlquiler_Load(object sender, EventArgs e)
        {
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
