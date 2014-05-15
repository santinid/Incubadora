using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace Cliente
{
    public partial class NuevoCliente : Form
    {
        Logica.Cliente conexion = new Logica.Cliente();

        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        void limpear() 
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
        }
        private void NuevoCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Logica.Cliente c = new Logica.Cliente();
            c.Nombre = txtNombre.Text;
            c.Apellido = txtApellido.Text;
            c.Agregar();
            limpear();
            MessageBox.Show("Registro guardado con exito");
        }
    }
}
