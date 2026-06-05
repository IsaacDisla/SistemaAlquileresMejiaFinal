namespace Capa.Presentacion
{
    partial class FormBuscarAlquilerPago
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
            this.dgvAlquileres = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlquileres
            // 
            this.dgvAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlquileres.Location = new System.Drawing.Point(42, 166);
            this.dgvAlquileres.Name = "dgvAlquileres";
            this.dgvAlquileres.RowHeadersWidth = 51;
            this.dgvAlquileres.RowTemplate.Height = 24;
            this.dgvAlquileres.Size = new System.Drawing.Size(1408, 464);
            this.dgvAlquileres.TabIndex = 0;
            this.dgvAlquileres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlquileres_CellContentClick);
            this.dgvAlquileres.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlquileres_CellContentDoubleClick_1);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(42, 72);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1408, 97);
            this.panel7.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 41);
            this.label1.TabIndex = 40;
            this.label1.Text = "Lista de clientes";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(32, 22);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(167, 44);
            this.btnCerrar.TabIndex = 44;
            this.btnCerrar.Text = "Cerrar Formulario";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormBuscarAlquilerPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 661);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.dgvAlquileres);
            this.Name = "FormBuscarAlquilerPago";
            this.Text = "FormBuscarAlquilerPago";
            this.Load += new System.EventHandler(this.FormBuscarAlquilerPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlquileres;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
    }
}