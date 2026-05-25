namespace Capa.Presentacion
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRol = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblVehiculos = new System.Windows.Forms.Label();
            this.lblPagos = new System.Windows.Forms.Label();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.lblAlquileres = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(648, 77);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(44, 16);
            this.lblRol.TabIndex = 23;
            this.lblRol.Text = "label1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(489, 77);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(44, 16);
            this.lblUsuario.TabIndex = 22;
            this.lblUsuario.Text = "label1";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelMenu.Controls.Add(this.lblAlquileres);
            this.panelMenu.Controls.Add(this.lblUsuarios);
            this.panelMenu.Controls.Add(this.lblCerrarSesion);
            this.panelMenu.Controls.Add(this.lblPagos);
            this.panelMenu.Controls.Add(this.lblVehiculos);
            this.panelMenu.Controls.Add(this.lblClientes);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(207, 1018);
            this.panelMenu.TabIndex = 24;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClientes.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.SystemColors.Window;
            this.lblClientes.Location = new System.Drawing.Point(12, 165);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(117, 32);
            this.lblClientes.TabIndex = 25;
            this.lblClientes.Text = "Clientes";
            this.lblClientes.Click += new System.EventHandler(this.lblClientes_Click);
            this.lblClientes.Enter += new System.EventHandler(this.Label_MouseEnter);
            this.lblClientes.Leave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // lblVehiculos
            // 
            this.lblVehiculos.AutoSize = true;
            this.lblVehiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVehiculos.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculos.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVehiculos.Location = new System.Drawing.Point(16, 215);
            this.lblVehiculos.Name = "lblVehiculos";
            this.lblVehiculos.Size = new System.Drawing.Size(136, 32);
            this.lblVehiculos.TabIndex = 26;
            this.lblVehiculos.Text = "Vehiculos";
            this.lblVehiculos.Click += new System.EventHandler(this.lblVehiculos_Click);
            this.lblVehiculos.Enter += new System.EventHandler(this.Label_MouseEnter);
            this.lblVehiculos.Leave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // lblPagos
            // 
            this.lblPagos.AutoSize = true;
            this.lblPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPagos.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagos.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPagos.Location = new System.Drawing.Point(16, 369);
            this.lblPagos.Name = "lblPagos";
            this.lblPagos.Size = new System.Drawing.Size(90, 32);
            this.lblPagos.TabIndex = 27;
            this.lblPagos.Text = "Pagos";
            this.lblPagos.Click += new System.EventHandler(this.lblPagos_Click);
            this.lblPagos.Enter += new System.EventHandler(this.Label_MouseEnter);
            this.lblPagos.Leave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrarSesion.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarSesion.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCerrarSesion.Location = new System.Drawing.Point(12, 513);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(185, 32);
            this.lblCerrarSesion.TabIndex = 28;
            this.lblCerrarSesion.Text = "Cerrar Sesion";
            this.lblCerrarSesion.Click += new System.EventHandler(this.lblClientes_Click);
            this.lblCerrarSesion.Enter += new System.EventHandler(this.Label_MouseEnter);
            this.lblCerrarSesion.Leave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsuarios.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUsuarios.Location = new System.Drawing.Point(32, 438);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(124, 32);
            this.lblUsuarios.TabIndex = 29;
            this.lblUsuarios.Text = "Usuarios";
            this.lblUsuarios.Click += new System.EventHandler(this.lblVehiculos_Click);
            this.lblUsuarios.Enter += new System.EventHandler(this.Label_MouseEnter);
            this.lblUsuarios.Leave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // lblAlquileres
            // 
            this.lblAlquileres.AutoSize = true;
            this.lblAlquileres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAlquileres.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquileres.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAlquileres.Location = new System.Drawing.Point(16, 274);
            this.lblAlquileres.Name = "lblAlquileres";
            this.lblAlquileres.Size = new System.Drawing.Size(140, 32);
            this.lblAlquileres.TabIndex = 30;
            this.lblAlquileres.Text = "Alquileres";
            this.lblAlquileres.Click += new System.EventHandler(this.lblAlquileres_Click);
            this.lblAlquileres.Enter += new System.EventHandler(this.Label_MouseEnter);
            this.lblAlquileres.Leave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 1018);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblUsuario);
            this.Name = "FrmMenuPrincipal";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.Label lblPagos;
        private System.Windows.Forms.Label lblVehiculos;
        private System.Windows.Forms.Label lblAlquileres;
    }
}