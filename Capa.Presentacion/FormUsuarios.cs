using Capa.Entidades;
using Capa.Negocios;
using Microsoft.VisualBasic;
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
    public partial class FormUsuarios : Form
    {
        UsuariosBL blUsuarios = new UsuariosBL();
        RolesBL blRoles = new RolesBL();

        int idUsuarioSeleccionado = 0;

        public FormUsuarios()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

        }

        private void CargarUsuarios()
        {
            dataGridView1.DataSource = blUsuarios.Listar();

            dataGridView1.Columns["Estado"].Visible = false;


          
        }
        private void ConfigurarGrid()
        {
            dataGridView1.Columns["Clave"].Visible = false;

            if (!dataGridView1.Columns.Contains("VerClave"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                btn.Name = "VerClave";
                btn.HeaderText = "Contraseña";
                btn.Text = "Ver";
                btn.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(btn);
            }
        }

        public bool ValidarAdmin(string clave)
        {
            DataTable dt = blUsuarios.Listar();

            foreach (DataRow row in dt.Rows)
            {
                if (row["Rol"].ToString() == "Administrador"
                    && row["Clave"].ToString() == clave)
                {
                    return true;
                }
            }

            return false;
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

        private void EstiloGridUsuarios()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 0, 102);

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI Semibold", 12, FontStyle.Bold);

            dataGridView1.ColumnHeadersHeight = 45;

            dataGridView1.DefaultCellStyle.BackColor =
                Color.White;

            dataGridView1.DefaultCellStyle.ForeColor =
                Color.Black;

            dataGridView1.DefaultCellStyle.Font =
                new Font("Segoe UI", 11);

            dataGridView1.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(65, 105, 225);

            dataGridView1.DefaultCellStyle.SelectionForeColor =
                Color.White;

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            dataGridView1.GridColor =
                Color.LightGray;

            dataGridView1.RowTemplate.Height = 35;

            dataGridView1.RowHeadersVisible = false;

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.AllowUserToDeleteRows = false;

            dataGridView1.AllowUserToResizeRows = false;

            dataGridView1.ReadOnly = true;
        }
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            EstiloGridUsuarios();

            CargarRoles();      // 🔥 IMPORTANTE
            CargarUsuarios();
            ConfigurarGrid();

            lblUsuario.Text = Sesion.Nombre;
            lblRol.Text = Sesion.Rol;

            AplicarPermisos();

        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AbrirFormulario(Form formulario)
        {
            formulario.Show();
            this.Hide();
        }

        private void lblUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormUsuarios());
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                idUsuarioSeleccionado = Convert.ToInt32(row.Cells["Id_Usuario"].Value);
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtUsuario.Text = row.Cells["Usuario"].Value.ToString();
                txtClave.Clear();

                cbRol.Text = row.Cells["Rol"].Value.ToString();

                if (e.RowIndex < 0)
                    return;

                if (e.ColumnIndex == dataGridView1.Columns["VerClave"].Index)
                {
                    string claveAdmin = Interaction.InputBox(
                        "Ingrese la clave de administrador:",
                        "Validación",
                        "");

                    if (ValidarAdmin(claveAdmin))
                    {
                        string claveUsuario = dataGridView1.Rows[e.RowIndex]
                            .Cells["Clave"].Value.ToString();

                        MessageBox.Show(
                            "La contraseña es: " + claveUsuario,
                            "Contraseña",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(
                            "Contraseña incorrecta",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    return;
                }

                // Cargar datos del usuario seleccionado

                idUsuarioSeleccionado = Convert.ToInt32(row.Cells["Id_Usuario"].Value);
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtUsuario.Text = row.Cells["Usuario"].Value.ToString();

                // NO mostrar contraseña
                txtClave.Clear();

                cbRol.Text = row.Cells["Rol"].Value.ToString();
            }
        }

        private void lblRoles_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormRoles());

        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
      "¿Deseas cerrar sesión?",
      "Cerrar Sesión",
      MessageBoxButtons.YesNo,
      MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Sesion.IdUsuario = 0;
                Sesion.Nombre = "";
                Sesion.Rol = "";

                FormLogin login = new FormLogin();
                login.Show();

                this.Close();
            }
        }

        private void lblReportes_Click(object sender, EventArgs e)
        {
            FormReportes frm = new FormReportes();

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }

        private void lblUsuarios_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormUsuarios());

        }

        private void lblClientes_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormClientes());

        }

        private void label9_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Menu_FacturaAlquiler());

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.Nombre = txtNombre.Text;
            u.Usuario = txtUsuario.Text;
            u.Clave = txtClave.Text;
            u.Id_Rol = Convert.ToInt32(cbRol.SelectedValue);

            blUsuarios.Insertar(u);

            MessageBox.Show("Usuario guardado");
            CargarUsuarios();
            Limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un usuario primero");
                return;
            }

            if (cbRol.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un rol válido");
                return;
            }

            Usuarios usuario = new Usuarios();

            usuario.Id_Usuario = idUsuarioSeleccionado;
            usuario.Id_Rol = Convert.ToInt32(cbRol.SelectedValue);
            usuario.Nombre = txtNombre.Text ?? "";
            usuario.Usuario = txtUsuario.Text ?? "";
            usuario.Clave = txtClave.Text ?? "";
            usuario.Estado = true;

            UsuariosBL bl = new UsuariosBL();
            bl.ActualizarUsuario(usuario);

            MessageBox.Show("Usuario actualizado correctamente");

            Limpiar();
            CargarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }

            blUsuarios.Eliminar(idUsuarioSeleccionado);

            MessageBox.Show("Usuario eliminado");
            CargarUsuarios();
            Limpiar();
        }

        private void CargarRoles()
        {
            UsuariosBL bl = new UsuariosBL();
            cbRol.DataSource = blRoles.Listar();
            cbRol.DisplayMember = "Nombre_Rol";
            cbRol.ValueMember = "Id_Rol";
        }
        

        private void Limpiar()
        {
            txtNombre.Clear();
            txtUsuario.Clear();
            txtClave.Clear();
            cbRol.SelectedIndex = 0;
            idUsuarioSeleccionado = 0;
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
              txtClave.Clear();
    txtClave.Focus();

    MessageBox.Show(
        "Escriba la nueva contraseña y luego pulse Actualizar.");
        }
    }
}
