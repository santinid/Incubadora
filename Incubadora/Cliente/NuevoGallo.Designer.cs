namespace Cliente
{
    partial class NuevoGallo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoGallo));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.mcFechaNacido = new System.Windows.Forms.MonthCalendar();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblFoto = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.BuscarArchivo = new System.Windows.Forms.OpenFileDialog();
            this.GuardarArchivo = new System.Windows.Forms.SaveFileDialog();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.lblPedigree = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblPlacaPadre = new System.Windows.Forms.Label();
            this.lblPlacaMadre = new System.Windows.Forms.Label();
            this.txtPlacaPadre = new System.Windows.Forms.TextBox();
            this.txtPlacaMadre = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(518, 438);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(22, 97);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(50, 18);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa";
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaza.Location = new System.Drawing.Point(25, 133);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(47, 18);
            this.lblRaza.TabIndex = 2;
            this.lblRaza.Text = "Raza";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(303, 70);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(167, 18);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // mcFechaNacido
            // 
            this.mcFechaNacido.Location = new System.Drawing.Point(265, 97);
            this.mcFechaNacido.Name = "mcFechaNacido";
            this.mcFechaNacido.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(280, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(201, 35);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Nueva Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(86, 98);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(142, 24);
            this.txtPlaca.TabIndex = 6;
            this.txtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // txtRaza
            // 
            this.txtRaza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaza.Location = new System.Drawing.Point(86, 134);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(142, 24);
            this.txtRaza.TabIndex = 7;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(608, 438);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(594, 70);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(43, 18);
            this.lblFoto.TabIndex = 9;
            this.lblFoto.Text = "Foto";
            // 
            // pbImagen
            // 
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Location = new System.Drawing.Point(504, 97);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(210, 162);
            this.pbImagen.TabIndex = 10;
            this.pbImagen.TabStop = false;
            // 
            // BuscarArchivo
            // 
            this.BuscarArchivo.FileName = "openFileDialog1";
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(559, 265);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(109, 22);
            this.btnExaminar.TabIndex = 11;
            this.btnExaminar.Text = "Agregar Imagen";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // lblPedigree
            // 
            this.lblPedigree.AutoSize = true;
            this.lblPedigree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedigree.Location = new System.Drawing.Point(41, 229);
            this.lblPedigree.Name = "lblPedigree";
            this.lblPedigree.Size = new System.Drawing.Size(113, 24);
            this.lblPedigree.TabIndex = 12;
            this.lblPedigree.Text = "PEDIGREE";
            // 
            // cbSexo
            // 
            this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbSexo.Location = new System.Drawing.Point(85, 176);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(143, 26);
            this.cbSexo.TabIndex = 13;
            this.cbSexo.Text = "Seleccionar";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(26, 179);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(46, 18);
            this.lblSexo.TabIndex = 14;
            this.lblSexo.Text = "Sexo";
            // 
            // lblPlacaPadre
            // 
            this.lblPlacaPadre.AutoSize = true;
            this.lblPlacaPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaPadre.Location = new System.Drawing.Point(25, 261);
            this.lblPlacaPadre.Name = "lblPlacaPadre";
            this.lblPlacaPadre.Size = new System.Drawing.Size(129, 18);
            this.lblPlacaPadre.TabIndex = 16;
            this.lblPlacaPadre.Text = "Placa Del Padre";
            // 
            // lblPlacaMadre
            // 
            this.lblPlacaMadre.AutoSize = true;
            this.lblPlacaMadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaMadre.Location = new System.Drawing.Point(25, 323);
            this.lblPlacaMadre.Name = "lblPlacaMadre";
            this.lblPlacaMadre.Size = new System.Drawing.Size(151, 18);
            this.lblPlacaMadre.TabIndex = 17;
            this.lblPlacaMadre.Text = "Placa De La Madre";
            // 
            // txtPlacaPadre
            // 
            this.txtPlacaPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlacaPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaPadre.Location = new System.Drawing.Point(28, 288);
            this.txtPlacaPadre.Name = "txtPlacaPadre";
            this.txtPlacaPadre.Size = new System.Drawing.Size(119, 24);
            this.txtPlacaPadre.TabIndex = 18;
            this.txtPlacaPadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlacaPadre_KeyPress);
            // 
            // txtPlacaMadre
            // 
            this.txtPlacaMadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlacaMadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaMadre.Location = new System.Drawing.Point(28, 355);
            this.txtPlacaMadre.Name = "txtPlacaMadre";
            this.txtPlacaMadre.Size = new System.Drawing.Size(119, 24);
            this.txtPlacaMadre.TabIndex = 19;
            this.txtPlacaMadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlacaMadre_KeyPress);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Location = new System.Drawing.Point(207, 324);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(461, 108);
            this.txtObservaciones.TabIndex = 20;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(376, 289);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(121, 18);
            this.lblObservaciones.TabIndex = 21;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // NuevoGallo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 468);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtPlacaMadre);
            this.Controls.Add(this.txtPlacaPadre);
            this.Controls.Add(this.lblPlacaMadre);
            this.Controls.Add(this.lblPlacaPadre);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.lblPedigree);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.mcFechaNacido);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblRaza);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.btnGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoGallo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Emplacado";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.MonthCalendar mcFechaNacido;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.OpenFileDialog BuscarArchivo;
        private System.Windows.Forms.SaveFileDialog GuardarArchivo;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label lblPedigree;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblPlacaPadre;
        private System.Windows.Forms.Label lblPlacaMadre;
        private System.Windows.Forms.TextBox txtPlacaPadre;
        private System.Windows.Forms.TextBox txtPlacaMadre;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
    }
}