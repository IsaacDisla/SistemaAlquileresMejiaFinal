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
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        private void btnReporteFactura_Click(object sender, EventArgs e)
        {

        }

        private void btnReporteVehiculos_Click(object sender, EventArgs e)
        {
            FormReporteVehiculos1 frm = new FormReporteVehiculos1();
            frm.ShowDialog(); // o frm.Show();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnReportePendientes_Click(object sender, EventArgs e)
        {
            Reportedepagos frm = new Reportedepagos();
            frm.ShowDialog(); // o frm.Show();
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            FormIngresos frm = new FormIngresos();
            frm.ShowDialog(); // o frm.Show();
        }
    }
}
