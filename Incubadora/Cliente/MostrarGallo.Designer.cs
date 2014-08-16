namespace Cliente
{
    partial class MostrarGallo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarGallo));
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.mcFechaNacido = new System.Windows.Forms.MonthCalendar();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dgvAnimales = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pbMostrar = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtPlacaMadre = new System.Windows.Forms.TextBox();
            this.txtPlacaPadre = new System.Windows.Forms.TextBox();
            this.lblPlacaMadre = new System.Windows.Forms.Label();
            this.lblPlacaPadre = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblPedigree = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.lblFoto = new System.Windows.Forms.Label();
            this.BuscarArchivo = new System.Windows.Forms.OpenFileDialog();
            this.GuardarArchivo = new System.Windows.Forms.SaveFileDialog();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(100, 119);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.ReadOnly = true;
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 0;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(101, 165);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(100, 20);
            this.txtRaza.TabIndex = 1;
            // 
            // mcFechaNacido
            // 
            this.mcFechaNacido.Location = new System.Drawing.Point(311, 443);
            this.mcFechaNacido.Name = "mcFechaNacido";
            this.mcFechaNacido.TabIndex = 2;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(28, 118);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(60, 18);
            this.lblPlaca.TabIndex = 3;
            this.lblPlaca.Text = "Placa :";
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaza.Location = new System.Drawing.Point(28, 168);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(57, 18);
            this.lblRaza.TabIndex = 4;
            this.lblRaza.Text = "Raza :";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(305, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(271, 35);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Lista de animales";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(341, 416);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(167, 18);
            this.lblFechaNacimiento.TabIndex = 6;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // dgvAnimales
            // 
            this.dgvAnimales.AllowUserToAddRows = false;
            this.dgvAnimales.AllowUserToDeleteRows = false;
            this.dgvAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Placa,
            this.Raza,
            this.Sexo});
            this.dgvAnimales.Location = new System.Drawing.Point(238, 58);
            this.dgvAnimales.Name = "dgvAnimales";
            this.dgvAnimales.ReadOnly = true;
            this.dgvAnimales.Size = new System.Drawing.Size(597, 344);
            this.dgvAnimales.TabIndex = 7;
            this.dgvAnimales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnimales_CellClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(433, 617);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(338, 617);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pbMostrar
            // 
            this.pbMostrar.Location = new System.Drawing.Point(582, 443);
            this.pbMostrar.Name = "pbMostrar";
            this.pbMostrar.Size = new System.Drawing.Size(253, 162);
            this.pbMostrar.TabIndex = 10;
            this.pbMostrar.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(100, 68);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 12;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress_1);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(28, 70);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(66, 18);
            this.lblBuscar.TabIndex = 13;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtPlacaMadre
            // 
            this.txtPlacaMadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlacaMadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaMadre.Location = new System.Drawing.Point(31, 396);
            this.txtPlacaMadre.Name = "txtPlacaMadre";
            this.txtPlacaMadre.Size = new System.Drawing.Size(119, 24);
            this.txtPlacaMadre.TabIndex = 26;
            // 
            // txtPlacaPadre
            // 
            this.txtPlacaPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlacaPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaPadre.Location = new System.Drawing.Point(31, 329);
            this.txtPlacaPadre.Name = "txtPlacaPadre";
            this.txtPlacaPadre.Size = new System.Drawing.Size(119, 24);
            this.txtPlacaPadre.TabIndex = 25;
            // 
            // lblPlacaMadre
            // 
            this.lblPlacaMadre.AutoSize = true;
            this.lblPlacaMadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaMadre.Location = new System.Drawing.Point(28, 364);
            this.lblPlacaMadre.Name = "lblPlacaMadre";
            this.lblPlacaMadre.Size = new System.Drawing.Size(151, 18);
            this.lblPlacaMadre.TabIndex = 24;
            this.lblPlacaMadre.Text = "Placa De La Madre";
            // 
            // lblPlacaPadre
            // 
            this.lblPlacaPadre.AutoSize = true;
            this.lblPlacaPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaPadre.Location = new System.Drawing.Point(28, 302);
            this.lblPlacaPadre.Name = "lblPlacaPadre";
            this.lblPlacaPadre.Size = new System.Drawing.Size(129, 18);
            this.lblPlacaPadre.TabIndex = 23;
            this.lblPlacaPadre.Text = "Placa Del Padre";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(27, 221);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(56, 18);
            this.lblSexo.TabIndex = 22;
            this.lblSexo.Text = "Sexo :";
            // 
            // lblPedigree
            // 
            this.lblPedigree.AutoSize = true;
            this.lblPedigree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedigree.Location = new System.Drawing.Point(44, 270);
            this.lblPedigree.Name = "lblPedigree";
            this.lblPedigree.Size = new System.Drawing.Size(113, 24);
            this.lblPedigree.TabIndex = 20;
            this.lblPedigree.Text = "PEDIGREE";
            // 
            // txtSexo
            // 
            this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.Location = new System.Drawing.Point(101, 218);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(100, 24);
            this.txtSexo.TabIndex = 27;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(31, 469);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(269, 141);
            this.txtObservaciones.TabIndex = 28;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(97, 446);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(127, 20);
            this.lblObservaciones.TabIndex = 29;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(669, 617);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(91, 23);
            this.btnAgregarImagen.TabIndex = 30;
            this.btnAgregarImagen.Text = "Agregar Imagen";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(698, 416);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(43, 18);
            this.lblFoto.TabIndex = 31;
            this.lblFoto.Text = "Foto";
            // 
            // BuscarArchivo
            // 
            this.BuscarArchivo.FileName = "openFileDialog1";
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "Placa";
            this.Placa.HeaderText = "Placa Del Animal";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            // 
            // Raza
            // 
            this.Raza.DataPropertyName = "Raza";
            this.Raza.HeaderText = "Raza";
            this.Raza.Name = "Raza";
            this.Raza.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // MostrarGallo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 662);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtPlacaMadre);
            this.Controls.Add(this.txtPlacaPadre);
            this.Controls.Add(this.lblPlacaMadre);
            this.Controls.Add(this.lblPlacaPadre);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblPedigree);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pbMostrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvAnimales);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblRaza);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.mcFechaNacido);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtPlaca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MostrarGallo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Lista de Animales";
            this.Load += new System.EventHandler(this.MostrarGallo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.MonthCalendar mcFechaNacido;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DataGridView dgvAnimales;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.PictureBox pbMostrar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtPlacaMadre;
        private System.Windows.Forms.TextBox txtPlacaPadre;
        private System.Windows.Forms.Label lblPlacaMadre;
        private System.Windows.Forms.Label lblPlacaPadre;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblPedigree;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.OpenFileDialog BuscarArchivo;
        private System.Windows.Forms.SaveFileDialog GuardarArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
    }
}