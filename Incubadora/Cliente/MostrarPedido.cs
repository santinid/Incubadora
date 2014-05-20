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
            cmbCliente.DataSource = Cliente.ObtenerListado();
            cmbCliente.DisplayMember = "NombreCompleto";
            cmbCliente.ValueMember = "IdCliente";
        }

        void llenarPorNombre()
        {
            filtrar = cmbCliente.ValueMember;

            dgvPedidos.DataSource = incubadora.ObtenerListadoIdCliente();
        }

        void llenargridTodos()
        {
            dgvPedidos.DataSource = incubadora.ObtenerListado(); 
        }


        private void MostrarPedido_Load(object sender, EventArgs e)
        {
            llenargridTodos();
  
        }
    }
}