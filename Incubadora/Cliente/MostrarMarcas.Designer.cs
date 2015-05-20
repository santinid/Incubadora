namespace Cliente
{
    partial class MostrarMarcas
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
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cbNarIzq = new System.Windows.Forms.CheckBox();
            this.cbNarDer = new System.Windows.Forms.CheckBox();
            this.cbIzqIzq = new System.Windows.Forms.CheckBox();
            this.cbIzqDer = new System.Windows.Forms.CheckBox();
            this.cbDerIzq = new System.Windows.Forms.CheckBox();
            this.cbDerDer = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtModificar = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IzqIqz = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IzqDerr = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DerIzqq = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DerDerr = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nombre,
            this.IzqIqz,
            this.IzqDerr,
            this.DerIzqq,
            this.DerDerr});
            this.dgvMarcas.Location = new System.Drawing.Point(12, 62);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.Size = new System.Drawing.Size(727, 206);
            this.dgvMarcas.TabIndex = 0;
            this.dgvMarcas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarcas_CellClick);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(300, 9);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(144, 33);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "MARCAS";
            // 
            // cbNarIzq
            // 
            this.cbNarIzq.AutoSize = true;
            this.cbNarIzq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNarIzq.Location = new System.Drawing.Point(25, 319);
            this.cbNarIzq.Name = "cbNarIzq";
            this.cbNarIzq.Size = new System.Drawing.Size(103, 24);
            this.cbNarIzq.TabIndex = 2;
            this.cbNarIzq.Text = "Izquierda";
            this.cbNarIzq.UseVisualStyleBackColor = true;
            // 
            // cbNarDer
            // 
            this.cbNarDer.AutoSize = true;
            this.cbNarDer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNarDer.Location = new System.Drawing.Point(111, 319);
            this.cbNarDer.Name = "cbNarDer";
            this.cbNarDer.Size = new System.Drawing.Size(96, 24);
            this.cbNarDer.TabIndex = 3;
            this.cbNarDer.Text = "Derecha";
            this.cbNarDer.UseVisualStyleBackColor = true;
            // 
            // cbIzqIzq
            // 
            this.cbIzqIzq.AutoSize = true;
            this.cbIzqIzq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIzqIzq.Location = new System.Drawing.Point(268, 319);
            this.cbIzqIzq.Name = "cbIzqIzq";
            this.cbIzqIzq.Size = new System.Drawing.Size(103, 24);
            this.cbIzqIzq.TabIndex = 4;
            this.cbIzqIzq.Text = "Izquierda";
            this.cbIzqIzq.UseVisualStyleBackColor = true;
            // 
            // cbIzqDer
            // 
            this.cbIzqDer.AutoSize = true;
            this.cbIzqDer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIzqDer.Location = new System.Drawing.Point(389, 319);
            this.cbIzqDer.Name = "cbIzqDer";
            this.cbIzqDer.Size = new System.Drawing.Size(96, 24);
            this.cbIzqDer.TabIndex = 5;
            this.cbIzqDer.Text = "Derecha";
            this.cbIzqDer.UseVisualStyleBackColor = true;
            // 
            // cbDerIzq
            // 
            this.cbDerIzq.AutoSize = true;
            this.cbDerIzq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDerIzq.Location = new System.Drawing.Point(523, 319);
            this.cbDerIzq.Name = "cbDerIzq";
            this.cbDerIzq.Size = new System.Drawing.Size(103, 24);
            this.cbDerIzq.TabIndex = 6;
            this.cbDerIzq.Text = "Izquierda";
            this.cbDerIzq.UseVisualStyleBackColor = true;
            // 
            // cbDerDer
            // 
            this.cbDerDer.AutoSize = true;
            this.cbDerDer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDerDer.Location = new System.Drawing.Point(628, 319);
            this.cbDerDer.Name = "cbDerDer";
            this.cbDerDer.Size = new System.Drawing.Size(96, 24);
            this.cbDerDer.TabIndex = 7;
            this.cbDerDer.Text = "Derecha";
            this.cbDerDer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nariz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pie Izquierdo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(574, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pie Derecho";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(523, 387);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtModificar
            // 
            this.txtModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificar.Location = new System.Drawing.Point(327, 387);
            this.txtModificar.Name = "txtModificar";
            this.txtModificar.Size = new System.Drawing.Size(179, 26);
            this.txtModificar.TabIndex = 12;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Id";
            this.Numero.HeaderText = "Id";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre Marca";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // IzqIqz
            // 
            this.IzqIqz.DataPropertyName = "IzqIzq";
            this.IzqIqz.HeaderText = "Pie Izquierdo Izquierda";
            this.IzqIqz.Name = "IzqIqz";
            this.IzqIqz.ReadOnly = true;
            this.IzqIqz.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IzqIqz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // IzqDerr
            // 
            this.IzqDerr.DataPropertyName = "IzqDer";
            this.IzqDerr.HeaderText = "Pie Izquierdo Derecha";
            this.IzqDerr.Name = "IzqDerr";
            this.IzqDerr.ReadOnly = true;
            // 
            // DerIzqq
            // 
            this.DerIzqq.DataPropertyName = "DerIzq";
            this.DerIzqq.HeaderText = "Piez Derecho Izquierda";
            this.DerIzqq.Name = "DerIzqq";
            this.DerIzqq.ReadOnly = true;
            // 
            // DerDerr
            // 
            this.DerDerr.DataPropertyName = "DerDer";
            this.DerDerr.HeaderText = "Pie Derecho Derecha";
            this.DerDerr.Name = "DerDerr";
            this.DerDerr.ReadOnly = true;
            // 
            // MostrarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 437);
            this.Controls.Add(this.txtModificar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDerDer);
            this.Controls.Add(this.cbDerIzq);
            this.Controls.Add(this.cbIzqDer);
            this.Controls.Add(this.cbIzqIzq);
            this.Controls.Add(this.cbNarDer);
            this.Controls.Add(this.cbNarIzq);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.dgvMarcas);
            this.Name = "MostrarMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Marcas";
            this.Load += new System.EventHandler(this.MostrarMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.CheckBox cbNarIzq;
        private System.Windows.Forms.CheckBox cbNarDer;
        private System.Windows.Forms.CheckBox cbIzqIzq;
        private System.Windows.Forms.CheckBox cbIzqDer;
        private System.Windows.Forms.CheckBox cbDerIzq;
        private System.Windows.Forms.CheckBox cbDerDer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IzqIqz;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IzqDerr;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DerIzqq;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DerDerr;
    }
}