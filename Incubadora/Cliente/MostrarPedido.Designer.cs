namespace Cliente
{
    partial class MostrarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarPedido));
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.IdIncubadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoHuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadHuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdIncubadora,
            this.NombreCompleto,
            this.TipoHuevo,
            this.CantidadHuevo,
            this.Total,
            this.FechaInicio,
            this.FechaSalida,
            this.IdNivel,
            this.IdCliente});
            this.dgvPedidos.Location = new System.Drawing.Point(12, 113);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.Size = new System.Drawing.Size(745, 213);
            this.dgvPedidos.TabIndex = 0;
            // 
            // IdIncubadora
            // 
            this.IdIncubadora.DataPropertyName = "IdIncubadora";
            this.IdIncubadora.HeaderText = "IdIncubadora";
            this.IdIncubadora.Name = "IdIncubadora";
            this.IdIncubadora.ReadOnly = true;
            this.IdIncubadora.Visible = false;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "NombreCompleto";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            // 
            // TipoHuevo
            // 
            this.TipoHuevo.DataPropertyName = "TipoHuevo";
            this.TipoHuevo.HeaderText = "Tipo de huevo";
            this.TipoHuevo.Name = "TipoHuevo";
            this.TipoHuevo.ReadOnly = true;
            // 
            // CantidadHuevo
            // 
            this.CantidadHuevo.DataPropertyName = "CantidadHuevos";
            this.CantidadHuevo.HeaderText = "Cantidad de huevos";
            this.CantidadHuevo.Name = "CantidadHuevo";
            this.CantidadHuevo.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total a pagar";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "FechaInicio";
            this.FechaInicio.HeaderText = "Fecha de entrada";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // FechaSalida
            // 
            this.FechaSalida.DataPropertyName = "FechaFinal";
            this.FechaSalida.HeaderText = "Fecha de nacimiento";
            this.FechaSalida.Name = "FechaSalida";
            this.FechaSalida.ReadOnly = true;
            // 
            // IdNivel
            // 
            this.IdNivel.DataPropertyName = "IdNivel";
            this.IdNivel.HeaderText = "Nivel";
            this.IdNivel.Name = "IdNivel";
            this.IdNivel.ReadOnly = true;
            // 
            // IdCliente
            // 
            this.IdCliente.DataPropertyName = "IdCliente";
            this.IdCliente.HeaderText = "IdCliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Visible = false;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(125, 20);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 1;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(13, 28);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(106, 13);
            this.lblFiltrar.TabIndex = 2;
            this.lblFiltrar.Text = "Mostrar por Nombre: ";
            // 
            // MostrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 368);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.dgvPedidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MostrarPedido";
            this.Text = "Mostrar Pedido";
            this.Load += new System.EventHandler(this.MostrarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdIncubadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoHuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadHuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblFiltrar;

    }
}