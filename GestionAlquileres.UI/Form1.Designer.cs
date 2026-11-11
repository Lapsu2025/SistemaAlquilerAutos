namespace GestionAlquileres.UI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAutos = new System.Windows.Forms.DataGridView();
            this.btnAutos = new System.Windows.Forms.Button();
            this.btnAlquileres = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnDevolverAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutos
            // 
            this.dgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutos.Location = new System.Drawing.Point(12, 7);
            this.dgvAutos.Name = "dgvAutos";
            this.dgvAutos.RowHeadersWidth = 51;
            this.dgvAutos.RowTemplate.Height = 24;
            this.dgvAutos.Size = new System.Drawing.Size(776, 340);
            this.dgvAutos.TabIndex = 0;
            // 
            // btnAutos
            // 
            this.btnAutos.Location = new System.Drawing.Point(94, 388);
            this.btnAutos.Name = "btnAutos";
            this.btnAutos.Size = new System.Drawing.Size(97, 32);
            this.btnAutos.TabIndex = 1;
            this.btnAutos.Text = "Autos";
            this.btnAutos.UseVisualStyleBackColor = true;
            // 
            // btnAlquileres
            // 
            this.btnAlquileres.Location = new System.Drawing.Point(453, 388);
            this.btnAlquileres.Name = "btnAlquileres";
            this.btnAlquileres.Size = new System.Drawing.Size(96, 32);
            this.btnAlquileres.TabIndex = 3;
            this.btnAlquileres.Text = "Alquileres ";
            this.btnAlquileres.UseVisualStyleBackColor = true;
            this.btnAlquileres.Click += new System.EventHandler(this.btnAlquileres_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(253, 388);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(109, 32);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes ";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnDevolverAuto
            // 
            this.btnDevolverAuto.Location = new System.Drawing.Point(644, 388);
            this.btnDevolverAuto.Name = "btnDevolverAuto";
            this.btnDevolverAuto.Size = new System.Drawing.Size(118, 32);
            this.btnDevolverAuto.TabIndex = 6;
            this.btnDevolverAuto.Text = "Devolver Auto";
            this.btnDevolverAuto.UseVisualStyleBackColor = true;
            this.btnDevolverAuto.Click += new System.EventHandler(this.btnDevolverAuto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDevolverAuto);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnAlquileres);
            this.Controls.Add(this.btnAutos);
            this.Controls.Add(this.dgvAutos);
            this.Name = "Form1";
            this.Text = "Sistema de Alquiler de Autos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutos;
        private System.Windows.Forms.Button btnAutos;
        private System.Windows.Forms.Button btnAlquileres;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnDevolverAuto;
    }
}

