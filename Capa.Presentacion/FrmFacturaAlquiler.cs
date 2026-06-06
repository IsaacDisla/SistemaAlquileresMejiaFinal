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
using Capa.Entidades;

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

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void FrmFacturaAlquiler_Load(object sender, EventArgs e)
        {


            DataTable dt =
     reporteBL.ReporteFacturaAlquiler(idAlquiler);

            ReportParameter usuario =
    new ReportParameter(
        "UsuarioGenerador",
        Sesion.Nombre);

            reportViewer1.LocalReport.SetParameters(usuario);

            ReportDataSource rds =
                new ReportDataSource("DataSet1", dt);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.SetDisplayMode(DisplayMode.Normal);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;

            reportViewer1.RefreshReport();

        }
    }
}
