
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicosCSharp;
using System;

namespace UnitTestBasicosCSharp
{
    [TestClass]
    public class CuadradoTest
    {
        [TestMethod]
        // Fila de parámetros (lado, area)
        // Se ejecuta la prueba para cada fila de datos
        [DataRow(1, 1)]      
        [DataRow(5, 25)]
        [DataRow(10, 100)]
        public void AreaCuadradoTest (double lado, double area)
        {
            Cuadrado miCuadrado = new Cuadrado(lado);

            double real = miCuadrado.area();
            Assert.AreEqual(area, real);          
        }

        [TestMethod]
        // Fila de parámetros (lado, area)
        // Se ejecuta la prueba para cada fila de datos
        [DataRow(1, 4)]
        [DataRow(5, 20)]
        [DataRow(10, 40)]
        public void PerimetroCuadradoTest(double lado, double perimetro)
        {
            Cuadrado miCuadrado = new Cuadrado(lado);
            
            double real = miCuadrado.perimetro();
            Assert.AreEqual(perimetro, real);          
        }

        [TestMethod]
        [DataRow(-3)]
        public void LadoNegativoTest(double lado)
        {
            // Asignación de lado por constructor 
            // La prueba es correcta si se ha lanzado una excepción
            Assert.ThrowsException<Exception>(()=>new Cuadrado(lado));   // El parámetro es una REFERENCIA a la función constructor            

        }
    }
}
