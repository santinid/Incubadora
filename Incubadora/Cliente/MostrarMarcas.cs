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
    public partial class MostrarMarcas : Form
    {

        Logica.Marca Marca = new Logica.Marca();
        bool NarIzq;
        bool NarDer;
        bool IzqIzq;
        bool IzqDer;
        bool DerIzq;
        bool DerDer;
        int id;
        int validaID;
        public MostrarMarcas()
        {
            InitializeComponent();
        }

        void cargaGrid()
        {
            dgvMarcas.DataSource = Marca.ObtenerListado();
        }

        private void MostrarMarcas_Load(object sender, EventArgs e)
        {
            cargaGrid();
        }

        private void dgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            txtModificar.Text = dgvMarcas [1, dgvMarcas .CurrentCell.RowIndex].Value.ToString();
            cbNarIzq.Checked = Convert.ToBoolean (dgvMarcas[2, dgvMarcas .CurrentCell.RowIndex].Value.ToString () ) ;
            cbNarDer.Checked = Convert.ToBoolean(dgvMarcas[3, dgvMarcas.CurrentCell.RowIndex].Value.ToString());
            cbIzqIzq.Checked = Convert.ToBoolean(dgvMarcas[4, dgvMarcas.CurrentCell.RowIndex].Value.ToString());
            cbIzqDer.Checked = Convert.ToBoolean(dgvMarcas[5, dgvMarcas.CurrentCell.RowIndex].Value.ToString());
            cbDerIzq.Checked = Convert.ToBoolean(dgvMarcas[6, dgvMarcas.CurrentCell.RowIndex].Value.ToString());
            cbDerDer.Checked = Convert.ToBoolean(dgvMarcas[7, dgvMarcas.CurrentCell.RowIndex].Value.ToString());
            id = Convert.ToInt32 (dgvMarcas[0, dgvMarcas.CurrentCell.RowIndex].Value.ToString());
        }

        void limpear()
        {
            cbNarIzq.Checked = false;
            cbNarDer.Checked = false;
            cbIzqIzq.Checked = false;
            cbIzqDer.Checked = false;
            cbDerIzq.Checked = false;
            cbDerDer.Checked = false;
            txtModificar .Text = "";
            txtModificar .Focus();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtModificar .Text))
            {
                MessageBox.Show("Falta Nombre De La Marca Del Animal");
            }
            else
            {
                List<Logica.Marca> Marcas = Marca.ValidaMarcasConIDs ();
                foreach (Logica.Marca pla in Marcas)
                {

                    NarIzq = pla.NarizIzq;
                    NarDer = pla.NarizDer;
                    IzqIzq = pla.IzqIzq;
                    IzqDer = pla.IzqDer;
                    DerIzq = pla.DerIzq;
                    DerDer = pla.DerDer;
                    validaID = pla.Id ;
                    if (cbNarIzq.Checked == NarIzq && cbNarDer.Checked == NarDer && cbIzqIzq.Checked == IzqIzq && cbIzqDer.Checked == IzqDer && cbDerIzq.Checked == DerIzq && cbDerDer.Checked == DerDer && id != validaID  )
                    {
                        MessageBox.Show("Ya Existe esa marca");
                        limpear();
                        break;
                    }
                    continue;

                }

                if (string.IsNullOrEmpty(txtModificar .Text))
                {

                }
                else
                {

                    //NarizIzquierda
                    if (cbNarIzq.Checked == true)
                    {
                        Marca.NarizIzq = true;
                    }
                    else
                    {
                        Marca.NarizIzq = false;
                    }
                    //NarizDerecha
                    if (cbNarDer.Checked == true)
                    {
                        Marca.NarizDer = true;
                    }
                    else
                    {
                        Marca.NarizDer = false;
                    }
                    //PieIzquierdo Izquierdo
                    if (cbIzqIzq.Checked == true)
                    {
                        Marca.IzqIzq = true;
                    }
                    else
                    {
                        Marca.IzqIzq = false;
                    }
                    //PieIzquierdo Derecho
                    if (cbIzqDer.Checked == true)
                    {
                        Marca.IzqDer = true;
                    }
                    else
                    {
                        Marca.IzqDer = false;
                    }
                    //PieDerecho Izquierdo
                    if (cbDerIzq.Checked == true)
                    {
                        Marca.DerIzq = true;
                    }
                    else
                    {
                        Marca.DerIzq = false;
                    }
                    //PieDerecho Derecho
                    if (cbDerDer.Checked == true)
                    {
                        Marca.DerDer = true;
                    }
                    else
                    {
                        Marca.DerDer = false;
                    }
                    Marca.Id = id;
                    Marca.Nombre = txtModificar .Text;
                    Marca .Modificar ();
                    MessageBox.Show("Registro Modificado");
                    cargaGrid();
                    limpear();
                }
            }
        }

       
    }
}
