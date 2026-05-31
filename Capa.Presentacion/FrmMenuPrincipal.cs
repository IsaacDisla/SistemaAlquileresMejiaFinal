using Capa.Entidades;
using Capa.Negocio;
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
    public partial class FrmMenuPrincipal : Form
    {
        DashboardBLL dashboard = new DashboardBLL();
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void lblClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Menu_FacturaAlquiler());
        }

        private void AbrirFormulario(Form formulario)
        {
            formulario.Show();
            this.Hide();
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.Yellow;
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.White;
        }



        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Sesion.Nombre;
            this.WindowState = FormWindowState.Maximized;

            lblRol.Text = Sesion.Rol;

            CargarDashboard();
        }

        private void lblVehiculos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEntregaVehiculo());
        }

        private void lblPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPagos());
        }

        private void CargarDashboard()
        {
            lblVehiculosDisponibles.Text = dashboard.VehiculosDisponibles();
            lblVehiculosRentados.Text = dashboard.VehiculosRentados();
            lblVehiculosMantenimiento.Text = dashboard.VehiculosMantenimiento();
            lblAlquileresActivos.Text = dashboard.AlquileresActivos();
            lblPagosPendientes.Text = dashboard.PagosPendientes();

            decimal ingresos = Convert.ToDecimal(dashboard.IngresosMes());
            lblIngresosMes.Text = "RD$ " + ingresos.ToString("N2");
        }

        private void lblAlquileres_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormAlquileres());
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblRol_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void lblBackups_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblEntrega_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEntregaVehiculo());
        }

        private void lblAdicionales_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormCargosAdicionales());
        }

        private void lblBackups_Click_1(object sender, EventArgs e)
        {
            FormBackup frm = new FormBackup();

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }

        private void lblAlquileres_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormAlquileres());
        }

        private void lblClientes_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormClientes());

        }

        private void lblAlquileresActivos_Click(object sender, EventArgs e)
        {

        }

        private void lblVehiculosDisponibles_Click(object sender, EventArgs e)
        {

        }

        private void lblPagosPendientes_Click(object sender, EventArgs e)
        {

        }

        private void lblVehiculosRentados_Click(object sender, EventArgs e)
        {

        }

        private void lblVehiculosMantenimiento_Click(object sender, EventArgs e)
        {

        }

        private void lblIngresosMes_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
