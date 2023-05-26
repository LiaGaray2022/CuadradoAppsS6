using System;

namespace CuadradoApps.Models
{
    public class Cuadrado
    {
        public double Lado { get; set; }
        public double Lado2 { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }

        public Cuadrado(double lado, double lado2)
        {
            Lado = lado;
            Lado2 = lado2;
            CalcularArea();
            CalcularPerimetro();
        }

        public void CalcularArea()
        {
            Area = Lado * Lado2;
        }

        public void CalcularPerimetro()
        {
            Perimetro = 2 * (Lado + Lado2);
        }
    }
}

