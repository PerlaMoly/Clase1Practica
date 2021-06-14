using Logica;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PrimeraClase20211C
{
    class Program
    {
        static void Main(string[] args)
        {
            //EjercicioSumarNros();

            EjercicioOrdenarNombres.Ejecutar();
            EjercicioOrdenarNombres.Ejecutar2();
        }


        



        private static void EjercicioSumarNros()
        {
            Console.WriteLine("Ingrese un nro:");
            string num1 = Console.ReadLine();//1

            Console.WriteLine("Ingrese otro nro:");
            string num2 = Console.ReadLine();//2

            int resultado = Calculadora.Sumar(num1, num2);
            Console.WriteLine("La suma de ambos nros es: " + resultado);//12
        }
    }
}