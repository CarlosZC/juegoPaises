using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    class Dummy
    {
        public static void Main()
        {
            pintarEvaluacion((num)=>num*num, 5);
            // La anterior llamada lambda es equivalente a crear la función cuadrado y llamarla de la siguiente forma
             pintarEvaluacion(cuadrado, 5);

            pintarEvaluacion((j) => j / 3, 9);
            // La anterior llamada lambda es equivalente a crear la función tercio y llamarla de la siguiente forma
            pintarEvaluacion(tercio, 9);

            Console.ReadKey();
        }

        public static int cuadrado (int x)
        {
            return x*x;
        }

        public static int tercio(int j)
        {
            return j/3;
        }


        public static void pintarEvaluacion(Func<int,int> funcion,int x)
        {
            //Func<int,int> es un parámetro que es una función que recibe un int y devuelve un int
            int resultado = funcion(x);
            Console.WriteLine("La función llamada es " + funcion.Method.Name);
            Console.WriteLine("El resultado es " + resultado);
        }
    }
}
