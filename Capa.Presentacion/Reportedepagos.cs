using System;
using Microsoft.Reporting.WinForms;
using Capa.Entidades;
using Capa.Negocios;
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
    public partial class Reportedepagos : Form
    {
        public Reportedepagos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void Reportedepagos_Load(object sender, EventArgs e)
        {
            try
            {
                ReportesBL reporteBL = new ReportesBL();

                DataTable dt = reporteBL.ReportePagosPendientes();

                reportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource rds =
                    new ReportDataSource("DataSet1", dt);

                reportViewer1.LocalReport.DataSources.Add(rds);

                // Asignar parámetro
                ReportParameter usuario =
                    new ReportParameter("UsuarioGenerador", Sesion.Nombre);

                reportViewer1.LocalReport.SetParameters(usuario);

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar el reporte: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
    }
}
}

