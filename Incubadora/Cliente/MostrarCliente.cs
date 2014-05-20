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
    public partial class MostrarCliente : Form
    {
        Logica.Cliente cliente = new Logica.Cliente();
        int id;
        public MostrarCliente()
        {
            InitializeComponent();
        }

        void llenargrid()
        {
            dgvClientes.DataSource = cliente.ObtenerListado();
            
        }
        
        private void MostrarCliente_Load(object sender, EventArgs e)
        {
            llenargrid();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            cliente.IdCliente = id;
            cliente.Eliminar();
            MessageBox.Show("Registro Eliminado");
            limpear();
            llenargrid();
        }

        void limpear() 
        {
            txtApellido.Clear();
            txtNombre.Clear();
        }    
    
        private void btnModificar_Click(object sender, EventArgs e)
        {
          cliente.IdCliente = id;
          cliente.Nombre = txtNombre.Text;
          cliente.Apellido = txtApellido.Text;
          cliente.Modificar();
          MessageBox.Show("Registro Modificado");
          limpear();
          llenargrid();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvClientes[0, dgvClientes.CurrentCell.RowIndex].Value.ToString());
         txtNombre.Text = dgvClientes[2, dgvClientes.CurrentCell.RowIndex].Value.ToString();               txtApellido.Text = dgvClientes[1, dgvClientes.CurrentCell.RowIndex].Value.ToString();    
        }


       
    }
}
