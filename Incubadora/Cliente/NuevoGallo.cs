using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cliente
{
    public partial class NuevoGallo : Form
    {
        Logica.ControlAnimal Control = new Logica.ControlAnimal();

        public NuevoGallo()
        {
            InitializeComponent();
        }

        void limpear()
        {
            txtPlaca.Text = string.Empty;
            txtRaza.Text = string.Empty;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Control.Placa = Convert.ToInt32 (txtPlaca.Text);
            Control.Raza = txtRaza.Text;
            Control.FechaNacido = Convert.ToDateTime(mcFechaNacido.SelectionEnd.ToShortDateString());
            Control.Agregar();
            limpear();
            MessageBox.Show("Registro Guardado");
        }

        
    }
}
