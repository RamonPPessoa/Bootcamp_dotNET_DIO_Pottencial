using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperadoresAritméticos.Models
{
    public class Calculadora
    {
        public void Somar(int n1, int n2)
        {
            Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
        }

            public void Dividir(int n1, int n2)
        {
            Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
        }

            public void Subtrair(int n1, int n2)
        {
            Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
        }

            public void Multiplicar(int n1, int n2)
        {
            Console.WriteLine($"{n1} X {n2} = {n1 * n2}");
        }


        public void Potencia(int x, int y)
        {
           double pot = Math.Pow(x,y);
            System.Console.WriteLine($"{x} ^{y} = {pot}");
        }

       
    }
}