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
    public partial class NuevaMarca : Form
    {
        Logica.Marca marc = new Logica.Marca();
      
        bool NarIzq;
        bool NarDer;
        bool IzqIzq;
        bool IzqDer;
        bool DerIzq;
        bool DerDer;
        public NuevaMarca()
        {
            InitializeComponent();
            
           
        }
        
        void limpear()
        {
            cbNarIzq.Checked = false;
            cbNarDer.Checked = false;
            cbIzqIzq.Checked = false;
            cbIzqDer.Checked = false;
            cbDerIzq.Checked = false;
            cbDerDer.Checked = false;
            txtMarca.Text = "";
            txtMarca.Focus();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                MessageBox.Show("Falta Nombre De La Marca Del Animal");
            }
            else
            {
                List<Logica.Marca > Marca = marc .ValidaMarcas ();
                foreach (Logica.Marca pla in Marca)
                {
                    
                    NarIzq = pla.NarizIzq;
                    NarDer = pla.NarizDer; 
                    IzqIzq = pla.IzqIzq ;
                    IzqDer = pla.IzqDer;
                    DerIzq = pla.DerIzq ;
                    DerDer = pla.DerDer ;
                    if (cbNarIzq.Checked == NarIzq && cbNarDer.Checked == NarDer && cbIzqIzq.Checked  == IzqIzq && cbIzqDer.Checked == IzqDer && cbDerIzq.Checked == DerIzq && cbDerDer .Checked == DerDer  )
                    {
                        MessageBox.Show("Ya Existe esa marca");
                        limpear();
                        break;
                    }
                    continue;

                }

                if (string.IsNullOrEmpty(txtMarca.Text))
                {
                   
                }
                else
                {

               //NarizIzquierda
                if (cbNarIzq.Checked  == true )
                {
                    marc.NarizIzq = true;
                }
                 else
                {
                    marc.NarizIzq = false ;
                }
                //NarizDerecha
                if (cbNarDer .Checked == true)
                {
                    marc.NarizDer = true;
                }
                else
                {
                    marc.NarizDer = false;
                }
                //PieIzquierdo Izquierdo
                if (cbIzqIzq .Checked == true)
                {
                    marc.IzqIzq  = true;
                }
                else
                {
                    marc.IzqIzq  = false;
                }
                //PieIzquierdo Derecho
                if (cbIzqDer .Checked == true)
                {
                    marc.IzqDer  = true;
                }
                else
                {
                    marc.IzqDer  = false;
                }
                //PieDerecho Izquierdo
                if (cbDerIzq .Checked == true)
                {
                    marc.DerIzq = true;
                }
                else
                {
                    marc.DerIzq  = false;
                }
                //PieDerecho Derecho
                if (cbDerDer.Checked == true)
                {
                    marc.DerDer  = true;
                }
                else
                {
                    marc.DerDer = false;
                }
                marc.Nombre = txtMarca.Text;
                marc.Agregar();
                MessageBox.Show("Registro Guardado");
                limpear();
             }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
