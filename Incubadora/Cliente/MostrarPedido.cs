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
    public partial class MostrarPedido : Form
    {
        Logica.Incubadora incubadora = new Logica.Incubadora();
        Logica.Cliente Cliente = new Logica.Cliente();
        int filtrar;

        public MostrarPedido()
        {
            InitializeComponent();
            llenarComboCliente();
        }

        void llenarComboCliente()
        {
            cmbCliente.DataSource = Cliente.ObtenerListadoNombreCompleto();
            cmbCliente.DisplayMember = "NombreCompleto";
            cmbCliente.ValueMember = "IdCliente";
        }

        void llenarPorNombre()
        {
            try
            {
                filtrar = Convert.ToInt32(cmbCliente.SelectedValue);
                dgvPedidos.DataSource = incubadora.ObtenerListadoIdCliente(filtrar);
            }
            catch 
            { 
            }
       }
        
        void llenargridTodos()
        { 
            dgvPedidos.DataSource = incubadora.ObtenerListado(); 
        }

      
        private void MostrarPedido_Load(object sender, EventArgs e)
        {
            
                llenargridTodos();
            
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
         
             llenarPorNombre();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenargridTodos();
        }
    }
}