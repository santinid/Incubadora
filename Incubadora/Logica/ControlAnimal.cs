using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class ControlAnimal
    {
        int placa;
        string raza, sexo;
        DateTime fechaNacimiento;
        
        public int Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        
        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
    }
}
