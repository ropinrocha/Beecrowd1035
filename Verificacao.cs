using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel.DataAnnotations.Schema;


namespace Verificacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string []numeros = Console.ReadLine().Split(' ');
            int A = int.Parse(numeros[0]);
            int B = int.Parse(numeros[1]);
            int C = int.Parse(numeros[2]);
            int D = int.Parse(numeros[3]);

            if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0) 
            {
                Console.WriteLine("Valores aceitos");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
                Console.Read();
            }
            

        }
    }
}


