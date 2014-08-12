using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Cliente
{
    public partial class NuevoGallo : Form
    {
        Logica.ControlAnimal Control = new Logica.ControlAnimal();
        string ruta;
        Image newImage;
        string obtenerFormato;
        int validaPlaca;

        public NuevoGallo()
        {
            InitializeComponent();
        }

        void limpear()
        {
            txtPlaca.Text = string.Empty;
            txtRaza.Text = string.Empty;
            pbImagen.Image  = null;
            txtObservaciones.Text = string.Empty;
            txtPlacaMadre.Text = string.Empty;
            txtPlacaMadre.Text = string.Empty;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text == "")
            {
                MessageBox.Show("No Agrego Numero De Placa");
            }
            else
            {
                //Valida Si existe la placa
                List<Logica.ControlAnimal> Placas = Control.ValidarPlaca();
                foreach (Logica.ControlAnimal pla in Placas)
                {
                    validaPlaca = pla.Placa;
                    if (txtPlaca.Text == Convert.ToString(validaPlaca) )
                    {
                        MessageBox.Show("Ya Existe esa placa");
                        limpear();
                        break;
                    }
                    else
                    {
                        Control.Placa = Convert.ToInt32(txtPlaca.Text);
                       
                    }

                    //Valida El Tipo de Raza
                    if (txtRaza.Text == "")
                    {
                        MessageBox.Show("Falta Raza Del Animal");
                    }
                    else
                    {
                        Control.Raza = txtRaza.Text;
                    }

                    //Valida La Fecha De Nacimiento
                    if (Convert.ToString(mcFechaNacido.SelectionEnd) == "")
                    {
                        MessageBox.Show("No Selecciono Ninguna Fecha");
                    }
                    else
                    {
                        Control.FechaNacido = Convert.ToDateTime(mcFechaNacido.SelectionEnd.ToShortDateString());
                    }

                    //Guarda La Imagen
                    SaveFileDialog GuardarArchivo = new SaveFileDialog();
                    GuardarArchivo.FileName = txtPlaca.Text;


                    //Valida Si No Puso Imagen
                    if (string.IsNullOrEmpty(ruta))
                    {

                        Control.LugarFoto = " ";
                    }
                    else
                    {
                        //Guarda La Imagen Dependiendo El Tipo
                        switch (obtenerFormato)
                        {
                            case "jpg":
                                pbImagen.Image.Save(@"C:\Imagenes\" + GuardarArchivo.FileName + ".jpg", ImageFormat.Jpeg);
                                Control.LugarFoto = @"C:\Imagenes\" + GuardarArchivo.FileName + ".jpg";
                                break;

                            case "png":
                                pbImagen.Image.Save(@"C:\Imagenes\" + GuardarArchivo.FileName + ".png", ImageFormat.Png);
                                Control.LugarFoto = @"C:\Imagenes\" + GuardarArchivo.FileName + ".png";
                                break;

                            case "bmp":
                                pbImagen.Image.Save(@"C:\Imagenes\" + GuardarArchivo.FileName + ".bmp", ImageFormat.Bmp);
                                Control.LugarFoto = @"C:\Imagenes\" + GuardarArchivo.FileName + ".bmp";
                                break;
                        }
                    }

                    // Valida El Sexo Del Animal
                    if (cbSexo.Text == "Seleccionar")
                    {
                        MessageBox.Show("Seleccione el sexo del animal");
                    }
                    else
                    {
                        Control.Sexo  = cbSexo.Text;
                    }

                    //Valida La Placa Del Padre
                    if (string.IsNullOrEmpty(txtPlacaPadre.Text))
                    {
                        Control.PlacaPadre = 0;
                    }
                    else
                    {
                        Control.PlacaPadre = Convert.ToInt32(txtPlacaPadre.Text);
                    }

                    // Valida La Placa De La Madre
                    if (string.IsNullOrEmpty(txtPlacaMadre.Text))
                    {
                        Control.PlacaMadre = 0;
                    }
                    else
                    {
                        Control.PlacaMadre = Convert.ToInt32(txtPlacaMadre.Text);
                    }

                    // Valida El Campo Observaciones
                    if (string.IsNullOrEmpty(txtObservaciones.Text))
                    {
                        Control.Observaciones = " ";
                    }
                    else
                    {
                        Control.Observaciones = txtObservaciones.Text;
                    } 
                   
                    // Valida Si Faltan Campos Y no Guarda
                    if (txtPlaca.Text == "" || txtRaza.Text == "" || cbSexo.Text == "Seleccionar")
                    {
                        MessageBox.Show("Faltan campos por rellenar");
                        break;
                    }

                    //Guarda El Registro    
                    else
                    {
                        Control.Agregar();
                        limpear();
                        MessageBox.Show("Registro Guardado");
                        break;
                    }
                }
              
            }
           
        }

        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            
            var ratio = Math.Min (ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            return newImage;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarArchivo  = new OpenFileDialog();
            BuscarArchivo.Filter = "JPG|*.jpg|PNG|*.png|BMP|*.bmp";
            BuscarArchivo.Title = "SELECCIONE EL TIPO DE IMAGEN";

            if (BuscarArchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                    ruta = BuscarArchivo.FileName;
                    var image = Image.FromFile(ruta);
                    newImage = ScaleImage(image, 300, 160);
                    pbImagen.Image  = newImage;

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

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPlacaPadre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPlacaMadre_KeyPress(object sender, KeyPressEventArgs e)
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

    }
}
