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
        string nom;
        public MostrarCliente()
        {
            InitializeComponent();
        }

        void llenargrid()
        {
            
            dgCliente.DataSource = cliente.ObtenerListado();
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

        private void dgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgCliente[0, dgCliente.CurrentCell.RowIndex].Value.ToString());
           txtNombre.Text = dgCliente[3, dgCliente.CurrentCell.RowIndex].Value.ToString();
           txtApellido.Text = dgCliente[2, dgCliente.CurrentCell.RowIndex].Value.ToString();
          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
             
        void buscarPorplaca()
            {
            
            try
            {
                nom = txtNombre.Text;
                dgCliente.DataSource = cliente.ObtenerPorNombre(nom);
            }
            catch
            {
                

            }
        }

       
        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarPorplaca();
            }
        }

        } 
    
    }

