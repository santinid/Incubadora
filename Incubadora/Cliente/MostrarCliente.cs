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
            Close();
        }

        

        private void btnModificar_Click(object sender, EventArgs e)
        {
          
        }

       
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
            txtNombre.Text = Convert.ToString(dgvClientes.Rows[1].Cells["Nombre"]);
            
            //txtApellido.Text = Convert.ToString(dgvClientes.Rows[0].Cells[1]);
        }

       
    }
}
