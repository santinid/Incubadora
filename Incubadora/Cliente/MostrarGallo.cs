using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using System.IO;
using System.Diagnostics;

namespace Cliente
{
    public partial class MostrarGallo : Form
    {
        Logica.ControlAnimal control = new Logica.ControlAnimal();
        string ruta;
        string filtra;
        Image newImage;
        string obtenerFormato;
        int validaF = 0;
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
            txtSexo.Text = string.Empty;
            txtPlacaPadre.Text = string.Empty;
            txtPlacaMadre.Text = string.Empty;
            pbMostrar.Image = null;
            txtObservaciones.Text = string.Empty;
            llenarDatagrid();
        }

        private void dgvAnimales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlaca.Text = dgvAnimales[2, dgvAnimales.CurrentCell.RowIndex].Value.ToString();
            txtRaza.Text = dgvAnimales[7, dgvAnimales.CurrentCell.RowIndex].Value.ToString();
            txtPlacaMadre.Text = dgvAnimales[0, dgvAnimales.CurrentCell.RowIndex].Value.ToString();
            txtPlacaPadre.Text = dgvAnimales[1, dgvAnimales.CurrentCell.RowIndex].Value.ToString();
            txtSexo.Text = dgvAnimales[5, dgvAnimales.CurrentCell.RowIndex].Value.ToString();
            mcFechaNacido.SelectionEnd = Convert.ToDateTime(dgvAnimales[3, dgvAnimales.CurrentCell.RowIndex].Value.ToString());
            txtObservaciones.Text = dgvAnimales[4, dgvAnimales.CurrentCell.RowIndex].Value.ToString();
            ruta = dgvAnimales[6, dgvAnimales.CurrentCell.RowIndex].Value.ToString();
            if (ruta == " ")
            {
                pbMostrar.Image = null;
            }
            else
            {
                var image = Image.FromFile(ruta);
                pbMostrar.Image = image;
            }
        }
   
        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            if (validaF ==0)
            {
                if (txtPlaca .Text == "")
                    {
                        MessageBox.Show("Seleccione un registro");
                    }
                else
                {
                control.Placa = Convert.ToInt32(txtPlaca.Text);
                control.Raza = txtRaza.Text;
                control.FechaNacido = Convert.ToDateTime(mcFechaNacido.SelectionEnd.ToShortDateString());
                control.PlacaPadre = Convert.ToInt32(txtPlacaPadre.Text);
                control.PlacaMadre = Convert.ToInt32(txtPlacaMadre.Text);
                control.Observaciones = txtObservaciones.Text;
                control.Sexo = txtSexo.Text;
                control.ModificarSinFoto ();
                limpear();
                MessageBox.Show("Registro Modificado");
                }
            }
            else
            {
                
           
            control.Placa  = Convert.ToInt32(txtPlaca.Text);
            control.Raza = txtRaza.Text;
            control.FechaNacido = Convert.ToDateTime(mcFechaNacido.SelectionEnd.ToShortDateString());

            SaveFileDialog GuardarArchivo = new SaveFileDialog();
            GuardarArchivo.FileName = txtPlaca.Text;

            switch (obtenerFormato)
            {
                case "jpg":
                        pbMostrar.Image.Save(@"C:\Imagenes\" + GuardarArchivo.FileName + ".jpg", ImageFormat.Jpeg);
                        control.LugarFoto = @"C:\Imagenes\" + GuardarArchivo.FileName + ".jpg";
                    break;
                case "png":
                    pbMostrar.Image.Save(@"C:\Imagenes\" + GuardarArchivo.FileName + ".png", ImageFormat.Png);
                    control.LugarFoto = @"C:\Imagenes\" + GuardarArchivo.FileName + ".png";
                    break;

                case "bmp":
                    pbMostrar.Image.Save(@"C:\Imagenes\" + GuardarArchivo.FileName + ".bmp", ImageFormat.Bmp);
                    control.LugarFoto = @"C:\Imagenes\" + GuardarArchivo.FileName + ".bmp";
                    break;
            }

            control.PlacaPadre = Convert.ToInt32(txtPlacaPadre.Text);
            control.PlacaMadre = Convert.ToInt32(txtPlacaMadre.Text);
            control.Observaciones = txtObservaciones.Text;
            control.Sexo = txtSexo.Text;
            control.Modificar() ;
            limpear();
            MessageBox.Show("Registro Modificado");
            validaF = 0;
            }
        }

        void BuscarAnimal()
        {
            int valida = 0; 
            
               if (int.TryParse(txtBuscar.Text.Trim(), out valida)) 
               {
                   
                   dgvAnimales.DataSource = control.ObtenerPorPlaca(valida);
               }
               else if (txtBuscar.Text == "") 
               {
                   dgvAnimales.DataSource = control.ObtenerListado();
               }
               else
               {
                   filtra = txtBuscar.Text.Trim();
                   dgvAnimales.DataSource = control.ObtenerListaPorRaza(filtra);
               }
        }

        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;

            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            return newImage;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            BuscarAnimal();
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            validaF = 1;
            // Referenciamos el objeto Image del control
            Image img = pbMostrar .Image;
            // Destruyo la posible imagen existente en el control
            if (img != null) { img.Dispose(); }

            OpenFileDialog BuscarArchivo = new OpenFileDialog();
            BuscarArchivo.Filter = "JPG|*.jpg|PNG|*.png|BMP|*.bmp";
            BuscarArchivo.Title = "SELECCIONE EL TIPO DE IMAGEN";

            if (BuscarArchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ruta = BuscarArchivo.FileName;
                var image = Image.FromFile(ruta);
                newImage = ScaleImage(image, 300, 160);
                pbMostrar.Image = newImage;

                switch (BuscarArchivo.FilterIndex)
                {
                    case 1:
                        obtenerFormato = "jpg";
                        break;

                    case 2:
                        obtenerFormato = "png";
                        break;

                    case 3:
                        obtenerFormato = "bmp";
                        break;
                }

            }
        }

    }
}
