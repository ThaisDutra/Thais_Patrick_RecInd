using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thais_Patrick_RecInd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Número: ");
            num = int.Parse(Console.ReadLine());
            if(par(num))
            {
                Console.WriteLine("O número " + num + " é par");
            }
            else
	        {
                Console.WriteLine("O número "+ num +" é ímpar");
        	}
            Console.ReadKey();
        }
        static bool par(int n)
        {
            if(n == 0)
            {
                return true;
            }
            return impar(n - 1);
        }
        static bool impar(int n)
        {
            if(n == 0)
            {
                return false;
            }
            return par(n - 1);
        }
    }
}
