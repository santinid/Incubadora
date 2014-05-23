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
        DateTime fechaparaValidar;
        DateTime fecha;
        int idn;
        int idi;
        int quitar = 0;
        Logica.Incubadora incubadora = new Logica.Incubadora();
        Logica.Validar validar = new Logica.Validar();

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
            DateTime diahoy = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            String[] dato = validar.Obtener().Split('|');
            fechaparaValidar = Convert.ToDateTime(dato[0]);

           if (fechaparaValidar == diahoy)
           {
               MessageBox.Show("Bienvenido");
           }
               else
               {
            List <Logica.Incubadora >  list = incubadora.ObtenerIdNivel();
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
                    validar.Fechavalida = diahoy ;
                    validar.Modificar();
                    MessageBox.Show("Bienvenido");
                    MessageBox.Show("Hoy hay nuevos nacimientos");
                    }
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

        private void mostrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MostrarPedido  mostrarIncubadora = new MostrarPedido ();
            mostrarIncubadora.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoGallo  Gallo = new NuevoGallo();
            Gallo.Show();  
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarGallo  Gallo = new MostrarGallo();
            Gallo.Show(); 
        }
    }
}
