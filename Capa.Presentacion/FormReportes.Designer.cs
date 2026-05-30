namespace Capa.Presentacion
{
    partial class FormReportes
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnReporteVehiculos = new System.Windows.Forms.Button();
            this.btnReporteAlquileres = new System.Windows.Forms.Button();
            this.btnReporteClientes = new System.Windows.Forms.Button();
            this.btnReportePagos = new System.Windows.Forms.Button();
            this.btnReporteCargos = new System.Windows.Forms.Button();
            this.btnReporteEntregas = new System.Windows.Forms.Button();
            this.btnReportePendientes = new System.Windows.Forms.Button();
            this.btnReporteFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTE DEL SISTEMA";
            // 
            // btnReporteVehiculos
            // 
            this.btnReporteVehiculos.Location = new System.Drawing.Point(157, 126);
            this.btnReporteVehiculos.Name = "btnReporteVehiculos";
            this.btnReporteVehiculos.Size = new System.Drawing.Size(257, 23);
            this.btnReporteVehiculos.TabIndex = 3;
            this.btnReporteVehiculos.Text = "Vehículos Más Alquilados";
            this.btnReporteVehiculos.UseVisualStyleBackColor = true;
            // 
            // btnReporteAlquileres
            // 
            this.btnReporteAlquileres.Location = new System.Drawing.Point(157, 174);
            this.btnReporteAlquileres.Name = "btnReporteAlquileres";
            this.btnReporteAlquileres.Size = new System.Drawing.Size(257, 23);
            this.btnReporteAlquileres.TabIndex = 4;
            this.btnReporteAlquileres.Text = "Alquileres Realizados";
            this.btnReporteAlquileres.UseVisualStyleBackColor = true;
            // 
            // btnReporteClientes
            // 
            this.btnReporteClientes.Location = new System.Drawing.Point(157, 216);
            this.btnReporteClientes.Name = "btnReporteClientes";
            this.btnReporteClientes.Size = new System.Drawing.Size(257, 23);
            this.btnReporteClientes.TabIndex = 5;
            this.btnReporteClientes.Text = "Historial de Cliente";
            this.btnReporteClientes.UseVisualStyleBackColor = true;
            // 
            // btnReportePagos
            // 
            this.btnReportePagos.Location = new System.Drawing.Point(151, 255);
            this.btnReportePagos.Name = "btnReportePagos";
            this.btnReportePagos.Size = new System.Drawing.Size(257, 23);
            this.btnReportePagos.TabIndex = 6;
            this.btnReportePagos.Text = "Pagos";
            this.btnReportePagos.UseVisualStyleBackColor = true;
            // 
            // btnReporteCargos
            // 
            this.btnReporteCargos.Location = new System.Drawing.Point(157, 297);
            this.btnReporteCargos.Name = "btnReporteCargos";
            this.btnReporteCargos.Size = new System.Drawing.Size(268, 22);
            this.btnReporteCargos.TabIndex = 7;
            this.btnReporteCargos.Text = "Cargos Adicionales";
            this.btnReporteCargos.UseVisualStyleBackColor = true;
            // 
            // btnReporteEntregas
            // 
            this.btnReporteEntregas.Location = new System.Drawing.Point(168, 338);
            this.btnReporteEntregas.Name = "btnReporteEntregas";
            this.btnReporteEntregas.Size = new System.Drawing.Size(257, 23);
            this.btnReporteEntregas.TabIndex = 8;
            this.btnReporteEntregas.Text = "Entregas de Vehículos";
            this.btnReporteEntregas.UseVisualStyleBackColor = true;
            // 
            // btnReportePendientes
            // 
            this.btnReportePendientes.Location = new System.Drawing.Point(169, 385);
            this.btnReportePendientes.Name = "btnReportePendientes";
            this.btnReportePendientes.Size = new System.Drawing.Size(257, 23);
            this.btnReportePendientes.TabIndex = 9;
            this.btnReportePendientes.Text = "Pendientes de Pago";
            this.btnReportePendientes.UseVisualStyleBackColor = true;
            // 
            // btnReporteFactura
            // 
            this.btnReporteFactura.Location = new System.Drawing.Point(161, 453);
            this.btnReporteFactura.Name = "btnReporteFactura";
            this.btnReporteFactura.Size = new System.Drawing.Size(257, 23);
            this.btnReporteFactura.TabIndex = 10;
            this.btnReporteFactura.Text = "Factura de Alquiler";
            this.btnReporteFactura.UseVisualStyleBackColor = true;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.btnReporteFactura);
            this.Controls.Add(this.btnReportePendientes);
            this.Controls.Add(this.btnReporteEntregas);
            this.Controls.Add(this.btnReporteCargos);
            this.Controls.Add(this.btnReportePagos);
            this.Controls.Add(this.btnReporteClientes);
            this.Controls.Add(this.btnReporteAlquileres);
            this.Controls.Add(this.btnReporteVehiculos);
            this.Controls.Add(this.label1);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReporteVehiculos;
        private System.Windows.Forms.Button btnReporteAlquileres;
        private System.Windows.Forms.Button btnReporteClientes;
        private System.Windows.Forms.Button btnReportePagos;
        private System.Windows.Forms.Button btnReporteCargos;
        private System.Windows.Forms.Button btnReporteEntregas;
        private System.Windows.Forms.Button btnReportePendientes;
        private System.Windows.Forms.Button btnReporteFactura;
    }
}