using Capa.Entidades;
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
    public partial class FormReporteVehiculos1 : Form
    {
        public FormReporteVehiculos1()
        {
            InitializeComponent();
        }

        private void FormReporteVehiculos1_Load(object sender, EventArgs e)
        {

            var ds = new Alquiler_VehiculosMJDataSet5();
            var ds4 = new Alquiler_VehiculosMJDataSet6();

            var taMas = new Alquiler_VehiculosMJDataSet5TableAdapters
                .sp_VehiculosMasAlquiladosTableAdapter();

            var taMenos = new Alquiler_VehiculosMJDataSet5TableAdapters
                .sp_VehiculosMenosAlquiladosTableAdapter();

            var taTop = new Alquiler_VehiculosMJDataSet5TableAdapters
                .sp_VehiculoTopRentabilidadTableAdapter();

            var taMenosMenos = new Alquiler_VehiculosMJDataSet6TableAdapters
                .sp_VehiculoMenosMenosAlquiladoTableAdapter();

            taMas.Fill(ds.sp_VehiculosMasAlquilados);
            taMenos.Fill(ds.sp_VehiculosMenosAlquilados);
            taTop.Fill(ds.sp_VehiculoTopRentabilidad);
            taMenosMenos.Fill(ds4.sp_VehiculoMenosMenosAlquilado);

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource(
                    "DataSet1",
                    (System.Data.DataTable)ds.sp_VehiculosMasAlquilados));

            reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource(
                    "DataSet2",
                    (System.Data.DataTable)ds.sp_VehiculosMenosAlquilados));

            reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource(
                    "DataSet3",
                    (System.Data.DataTable)ds.sp_VehiculoTopRentabilidad));

            reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource(
                    "DataSet4",
                    (System.Data.DataTable)ds4.sp_VehiculoMenosMenosAlquilado));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter(
                    "UsuarioGenerador",
                    Sesion.Nombre));

            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
