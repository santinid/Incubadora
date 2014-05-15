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
    public partial class MenuPrincipal : Form
    {
        
        DateTime fecha;
        int idn;
        int idi;
        int quitar = 0;
        Logica.Incubadora incubadora = new Logica.Incubadora();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            eliminarCharola();
        }
        void eliminarCharola() 
        {
            Logica.Incubadora i = new Logica.Incubadora();

            DateTime diahoy = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            List <Logica.Incubadora >  list = i.ObtenerIdNivel();
            


            foreach (Logica.Incubadora fechass in list )
            {
                fecha = Convert .ToDateTime (fechass.FechaFinal);
                idi = fechass.IdNivel;
                

                Logica.Nivel n = new Logica.Nivel();
                List <Logica.Nivel>  nivel = n.ObtenerListado ();
                
                foreach (Logica .Nivel niv in nivel)
                {
                    idn = niv.IdNivel;
                    if (fecha == (diahoy)  & (idn == idi))
                    {
                    quitar = quitar + 1;
                    n.IdNivel = idn;     
                    n.Charola = quitar  - n.Charola  ;
                    n.Modificar();
                    MessageBox.Show("Hoy hay nuevos nacimientos");
                    }
                }       
            } 
        }
    
        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NuevoPedido pedido = new NuevoPedido();
            pedido.Show();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuevoCliente cliente = new NuevoCliente();
            cliente.Show();
        }

        private void mostrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarCliente mostrarc = new MostrarCliente();
            mostrarc.Show();
        }
    }
}
