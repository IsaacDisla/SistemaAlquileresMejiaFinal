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
    }
}
