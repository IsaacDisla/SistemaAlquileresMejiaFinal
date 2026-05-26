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
            System.Windows.Forms.Label label14;
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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.lblAlquileres = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.lblPagos = new System.Windows.Forms.Label();
            this.lblVehiculos = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleAlquiler)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCliente
            // 
            this.cbCliente.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(30, 140);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(414, 31);
            this.cbCliente.TabIndex = 0;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(1108, 48);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(44, 16);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "label1";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(596, 122);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaInicio.TabIndex = 2;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // cbEstadoAlquiler
            // 
            this.cbEstadoAlquiler.FormattingEnabled = true;
            this.cbEstadoAlquiler.Location = new System.Drawing.Point(596, 164);
            this.cbEstadoAlquiler.Name = "cbEstadoAlquiler";
            this.cbEstadoAlquiler.Size = new System.Drawing.Size(121, 24);
            this.cbEstadoAlquiler.TabIndex = 3;
            this.cbEstadoAlquiler.SelectedIndexChanged += new System.EventHandler(this.cbEstadoAlquiler_SelectedIndexChanged);
            // 
            // dgvAlquileres
            // 
            this.dgvAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlquileres.Location = new System.Drawing.Point(618, 216);
            this.dgvAlquileres.Name = "dgvAlquileres";
            this.dgvAlquileres.RowHeadersWidth = 51;
            this.dgvAlquileres.RowTemplate.Height = 24;
            this.dgvAlquileres.Size = new System.Drawing.Size(767, 150);
            this.dgvAlquileres.TabIndex = 4;
            this.dgvAlquileres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlquileres_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(876, 121);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(969, 124);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(1097, 121);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Nuevo";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Location = new System.Drawing.Point(621, 405);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(100, 22);
            this.txtVehiculo.TabIndex = 8;
            this.txtVehiculo.TextChanged += new System.EventHandler(this.txtVehiculo_TextChanged);
            // 
            // txtPrecioDia
            // 
            this.txtPrecioDia.Location = new System.Drawing.Point(625, 443);
            this.txtPrecioDia.Name = "txtPrecioDia";
            this.txtPrecioDia.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioDia.TabIndex = 9;
            this.txtPrecioDia.TextChanged += new System.EventHandler(this.txtPrecioDia_TextChanged);
            // 
            // txtKilometrajeSalida
            // 
            this.txtKilometrajeSalida.Location = new System.Drawing.Point(696, 480);
            this.txtKilometrajeSalida.Name = "txtKilometrajeSalida";
            this.txtKilometrajeSalida.Size = new System.Drawing.Size(100, 22);
            this.txtKilometrajeSalida.TabIndex = 10;
            this.txtKilometrajeSalida.TextChanged += new System.EventHandler(this.txtKilometrajeSalida_TextChanged);
            // 
            // btnSeleccionarVehiculo
            // 
            this.btnSeleccionarVehiculo.Location = new System.Drawing.Point(733, 405);
            this.btnSeleccionarVehiculo.Name = "btnSeleccionarVehiculo";
            this.btnSeleccionarVehiculo.Size = new System.Drawing.Size(233, 23);
            this.btnSeleccionarVehiculo.TabIndex = 11;
            this.btnSeleccionarVehiculo.Text = "Seleccionar Vehiculo";
            this.btnSeleccionarVehiculo.UseVisualStyleBackColor = true;
            this.btnSeleccionarVehiculo.Click += new System.EventHandler(this.btnSeleccionarVehiculo_Click);
            // 
            // dtpFechaEntregaEsperada
            // 
            this.dtpFechaEntregaEsperada.Location = new System.Drawing.Point(557, 534);
            this.dtpFechaEntregaEsperada.Name = "dtpFechaEntregaEsperada";
            this.dtpFechaEntregaEsperada.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaEntregaEsperada.TabIndex = 12;
            this.dtpFechaEntregaEsperada.ValueChanged += new System.EventHandler(this.dtpFechaEntregaEsperada_ValueChanged);
            // 
            // txtDiasAlquilados
            // 
            this.txtDiasAlquilados.Location = new System.Drawing.Point(677, 580);
            this.txtDiasAlquilados.Name = "txtDiasAlquilados";
            this.txtDiasAlquilados.Size = new System.Drawing.Size(100, 22);
            this.txtDiasAlquilados.TabIndex = 13;
            this.txtDiasAlquilados.TextChanged += new System.EventHandler(this.txtDiasAlquilados_TextChanged);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(635, 609);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubtotal.TabIndex = 14;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // cbCombustibleSalida
            // 
            this.cbCombustibleSalida.FormattingEnabled = true;
            this.cbCombustibleSalida.Location = new System.Drawing.Point(645, 637);
            this.cbCombustibleSalida.Name = "cbCombustibleSalida";
            this.cbCombustibleSalida.Size = new System.Drawing.Size(121, 24);
            this.cbCombustibleSalida.TabIndex = 15;
            this.cbCombustibleSalida.SelectedIndexChanged += new System.EventHandler(this.cbCombustibleSalida_SelectedIndexChanged);
            // 
            // cbEstadoDetalle
            // 
            this.cbEstadoDetalle.FormattingEnabled = true;
            this.cbEstadoDetalle.Location = new System.Drawing.Point(618, 676);
            this.cbEstadoDetalle.Name = "cbEstadoDetalle";
            this.cbEstadoDetalle.Size = new System.Drawing.Size(121, 24);
            this.cbEstadoDetalle.TabIndex = 16;
            this.cbEstadoDetalle.SelectedIndexChanged += new System.EventHandler(this.cbEstadoDetalle_SelectedIndexChanged);
            // 
            // cbEstadoSalida
            // 
            this.cbEstadoSalida.FormattingEnabled = true;
            this.cbEstadoSalida.Location = new System.Drawing.Point(969, 575);
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
            this.dgvDetalleAlquiler.Size = new System.Drawing.Size(246, 175);
            this.dgvDetalleAlquiler.TabIndex = 18;
            // 
            // btnGuardarAlquiler
            // 
            this.btnGuardarAlquiler.Location = new System.Drawing.Point(1006, 503);
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
            this.lblRol.Location = new System.Drawing.Point(1267, 48);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(44, 16);
            this.lblRol.TabIndex = 21;
            this.lblRol.Text = "label1";
            this.lblRol.Click += new System.EventHandler(this.lblRol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Vehiculo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Precio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Kilometrtaje de salida";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 583);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Dias Alquilados";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 612);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Subtotal";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 647);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Combustible";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(557, 679);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Estado";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(854, 580);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Estado de salida";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 23);
            this.label9.TabIndex = 31;
            this.label9.Text = "Clientes";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(492, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Estado Alquiler";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblAlquileres);
            this.panel1.Controls.Add(this.lblUsuarios);
            this.panel1.Controls.Add(this.lblCerrarSesion);
            this.panel1.Controls.Add(this.lblPagos);
            this.panel1.Controls.Add(this.lblVehiculos);
            this.panel1.Controls.Add(this.lblClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 1055);
            this.panel1.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Cambria", 17.8F);
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(29, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 36);
            this.label11.TabIndex = 34;
            this.label11.Text = "GESTION";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Cambria", 17.8F);
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(29, 779);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(256, 36);
            this.label12.TabIndex = 33;
            this.label12.Text = "ADMINISTRACIÓN";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Font = new System.Drawing.Font("Cambria", 17.8F);
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(29, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 36);
            this.label13.TabIndex = 32;
            this.label13.Text = "PRINCIPAL";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 120);
            this.panel2.TabIndex = 31;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Cursor = System.Windows.Forms.Cursors.Hand;
            label14.Font = new System.Drawing.Font("Cambria", 10.8F);
            label14.ForeColor = System.Drawing.Color.DodgerBlue;
            label14.Location = new System.Drawing.Point(128, 65);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(182, 21);
            label14.TabIndex = 40;
            label14.Text = "Y ALQUILA UN COCHE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.Font = new System.Drawing.Font("Cambria", 17.8F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(126, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 36);
            this.label15.TabIndex = 39;
            this.label15.Text = "Mejia Taller";
            // 
            // lblAlquileres
            // 
            this.lblAlquileres.AutoSize = true;
            this.lblAlquileres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAlquileres.Font = new System.Drawing.Font("Cambria", 17.8F);
            this.lblAlquileres.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAlquileres.Location = new System.Drawing.Point(101, 558);
            this.lblAlquileres.Name = "lblAlquileres";
            this.lblAlquileres.Size = new System.Drawing.Size(146, 36);
            this.lblAlquileres.TabIndex = 30;
            this.lblAlquileres.Text = "Alquileres";
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsuarios.Font = new System.Drawing.Font("Cambria", 17.8F);
            this.lblUsuarios.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUsuarios.Location = new System.Drawing.Point(68, 845);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(128, 36);
            this.lblUsuarios.TabIndex = 29;
            this.lblUsuarios.Text = "Usuarios";
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrarSesion.Font = new System.Drawing.Font("Cambria", 17.8F);
            this.lblCerrarSesion.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCerrarSesion.Location = new System.Drawing.Point(52, 983);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(188, 36);
            this.lblCerrarSesion.TabIndex = 28;
            this.lblCerrarSesion.Text = "Cerrar Sesion";
            // 
            // lblPagos
            // 
            this.lblPagos.AutoSize = true;
            this.lblPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPagos.Font = new System.Drawing.Font("Cambria", 17.8F);
            this.lblPagos.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPagos.Location = new System.Drawing.Point(101, 644);
            this.lblPagos.Name = "lblPagos";
            this.lblPagos.Size = new System.Drawing.Size(90, 36);
            this.lblPagos.TabIndex = 27;
            this.lblPagos.Text = "Pagos";
            // 
            // lblVehiculos
            // 
            this.lblVehiculos.AutoSize = true;
            this.lblVehiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVehiculos.Font = new System.Drawing.Font("Cambria", 17.8F);
            this.lblVehiculos.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVehiculos.Location = new System.Drawing.Point(101, 466);
            this.lblVehiculos.Name = "lblVehiculos";
            this.lblVehiculos.Size = new System.Drawing.Size(138, 36);
            this.lblVehiculos.TabIndex = 26;
            this.lblVehiculos.Text = "Vehiculos";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClientes.Font = new System.Drawing.Font("Cambria", 17.8F);
            this.lblClientes.ForeColor = System.Drawing.SystemColors.Window;
            this.lblClientes.Location = new System.Drawing.Point(101, 380);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(118, 36);
            this.lblClientes.TabIndex = 25;
            this.lblClientes.Text = "Clientes";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Capa.Presentacion.Properties.Resources.cartera;
            this.pictureBox4.Location = new System.Drawing.Point(45, 644);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Capa.Presentacion.Properties.Resources.senal_de_alquiler;
            this.pictureBox3.Location = new System.Drawing.Point(45, 558);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Capa.Presentacion.Properties.Resources.lado_del_coche;
            this.pictureBox2.Location = new System.Drawing.Point(45, 466);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Capa.Presentacion.Properties.Resources.usuarios;
            this.pictureBox1.Location = new System.Drawing.Point(45, 380);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = global::Capa.Presentacion.Properties.Resources.coche_trasero__1_;
            this.pictureBox5.Location = new System.Drawing.Point(34, 29);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(73, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.cbCliente);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(1447, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(475, 665);
            this.panel4.TabIndex = 35;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(1205, 29);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 33);
            this.label24.TabIndex = 22;
            this.label24.Text = "label1";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1356, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 33);
            this.label23.TabIndex = 23;
            this.label23.Text = "label1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label22.Font = new System.Drawing.Font("Cambria", 17.8F);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(32, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(432, 36);
            this.label22.TabIndex = 39;
            this.label22.Text = "PANEL DE CONTROL PRINCIPAL";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Location = new System.Drawing.Point(427, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1658, 120);
            this.panel3.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label16.Font = new System.Drawing.Font("Cambria", 17.8F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(24, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(242, 36);
            this.label16.TabIndex = 39;
            this.label16.Text = "Datos del alquiler";
            // 
            // FormAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label10);
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
            this.Name = "FormAlquileres";
            this.Text = "FormAlquileres";
            this.Load += new System.EventHandler(this.FormAlquileres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleAlquiler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblAlquileres;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.Label lblPagos;
        private System.Windows.Forms.Label lblVehiculos;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
    }
}