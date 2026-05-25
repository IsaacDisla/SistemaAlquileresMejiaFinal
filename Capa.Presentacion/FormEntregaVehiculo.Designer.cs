namespace Capa.Presentacion
{
    partial class FormEntregaVehiculo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCombustibleEntrada = new System.Windows.Forms.ComboBox();
            this.btnBuscarDetalle = new System.Windows.Forms.Button();
            this.txtKilometrajeEntrada = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtIdDetalle = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvEntregas = new System.Windows.Forms.DataGridView();
            this.cbEstadoEntrada = new System.Windows.Forms.ComboBox();
            this.dtFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.numDiasRetraso = new System.Windows.Forms.NumericUpDown();
            this.Detalle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAplicaRetraso = new System.Windows.Forms.CheckBox();
            this.chkTieneDanos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasRetraso)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Kilometrtaje ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(760, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Observaciones";
            // 
            // cbCombustibleEntrada
            // 
            this.cbCombustibleEntrada.FormattingEnabled = true;
            this.cbCombustibleEntrada.Location = new System.Drawing.Point(594, 92);
            this.cbCombustibleEntrada.Name = "cbCombustibleEntrada";
            this.cbCombustibleEntrada.Size = new System.Drawing.Size(121, 24);
            this.cbCombustibleEntrada.TabIndex = 43;
            // 
            // btnBuscarDetalle
            // 
            this.btnBuscarDetalle.Location = new System.Drawing.Point(715, 36);
            this.btnBuscarDetalle.Name = "btnBuscarDetalle";
            this.btnBuscarDetalle.Size = new System.Drawing.Size(233, 23);
            this.btnBuscarDetalle.TabIndex = 39;
            this.btnBuscarDetalle.Text = "Seleccionar Vehiculo";
            this.btnBuscarDetalle.UseVisualStyleBackColor = true;
            this.btnBuscarDetalle.Click += new System.EventHandler(this.btnBuscarDetalle_Click);
            // 
            // txtKilometrajeEntrada
            // 
            this.txtKilometrajeEntrada.Location = new System.Drawing.Point(604, 173);
            this.txtKilometrajeEntrada.Name = "txtKilometrajeEntrada";
            this.txtKilometrajeEntrada.Size = new System.Drawing.Size(100, 22);
            this.txtKilometrajeEntrada.TabIndex = 38;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(865, 206);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(175, 33);
            this.txtObservaciones.TabIndex = 37;
            this.txtObservaciones.TextChanged += new System.EventHandler(this.txtObservaciones_TextChanged);
            // 
            // txtIdDetalle
            // 
            this.txtIdDetalle.AcceptsReturn = true;
            this.txtIdDetalle.Location = new System.Drawing.Point(595, 35);
            this.txtIdDetalle.Name = "txtIdDetalle";
            this.txtIdDetalle.Size = new System.Drawing.Size(100, 22);
            this.txtIdDetalle.TabIndex = 36;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(965, 136);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 35;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(884, 133);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvEntregas
            // 
            this.dgvEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregas.Location = new System.Drawing.Point(382, 261);
            this.dgvEntregas.Name = "dgvEntregas";
            this.dgvEntregas.RowHeadersWidth = 51;
            this.dgvEntregas.RowTemplate.Height = 24;
            this.dgvEntregas.Size = new System.Drawing.Size(767, 150);
            this.dgvEntregas.TabIndex = 33;
            this.dgvEntregas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntregas_CellContentClick);
            // 
            // cbEstadoEntrada
            // 
            this.cbEstadoEntrada.FormattingEnabled = true;
            this.cbEstadoEntrada.Location = new System.Drawing.Point(604, 220);
            this.cbEstadoEntrada.Name = "cbEstadoEntrada";
            this.cbEstadoEntrada.Size = new System.Drawing.Size(121, 24);
            this.cbEstadoEntrada.TabIndex = 32;
            // 
            // dtFechaEntrega
            // 
            this.dtFechaEntrega.Location = new System.Drawing.Point(594, 133);
            this.dtFechaEntrega.Name = "dtFechaEntrega";
            this.dtFechaEntrega.Size = new System.Drawing.Size(200, 22);
            this.dtFechaEntrega.TabIndex = 31;
            // 
            // numDiasRetraso
            // 
            this.numDiasRetraso.Location = new System.Drawing.Point(595, 64);
            this.numDiasRetraso.Name = "numDiasRetraso";
            this.numDiasRetraso.Size = new System.Drawing.Size(120, 22);
            this.numDiasRetraso.TabIndex = 53;
            // 
            // Detalle
            // 
            this.Detalle.AutoSize = true;
            this.Detalle.Location = new System.Drawing.Point(517, 40);
            this.Detalle.Name = "Detalle";
            this.Detalle.Size = new System.Drawing.Size(50, 16);
            this.Detalle.TabIndex = 54;
            this.Detalle.Text = "Detalle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 55;
            this.label4.Text = "Dias de retaso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "Combustible";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "Fecha entrega";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Estado de entrada";
            // 
            // chkAplicaRetraso
            // 
            this.chkAplicaRetraso.AutoSize = true;
            this.chkAplicaRetraso.Location = new System.Drawing.Point(393, 69);
            this.chkAplicaRetraso.Name = "chkAplicaRetraso";
            this.chkAplicaRetraso.Size = new System.Drawing.Size(95, 20);
            this.chkAplicaRetraso.TabIndex = 59;
            this.chkAplicaRetraso.Text = "checkBox1";
            this.chkAplicaRetraso.UseVisualStyleBackColor = true;
            this.chkAplicaRetraso.CheckedChanged += new System.EventHandler(this.chkAplicaRetraso_CheckedChanged_1);
            // 
            // chkTieneDanos
            // 
            this.chkTieneDanos.AutoSize = true;
            this.chkTieneDanos.Location = new System.Drawing.Point(745, 186);
            this.chkTieneDanos.Name = "chkTieneDanos";
            this.chkTieneDanos.Size = new System.Drawing.Size(95, 20);
            this.chkTieneDanos.TabIndex = 60;
            this.chkTieneDanos.Text = "checkBox1";
            this.chkTieneDanos.UseVisualStyleBackColor = true;
            this.chkTieneDanos.CheckedChanged += new System.EventHandler(this.chkTieneDanos_CheckedChanged_1);
            // 
            // FormEntregaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 703);
            this.Controls.Add(this.chkTieneDanos);
            this.Controls.Add(this.chkAplicaRetraso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Detalle);
            this.Controls.Add(this.numDiasRetraso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCombustibleEntrada);
            this.Controls.Add(this.btnBuscarDetalle);
            this.Controls.Add(this.txtKilometrajeEntrada);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtIdDetalle);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvEntregas);
            this.Controls.Add(this.cbEstadoEntrada);
            this.Controls.Add(this.dtFechaEntrega);
            this.Name = "FormEntregaVehiculo";
            this.Text = "FormEntregaVehiculo";
            this.Load += new System.EventHandler(this.FormEntregaVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasRetraso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCombustibleEntrada;
        private System.Windows.Forms.Button btnBuscarDetalle;
        private System.Windows.Forms.TextBox txtKilometrajeEntrada;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtIdDetalle;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvEntregas;
        private System.Windows.Forms.ComboBox cbEstadoEntrada;
        private System.Windows.Forms.DateTimePicker dtFechaEntrega;
        private System.Windows.Forms.NumericUpDown numDiasRetraso;
        private System.Windows.Forms.Label Detalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAplicaRetraso;
        private System.Windows.Forms.CheckBox chkTieneDanos;
    }
}