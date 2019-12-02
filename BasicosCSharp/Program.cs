using System;

namespace BasicosCSharp
{
    public class Program
    {
        static int maximo(int a, int b)
        {
            if (a > b)
                return a;

            return b;
        }

        static int maximoDe3(int a, int b, int c)
        {
            return (maximo(a, maximo(b, c)));
        }

        static int factorial(int n)
        {

            if (n == 0) return 1;

            return n * factorial(n - 1);

        }

        static int factorialWhile(int n)
        {
            int resultado = n;
            while (n-- > 0)         // if n < 0, sino n--
                resultado *= n;    // resultado = resultado * n;

            return resultado;
        }

        public static int factorialFor(int n)
        {
            int resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;        
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int numero = 8;                 // Los tipos de variable simples comienzan con minúsculas (p.e. int, double, bool, ....)
            const double miDecimal = 9.8;   // Constante     -- Comentario en línea
            String texto = "Hola";          // Los tipos de variable complejos comienzan con mayúsculas (p.e. String)
            bool logico = true;

            numero = 3 + 4;  // Esto devuelve 7
            numero++; // Evalúa y después incrementa
            ++numero; // Incremente y despues evalúa           
                         

            if (numero == 7)
            {
                //Aquí entraría si la evaluación es true
            }
            {
                //Aquí entraría si la evaluación es falso
            }

            /*
             * COMPARADOR ==
             * 
             * El comparador == solamente mira el valor de las variables para tipo básicos
             * Para tipos complejos, el operador == mira si apuntan al mismo espacio de memoria
             * Para comparar el valor de las variables en tipos complejos hay que utilizar el método Equals (p.e. en Strings)
             */


            // Llamada a una función
            int miMaximo = maximo(3, 5);


            // Bucle for
            for (int i = 0; i < 10; i++) { }
            for (int i = 0; i < 10; i += 2) { }
            for (int i = 10; i > 10; i--) { }


            Console.ReadKey();
        }

    }
}
