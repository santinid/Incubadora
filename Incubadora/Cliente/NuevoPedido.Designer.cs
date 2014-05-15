namespace Cliente
{
    partial class NuevoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoPedido));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.txtFechaFinal = new System.Windows.Forms.TextBox();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.txtCantidadHuevos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cbTipoHuevo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-6, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Incubadora Granja Los Limon";
            // 
            // cmbNivel
            // 
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Items.AddRange(new object[] {
            "0"});
            this.cmbNivel.Location = new System.Drawing.Point(156, 284);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(109, 21);
            this.cmbNivel.TabIndex = 30;
            this.cmbNivel.Text = "Seleccionar";
            this.cmbNivel.SelectedIndexChanged += new System.EventHandler(this.cmbNivel_SelectedIndexChanged);
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(156, 46);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(255, 21);
            this.cmbCliente.TabIndex = 29;
            this.cmbCliente.Text = "Seleccionar";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Location = new System.Drawing.Point(156, 247);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(109, 20);
            this.txtTotalPagar.TabIndex = 28;
            // 
            // txtFechaFinal
            // 
            this.txtFechaFinal.Enabled = false;
            this.txtFechaFinal.Location = new System.Drawing.Point(156, 210);
            this.txtFechaFinal.Name = "txtFechaFinal";
            this.txtFechaFinal.Size = new System.Drawing.Size(109, 20);
            this.txtFechaFinal.TabIndex = 27;
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Enabled = false;
            this.txtFechaInicio.Location = new System.Drawing.Point(156, 171);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(109, 20);
            this.txtFechaInicio.TabIndex = 26;
            // 
            // txtCantidadHuevos
            // 
            this.txtCantidadHuevos.Location = new System.Drawing.Point(156, 89);
            this.txtCantidadHuevos.Name = "txtCantidadHuevos";
            this.txtCantidadHuevos.Size = new System.Drawing.Size(109, 20);
            this.txtCantidadHuevos.TabIndex = 24;
            this.txtCantidadHuevos.TextChanged += new System.EventHandler(this.txtCantidadHuevos_TextChanged);
            this.txtCantidadHuevos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadHuevos_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nivel de Incubadora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Total a Pagar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha de Entrega";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fecha de Llegada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tipo de Huevo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cantidad de Huevos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cliente";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(255, 329);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(336, 329);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 32;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cbTipoHuevo
            // 
            this.cbTipoHuevo.FormattingEnabled = true;
            this.cbTipoHuevo.Items.AddRange(new object[] {
            "Gallina",
            "Ganso",
            "Faisán",
            "Pato",
            "Pavo Real"});
            this.cbTipoHuevo.Location = new System.Drawing.Point(156, 131);
            this.cbTipoHuevo.Name = "cbTipoHuevo";
            this.cbTipoHuevo.Size = new System.Drawing.Size(109, 21);
            this.cbTipoHuevo.TabIndex = 33;
            this.cbTipoHuevo.Text = "Seleccionar";
            this.cbTipoHuevo.SelectedIndexChanged += new System.EventHandler(this.cbTipoHuevo_SelectedIndexChanged);
            // 
            // NuevoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 364);
            this.Controls.Add(this.cbTipoHuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.txtFechaFinal);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.txtCantidadHuevos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.TextBox txtFechaFinal;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.TextBox txtCantidadHuevos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cbTipoHuevo;

    }
}