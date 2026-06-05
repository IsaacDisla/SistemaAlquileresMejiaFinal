using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using Capa.Negocios;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.Presentacion
{
    public partial class FrmFacturaAlquiler : Form
    {
        private ReportesBL reporteBL =  new ReportesBL();
        private int idAlquiler;
        public FrmFacturaAlquiler(int idAlquiler)
        {
            InitializeComponent();
            this.idAlquiler = idAlquiler;
        }

        private void FrmFacturaAlquiler_Load(object sender, EventArgs e)
        {


            DataTable dt =
     reporteBL.ReporteFacturaAlquiler(idAlquiler);

            ReportDataSource rds =
                new ReportDataSource("DataSet1", dt);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.SetDisplayMode(
                Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            reportViewer1.ZoomMode =
                Microsoft.Reporting.WinForms.ZoomMode.FullPage;

            reportViewer1.RefreshReport();

        }
    }
}
