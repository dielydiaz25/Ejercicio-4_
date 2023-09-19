using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalcularArea
{
    public class Calcular
    {
        public decimal lado { get; set; }
        public decimal base1 { get; set; }
        public decimal altura { get; set; }
        public double radio { get; set; }
     
        public decimal cuadrado(decimal l)
        {
            lado = l;
            return lado * lado;
        }
        public decimal triangulo(decimal b, decimal a)
        {
            base1 = b;
            altura = a;
            return base1 * altura / 2;
        }
        public double circulo(double r)
        {
            radio = r;
            return Math.PI * radio * radio;
        }

    }
}
