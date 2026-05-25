using Capa.Entidades;
using Capa.Negocios;
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
    public partial class FormRoles : Form
    {
        RolesBL bl = new RolesBL();
        Roles rolSeleccionado = new Roles();

        public FormRoles()
        {
            InitializeComponent();
        }


        private void FormRoles_Load(object sender, EventArgs e)
        {
            ListarRoles();
        }

        private void ListarRoles()
        {
            dgvRoles.DataSource = bl.Listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreRol.Text == "")
            {
                MessageBox.Show("Ingrese un nombre de rol");
                return;
            }

            Roles rol = new Roles();
            rol.Nombre_Rol = txtNombreRol.Text;

            bl.Insertar(rol);

            MessageBox.Show("Rol guardado correctamente");

            Nuevo();
            ListarRoles();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (rolSeleccionado.Id_Rol == 0)
            {
                MessageBox.Show("Seleccione un rol de la tabla");
                return;
            }

            rolSeleccionado.Nombre_Rol = txtNombreRol.Text;

            bl.Actualizar(rolSeleccionado);

            MessageBox.Show("Rol actualizado correctamente");

            Nuevo();
            ListarRoles();
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rolSeleccionado.Id_Rol = Convert.ToInt32(dgvRoles.Rows[e.RowIndex].Cells["Id_Rol"].Value);
                rolSeleccionado.Nombre_Rol = dgvRoles.Rows[e.RowIndex].Cells["Nombre_Rol"].Value.ToString();

                txtNombreRol.Text = rolSeleccionado.Nombre_Rol;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo()
        {
            txtNombreRol.Clear();
            rolSeleccionado = new Roles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm =
                      new FrmMenuPrincipal();

            frm.Show();

            this.Hide();
        }
    }
}
