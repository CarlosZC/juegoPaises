using System;
using System.Collections.Generic;
using System.Text;

namespace BasicosCSharp
{
    public class Rectangulo
    {
        private double _ancho;
        private double _alto;         

        public double ancho
        {
            get => _ancho;
            set
            {
                if (value >= 0) _ancho = value;
                else throw new Exception("Valor del ancho incorrecto");
            }
        }

        public double alto
        {
            get => _alto;
            set
            {
                if (value >= 0) _alto = value;
                else throw new Exception("Valor del alto incorrecto");
            }
        }


        /* Constructor implícito por defecto para la clase.
       * No tiene nombre. "Rectangulo" es el tipo del objeto que devuelve
       * Solamente se crea de forma implícita si no hay otro constructor en la clase */
        public Rectangulo() { }

        // Constructor específico
        public Rectangulo(double nuevoAncho, double nuevoAlto) // Constructor sobrecargado con parámetro
        {
            _ancho = nuevoAncho;
            _alto = nuevoAlto;
        }

        public double perimetro()
        {
            return ancho * 2 + alto * 2;
        }

        public double area()
        {
            return ancho * alto;
        }
        
    }

}
