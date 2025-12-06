// See https://aka.ms/new-console-template for more information
// Nombre: Nayerli Martinez
// Fecha: 06/12/2025

using System;

namespace Tarea1
{
    // Clase Circulo
    public class Circulo
    {
        // Atributo privado que almacena el radio
        private double radio;

        // Constructor que inicializa el radio
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // CalcularArea devuelve el área del círculo
        // Fórmula: π * radio^2
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // CalcularPerimetro devuelve la circunferencia del círculo
        // Fórmula: 2 * π * radio
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase Cuadrado
    public class Cuadrado
    {
        // Atributo privado que almacena el lado
        private double lado;

        // Constructor que inicializa el lado
        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        // CalcularArea devuelve el área del cuadrado
        // Fórmula: lado * lado
        public double CalcularArea()
        {
            return lado * lado;
        }

        // CalcularPerimetro devuelve el perímetro del cuadrado
        // Fórmula: 4 * lado
        public double CalcularPerimetro()
        {
            return 4 * lado;
        }
    }

    // Clase Rectangulo
    public class Rectangulo
    {
        // Atributos privados que almacenan ancho y alto
        private double ancho;
        private double alto;

        // Constructor que inicializa ancho y alto
        public Rectangulo(double ancho, double alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        // CalcularArea devuelve el área del rectángulo
        // Fórmula: ancho * alto
        public double CalcularArea()
        {
            return ancho * alto;
        }

        // CalcularPerimetro devuelve el perímetro del rectángulo
        // Fórmula: 2 * (ancho + alto)
        public double CalcularPerimetro()
        {
            return 2 * (ancho + alto);
        }
    }

    // Clase principal para probar las figuras
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un círculo con radio 5
            Circulo c = new Circulo(5);
            Console.WriteLine("Área del círculo: " + c.CalcularArea());
            Console.WriteLine("Perímetro del círculo: " + c.CalcularPerimetro());

            // Crear un cuadrado con lado 4
            Cuadrado q = new Cuadrado(4);
            Console.WriteLine("Área del cuadrado: " + q.CalcularArea());
            Console.WriteLine("Perímetro del cuadrado: " + q.CalcularPerimetro());

            // Crear un rectángulo de 4x6
            Rectangulo r = new Rectangulo(4, 6);
            Console.WriteLine("Área del rectángulo: " + r.CalcularArea());
            Console.WriteLine("Perímetro del rectángulo: " + r.CalcularPerimetro());
        }
    }
}