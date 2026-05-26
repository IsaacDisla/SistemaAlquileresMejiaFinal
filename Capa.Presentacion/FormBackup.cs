using System; 
using Capa.Negocios;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Capa.Presentacion
{
    public partial class FormBackup : Form
    {
        BackupBLL backup = new BackupBLL();
        public FormBackup()
        {
            InitializeComponent();
        }

        private void FormBackup_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            string carpeta = @"C:\BackupsSistema";

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            if (dgvHistorial.Columns.Count == 0)
            {
                dgvHistorial.Columns.Add("Archivo", "Archivo");
                dgvHistorial.Columns.Add("Fecha", "Fecha");
                dgvHistorial.Columns.Add("Tamano", "Tamaño");
            }

            DirectoryInfo dir = new DirectoryInfo(carpeta);

            FileInfo[] archivos = dir.GetFiles("*.bak")
                                     .OrderByDescending(x => x.CreationTime)
                                     .ToArray();

            dgvHistorial.Rows.Clear();

            foreach (FileInfo file in archivos)
            {
                dgvHistorial.Rows.Add(
                    file.Name,
                    file.CreationTime.ToString("dd/MM/yyyy hh:mm tt"),
                    (file.Length / 1024) + " KB"
                );
            }

            if (archivos.Length > 0)
            {
                FileInfo ultimo = archivos.First();

                lblUltimoBackup.Text =
                    "Último Backup: " + ultimo.CreationTime.ToString("dd/MM/yyyy hh:mm tt");
            }
            else
            {
                lblUltimoBackup.Text = "Último Backup: No hay backups";
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                backup.HacerBackup();

                MessageBox.Show("Backup realizado correctamente.",
                                "Backup",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                CargarHistorial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar backup: " + ex.Message);
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult pregunta = MessageBox.Show(
                    "¿Deseas restaurar la base de datos?\nSe perderán los cambios actuales.",
                    "Confirmar restauración",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (pregunta == DialogResult.No)
                    return;

                OpenFileDialog open = new OpenFileDialog();

                open.Filter = "Backup SQL (*.bak)|*.bak";
                open.InitialDirectory = @"C:\BackupsSistema";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    backup.Restaurar(open.FileName);

                    MessageBox.Show("Base de datos restaurada correctamente.",
                                    "Restauración",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    CargarHistorial();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restaurar backup: " + ex.Message);
            }
        }
    }
}
