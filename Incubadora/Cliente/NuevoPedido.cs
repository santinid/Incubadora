using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica ;
namespace Cliente
{
    public partial class NuevoPedido : Form
    {
        Logica.Cliente Cliente = new Logica.Cliente();
        Logica.Nivel nivel = new Logica.Nivel();
        Logica.Incubadora incubadora = new Logica.Incubadora();

        string animal ;
        int charola;
        public NuevoPedido()
        {
            InitializeComponent();
            llenarComboCliente();
            llenarComboNivel();
            fechaHoy();
            
        }

        void llenarComboCliente ()
        {
            cmbCliente.DataSource = Cliente.ObtenerListado() ;
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "IdCliente";
        }
        void llenarComboNivel()
        {
          
            cmbNivel.DataSource = nivel.ObtenerListado();
            cmbNivel.DisplayMember = "IdNivel";
            cmbNivel.ValueMember = "IdNivel";
            
        }

       
        #region "Dias de encubar" 
        void fechaHoy()
        {
            txtFechaInicio.Text = DateTime.Now.ToShortDateString();
        }
        void fechaFinalGallina() 
        {
            txtFechaFinal.Text = DateTime.Now.AddDays(21).ToShortDateString();
        }
        void fechaFinalFaisan()
        {
            txtFechaFinal.Text = DateTime.Now.AddDays(24).ToShortDateString();
        }
        void fechaFinalDemas()
        {
            txtFechaFinal.Text = DateTime.Now.AddDays(28).ToShortDateString();
        }
#endregion

        #region "Limpear todo"
        void limpear()
        {
            txtTotalPagar.Clear();
            txtFechaFinal.Clear();
            txtCantidadHuevos.Clear();
        }
            
        #endregion

        
        private void cbTipoHuevo_SelectedIndexChanged(object sender, EventArgs e)
        {
            animal = cbTipoHuevo.SelectedIndex.ToString();
            if (animal == "0" )
            {
                fechaFinalGallina();
            }
            else if (animal == "1")
            {
                fechaFinalDemas();
            }
            else if (animal == "2")
            {
                fechaFinalFaisan();
            }
            else if (animal == "3")
            {
                fechaFinalDemas();
            }
            else if (animal == "4")
            {
                fechaFinalDemas();
            }
            else 
            {
                MessageBox.Show("Selecciona el tipo de huevo", "Error",MessageBoxButtons.OKCancel);
            } 

        }

        private void txtCantidadHuevos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCantidadHuevos_TextChanged(object sender, EventArgs e)
        {
           if (txtCantidadHuevos.Text.Equals(string.Empty))
           {
               txtTotalPagar.Text = string.Empty;
           }

           else
           {
               int total = Convert.ToInt32(txtCantidadHuevos.Text) * 8;
               txtTotalPagar.Text = total.ToString();
           }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Logica.Nivel n = new Logica.Nivel();
            n.IdNivel = cmbNivel.SelectedIndex;
           
            string[] datos = n.Obtener().Split('|');
            charola = Convert.ToInt32(datos[1]);

            if (charola < 4)
            {
                Logica.Incubadora i = new Logica.Incubadora();
                i.IdCliente = Convert.ToInt32(cmbCliente.SelectedValue);
                i.CantidadHuevos = Convert.ToInt32(txtCantidadHuevos.Text);
                i.TipoHuevo = cbTipoHuevo.Text;
                i.FechaInicio = Convert.ToDateTime(txtFechaInicio.Text);
                i.FechaFinal = Convert.ToDateTime(txtFechaFinal.Text);
                i.Total = Convert.ToDouble(txtTotalPagar.Text);
                i.IdNivel = Convert.ToInt32(cmbNivel.SelectedValue);
                charola = charola + 1;
                n.Charola = charola;
                n.Modificar();
                i.Agregar();
                
                MessageBox.Show("Registro Guardado");
                limpear();
            }
                else 
                {
                    MessageBox.Show("Nivel lleno");
                }
        }

        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        
    }
}
