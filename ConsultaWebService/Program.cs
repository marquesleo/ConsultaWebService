using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaWebService
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            var calcWS = new CalculadoraWS.Calculator();

            int a = 1;
            int b = 2;
            var resultado = calcWS.Add(a, b);
            Console.WriteLine(a + "+" + b +  "=" + resultado );
            Console.ReadLine();

            a = 10;
            b = 5;
            resultado = calcWS.Divide(a, b);
            Console.WriteLine(a + "/" + b + "=" + resultado);
            Console.ReadLine();
            a = 10;
            b = 10;
            resultado = calcWS.Multiply(a, b);
            Console.WriteLine(a + "*" + b + "=" + resultado);
            Console.ReadLine();
            a = 20;
            b = 10;
            resultado = calcWS.Subtract(a, b);
            Console.WriteLine(a + "-" + b + "=" + resultado);

            Console.ReadLine();
           






        }
    }
}
