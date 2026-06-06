using Capa.Negocios;
using Microsoft.Reporting.WinForms;
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
    public partial class FormIngresos : Form
    {
        public FormIngresos()
        {
            InitializeComponent();
        }

        private void FormIngresos_Load(object sender, EventArgs e)
        {

            try
            {
                ReportesBL obj = new ReportesBL();

                DataTable dt =
                    obj.ReporteIngresosPorMes();

                reportViewer1.LocalReport.ReportEmbeddedResource =
                 "Capa.Presentacion.Report4.rdlc";

                reportViewer1.LocalReport.DataSources.Clear();
                
                ReportDataSource rds = new ReportDataSource("DataSet1",dt);

                reportViewer1.LocalReport.DataSources.Add(rds);

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar el reporte: " +
                    ex.Message);
            }
        }
    }
}
