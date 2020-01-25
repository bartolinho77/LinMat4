using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinMat4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Podaj operację w formacie infix:");
            string input = Console.ReadLine(); //@"(3*4+3)/5#";
            ParserONP tool = new ParserONP();
            string output = tool.ParseExample(input);
            
            Console.WriteLine(input);
            Console.WriteLine(output);
            Console.ReadKey();
        }

       
    }
}



/*Oper Prio
(  0
+ 1
-  1
* 2
/ 2
^ 3
*/
