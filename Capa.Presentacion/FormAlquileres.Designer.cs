namespace Capa.Presentacion
{
    partial class FormAlquileres
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
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cbEstadoAlquiler = new System.Windows.Forms.ComboBox();
            this.dgvAlquileres = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.txtPrecioDia = new System.Windows.Forms.TextBox();
            this.txtKilometrajeSalida = new System.Windows.Forms.TextBox();
            this.btnSeleccionarVehiculo = new System.Windows.Forms.Button();
            this.dtpFechaEntregaEsperada = new System.Windows.Forms.DateTimePicker();
            this.txtDiasAlquilados = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.cbCombustibleSalida = new System.Windows.Forms.ComboBox();
            this.cbEstadoDetalle = new System.Windows.Forms.ComboBox();
            this.cbEstadoSalida = new System.Windows.Forms.ComboBox();
            this.dgvDetalleAlquiler = new System.Windows.Forms.DataGridView();
            this.btnGuardarAlquiler = new System.Windows.Forms.Button();
            this.lblRol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblAlquileres = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.lblPagos = new System.Windows.Forms.Label();
            this.lblVehiculos = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleAlquiler)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(342, 44);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 24);
            this.cbCliente.TabIndex = 0;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(858, 44);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(44, 16);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "label1";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(346, 118);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaInicio.TabIndex = 2;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // cbEstadoAlquiler
            // 
            this.cbEstadoAlquiler.FormattingEnabled = true;
            this.cbEstadoAlquiler.Location = new System.Drawing.Point(346, 160);
            this.cbEstadoAlquiler.Name = "cbEstadoAlquiler";
            this.cbEstadoAlquiler.Size = new System.Drawing.Size(121, 24);
            this.cbEstadoAlquiler.TabIndex = 3;
            this.cbEstadoAlquiler.SelectedIndexChanged += new System.EventHandler(this.cbEstadoAlquiler_SelectedIndexChanged);
            // 
            // dgvAlquileres
            // 
            this.dgvAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlquileres.Location = new System.Drawing.Point(326, 220);
            this.dgvAlquileres.Name = "dgvAlquileres";
            this.dgvAlquileres.RowHeadersWidth = 51;
            this.dgvAlquileres.RowTemplate.Height = 24;
            this.dgvAlquileres.Size = new System.Drawing.Size(767, 150);
            this.dgvAlquileres.TabIndex = 4;
            this.dgvAlquileres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlquileres_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(626, 117);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(719, 120);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(847, 117);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Nuevo";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Location = new System.Drawing.Point(390, 409);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(100, 22);
            this.txtVehiculo.TabIndex = 8;
            this.txtVehiculo.TextChanged += new System.EventHandler(this.txtVehiculo_TextChanged);
            // 
            // txtPrecioDia
            // 
            this.txtPrecioDia.Location = new System.Drawing.Point(394, 447);
            this.txtPrecioDia.Name = "txtPrecioDia";
            this.txtPrecioDia.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioDia.TabIndex = 9;
            this.txtPrecioDia.TextChanged += new System.EventHandler(this.txtPrecioDia_TextChanged);
            // 
            // txtKilometrajeSalida
            // 
            this.txtKilometrajeSalida.Location = new System.Drawing.Point(465, 484);
            this.txtKilometrajeSalida.Name = "txtKilometrajeSalida";
            this.txtKilometrajeSalida.Size = new System.Drawing.Size(100, 22);
            this.txtKilometrajeSalida.TabIndex = 10;
            this.txtKilometrajeSalida.TextChanged += new System.EventHandler(this.txtKilometrajeSalida_TextChanged);
            // 
            // btnSeleccionarVehiculo
            // 
            this.btnSeleccionarVehiculo.Location = new System.Drawing.Point(502, 409);
            this.btnSeleccionarVehiculo.Name = "btnSeleccionarVehiculo";
            this.btnSeleccionarVehiculo.Size = new System.Drawing.Size(233, 23);
            this.btnSeleccionarVehiculo.TabIndex = 11;
            this.btnSeleccionarVehiculo.Text = "Seleccionar Vehiculo";
            this.btnSeleccionarVehiculo.UseVisualStyleBackColor = true;
            this.btnSeleccionarVehiculo.Click += new System.EventHandler(this.btnSeleccionarVehiculo_Click);
            // 
            // dtpFechaEntregaEsperada
            // 
            this.dtpFechaEntregaEsperada.Location = new System.Drawing.Point(326, 538);
            this.dtpFechaEntregaEsperada.Name = "dtpFechaEntregaEsperada";
            this.dtpFechaEntregaEsperada.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaEntregaEsperada.TabIndex = 12;
            this.dtpFechaEntregaEsperada.ValueChanged += new System.EventHandler(this.dtpFechaEntregaEsperada_ValueChanged);
            // 
            // txtDiasAlquilados
            // 
            this.txtDiasAlquilados.Location = new System.Drawing.Point(446, 584);
            this.txtDiasAlquilados.Name = "txtDiasAlquilados";
            this.txtDiasAlquilados.Size = new System.Drawing.Size(100, 22);
            this.txtDiasAlquilados.TabIndex = 13;
            this.txtDiasAlquilados.TextChanged += new System.EventHandler(this.txtDiasAlquilados_TextChanged);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(404, 613);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubtotal.TabIndex = 14;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // cbCombustibleSalida
            // 
            this.cbCombustibleSalida.FormattingEnabled = true;
            this.cbCombustibleSalida.Location = new System.Drawing.Point(414, 641);
            this.cbCombustibleSalida.Name = "cbCombustibleSalida";
            this.cbCombustibleSalida.Size = new System.Drawing.Size(121, 24);
            this.cbCombustibleSalida.TabIndex = 15;
            this.cbCombustibleSalida.SelectedIndexChanged += new System.EventHandler(this.cbCombustibleSalida_SelectedIndexChanged);
            // 
            // cbEstadoDetalle
            // 
            this.cbEstadoDetalle.FormattingEnabled = true;
            this.cbEstadoDetalle.Location = new System.Drawing.Point(387, 680);
            this.cbEstadoDetalle.Name = "cbEstadoDetalle";
            this.cbEstadoDetalle.Size = new System.Drawing.Size(121, 24);
            this.cbEstadoDetalle.TabIndex = 16;
            this.cbEstadoDetalle.SelectedIndexChanged += new System.EventHandler(this.cbEstadoDetalle_SelectedIndexChanged);
            // 
            // cbEstadoSalida
            // 
            this.cbEstadoSalida.FormattingEnabled = true;
            this.cbEstadoSalida.Location = new System.Drawing.Point(738, 579);
            this.cbEstadoSalida.Name = "cbEstadoSalida";
            this.cbEstadoSalida.Size = new System.Drawing.Size(121, 24);
            this.cbEstadoSalida.TabIndex = 17;
            this.cbEstadoSalida.SelectedIndexChanged += new System.EventHandler(this.cbEstadoSalida_SelectedIndexChanged);
            // 
            // dgvDetalleAlquiler
            // 
            this.dgvDetalleAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleAlquiler.Location = new System.Drawing.Point(1113, 506);
            this.dgvDetalleAlquiler.Name = "dgvDetalleAlquiler";
            this.dgvDetalleAlquiler.RowHeadersWidth = 51;
            this.dgvDetalleAlquiler.RowTemplate.Height = 24;
            this.dgvDetalleAlquiler.Size = new System.Drawing.Size(363, 175);
            this.dgvDetalleAlquiler.TabIndex = 18;
            // 
            // btnGuardarAlquiler
            // 
            this.btnGuardarAlquiler.Location = new System.Drawing.Point(775, 507);
            this.btnGuardarAlquiler.Name = "btnGuardarAlquiler";
            this.btnGuardarAlquiler.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarAlquiler.TabIndex = 19;
            this.btnGuardarAlquiler.Text = "Guardar";
            this.btnGuardarAlquiler.UseVisualStyleBackColor = true;
            this.btnGuardarAlquiler.Click += new System.EventHandler(this.btnGuardarAlquiler_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(1017, 44);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(44, 16);
            this.lblRol.TabIndex = 21;
            this.lblRol.Text = "label1";
            this.lblRol.Click += new System.EventHandler(this.lblRol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Vehiculo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Precio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Kilometrtaje de salida";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 587);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Dias Alquilados";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 616);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Subtotal";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 651);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Combustible";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 683);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Estado";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(623, 584);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Estado de salida";
            this.label8.Click += new System.EventHandler(this.label8_Click);
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
            this.panelMenu.Size = new System.Drawing.Size(207, 733);
            this.panelMenu.TabIndex = 30;
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
            this.lblCerrarSesion.Click += new System.EventHandler(this.lblCerrarSesion_Click);
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
            // 
            // FormAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 733);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.btnGuardarAlquiler);
            this.Controls.Add(this.dgvDetalleAlquiler);
            this.Controls.Add(this.cbEstadoSalida);
            this.Controls.Add(this.cbEstadoDetalle);
            this.Controls.Add(this.cbCombustibleSalida);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtDiasAlquilados);
            this.Controls.Add(this.dtpFechaEntregaEsperada);
            this.Controls.Add(this.btnSeleccionarVehiculo);
            this.Controls.Add(this.txtKilometrajeSalida);
            this.Controls.Add(this.txtPrecioDia);
            this.Controls.Add(this.txtVehiculo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvAlquileres);
            this.Controls.Add(this.cbEstadoAlquiler);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cbCliente);
            this.Name = "FormAlquileres";
            this.Text = "FormAlquileres";
            this.Load += new System.EventHandler(this.FormAlquileres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleAlquiler)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.ComboBox cbEstadoAlquiler;
        private System.Windows.Forms.DataGridView dgvAlquileres;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.TextBox txtPrecioDia;
        private System.Windows.Forms.TextBox txtKilometrajeSalida;
        private System.Windows.Forms.Button btnSeleccionarVehiculo;
        private System.Windows.Forms.DateTimePicker dtpFechaEntregaEsperada;
        private System.Windows.Forms.TextBox txtDiasAlquilados;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.ComboBox cbCombustibleSalida;
        private System.Windows.Forms.ComboBox cbEstadoDetalle;
        private System.Windows.Forms.ComboBox cbEstadoSalida;
        private System.Windows.Forms.DataGridView dgvDetalleAlquiler;
        private System.Windows.Forms.Button btnGuardarAlquiler;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblAlquileres;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.Label lblPagos;
        private System.Windows.Forms.Label lblVehiculos;
        private System.Windows.Forms.Label lblClientes;
    }
}