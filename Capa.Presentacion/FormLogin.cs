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
            this.StartPosition = FormStartPosition.CenterScreen;

            txtClave.UseSystemPasswordChar = true;

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = bl.Login(txtUsuario.Text, txtClave.Text);

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

                    FrmMenuPrincipal frm = new FrmMenuPrincipal();

                    frm.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Usuario o contraseña incorrectos",
                        "Inicio de Sesión",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al iniciar sesión:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {


            txtUsuario.Text = "Ingrese su usuario";
            txtUsuario.ForeColor = Color.Gray;

            txtClave.Text = "Ingrese su contraseña";
            txtClave.ForeColor = Color.Gray;



            txtUsuario.Font = new Font("Arial", 14);
            txtClave.Font = new Font("Arial", 14);
            // TITULO
            label6.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;

            // RENT A CAR
            label7.Parent = pictureBox1;
            label7.BackColor = Color.Transparent;

            // SISTEMA DE GESTION
            label8.Parent = pictureBox1;
            label8.BackColor = Color.Transparent;

            // TEXTO DE ABAJO
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;

            txtClave.UseSystemPasswordChar = false;

        }


        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingrese su usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingrese su usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "Ingrese su contraseña")
            {
                txtClave.Text = "";
                txtClave.ForeColor = Color.Black;
            }

            txtClave.PasswordChar = '*';
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.Text = "Ingrese su contraseña";
                txtClave.ForeColor = Color.Gray;
                txtClave.PasswordChar = '\0';
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(90, 0, 0, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Deseas salir del sistema?",
                    "Salir",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cerrar la aplicación:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
