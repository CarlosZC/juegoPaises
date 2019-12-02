using System;
using System.Collections.Generic;
using System.Text;

namespace BasicosCSharp
{
    public class Cuadrado
    {
        private double _lado;        

        public double lado
        {
            get => _lado;
            set
            {
                if (value >= 0) _lado = value;
                else throw new Exception("Valor del lado incorrecto");
            }
        }
       

        /* Constructor implícito por defecto para la clase.
       * No tiene nombre. "Cuadrado" es el tipo del objeto que devuelve
       * Solamente se crea de forma implícita si no hay otro constructor en la clase */
        public Cuadrado() { }

        // Constructor específico
        public Cuadrado(double nuevoLado) // Constructor sobrecargado con parámetro
        {
            lado = nuevoLado;
        }

        public double perimetro()
        {
            return lado * 4;
        }

        public double area()
        {
            return lado * lado;
        }
        
    }

}
