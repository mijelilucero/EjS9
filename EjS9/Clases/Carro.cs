using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjS9.Clases
{
    public class Carro
    {
        public string Marca { get; }
        public int Modelo { get; }
        public string Color {  get; set; }
        public string Owner { get; set; }


        private int Encendido = 0;
        public int velocidad_actual { get; set; }


        public int MAXVELOCIDAD { get; set; }


        public Carro(string m, int model)
        {
            Marca = m;
            Modelo = model;
        }


        public int Acelerar()
        {
            if (Encendido == 0)
            {
                return 0;
            }
            velocidad_actual += 10;
            return velocidad_actual;
        }

        public void Encender()
        {
            if (Encendido != 1)
            {
                Encendido = 1;
            }
        }

        public void Apagar()
        {
            if (Encendido != 0 && velocidad_actual == 0)
            {
                Encendido = 0;
            }
        }




    }
}
