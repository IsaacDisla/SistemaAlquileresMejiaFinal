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
        }

        private void Menu_FacturaAlquiler_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();

            dgvFactura.DataSource = negocio.MostrarTodasFacturas();

            DarFormatoColumnas();
            ColorearBalance();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar facturas: " + ex.Message);
            }
        }
    }
}
