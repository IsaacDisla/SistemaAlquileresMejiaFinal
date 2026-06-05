using Capa.Entidades;
using Capa.Negocio;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Capa.Presentacion
{
    public partial class Menu_FacturaAlquiler : Form
    {
        FacturaAlquilerBL negocio = new FacturaAlquilerBL();

        public Menu_FacturaAlquiler()
        {
            InitializeComponent();


            lblUsuario.Text = Sesion.Nombre;

            lblRol.Text = Sesion.Rol;

            this.WindowState = FormWindowState.Maximized;

        }

        private void AplicarPermisos()
        {
            if (Sesion.Rol == "Administrador")
            {
                return;
            }

            if (Sesion.Rol == "Gerente")
            {
                lblUsuarios.Visible = false;
                lblRoles.Visible = false;
                lblBackups.Visible = false;
            }

            if (Sesion.Rol == "Empleado")
            {
                lblUsuarios.Visible = false;
                lblRoles.Visible = false;
                lblBackups.Visible = false;
                lblReportes.Visible = false;
            }
        }

        private void Menu_FacturaAlquiler_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();

            dgvFactura.DataSource = negocio.MostrarTodasFacturas();

            DarFormatoColumnas();
            ColorearBalance();

            CargarFacturas();

            AplicarPermisos();


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdAlquiler.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el ID del alquiler.");
                    txtIdAlquiler.Focus();
                    return;
                }

                int idAlquiler = Convert.ToInt32(txtIdAlquiler.Text.Trim());

                DataTable dt = negocio.BuscarFacturaAlquiler(idAlquiler);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró factura para ese alquiler.");
                    dgvFactura.DataSource = null;
                    return;
                }

                dgvFactura.DataSource = dt;
                DarFormatoColumnas();
                ColorearBalance();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar factura: " + ex.Message);
            }
        }

        private void ConfigurarGrid()
        {
            dgvFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFactura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFactura.ReadOnly = true;
            dgvFactura.AllowUserToAddRows = false;
            dgvFactura.AllowUserToDeleteRows = false;
            dgvFactura.RowHeadersVisible = false;
        }

        private void DarFormatoColumnas()
        {
            if (dgvFactura.Columns.Contains("Id_Alquiler"))
                dgvFactura.Columns["Id_Alquiler"].HeaderText = "ID ALQUILER";

            if (dgvFactura.Columns.Contains("Cliente"))
                dgvFactura.Columns["Cliente"].HeaderText = "CLIENTE";

            if (dgvFactura.Columns.Contains("Vehiculo"))
                dgvFactura.Columns["Vehiculo"].HeaderText = "VEHÍCULO";

            if (dgvFactura.Columns.Contains("Subtotal"))
                dgvFactura.Columns["Subtotal"].HeaderText = "SUBTOTAL";

            if (dgvFactura.Columns.Contains("Cargos_Adicionales"))
                dgvFactura.Columns["Cargos_Adicionales"].HeaderText = "CARGOS";

            if (dgvFactura.Columns.Contains("Total_General"))
                dgvFactura.Columns["Total_General"].HeaderText = "TOTAL GENERAL";

            if (dgvFactura.Columns.Contains("Total_Pagado"))
                dgvFactura.Columns["Total_Pagado"].HeaderText = "TOTAL PAGADO";

            if (dgvFactura.Columns.Contains("Balance_Pendiente"))
                dgvFactura.Columns["Balance_Pendiente"].HeaderText = "PENDIENTE";

            dgvFactura.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
            dgvFactura.Columns["Cargos_Adicionales"].DefaultCellStyle.Format = "N2";
            dgvFactura.Columns["Total_General"].DefaultCellStyle.Format = "N2";
            dgvFactura.Columns["Total_Pagado"].DefaultCellStyle.Format = "N2";
            dgvFactura.Columns["Balance_Pendiente"].DefaultCellStyle.Format = "N2";
        }

        private void ColorearBalance()
        {
            foreach (DataGridViewRow fila in dgvFactura.Rows)
            {
                decimal balance = Convert.ToDecimal(fila.Cells["Balance_Pendiente"].Value);

                if (balance <= 0)
                {
                    fila.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    fila.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            try
            {
                dgvFactura.DataSource = negocio.MostrarTodasFacturas();

                DarFormatoColumnas();
                ColorearBalance();
                CargarFacturas();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar facturas: " + ex.Message);
            }
        }


        private void CargarFacturas()
        {
            dgvFactura.DataSource =
                negocio.MostrarTodasFacturas();

            DarFormatoColumnas();
            ColorearBalance();
        }
        private void AbrirFormulario(Form formulario)
        {
            formulario.Show();
            this.Hide();
        }



        private void label23_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmMenuPrincipal());

        }

        private void lblClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormClientes());

        }

        private void lblVehiculos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormVehiculos());

        }

        private void lblAlquileres_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormAlquileres());

        }

        private void label17_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Menu_FacturaAlquiler());

        }

        private void lblPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPagos());

        }

        private void lblEntrega_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEntregaVehiculo());

        }

        private void lblAdicionales_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormCargosAdicionales());
        }

        private void lblUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormUsuarios());

        }

        private void lblRoles_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormRoles());

        }

        private void lblBackups_Click(object sender, EventArgs e)
        {
            FormBackup frm = new FormBackup();

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();

        }

        private void lblReportes_Click(object sender, EventArgs e)
        {
            FormReportes frm = new FormReportes();

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }

        private void lblBackups_Click_1(object sender, EventArgs e)
        {
            FormBackup frm = new FormBackup();

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }

        private void lblRoles_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormRoles());

        }

        private void lblUsuarios_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormUsuarios());

        }

        private void lblPagos_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPagos());
        }

        private void lblAdicionales_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormCargosAdicionales());

        }

        private void lblEntrega_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEntregaVehiculo());

        }

        private void lblAlquileres_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormAlquileres());

        }

        private void lblVehiculos_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormVehiculos());

        }

        private void lblClientes_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormClientes());

        }

        private void label23_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmMenuPrincipal());

        }
    }
}
