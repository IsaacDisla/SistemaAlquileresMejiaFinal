using Capa.Entidades;
using System.Data;
using Capa.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.Presentacion
{
    public partial class FormLogin : Form
    {
        UsuariosBL bl = new UsuariosBL();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            DataTable dt =
             bl.Login(txtUsuario.Text, txtClave.Text);

            if (dt.Rows.Count > 0)
            {
                Sesion.IdUsuario =
                Convert.ToInt32(dt.Rows[0]["Id_Usuario"]);

                Sesion.Nombre =
                dt.Rows[0]["Nombre"].ToString();

                Sesion.Usuario =
                dt.Rows[0]["Usuario"].ToString();

                Sesion.Rol =
                dt.Rows[0]["Nombre_Rol"].ToString();

                MessageBox.Show("Bienvenido " + Sesion.Nombre);

                FrmMenuPrincipal frm =
                new FrmMenuPrincipal();

                frm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
