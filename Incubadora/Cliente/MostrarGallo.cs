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
    public partial class MostrarGallo : Form
    {
        Logica.ControlAnimal control = new Logica.ControlAnimal();
        int placa;
        public MostrarGallo()
        {
            InitializeComponent();
        }

        void llenarDatagrid() 
        {
            dgvAnimales.DataSource = control.ObtenerListado();
        }

        private void MostrarGallo_Load(object sender, EventArgs e)
        {
            llenarDatagrid();
        }

        void limpear()
        {
            txtPlaca.Text = string.Empty;
            txtRaza.Text = string.Empty;
        }


        private void dgvAnimales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlaca.Text = dgvAnimales[0, dgvAnimales.CurrentCell.RowIndex].Value.ToString();
            txtRaza.Text = dgvAnimales[2, dgvAnimales.CurrentCell.RowIndex].Value.ToString();
            mcFechaNacido.SelectionEnd = Convert.ToDateTime(dgvAnimales[1, dgvAnimales.CurrentCell.RowIndex].Value.ToString()); 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            control.Placa = Convert.ToInt32(txtPlaca.Text);
            control.Raza = txtRaza.Text;
            control.FechaNacido = Convert.ToDateTime(mcFechaNacido.SelectionEnd.ToShortDateString());
            control.Modificar();
            limpear();
            MessageBox.Show("Registro Modificado");
        }

        void buscarPorplaca()
        {
            try
            {
                placa = Convert.ToInt32(txtPlaca.Text);
                dgvAnimales.DataSource = control.ObtenerPorPlaca(placa);
            }
            catch
            {

            }
        }

        private void txtPlaca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarPorplaca();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }



    

        
    }
}
