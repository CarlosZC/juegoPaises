
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicosCSharp;
using System;

namespace UnitTestBasicosCSharp
{
    [TestClass]
    public class RectanguloTest
    {
        [TestMethod]
        // Fila de parámetros (alto, area)
        // Se ejecuta la prueba para cada fila de datos
        [DataRow(1, 2, 2)]      
        [DataRow(5, 6, 30)]
        [DataRow(10, 15, 150)]
        public void AreaRectanguloTest (double alto, double ancho, double area)
        {
            Rectangulo miRectangulo = new Rectangulo(alto, ancho);

            double real = miRectangulo.area();
            Assert.AreEqual(area, real);          
        }

        [TestMethod]
        // Fila de parámetros (alto, area)
        // Se ejecuta la prueba para cada fila de datos
        [DataRow(1, 2, 6)]
        [DataRow(5, 6, 22)]
        [DataRow(10, 15, 50)]
        public void PerimetroRectanguloTest(double alto, double ancho, double perimetro)
        {
            Rectangulo miRectangulo = new Rectangulo(alto, ancho);
            
            double real = miRectangulo.perimetro();
            Assert.AreEqual(perimetro, real);          
        }

        [TestMethod]
        [DataRow(-1, 5)]
        [DataRow(3, -8)]
        public void altoNegativoTest(double alto, double ancho)
        {
            // Asignación de alto por constructor 
            // La prueba es correcta si se ha lanzado una excepción
            Assert.ThrowsException<Exception>(()=>new Rectangulo(alto, ancho));   // El parámetro es una REFERENCIA a la función constructor            

        }
    }
}
