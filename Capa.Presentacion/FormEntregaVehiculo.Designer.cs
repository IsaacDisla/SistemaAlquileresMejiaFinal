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
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarAlquiler = new System.Windows.Forms.Button();
            this.cbEstadoSalida = new System.Windows.Forms.ComboBox();
            this.cbCombustible = new System.Windows.Forms.ComboBox();
            this.btnBuscarDetalle = new System.Windows.Forms.Button();
            this.txtKilometraje = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvEntregas = new System.Windows.Forms.DataGridView();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.nudDiasRetraso = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasRetraso)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 582);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 52;
            this.label8.Text = "Estado de salida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Kilometrtaje ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Observaciones";
            // 
            // btnGuardarAlquiler
            // 
            this.btnGuardarAlquiler.Location = new System.Drawing.Point(489, 505);
            this.btnGuardarAlquiler.Name = "btnGuardarAlquiler";
            this.btnGuardarAlquiler.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarAlquiler.TabIndex = 45;
            this.btnGuardarAlquiler.Text = "Guardar";
            this.btnGuardarAlquiler.UseVisualStyleBackColor = true;
            // 
            // cbEstadoSalida
            // 
            this.cbEstadoSalida.FormattingEnabled = true;
            this.cbEstadoSalida.Location = new System.Drawing.Point(452, 577);
            this.cbEstadoSalida.Name = "cbEstadoSalida";
            this.cbEstadoSalida.Size = new System.Drawing.Size(121, 24);
            this.cbEstadoSalida.TabIndex = 44;
            // 
            // cbCombustible
            // 
            this.cbCombustible.FormattingEnabled = true;
            this.cbCombustible.Location = new System.Drawing.Point(251, 78);
            this.cbCombustible.Name = "cbCombustible";
            this.cbCombustible.Size = new System.Drawing.Size(121, 24);
            this.cbCombustible.TabIndex = 43;
            // 
            // btnBuscarDetalle
            // 
            this.btnBuscarDetalle.Location = new System.Drawing.Point(160, 39);
            this.btnBuscarDetalle.Name = "btnBuscarDetalle";
            this.btnBuscarDetalle.Size = new System.Drawing.Size(233, 23);
            this.btnBuscarDetalle.TabIndex = 39;
            this.btnBuscarDetalle.Text = "Seleccionar Vehiculo";
            this.btnBuscarDetalle.UseVisualStyleBackColor = true;
            this.btnBuscarDetalle.Click += new System.EventHandler(this.btnBuscarDetalle_Click);
            // 
            // txtKilometraje
            // 
            this.txtKilometraje.Location = new System.Drawing.Point(149, 164);
            this.txtKilometraje.Name = "txtKilometraje";
            this.txtKilometraje.Size = new System.Drawing.Size(100, 22);
            this.txtKilometraje.TabIndex = 38;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(292, 198);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(175, 33);
            this.txtObservaciones.TabIndex = 37;
            this.txtObservaciones.TextChanged += new System.EventHandler(this.txtObservaciones_TextChanged);
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(40, 39);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(100, 22);
            this.txtDetalle.TabIndex = 36;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(433, 118);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 35;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(340, 115);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dgvEntregas
            // 
            this.dgvEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregas.Location = new System.Drawing.Point(12, 254);
            this.dgvEntregas.Name = "dgvEntregas";
            this.dgvEntregas.RowHeadersWidth = 51;
            this.dgvEntregas.RowTemplate.Height = 24;
            this.dgvEntregas.Size = new System.Drawing.Size(767, 150);
            this.dgvEntregas.TabIndex = 33;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(42, 198);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 24);
            this.cbEstado.TabIndex = 32;
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(40, 119);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaEntrega.TabIndex = 31;
            // 
            // nudDiasRetraso
            // 
            this.nudDiasRetraso.Location = new System.Drawing.Point(43, 78);
            this.nudDiasRetraso.Name = "nudDiasRetraso";
            this.nudDiasRetraso.Size = new System.Drawing.Size(120, 22);
            this.nudDiasRetraso.TabIndex = 53;
            // 
            // FormEntregaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 703);
            this.Controls.Add(this.nudDiasRetraso);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardarAlquiler);
            this.Controls.Add(this.cbEstadoSalida);
            this.Controls.Add(this.cbCombustible);
            this.Controls.Add(this.btnBuscarDetalle);
            this.Controls.Add(this.txtKilometraje);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvEntregas);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.dtpFechaEntrega);
            this.Name = "FormEntregaVehiculo";
            this.Text = "FormEntregaVehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasRetraso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardarAlquiler;
        private System.Windows.Forms.ComboBox cbEstadoSalida;
        private System.Windows.Forms.ComboBox cbCombustible;
        private System.Windows.Forms.Button btnBuscarDetalle;
        private System.Windows.Forms.TextBox txtKilometraje;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvEntregas;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.NumericUpDown nudDiasRetraso;
    }
}