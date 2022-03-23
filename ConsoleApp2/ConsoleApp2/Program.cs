using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //const double PI = 3.14159265359;
        //const int semanas = 52, meses = 12;
        //const string nacimiento = "15.01.1982";

        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;
            // operadores unarios
            num3 = -num1;
            Console.WriteLine("El número negativo de num1 es {0}",num3);

            bool haysol = true;
            Console.WriteLine("Hay sol? {0}", !haysol);
            

            //Operadores de adicion
            int num=2;
            num++;
            Console.WriteLine("num es {0}", num);
            Console.WriteLine("num es {0}", num++);
            Console.WriteLine("num es {0}", num);

            //operadores de sustracción
            num--;
            Console.WriteLine("num es {0}", num);
            Console.WriteLine("num es {0}", --num);
            Console.WriteLine("num es {0}", num);

            //operadores matemáticos

            int resultado = num1 + num2;
            Console.WriteLine("El resultado de " + num1 + " + " + num2 + " es " + resultado);
            resultado = num1 - num2;
            Console.WriteLine("El resultado de " + num1 + " - " + num2 + " es " + resultado);
            resultado = num1 * num2;
            Console.WriteLine("El resultado de " + num1 + " * " + num2 + " es " + resultado);
            double resultado1 = num1 / num2;
            Console.WriteLine("El resultado de " + num1 + " / " + num2 + " es " + resultado1);
            
            //operador modular
            resultado = num1 % num2;
            Console.WriteLine("El resultado de " + num1 + " % " + num2 + " es " + resultado);


            //operadores relacionales
            bool esMenor;
            esMenor = num1 < num2;
            Console.WriteLine("El resultado de " + num1 + " < " + num2 + " es " + esMenor);

            //operadores de igualdad
            bool esIgual;
            esIgual = num1 == num2;
            Console.WriteLine("El resultado de " + num1 + " = " + num2 + " es " + esIgual);

            esIgual = num1 != num2;
            Console.WriteLine("El resultado de " + num1 + " != " + num2 + " es " + esIgual);

            //operadoes condicionales
            //Y

            bool esMenorYSoleado;
            esMenorYSoleado = esMenor && haysol;
            Console.WriteLine("El resultado de " + esMenor + " && " + haysol + " es " + esMenorYSoleado);
            //O
            esMenorYSoleado = esMenor || haysol;
            Console.WriteLine("El resultado de " + esMenor + " && " + haysol + " es " + esMenorYSoleado);






            Console.Read();
            /*Console.WriteLine(Sumar(15, 3));
            Console.WriteLine(Multi(2, 8));
            Console.WriteLine(Divide(15, 8));
            Console.Read();*/
            //EscribeAlgo();
            //EscribeAlgoEspecifico("Soy un argumento y me llamaron desde un método");
            //Console.WriteLine("Mi nacimiento fue el: {0}", nacimiento);
            //Console.Read();
        }

        /*}
        //Nivel de Acceso - Tipo de Retorno - Nombre del metodo (parámetro1, parámetro2) 
        public static void EscribeAlgo()
        {
            Console.WriteLine("Yo nací en un metodo");
        }

        public static void EscribeAlgoEspecifico(string miTexto) {

            Console.WriteLine(miTexto);
        }*/


        public static int Sumar(int num1, int num2)
        {
            /*int num3, num4, num5;

            double d1 = 3.2;
            double d2 = 1.337;
            double sumd = d1 + num2;

            int sum2 = num3 + num4 + num5;

            float f1 = 3.5f;

            Console.WriteLine("La suma de " + d1 + " mas " + num2 + " da como resultado " + sumd);
            Console.WriteLine(sum2);
            Console.Read(); */

            return num1 + num2;
        }
        public static int Multi(int num3, int num4)
        {
            return (num3 * num4);
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

    }


    /*cadenastexto();{
    string MiNombre = "Alex";
    string mensaje = "Mi nombre es " + MiNombre;
    string mensajemay = mensaje.ToUpper();
    string mensajemin = mensaje.ToLower();
    Console.WriteLine(mensajemay);
          Console.WriteLine(mensajemin);
        Console.Read();
    }*/

    /*convertirvariables();{
    string miString = "15";
    string miSegundoString = "10";
    string resultado = miString + miSegundoString;
      int num1 = Int32.Parse(miString);
    int num2 = Int32.Parse(miSegundoString);
    int resultado2 = num1 + num2;

    Console.WriteLine(resultado2);
          Console.Read();
    }*/
}
