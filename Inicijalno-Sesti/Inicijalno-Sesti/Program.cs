using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicijalno_Sesti
{
    internal class Program
    {
        static void Main(string[] args)
        {           
                int brClanova;
                double suma = 0;
                double br = 1;

                Console.WriteLine("Unesi broj članova reda: ");
                brClanova = Convert.ToInt32(Console.ReadLine());

                for (int i=0; i<brClanova; i++)
                {
                    br = br*3;
                    suma = suma+(1/br);
                }

                Console.WriteLine(suma);
                Console.ReadKey();
            
        }
    }
}

