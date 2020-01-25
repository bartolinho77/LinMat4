using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinMat4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj operację w formacie infix:");
            string operacjaInfix = Console.ReadLine();

            char[] tymczasowaTablicaZnakow = operacjaInfix.ToCharArray();


            for(int i = 0; i<tymczasowaTablicaZnakow.Length; i++)
            {

            }
        }
    }
}
